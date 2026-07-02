# `buscall` — zdalne wywoływanie metod aplikacji (referencja)

Narzędzie CLI do **zdalnego sterowania działającą aplikacją Soneta/enova365**: nawigacja po
folderach programu, otwieranie formularzy, odczyt i edycja gridów, zmiana pól, zrzuty ekranu.
`buscall` mostuje pojedyncze wywołanie do uruchomionego GUI (`SonetaFrameNew`), które wykonuje
metodę warstwy **Bundle** i zwraca wynik jako JSON.

To referencja **funkcji i składni**. Konkretne zastosowanie — wizualna weryfikacja kodu podczas
developmentu (konfiguracja bazy, rebuild, pułapki procesów) — opisuje
[buscall-live-testing.md](buscall-live-testing.md).

## Uruchamianie i tryby

Binarka `buscall` (oraz `BusCall.dll`) leży w katalogu build projektu BusCall
(`bin/Debug/net10.0/`) — podstaw własną ścieżkę:

```bash
<ścieżka>/buscall --db <Baza> <tryb> …          # albo: dotnet <ścieżka>/BusCall.dll …
```

- **`call`** — pojedyncze wywołanie: `buscall --db <Baza> call <metoda> [klucz=wartość ...]`.
  Wykonuje **jedną** metodę, wypisuje wynik JSON na STDOUT i kończy proces. Bez handshake'u
  i utrzymywania procesu. **Domyślny, najprostszy tryb.**
- **`callmcp`** — wariant zgodny ze standardem **MCP**: czyta z STDIN komunikat JSON-RPC 2.0
  `tools/call` i zwraca odpowiedź MCP (patrz sekcja na końcu). Do własnych orkiestratorów.
- `mcp` (dawny) — długożyjący serwer stdio JSON-RPC; nadal działa, ale do większości zadań
  zbędnie skomplikowany względem `call`.

`--db <Baza>` wskazuje **nazwę połączenia bazy** zdefiniowaną w SonetaFrame (nie fizyczną nazwę
bazy SQL). To połączenie decyduje też, z jakiego kodu startuje aplikacja — szczegóły w
[buscall-live-testing.md](buscall-live-testing.md).

## Argumenty metod: pary `klucz=wartość`

W trybie `call` argumenty podaje się jako **pary `klucz=wartość`** po nazwie metody. Wartość jest
interpretowana jako JSON, gdy jest poprawnym literałem (liczba, `true`/`false`/`null`, tekst
w cudzysłowie, obiekt/tablica); w przeciwnym razie traktowana jako zwykły string:

```bash
buscall --db Demo call navigate_to_folder programFolderPath=Handel        # string
buscall --db Demo call open_form tableName=Towary objectID=2              # objectID = liczba
buscall --db Demo call update_field_value 'fieldsValues=["Nazwa=Buciki"]' # wartość = tablica JSON
```

- Wartości ze spacjami/znakami specjalnymi ujmij w cudzysłów powłoki:
  `"programFolderPath=Handel/Kartoteki/Towary i usługi"`.
- Wartość będąca JSON-em (obiekt/tablica) — cały argument w apostrofach powłoki, aby powłoka
  nie interpretowała `{}`/`[]`.
- Metoda bez argumentów: po prostu `buscall --db Demo call where_I_am`.

## Odkrywanie metod i ich parametrów

Nie zgaduj nazw ani parametrów — odpytaj `methods.list` (zwraca schematy: `name`, `description`,
`parameters`, `*Hint`):

```bash
buscall --db Demo call methods.list                                        # pełne schematy
buscall --db Demo call methods.list | jq -r '.[].name'                     # same nazwy metod
buscall --db Demo call methods.list | jq '.[] | select(.name=="open_form") | .parameters'
```

## Odkrywanie ścieżki folderów

Ścieżkę do listy odkrywaj **nawigacją**, nie zgadując. `navigate_to_folder` zwraca albo **menu
podfolderów** (`kind: folderMenu`, pole `folders[]` z `programFolderPath`/`type`), albo — dla
foldera `type: list` — **od razu otwiera listę** (nie trzeba wtedy osobnego `retrieve_list`, aby
ją wyświetlić czy zrobić zrzut; `retrieve_list` jest wymagany dopiero przed `open_form`). Korzeń
menu programu odkryjesz podając **pusty** `programFolderPath`:

```bash
buscall --db Demo call navigate_to_folder programFolderPath=""                      # korzeń: główne moduły
buscall --db Demo call navigate_to_folder "programFolderPath=Kadry i płace/Kadry"   # drążenie w głąb
# wpis z "type":"list" — nawigacja do niego otwiera listę:
buscall --db Demo call navigate_to_folder "programFolderPath=Kadry i płace/Kadry/Pracownicy"
```

## Katalog metod (warstwa Bundle)

| Metoda | Do czego |
|---|---|
| `where_I_am` | bieżące położenie w aplikacji (bez argumentów) |
| `navigate_to_folder` | przejście do foldera programu, np. `programFolderPath=Handel/Kartoteki/Towary i usługi` |
| `retrieve_list` | odczyt danych listy (stronicowane); zwraca `data.rows[{objectID,values}]` i oznacza wiersze jako „odwiedzone" (wymagane przez `open_form`) |
| `open_form` | otwarcie formularza obiektu: `tableName=Towary objectID=<id>` |
| `search_object` | otwarcie formularza po warunku: `tableName=… objectSelector=Kod=…` |
| `switch_form_page` | zmiana zakładki formularza: `pageID=TowarCennikKontrahentowPage` |
| `get_grid_rows` | pełny grid z formularza + filtr regex: `gridPath=… regexFilter=… regexOptions=IgnoreCase` |
| `update_field_value` | zmiana pól: `'fieldsValues=["Nazwa=Buciki"]'` |
| `edit_grid_rows` | edycja / dodanie / usunięcie wierszy grida in-place |
| `take_screenshot` | zrzut ekranu bieżącego widoku → ścieżka do PNG (patrz niżej) |

Pełny, aktualny zestaw metod i ich parametry daje `methods.list` — powyższa tabela to najczęściej
używane. Grid w danych formularza jest domyślnie **obcinany do kilku wierszy** (`data.truncated=true`);
pełną zawartość pobiera `get_grid_rows`.

### `retrieve_list` przed `open_form`

`retrieve_list` **musi** poprzedzać `open_form` — oznacza wiersze jako „odwiedzone", inaczej próba
otwarcia kończy się błędem „unsafe open". Typowy łańcuch: `navigate_to_folder` → `retrieve_list`
→ `open_form`.

### `take_screenshot` — kontrakt

Robi zrzut **bieżącego widoku** aplikacji. **Frame** zapisuje PNG w katalogu tymczasowym i zwraca
**samą ścieżkę** do pliku (bez base64, bez obrazu inline):

```bash
SHOT=$(buscall --db Demo call take_screenshot)
echo "$SHOT"     # np. /var/folders/.../T/soneta-screenshots/screenshot-<data>.png
```

- Schemat deklaruje opcjonalny parametr `databaseName` („przełącza bazę przed zrzutem"); w praktyce
  wołaj **bez argumentów**, aby zrzucić bieżący widok.
- Wymaga prawa `Zrzuty ekranu` (`BundleRights.Screenshots`) w roli operatora.
- Pliki są efemeryczne — kasuje je **Frame** (proces długożyjący) przy starcie serwera pipe;
  krótkożyjący `call` pliku **nie** usuwa, więc ścieżka pozostaje ważna po zakończeniu polecenia.

Wykorzystanie zrzutu do wizualnej weryfikacji layoutu/pól opisuje [buscall-live-testing.md](buscall-live-testing.md).

## Wyniki i kody wyjścia

- **Wynik metody** wraca jako JSON na STDOUT.
- **Błąd wykonania metody** (np. złe `regexOptions`, brak prawa) → JSON `{"kind":"error","error":"..."}`
  na STDOUT, **kod wyjścia 0** (samo wywołanie się powiodło).
- **Błąd samego wywołania** (nieznana metoda, brak połączenia z pipe) → komunikat na **STDERR**
  i **kod wyjścia 1**.

## Wariant zgodny z MCP: `callmcp`

Gdy potrzebujesz warstwy zgodnej z protokołem MCP (np. własny orkiestrator budujący JSON-RPC),
użyj `callmcp` — czyta **cały STDIN** jako pojedynczy komunikat JSON-RPC 2.0 `tools/call`, wykonuje
go i wypisuje na STDOUT **odpowiedź JSON-RPC MCP** (`result` = CallToolResult lub `error`):

```bash
echo '{"jsonrpc":"2.0","id":1,"method":"tools/call","params":{"name":"where_I_am","arguments":{}}}' \
  | buscall --db Demo callmcp
# -> {"jsonrpc":"2.0","id":1,"result":{"content":[{"type":"text","text":"…"}],"isError":false}}
```

Błąd wykonania narzędzia wraca zgodnie z konwencją MCP w `result` z `isError:true` (a nie jako
JSON-RPC `error`); błąd parsowania/nieprawidłowy komunikat → JSON-RPC `error` i kod wyjścia 1.
