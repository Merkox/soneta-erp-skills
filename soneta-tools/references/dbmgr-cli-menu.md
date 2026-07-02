# Interaktywne menu CLI wokół `dbmgr` (wzorzec + gotowy skrypt)

Praktyczny przykład, jak owinąć `dbmgr` w **interaktywne menu** zamiast pamiętać komendy
i długie listy opcji. To zarazem realny use-case narzędzia i pokazowy wzorzec budowy
**UI w konsoli** na jednoplikowej aplikacji C#.

Gotowy skrypt: [../assets/dbmgr-menu.cs](../assets/dbmgr-menu.cs). Skopiuj go, dostosuj
ścieżki/poświadczenia i uruchamiaj u siebie.

## Co robi

Wyświetla pętlę menu (Spectre.Console `SelectionPrompt`) z akcjami: `List`, `Create`,
`Drop`, `Convert`, `Restore`, `Backup` oraz przełącznikami trybu. Wybór akcji, która
operuje na bazie, najpierw **pobiera listę baz z `dbmgr list`** i pozwala wskazać bazę
strzałkami — bez ręcznego wpisywania nazwy. Create zakłada bazę demo `gold` z licencją,
Backup/Restore operują na katalogu backupów serwera SQL.

## Ciekawe techniki (przenośne do innych narzędzi)

### 1. Jednoplikowa, uruchamialna aplikacja C# (.NET 10 file-based app)

```csharp
#!/usr/local/share/dotnet/dotnet run   // shebang → plik .cs jest wykonywalny
#:package Spectre.Console.Cli@*          // deklaracja pakietu NuGet inline (bez .csproj)
```

- `chmod +x dbmgr-menu.cs` → uruchamiasz przez `./dbmgr-menu.cs`.
- Albo bez shebanga: `dotnet run dbmgr-menu.cs`.
- Dyrektywa `#:package` pobiera NuGet w locie — nie potrzeba projektu ani `dotnet add package`.

### 2. Cienki wrapper wywołujący `dbmgr` przez `Process`

```csharp
var premium = "--standard";                    // wspólna opcja doklejana do każdego wywołania
void DbMgr(params string[] args) {
    var allArgs = args.Append(premium).ToArray();
    var p = Process.Start(new ProcessStartInfo {
        FileName = "dotnet", Arguments = $"{dbmgr} {string.Join(" ", allArgs)}",
        UseShellExecute = false               // output leci wprost na konsolę
    });
    p!.WaitForExit();
}
// użycie: DbMgr("create", db, "--recreate", "--demo=gold");
```

Wszystkie akcje sprowadzają się do złożenia argumentów i oddania sterowania `dbmgr` —
to samo podejście zadziała dla `buscall` czy dowolnego innego CLI.

### 3. Odczyt listy baz z `dbmgr list -o json` → menu wyboru

Skrypt uruchamia `dbmgr list -o json` z `RedirectStandardOutput = true` i **deserializuje
JSON** — zamiast parsować tabelę tekstową dla człowieka. `-o json` to stabilny kontrakt
maszynowy: `[{Name, Active, Server, Database, Status, Message}, …]`. Logi lecą na `stderr`,
więc `stdout` to czysty JSON (dla pewności bierzemy podłańcuch od pierwszego `[`).

```csharp
var start = output.IndexOf('[');
using var doc = JsonDocument.Parse(output[start..]);
var dbs = doc.RootElement.EnumerateArray()
    .Select(e => e.GetProperty("Name").GetString()!)
    .ToList();
var db = AnsiConsole.Prompt(new SelectionPrompt<string>().Title(desc).AddChoices(dbs));
```

> **Dlaczego nie parsować tabeli:** domyślny output `dbmgr list` jest sformatowany pod
> czytelność (ramki, separatory `──`) i może zmienić układ; `-o json` jest niezależny
> od prezentacji. Ta sama zasada dotyczy `info`, `status`, `extlist`.

### 4. Pętla menu z przełącznikami stanu

Główna pętla `for(;;)` pokazuje menu i rozgałęzia się po pierwszej literze wyboru
(`opt[0]`). Dwie pozycje **przełączają stan** kolejnych wywołań:

- `Version` — przełącza `--standard` ⇄ `--premium` (którą konfigurację baz brać),
- `Folder` — przełącza między dwiema lokalizacjami buildu narzędzia (np. dwa checkouty
  repozytorium / dwie gałęzie), aby uruchamiać `dbmgr` z wybranego katalogu.

Dzięki temu jedno menu obsługuje kilka środowisk bez edycji kodu.

## Uruchomienie

```bash
chmod +x dbmgr-menu.cs      # jednorazowo
./dbmgr-menu.cs             # lub: dotnet run dbmgr-menu.cs
```

Wymaga zainstalowanego .NET SDK 10 (`dotnet`) — pakiet `Spectre.Console` dociągnie się sam.

## Zanim użyjesz — dostosuj do środowiska

Skrypt jest szablonem pod konkretną maszynę. Sprawdź/zmień:

- **Poświadczenia i serwer SQL** — w `assets/dbmgr-menu.cs` serwer/użytkownik/hasło są
  w bloku konfiguracji na górze pliku; hasło to placeholder `<sa-password>`. Wpisz własne
  (lub lepiej: czytaj ze zmiennej środowiskowej, nie z kodu).
- **Ścieżka licencji** — stała `licencePath` (Twój plik `*.xml` z licencją).
- **Ścieżki narzędzia i buildów** — stałe `dbmgr` / `dbmgrAlt` (lokalizacja `dbmgr.dll`).
- **Katalogi backupów** — stałe `clientBackupDir` (po stronie klienta) i `serverBackupDir`
  (katalog widoczny dla serwera SQL) — ustaw pod swój system.
- **Flagi zależne od wersji** — `--activate`, `--premium`, `restore … --convert` mogą się
  różnić między buildami; jeśli któraś nie zadziała, zweryfikuj `dbmgr <komenda> --help`
  (aktualny zestaw opcji opisuje [dbmgr.md](dbmgr.md)).

Pełny opis samych komend i opcji `dbmgr`: [dbmgr.md](dbmgr.md).
