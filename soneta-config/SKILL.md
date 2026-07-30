---
name: soneta-config
description: >
  Narzędzia i mechanizmy platformy Soneta (enova365, Triva) związane z konfiguracją
  systemu i funkcjami domenowymi. Obecnie: (A) IMPORT/EKSPORT DANYCH I USTAWIEŃ
  KONFIGURACYJNYCH przez pliki XML — struktura pliku `<session>`, import według rekordów
  (business="false", pliki *.dbinit.xml, baza demo), import przez logikę biznesową
  (business="true"), eksport datapacku, identyfikacja rekordów po GUID, formaty wartości;
  (B) `scan-folders` — inwentaryzacja statycznych folderów menu (`[assembly: FolderView]`)
  z bibliotek DLL; (C) KONFIGURACJA URUCHOMIENIOWA `appsettings.json` — porty i adresy
  komponentów (orchestrator/server/web/webapi/webwcf/router/commhub), kolejność nadpisań
  konfiguracji (profil systemu, nakładki `-c`, zmienne `SONETA_`, argumenty CLI), znaczenie
  kluczy; (D) REJESTR KONFIGURACJI (ConfigReg, „Zarządzanie konfiguracją") — zrzut całej
  konfiguracji bazy do pliku `*.reg.json`, porównanie dwóch baz, scalanie paczek ustawień,
  sigile formatu (`$strict`, `$v`, `#klucz`, `@atrybut`, `$blob`), ścieżki węzłów.
  Używaj gdy użytkownik: (1) buduje lub analizuje plik XML importu danych
  do platformy Soneta (dbinit.xml, dane demo, przenoszenie ustawień między bazami);
  (2) pyta o atrybuty guid/where/key/id/business/deleted/dbversion w XML Soneta;
  (3) eksportuje rekordy guidowane do XML; (4) chce zmapować strukturę menu programu
  z DLL (drzewo folderów, listy, formularze) lub wpiąć nowy folder w istniejące menu;
  (5) konfiguruje porty/adresy komponentów albo pyta, co robi klucz w `appsettings.json`
  i która warstwa go nadpisuje; (6) pyta o rejestr konfiguracji, ConfigReg lub menu
  „Zarządzanie konfiguracją", buduje albo debuguje plik `*.reg.json`, przenosi ustawienia
  między bazami przez rejestr lub diagnozuje, czemu wiersz nie został dopasowany przy scalaniu.
  Warstwa kodu importu (SessionReader/SessionWriter) i ORM → /soneta-programming;
  operacje na bazie z CLI → /soneta-tools.
---

# Ustawienia, konfiguracja i funkcje domenowe platformy Soneta (enova365, Triva)

Skill gromadzi narzędzia i mechanizmy związane z **konfiguracją systemu** oraz
**funkcjami domenowymi** platformy Soneta. Zawartość jest rozwijana — poniżej udokumentowane
są wyłącznie mechanizmy faktycznie obecne w skillu; kolejne artykuły dodawane są sukcesywnie.

## Kiedy ten skill, a kiedy inny

| Potrzeba | Skill |
|---|---|
| **Budowa pliku XML importu/eksportu danych i ustawień** (dbinit.xml, demo, przenoszenie konfiguracji) | **/soneta-config** ([import-export-xml](references/import-export-xml.md)) |
| Inwentaryzacja/mapa **folderów statycznych menu** (`[assembly: FolderView]`) z DLL | **/soneta-config** ([scan-folders](references/scan-folders.md)) |
| **Konfiguracja uruchomieniowa** (porty, adresy komponentów, warstwy nadpisań `appsettings.json`) | **/soneta-config** ([appsettings](references/appsettings.md)) |
| **Rejestr konfiguracji** (ConfigReg): `*.reg.json`, porównanie i scalanie ustawień między bazami | **/soneta-config** ([config-reg](references/config-reg.md)) |
| Kod obsługujący import/eksport (`SessionReader`/`SessionWriter`), klasy ORM, workery | [/soneta-programming](../soneta-programming/SKILL.md) |
| Inwentaryzacja modułów/tabel (`scan-modules`), pól (`scan-props`), workerów (`scan-workers`) | [/soneta-programming](../soneta-programming/SKILL.md) |
| Operacje na bazie z CLI (dbmgr), test na żywej aplikacji (buscall) | [/soneta-tools](../soneta-tools/SKILL.md) |
| Definicja struktury tabel/kolumn/relacji w XML (business.xml) | [/soneta-business-xml](../soneta-business-xml/SKILL.md) |
| Formularze i widoki UI (form.xml) | [/soneta-form-xml](../soneta-form-xml/SKILL.md) |
| Planowanie całego dodatku/modułu | [/soneta-addon-planning](../soneta-addon-planning/SKILL.md) |

## Artykuły i narzędzia

### Import i eksport danych przez XML — [references/import-export-xml.md](references/import-export-xml.md)

Struktura i sposób budowania plików XML (`<session xmlns="http://www.soneta.pl/schema/business">`)
do wczytywania danych i ustawień konfiguracyjnych oraz ich eksportu. Trzy części:

1. **Import według rekordów** (domyślny) — dane wprost do pól rekordów, bez logiki biznesowej;
   kolejność pól bez znaczenia; do danych konfiguracyjnych, plików `*.dbinit.xml` i bazy demo.
2. **Import przez logikę biznesową** (`business="true"`) — ustawianie właściwości biznesowych
   z pełną walidacją; kolejność elementów jak przy wpisywaniu danych na formularzu.
3. **Eksport** — wskazany rekord guidowany + rekordy powiązane (datapack), wynik zdatny
   do ponownego importu; podstawa przenoszenia ustawień między bazami.

Artykuł specyfikuje identyfikację rekordów (GUID, `where`, `key`, `id`), formaty wartości
(liczby, daty, referencje, kwoty z walutą), atrybuty specjalne oraz reguły plików
`*.dbinit.xml` (`priority`, `versionName`, `dbversion`). Zawiera też gotowy, zweryfikowany
importem **przykład** (obiekt w modelu „root + historia") —
[examples/import-pracownik-etatowy.xml](examples/import-pracownik-etatowy.xml).

### `scan-folders` — [references/scan-folders.md](references/scan-folders.md)

Buduje drzewo **folderów statycznych menu** programu z atrybutów assembly
`[assembly: FolderView(...)]` (oraz pochodnych) w skompilowanych bibliotekach. Klasyfikuje
węzły na listy (`ViewInfoType`/`ViewType`/`TableName`), formularze (`ObjectType`) i menu;
przy widokach pokazuje `Description` oraz powiązaną tabelę/`ViewInfo`. Filtr prefiksem ścieżki
i tryb `--flat`. Czyta metadane przez Roslyn — bez uruchamiania aplikacji i bez ładowania IL
do CLR. Skrypt: [scripts/scan-folders.csx](scripts/scan-folders.csx).

Perspektywa **funkcjonalno-użytkowa** (co użytkownik klika w menu) — komplementarna do
perspektywy **danych** (`scan-modules`) i **pól** (`scan-props`) ze skilla
[/soneta-programming](../soneta-programming/SKILL.md). Planistyczne użycie inwentaryzacji
opisuje [/soneta-addon-planning](../soneta-addon-planning/SKILL.md).

### Konfiguracja uruchomieniowa `appsettings.json` — [references/appsettings.md](references/appsettings.md)

Ustawienia uruchomieniowe komponentów (orchestrator, server, web, webapi, webwcf, router,
commhub): **dwa pliki** `appsettings.json` (część back-end i część front-end) i które
komponenty obsługują, mapa domyślnych **portów** oraz **trzy pary adresów, które muszą się
zgadzać** (`Server:Urls`↔`ServerEndpoint`, `Router:Urls`↔`RouterEndpoint`,
`CommHub:Urls`↔`CommHubClient`), **kolejność warstw nadpisań** (plik bazowy → profil systemu
→ nakładka `-c` → zmienne `SONETA_` → argumenty CLI) — źródło najczęstszej pułapki „zmieniłem
`appsettings.json`, a nic się nie zmieniło" — dwa tryby połączenia frontend→serwer
(bezpośredni vs przez router) oraz słownik znaczeń kluczy. Zawiera checklistę zmiany
portu/adresu.

Uruchamianie komponentów, ramki hostującej i zarządzanie bazami opisuje
[/soneta-tools](../soneta-tools/SKILL.md).

### Rejestr konfiguracji (ConfigReg) — [references/config-reg.md](references/config-reg.md)

Zrzut **całej konfiguracji bazy** do jednego drzewa zapisywanego jako `*.reg.json`, który da się
porównać z inną bazą, scalić i wgrać z powrotem (menu **Narzędzia → Zarządzanie konfiguracją**).
Artykuł opisuje pięć operacji formularza, zakres rejestru (co wchodzi, a co zostaje poza nim —
w tym pola wrażliwe), format pliku wraz z sigilami (`$strict`, `$v`, `#klucz`, `@atrybut`,
`$blob`), składnię ścieżek węzłów, semantykę kolekcji `$strict` (**usuwa** wiersze nieobecne
w pliku) oraz diagnostykę najczęstszej pułapki — wiersza pokazywanego jednocześnie jako usunięty
i dodany. Zawiera dwie checklisty: przeniesienie ustawień między bazami i kroki przed scaleniem
do bazy operacyjnej.

**Nie myl dwóch mechanizmów przenoszenia ustawień.** XML (`<session>`, `*.dbinit.xml`) przenosi
*wskazane rekordy* i nie wykrywa różnic. Rejestr zdejmuje *stan konfiguracji jako całość*,
porównuje i scala. Formaty plików są rozłączne — kryterium wyboru i porównanie w tabeli na
początku artykułu.

## Powiązania

- [/soneta-programming](../soneta-programming/SKILL.md) — warstwa kodu importu/eksportu
  (*sessionreader-sessionwriter*), rekordy guidowane (*datapack-guidedrow*), `OnImporting`/
  `OnImported` (*row-types*), testy z `ImportBusinessXml` (*integration-tests*), skany DLL
  (`scan-modules`, `scan-props`, `scan-workers`) oraz pisanie folderów/list w C#.
- [/soneta-addon-planning](../soneta-addon-planning/SKILL.md) — użycie inwentaryzacji menu
  na etapie planowania dodatku.
- [/soneta-tools](../soneta-tools/SKILL.md) — operacje na bazie z CLI, weryfikacja efektów
  importu na żywej aplikacji (buscall).
- [/soneta-business-xml](../soneta-business-xml/SKILL.md) — definicja tabel i kolumn, w tym
  oznaczanie tabeli jako konfiguracyjnej, co decyduje o jej obecności w rejestrze konfiguracji.
- [/soneta-erp](../soneta-erp/SKILL.md) — mapa wyboru skilla.
