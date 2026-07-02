# Testowanie aplikacji na żywo przez `buscall call` (CLI)

Sprawdzony sposób end-to-end na **uruchomienie działającej aplikacji Soneta/enova365 i sterowanie
nią zdalnie** (nawigacja, otwieranie formularzy, odczyt gridów, edycja pól, **zrzuty ekranu**).
Idealny do weryfikacji zmian w kodzie biznesowym/UI na realnej bazie **bez** klikania ręcznego.

**Używaj trybu `call`** — pojedyncze wywołanie CLI: `buscall --db <Baza> call <metoda> [klucz=wartość ...]`.
BusCall startuje, wykonuje **jedną** metodę, wypisuje wynik na STDOUT i **sam się zamyka**. Nie trzeba
zarządzać długożyjącym procesem, robić handshake'u MCP ani utrzymywać stdio (jak w dawnym trybie `mcp`).
Frame (GUI) zostaje uruchomiony przy pierwszym wywołaniu i **pozostaje** w tle — kolejne `call`-e
podłączają się do niego przez named pipe, więc są szybkie.

> Dawny sposób (`buscall … mcp` + klient stdio JSON-RPC utrzymujący proces) nadal działa, ale do
> testów/weryfikacji jest zbędnie skomplikowany. Jeśli potrzebujesz integracji zgodnej **ze standardem
> MCP** (np. własny orkiestrator), użyj `buscall … callmcp` — patrz sekcja na końcu.

## Wymaganie wstępne (jednorazowa konfiguracja)

Parametr `--db Demo` przekazywany do `buscall` odwołuje się do bazy o nazwie **`Demo`
zdefiniowanej wcześniej w aplikacji `SonetaFrame`**. Ta konfiguracja bazy musi być ustawiona tak,
aby **startowała z kodów źródłowych bieżącego projektu** (biblioteki z `~/d/dev/bin/Debug`). Bez tego
`buscall --db Demo call …` albo nie znajdzie bazy, albo uruchomi frame na innym (nieaktualnym) kodzie.

Innymi słowy: nazwa po `--db` = nazwa połączenia bazy w SonetaFrame, a to połączenie decyduje, skąd
ładowany jest kod. Jeśli testujesz inny projekt/bazę, zdefiniuj analogiczne połączenie i podaj jego
nazwę w `--db`.

### Gdzie jest definicja bazy
Konfiguracja połączeń SonetaFrame (macOS):
`~/Library/Application Support/Soneta.Frame/Settings_Standard.json`, tablica **`Sources`**. Każdy wpis
to string z parametrami rozdzielonymi `;`. Przykład bazy `Demo` startującej kod z bieżącego projektu:

```json
"Sources": [
  "process:Demo;caption=dev;path=~/d/dev;user=Administrator;pwd="
]
```

Znaczenie pól:
- `process:Demo` — tryb `process` + **nazwa bazy** `Demo` (to jest wartość podawana w `buscall --db Demo`),
- `caption=dev` — etykieta połączenia w UI,
- `path=~/d/dev` — **katalog projektu, z którego ładowany jest kod** (biblioteki z `~/d/dev/bin/Debug`),
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
(most)                                            └── ładuje Soneta.*.dll z ~/d/dev/bin/Debug
```

- **Ścieżka binarki:** `~/d/SonetaFrameNew/BusCall/bin/Debug/net10.0/buscall`
  (możesz też uruchamiać przez `dotnet ~/d/SonetaFrameNew/BusCall/bin/Debug/net10.0/BusCall.dll`).
- `buscall call` **tylko mostuje** jedno wywołanie przez named pipe do GUI **`SonetaFrameNew`**. To
  **frame** wykonuje metody (warstwa Bundle) i **ładuje biblioteki z `~/d/dev/bin/Debug`**.
- Jeśli frame nie działa, `buscall` **sam go uruchamia** przy pierwszym wywołaniu i czeka na gotowość.
  Frame pozostaje uruchomiony po zakończeniu `call` — kolejne `call`-e podłączą się do niego przez pipe.

### Aby frame miał NOWY kod
1. Przebuduj DLL w dev:
   `dotnet build ~/d/dev/Soneta.Net.Business/Soneta.Net.Business.csproj` (lub właściwy projekt).
2. Upewnij się, że **nie działa stary frame ANI osierocone serwery** — inaczej podłączysz się do
   poprzedniego kodu (patrz „Osierocone serwery i porty" niżej).
3. Pierwsze wywołanie `call` uruchomi świeży frame z nowym DLL.

### Osierocone serwery i porty (częsta pułapka — WERYFIKUJ ZAWSZE)
Frame **nie jest** procesem o nazwie `SonetaFrameNew` — uruchamia dwa procesy `dotnet` z DLL-kami
z `~/d/dev/bin`, które **nasłuchują na portach TCP**:
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

## Argumenty metod: pary `klucz=wartość`

W trybie `call` argumenty metody podaje się jako **pary `klucz=wartość`** po nazwie metody. Wartość jest
interpretowana jako JSON, gdy jest poprawnym literałem (liczba, `true`/`false`/`null`, tekst w cudzysłowie,
obiekt/tablica); w przeciwnym razie traktowana jako zwykły string:

```bash
buscall --db Demo call navigate_to_folder programFolderPath=Handel      # string
buscall --db Demo call open_form tableName=Towary objectID=2            # objectID = liczba
buscall --db Demo call update_field_value 'fieldsValues=["Nazwa=Buciki"]'  # wartość = tablica JSON
```

- Wartości ze spacjami/znakami specjalnymi ujmij w cudzysłów powłoki: `"programFolderPath=Handel/Kartoteki/Towary i usługi"`.
- Wartość będąca JSON-em (obiekt/tablica) — cały argument w apostrofach powłoki, aby nie interpretowała `{}`/`[]`.
- Metoda bez argumentów: po prostu `buscall --db Demo call where_I_am`.

### Odkrywanie ścieżki folderów
Ścieżkę do listy odkrywaj nawigacją, nie zgadując. `navigate_to_folder` zwraca albo **menu podfolderów**
(`kind: folderMenu`, pole `folders[]` z `programFolderPath`/`type`), albo — dla foldera `type: list` —
**od razu otwiera listę** (nie trzeba wtedy osobnego `retrieve_list`, aby ją wyświetlić czy zrobić zrzut;
`retrieve_list` jest wymagany dopiero przed `open_form`). Korzeń menu programu odkryjesz podając **pusty
`programFolderPath`**:

```bash
buscall --db Demo call navigate_to_folder programFolderPath=""            # korzeń: główne moduły
buscall --db Demo call navigate_to_folder "programFolderPath=Kadry i płace/Kadry"   # drążenie w głąb
# gdy trafisz na wpis z "type":"list" — nawigacja do niego otwiera listę:
buscall --db Demo call navigate_to_folder "programFolderPath=Kadry i płace/Kadry/Pracownicy"
```

### Odkrywanie metod i ich parametrów
```bash
# pełna lista metod ze schematami (name, description, parameters, *Hint):
buscall --db Demo call methods.list
# nazwy metod:
buscall --db Demo call methods.list | jq -r '.[].name'
# parametry konkretnej metody:
buscall --db Demo call methods.list | jq '.[] | select(.name=="open_form") | .parameters'
```

## Kluczowe narzędzia (metody Bundle)

| Narzędzie | Do czego |
|---|---|
| `navigate_to_folder` | przejście do foldera programu, np. `programFolderPath=Handel/Kartoteki/Towary i usługi` |
| `retrieve_list` | odczyt danych listy (stronicowane); zwraca `data.rows[{objectID,values}]` i oznacza wiersze jako „odwiedzone" (wymagane przez `open_form`) |
| `open_form` | otwarcie formularza obiektu: `tableName=Towary objectID=<id>` |
| `search_object` | otwarcie formularza po warunku: `tableName=… objectSelector=Kod=…` |
| `switch_form_page` | zmiana zakładki: `pageID=TowarCennikKontrahentowPage` |
| `get_grid_rows` | pełny grid z formularza + filtr regex: `gridPath=… regexFilter=… regexOptions=IgnoreCase` |
| `update_field_value` | zmiana pól: `'fieldsValues=["Nazwa=Buciki"]'` |
| `edit_grid_rows` | edycja/dodanie/usunięcie wierszy grida in-place |
| `take_screenshot` | **zrzut ekranu bieżącego okna** (patrz niżej) |

Grid w danych formularza jest domyślnie **obcinany do kilku wierszy** (`data.truncated=true`); pełną
zawartość pobiera `get_grid_rows`.

## Zrzuty ekranu — analiza wizualna okien/formularzy

`take_screenshot` robi zrzut **bieżącego widoku** aplikacji — tego miejsca, w którym jest teraz otwarta
baza. **Frame** zapisuje go do pliku PNG w katalogu tymczasowym i zwraca **samą ścieżkę** do tego pliku
(`/var/folders/.../T/soneta-screenshots/screenshot-<data>.png`) — bez base64, bez obrazu inline.

Schemat metody deklaruje jeden **opcjonalny** parametr `databaseName` (string) — wg opisu „przełącza bazę
przed zrzutem". W praktyce wołaj metodę **bez argumentów** (`call take_screenshot`), aby zrzucić bieżący
widok; bieżąca implementacja frame'a zrzuca aktualny widok i tego parametru nie wymaga.

```bash
SHOT=$(buscall --db Demo call take_screenshot)
echo "$SHOT"     # ścieżka do PNG
```

Otwórz plik z podanej ścieżki i **obejrzyj go** (narzędziem czytającym obrazy) — pozwala wizualnie
zweryfikować layout formularza, wartości pól, widoczność kontrolek, motyw itp.
Wymaga prawa `Zrzuty ekranu` (`BundleRights.Screenshots`) w roli operatora.

Pliki są efemeryczne — **czyści je Frame** (proces długożyjący) przy starcie serwera pipe. Krótkożyjący
`call` **nie** kasuje pliku, więc ścieżka pozostaje ważna po zakończeniu polecenia — możesz ją bezpiecznie
odczytać/obejrzeć.

## Minimalny przepływ (skopiuj i uruchom)

Handshake nie jest potrzebny — każde `call` to niezależne wywołanie. Przykład: otwarcie konkretnego
towaru i zrzut ekranu.

```bash
BUSCALL=~/d/SonetaFrameNew/BusCall/bin/Debug/net10.0/buscall
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
- `retrieve_list` **musi** poprzedzać `open_form` (oznacza wiersze jako odwiedzone — inaczej „unsafe open").
- Wynik metody błędnej (np. złe `regexOptions`, brak prawa) wraca jako JSON `{"kind":"error","error":"..."}`
  na STDOUT (exit 0). Błąd samego wywołania (brak metody, brak połączenia z pipe) → komunikat na **STDERR**
  i **kod wyjścia 1**.
- Frame zostaje uruchomiony po teście — kolejne wywołania podłączą się do niego przez pipe
  (bez mnożenia procesów). Aby przeładować kod, ubij osierocone `server.dll`/`web.dll` i zwolnij porty
  (patrz „Osierocone serwery i porty" wyżej) — samo `grep SonetaFrameNew` NIE wystarczy.

## Alternatywa zgodna ze standardem MCP: `callmcp`

Gdy potrzebujesz warstwy zgodnej z protokołem MCP (np. własny orkiestrator budujący komunikaty
JSON-RPC), użyj `callmcp` — czyta **cały STDIN** jako pojedynczy komunikat JSON-RPC 2.0 `tools/call`,
wykonuje go i wypisuje na STDOUT **odpowiedź JSON-RPC MCP** (`result` = CallToolResult lub `error`),
po czym kończy proces:

```bash
echo '{"jsonrpc":"2.0","id":1,"method":"tools/call","params":{"name":"where_I_am","arguments":{}}}' \
  | buscall --db Demo callmcp
# -> {"jsonrpc":"2.0","id":1,"result":{"content":[{"type":"text","text":"…"}],"isError":false}}
```

Błąd wykonania narzędzia wraca zgodnie z konwencją MCP w `result` z `isError:true` (a nie jako JSON-RPC
`error`); błąd parsowania/nieprawidłowy komunikat → JSON-RPC `error` i kod wyjścia 1.

## Weryfikacja jednostkowa tej samej warstwy
Metody Bundle mają też testy NUnit w projekcie `Soneta.Net.Test` (klasa `BundleTest`,
`namespace Soneta.Net.Test.Bundles`). Uruchamianie:
`dotnet test --project Soneta.Net.Test/Soneta.Net.Test.csproj --filter "FullyQualifiedName~BundleTest.<Nazwa>"`.
Wzorzec: `NavigateFolder` → `MarkVisited` → `HandleBundle<T>(nameof(...), new {...})`.
```
