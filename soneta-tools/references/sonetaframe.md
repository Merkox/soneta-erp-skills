# `SonetaFrame` — aplikacja ramki (referencja)

`SonetaFrame` / `SonetaFrameNew` to **aplikacja ramki** hostująca webową wersję
aplikacji platformy Soneta. Obie nazwy funkcjonują równolegle i odnoszą się do tej samej
ramki. Wewnątrz swojej wbudowanej przeglądarki uruchamia interfejs web
programu, a jednocześnie wykonuje zadania, których sama przeglądarka wykonać nie może —
ze względu na ograniczenia silnika skryptowego lub polityki bezpieczeństwa. Ramka zarządza też
wieloma połączeniami do różnych baz danych, znacznie upraszczając pracę operatorów.

Ramka jest ściśle powiązana z `buscall` — to właśnie do uruchomionej instancji ramki
`buscall` kieruje wywołania metod warstwy Bundle (patrz [buscall.md](buscall.md)).

## Uruchamianie

Standardowo przez `dotnet`:

```bash
dotnet SonetaFrameNew.dll
```

Bez parametrów ramka pokazuje menu wyboru połączeń/baz danych.

## Parametry uruchomieniowe

| Parametr | Skrót | Argument | Działanie |
|---|---|---|---|
| `--start` | `-s` | `<baza>` | Automatycznie uruchamia aplikację w zadanej, wcześniej zarejestrowanej bazie danych. Menu programu nie jest pokazywane — od razu otwiera się menu bazy. |
| `--connection` | `-c` | `<połączenie-bazy>` | Definiuje źródło baz danych (connection string) określające, jak ramka ma połączyć się z bazą. Można podać **wielokrotnie**, definiując więcej niż jedno połączenie. Gdy użyty, konfiguracje połączeń **nie** są wczytywane z pliku konfiguracyjnego. |

```bash
dotnet SonetaFrameNew.dll -s Demo
dotnet SonetaFrameNew.dll -c "process:Demo;path=~/d/dev" -c "demo:"
```

## Plik konfiguracyjny

Ustawienia ramki przechowywane są w pliku JSON w katalogu danych aplikacji użytkownika,
w podkatalogu `Soneta.Frame`. Nazwa pliku zależy od wersji produktu:
`Settings_Standard.json` lub `Settings_Premium.json`.

Lokalizacja zależnie od platformy:

| Platforma | Lokalizacja |
|---|---|
| **macOS** | `~/Library/Application Support/…/Soneta.Frame/Settings_<Product>.json` |
| **Windows** | `%APPDATA%\Soneta.Frame\Settings_<Product>.json` (czyli `C:\Users\<user>\AppData\Roaming\Soneta.Frame\`) |
| **Linux** | `$XDG_CONFIG_HOME/Soneta.Frame/…` lub `~/.config/Soneta.Frame/Settings_<Product>.json` |

Przykładowa zawartość:

```json
{
  "WindowX": 170,
  "WindowY": 218,
  "WindowWidth": 2342,
  "WindowHeight": 1478,
  "Maximized": false,
  "Sources": [
    "demo:",
    "process:OcenaKontrahenta;caption=OcenaKontrahenta;path=~/d/dev;config-file=/Users/marcin/p/Ocena Kontrahenta/serversettings.json",
    "process:Demo;caption=dev;path=~/d/dev",
    "process:Test2;caption=Addon;path=~/d/dev;user=Administrator;pwd=;config-file=/Users/marcin/Desktop/app.json",
    "http://localhost:5005;user=Administrator;pwd=;caption=Demo",
    "process:Test;path=~/d/dev"
  ],
  "Favorites": null,
  "Language": null,
  "Theme": "Dark",
  "AutoStartDatabase": "",
  "RemoveConnWizard": false,
  "IsDeveloperMode": true,
  "DisableAutoUpdate": false,
  "DefaultPrinter": "",
  "AiAgent": "Codex",
  "TerminalDock": "Right",
  "TerminalHeight": 290,
  "TerminalWidth": 627
}
```

Znaczenie kluczowych pól:

| Pole | Znaczenie |
|---|---|
| `WindowX` / `WindowY` / `WindowWidth` / `WindowHeight` / `Maximized` | Położenie i rozmiar okna aplikacji. |
| `Sources` | Lista **źródeł baz danych** — connection stringi opisujące, skąd pobierane są bazy widoczne w programie (patrz niżej). |
| `Favorites` | Bazy oznaczone jako ulubione. |
| `AutoStartDatabase` | Baza, z której aplikacja startuje automatycznie (odpowiednik `-s`/`--start`). |
| `Language` / `Theme` | Język oraz kolorystyka interfejsu (`Light` / `Dark`). |
| `IsDeveloperMode` | Tryb deweloperski udostępniający funkcje szczególne. |
| `DisableAutoUpdate` | Wyłączenie automatycznej aktualizacji. |
| `RemoveConnWizard` | Ukrycie kreatora połączeń. |
| `DefaultPrinter` | Domyślna drukarka. |
| `AiAgent` | Agent AI używany w aplikacji (np. `Codex`). |
| `TerminalDock` / `TerminalHeight` / `TerminalWidth` | Umiejscowienie i wymiary wbudowanego terminala. |

## Źródła baz danych (connection string)

Każdy wpis w `Sources` (albo argument `-c`/`--connection`) to **connection string** opisujący,
w jaki sposób dostarczane są bazy danych wyświetlane w programie. Źródeł może być wiele,
działających na różne sposoby. Do każdego można dodać wspólne modyfikatory (operator, hasło,
caption itd. — patrz koniec sekcji).

### Baza demonstracyjna

```
demo:
demo:baza_danych
```
Podłączenie do demonstracyjnej bazy danych (`demo`, `demomobile`).

### Serwer HTTP

```
https://serwer
https://serwer;db=baza_danych
http://serwer
```
Odczytanie listy baz danych z serwera; opcjonalnie `db=` ogranicza do jednej bazy z listy.

### Docker

```
docker:baza_danych
```
Utworzenie na Dockerze lokalnego serwera programu w aktualnej wersji, z automatycznym
utworzeniem serwera SQL.

```
docker:baza_danych;version=2506.0.0
```
Jak wyżej, ale w określonej wersji programu.

```
docker:baza_danych;version=2506.0.0;sqlserver=.;sqluser=;sqlpwd=
```
Lokalny serwer programu połączony do **zewnętrznego** serwera SQL.

```
docker:baza_danych;sqldb=sql_baza_danych
```
Baza danych na serwerze SQL, jeżeli jej nazwa jest inna niż `baza_danych`.

```
docker:baza_danych;repo=repozytorium_obrazow
```
Adres repozytorium obrazów Dockera; wartości `public` (domyślna) lub `internal`.

```
docker:baza_danych;port=60123;keeprunning=1
```
- `port` — port, na którym wystawiony będzie serwer WWW (standardowo `60001`+),
- `keeprunning=1` — zachowuje kontener uruchomiony po zamknięciu aplikacji.

### Procesy lokalne

```
process:baza_danych;path=~/dev/bin
```
Uruchomienie serwera biznesowego i web jako procesów; `path` określa katalog, w którym
poszukiwane są pliki DLL.

```
process:baza_danych;path=...;port=5005;serverport=22000
```
Pozwala określić porty serwera web-owego (`port`) oraz biznesowego (`serverport`).

### Orchestrator

```
orchestrator:baza_danych;path=~/dev/bin
```
Wariant `process:` — również uruchamia serwery lokalnie na maszynie, ale procesami zarządza
program `orchestrator.dll` (inny sposób startu procesów). Przyjmuje te same parametry co
`process:` (m.in. `path`, `port`, `serverport`).

### Wspólne modyfikatory (dla każdego źródła)

| Modyfikator | Znaczenie |
|---|---|
| `;user=Administrator;pwd=` | Operator i hasło programu. |
| `;config-file=path-to-appsettings.json` | Indywidualne ustawienia serwerów. |
| `;trusted=true` | Połączenie traktowane jako zaufane. |
| `;caption=Nazwa_w_menu` | Alternatywna nazwa wyświetlana w menu. |

## Powiązania

- **`buscall`** ([buscall.md](buscall.md)) — kieruje wywołania metod do uruchomionej ramki;
  `--db <Baza>` w `buscall` odwołuje się do wpisu połączenia zdefiniowanego w tej ramce.
- **`dbmgr`** ([dbmgr.md](dbmgr.md)) — operacje na strukturze/danych baz, które ramka później
  wyświetla i uruchamia.
