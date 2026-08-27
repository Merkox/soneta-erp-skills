#!/usr/local/share/dotnet/dotnet run

// Interaktywne menu CLI wokół narzędzia `dbmgr` (Spectre.Console).
// Jednoplikowa aplikacja C# uruchamiana bezpośrednio: `dotnet run dbmgr-menu.cs`
// albo — po `chmod +x dbmgr-menu.cs` — po prostu `./dbmgr-menu.cs`.
//
// To SZABLON. Wszystko zależne od środowiska ustaw w bloku KONFIGURACJA poniżej.
// Niektóre flagi (np. --activate, --premium, restore --convert) zależą od wersji
// dbmgr — sprawdź `dbmgr <komenda> --help`, jeśli nie zadziałają.

#:package Spectre.Console.Cli@*

using Spectre.Console;
using System.Diagnostics;
using System.Text.Json;

// ============================ KONFIGURACJA ============================
// Dostosuj do swojego systemu. Ścieżki mogą być absolutne albo względne
// do katalogu, z którego uruchamiasz skrypt.
var dbmgr = "bin/Debug/dbmgr.dll";                    // lokalizacja dbmgr.dll
var dbmgrAlt = "../alt/bin/Debug/dbmgr.dll";          // alternatywny build (przełącznik "Folder")
var sqlServer = "localhost";                          // adres serwera SQL
var sqlUser = "sa";                                   // użytkownik SQL
var sqlPassword = "<sa-password>";                    // hasło SQL (lepiej: zmienna środowiskowa)
var licencePath = "<ścieżka-do-licencji>.xml";        // plik licencji nakładany przy tworzeniu bazy
var clientBackupDir = "<katalog-backupów-klienta>";   // katalog z plikami *.bac po stronie klienta
var serverBackupDir = "<katalog-backupów-serwera>";   // katalog backupów widoczny dla serwera SQL
// ======================================================================

var premium = "--standard";

void DbMgr(params string[] args)
{
    var allArgs = args.Append(premium).ToArray();

    Console.WriteLine();
    Console.WriteLine($"dbmgr {string.Join(" ", allArgs)}");
    Console.WriteLine();

    var process = new Process
    {
        StartInfo = new ProcessStartInfo
        {
            FileName = "dotnet",
            Arguments = $"{dbmgr} {string.Join(" ", allArgs)}",
            UseShellExecute = false,
            RedirectStandardOutput = false,
            RedirectStandardError = false
        }
    };

    process.Start();
    process.WaitForExit();
}

string GetDatabases(string desc)
{
    var args = premium == "--standard"
        ? new[] { "list", "-o", "json" }
        : new[] { "list", "--premium", "-o", "json" };

    var process = new Process
    {
        StartInfo = new ProcessStartInfo
        {
            FileName = "dotnet",
            Arguments = $"{dbmgr} {string.Join(" ", args)}",
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = false
        }
    };

    process.Start();
    var output = process.StandardOutput.ReadToEnd();
    process.WaitForExit();

    // `dbmgr list -o json` zwraca tablicę: {Name, Active, Server, Database, Status, Message}.
    // Logi lecą na stderr, więc stdout to czysty JSON — dla pewności bierzemy od pierwszego '['.
    var start = output.IndexOf('[');
    var dbs = new List<string>();
    if (start >= 0)
    {
        using var doc = JsonDocument.Parse(output[start..]);
        dbs = doc.RootElement.EnumerateArray()
            .Select(e => e.GetProperty("Name").GetString()!)
            .ToList();
    }

    return AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title(desc)
            .PageSize(10)
            .AddChoices(dbs));   // Name jest już nazwą bazy — bez wycinania pierwszej kolumny
}

string? GetFileName(string desc)
{
    var files = Directory.GetFiles(clientBackupDir, "*.bac")
        .Select(fn => Path.GetFileName(fn));

    if (!files.Any())
    {
        Console.WriteLine("No database backups found");
        return null;
    }

    var opt = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title(desc)
            .PageSize(10)
            .AddChoices(files));

    return opt;
}

void DatabaseList()
{
    DbMgr("list", "--status");
}

void DatabaseCreate()
{
    var db = GetDatabases("Create database...");

    DbMgr("create", db,
        $"--sqlserver={sqlServer}",
        $"--sqluser={sqlUser}",
        $"--sqlpwd={sqlPassword}",
        $"--licence={licencePath}",
        "--activate",
        "--recreate",
        "--demo=gold");
    //--sampledata
}

void DatabaseDrop()
{
    var db = GetDatabases("Drop database...");
    DbMgr("drop", db);
}

void DatabaseRestore()
{
    Console.WriteLine($"server: {clientBackupDir} => {serverBackupDir} *.bac");
    var file = GetFileName("Select backup file");
    if (file == null) return;

    var db = GetDatabases("Restore database...");

    DbMgr("restore", db, $"{serverBackupDir}/{file}", "--convert", "--force");
}

void DatabaseConvert()
{
    var db = GetDatabases("Convert database...");
    DbMgr("convert", db, "--force");
}

void DatabaseBackup()
{
    Console.WriteLine($"server: {serverBackupDir} => {clientBackupDir}");
    var db = GetDatabases("Backup database...");
    DbMgr("backup", db, $"{serverBackupDir}/{db}.bac");
}

// Main loop
for (;;)
{
    var opt = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("Select option?")
            .AddChoices([
                "Version " + premium,
                "Folder " + dbmgr,
                "List",
                "Create",
                "Drop",
                "Convert",
                "Restore",
                "Backup",
                "Exit"
            ]));

    switch (opt[0])
    {
        case 'V':
            premium = premium == "--standard" ? "--premium" : "--standard";
            break;
        case 'F':
            (dbmgr, dbmgrAlt) = (dbmgrAlt, dbmgr);   // przełącz build ⇄ alternatywny build
            break;
        case 'L':
            DatabaseList();
            break;
        case 'C':
            if (opt == "Create")
                DatabaseCreate();
            else
                DatabaseConvert();
            return;
        case 'D':
            DatabaseDrop();
            break;
        case 'R':
            DatabaseRestore();
            return;
        case 'B':
            DatabaseBackup();
            return;
        case 'E':
            return;
    }
}
