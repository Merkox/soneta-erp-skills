# Weryfikacja kodu na żywej aplikacji przez `buscall` (zrzuty ekranu)

Konkretne zastosowanie `buscall`: **wizualna weryfikacja działania aplikacji podczas tworzenia
i sprawdzania kodu**. Zamiast klikać ręcznie, sterujesz uruchomioną aplikacją z CLI (nawigacja,
otwieranie formularzy, edycja pól) i robisz **zrzuty ekranu**, które oglądasz, aby potwierdzić
layout, wartości pól, widoczność kontrolek czy motyw — na realnej bazie i na **swoim** kodzie.

Składnię wywołań, katalog metod i kody wyjścia opisuje [buscall.md](buscall.md). Tu skupiamy się
na tym, co jest specyficzne dla weryfikacji na żywo: **konfiguracji bazy startującej z Twojego
kodu**, przeładowaniu kodu i pułapkach procesów.

Używamy trybu `call` — każde wywołanie jest niezależne (`buscall --db <Baza> call <metoda> …`),
frame (GUI) startuje przy pierwszym wywołaniu i **zostaje** w tle, więc kolejne `call`-e są szybkie.

## Wymaganie wstępne: baza startująca z Twojego kodu

Parametr `--db Demo` odwołuje się do bazy o nazwie **`Demo` zdefiniowanej w aplikacji
`SonetaFrame`**. To połączenie musi być ustawione tak, aby **startowało z kodu bieżącego projektu**
(biblioteki z katalogu build `bin/Debug`). Bez tego `buscall --db Demo call …` albo nie znajdzie
bazy, albo uruchomi frame na innym (nieaktualnym) kodzie — i zweryfikujesz nie to, co trzeba.

Innymi słowy: nazwa po `--db` = nazwa połączenia w SonetaFrame, a to połączenie decyduje, skąd
ładowany jest kod. Testujesz inny projekt/bazę → zdefiniuj analogiczne połączenie i podaj jego nazwę.

### Gdzie jest definicja bazy

Konfiguracja połączeń SonetaFrame (macOS):
`~/Library/Application Support/Soneta.Frame/Settings_Standard.json`, tablica **`Sources`**. Każdy
wpis to string z parametrami rozdzielonymi `;`. Przykład bazy `Demo` startującej kod z projektu:

```json
"Sources": [
  "process:Demo;caption=dev;path=<katalog-projektu>;user=Administrator;pwd="
]
```

Znaczenie pól:
- `process:Demo` — tryb `process` + **nazwa bazy** `Demo` (wartość podawana w `buscall --db Demo`),
- `caption=dev` — etykieta połączenia w UI,
- `path=<katalog-projektu>` — **katalog projektu, z którego ładowany jest kod** (biblioteki z jego `bin/Debug`),
- `user` / `pwd` — poświadczenia logowania (tu operator `Administrator`, puste hasło).

Aby przetestować inny projekt: dodaj analogiczny wpis w `Sources` z własną nazwą bazy i `path`,
po czym wywołuj `buscall --db <nazwa> call …`. Dodatkowo `IsDeveloperMode: true` w tym samym pliku
włącza tryb dewelopera.

## Architektura

```
CLI (jednorazowo):  buscall --db Demo call <metoda> [klucz=wartość ...]
   │  connect (named pipe "SonetaFrameBridge"); jak brak — spawn frame
   ▼
buscall  ── named pipe "SonetaFrameBridge" ──►  SonetaFrameNew (GUI, zostaje w tle)
(most)                                            └── ładuje Soneta.*.dll z bin/Debug projektu
```

- `buscall call` **tylko mostuje** jedno wywołanie przez named pipe do GUI **`SonetaFrameNew`**.
  To **frame** wykonuje metody i **ładuje biblioteki z `bin/Debug` Twojego projektu**.
- Jeśli frame nie działa, `buscall` **sam go uruchamia** przy pierwszym wywołaniu i czeka na gotowość.
  Frame pozostaje uruchomiony po zakończeniu `call` — kolejne `call`-e podłączą się do niego przez pipe.

### Aby frame miał NOWY kod

1. Przebuduj właściwy projekt logiki: `dotnet build <projekt>.csproj` (ten, którego zmiany testujesz).
2. Upewnij się, że **nie działa stary frame ANI osierocone serwery** — inaczej podłączysz się do
   poprzedniego kodu (patrz „Osierocone serwery i porty" niżej).
3. Pierwsze wywołanie `call` uruchomi świeży frame z nowym DLL.

### Osierocone serwery i porty (częsta pułapka — WERYFIKUJ ZAWSZE)

Frame **nie jest** procesem o nazwie `SonetaFrameNew` — uruchamia dwa procesy `dotnet` z DLL-kami
z katalogu build projektu, które **nasłuchują na portach TCP**:
- **`server.dll`** — `--runjobs=true --SingleDbName=<Baza> --Urls=http://+:<port>` (obserwowane: `22101`, dodatkowo `4000`),
- **`web.dll`** — `--server-endpoint=http://localhost:<portServera> --Urls=http://+:<port>` (obserwowane: `5101`).

Po przerwanym/zabitym teście te procesy **zostają jako osierocone** (`PPID=1`), trzymają porty i
**ładują STARY kod** (sprzed rebuildu). Podłączenie do nich = weryfikacja nieaktualnego kodu.
`grep SonetaFrameNew` ich **nie znajdzie** — szukaj po `server.dll`/`web.dll`/`--SingleDbName`.

**WAŻNE — porty per baza:** każda baza otwierana w programie dostaje **własny port**. Nie sprawdzaj
tylko `22101`/`5101` — przeskanuj **kilka–kilkanaście kolejnych** (np. `22101–22120`, `5101–5120`,
`4000–4010`), bo równolegle otwarte bazy zajmują sąsiednie porty.

```bash
# 1) Znajdź osierocone serwery Soneta (dowolna baza) — po DLL, nie po nazwie frame:
ps ax -o pid,ppid,etime,command | grep -Ei 'server\.dll|web\.dll|--SingleDbName' | grep -v grep
# 2) Sprawdź zajęte porty w ZAKRESIE (nie pojedyncze!) — każda baza = inny port:
lsof -nP -iTCP -sTCP:LISTEN 2>/dev/null | grep -E ':(4[0-9]{3}|22[0-9]{3}|5[0-9]{3})\b'
# 3) Ubij osierocone procesy (web przed server), potwierdź zwolnienie portów:
ps ax -o pid,command | grep -Ei 'web\.dll|server\.dll' | grep -v grep | awk '{print $1}' | xargs -r kill
lsof -nP -iTCP -sTCP:LISTEN 2>/dev/null | grep -E ':(4[0-9]{3}|22[0-9]{3}|5[0-9]{3})\b'   # ma być pusto
```

Dopiero po wyczyszczeniu portów pierwsze wywołanie `call` wystartuje świeży frame/serwer z nowym kodem.
Zabicie tych procesów jest bezpieczne i odwracalne (frame odtworzy je przy następnym wywołaniu).

## Zrzut ekranu → analiza wizualna

Sedno tej weryfikacji: `take_screenshot` zwraca **ścieżkę do PNG** bieżącego widoku (kontrakt metody
opisuje [buscall.md](buscall.md#take_screenshot--kontrakt)). Otwórz plik z tej ścieżki i **obejrzyj go**
narzędziem czytającym obrazy — tak potwierdzasz wizualnie layout formularza, wartości pól, widoczność
kontrolek, wyrównanie, motyw itp. To krok, którego nie zastąpi odczyt danych JSON-em.

```bash
SHOT=$(buscall --db Demo call take_screenshot)
echo "$SHOT"     # ścieżka do PNG — otwórz i obejrzyj
```

## Minimalny przepływ (skopiuj i uruchom)

Przykład: otwarcie konkretnego towaru i zrzut ekranu do oceny wyglądu formularza.

```bash
BUSCALL=<ścieżka>/buscall     # binarka z katalogu build projektu BusCall
DB=Demo

# 1) nawigacja do listy (pierwsze wywołanie może wystartować frame — daj czas)
"$BUSCALL" --db "$DB" call navigate_to_folder "programFolderPath=Handel/Kartoteki/Towary i usługi"

# 2) retrieve_list — MUSI poprzedzać open_form (oznacza wiersze jako odwiedzone)
ID=$("$BUSCALL" --db "$DB" call retrieve_list | jq -r '.data.rows[0].objectID')

# 3) otwarcie formularza po liczbowym objectID
"$BUSCALL" --db "$DB" call open_form tableName=Towary objectID="$ID"

# 4) (opcjonalnie) zmiana zakładki
"$BUSCALL" --db "$DB" call switch_form_page pageID=TowarCennikKontrahentowPage

# 5) zrzut ekranu bieżącego widoku -> ścieżka do PNG (otwórz go i obejrzyj)
"$BUSCALL" --db "$DB" call take_screenshot
```

Uwagi praktyczne:
- Pierwsze wywołanie po starcie bywa wolne (uruchomienie/logowanie frame'a) — dawaj timeout ~120–300 s
  (zimny start po ubiciu serwerów potrafi przekroczyć 2 min). Kolejne `call`-e są szybkie (frame w tle).
- `retrieve_list` **musi** poprzedzać `open_form` (inaczej „unsafe open").
- Aby przeładować kod, ubij osierocone `server.dll`/`web.dll` i zwolnij porty (patrz wyżej) — samo
  `grep SonetaFrameNew` NIE wystarczy.

Pełna składnia metod, `methods.list` i wariant `callmcp`: [buscall.md](buscall.md).
