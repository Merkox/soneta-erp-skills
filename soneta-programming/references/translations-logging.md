# Tłumaczenia i logowanie

Soneta dostarcza dwa fundamenty obserwowalności i lokalizacji, które działają razem - tłumaczenia napisów oraz log zmian / śledzenie czasu wykonania.

## Tłumaczenie i formatowanie napisów

Biblioteka obsługuje słowniki tłumaczące napisy w aplikacji Soneta.

- Tłumaczone napisy muszą używać metody string-extender: `"napis do tłumaczenia".Translate()`.
- Tłumaczenie tekstów formatowanych: `"napis {0} z wartością {1}".TranslateFormat(arg0, arg1)`.
- Gdy string ma być **zignorowany** przez tłumacza, MUSISZ oznaczyć go metodą `"nie tłumaczymy".TranslateIgnore()` - inaczej błąd kompilacji.
- Jeśli w metodzie lub klasie jest wiele napisów do zignorowania, użyj atrybutu `[TranslateIgnore]` na metodzie / klasie.
- Parametr metody ignorowany przez tłumacza - atrybut `[TranslateIgnore]` na parametrze.

## Log zmian i obserwowalność

Używaj standardowych narzędzi do logowania `ILogger<T>`. Użyj `[TranslateIgnore]` w metodzie wywołującej log (komunikaty logu nie są tłumaczone). Używaj `logger.IsEnabled(LogLevel)` kiedy parametry wymagają dodatkowych operacji.

### Użycie `ILogger` oraz exception log

```csharp
class Test
{
    private readonly ILogger<Test> logger =
        BusApplication.Instance.GetRequiredService<ILogger<Test>>();

    public decimal Kwota;

    [TranslateIgnore]
    public void Metoda()
    {
        try
        {
            logger.LogInformation("Wywołanie metody {nazwa}", nameof(Metoda));
            if (Kwota < 0)
                logger.LogWarning("Kwota {kwota} nie może być ujemna w metodzie '{metoda}'", Kwota, nameof(Metoda));
        }
        catch (Exception ex)
        {
            // Sposób na wrzucenie exception do trace
            ex.Log<Test>();
            throw;
        }
    }
}
```

### Śledzenie czasu wykonania z obsługą exception

```csharp
class Test
{
    private static readonly ActSource actSource = new(nameof(Test), ActSource.TraceLevel.Default);

    public void Action()
    {
        using var activity = actSource.Start();

        try
        {
            // Algorytm do śledzenia
        }
        catch (Exception ex)
        {
            activity.AddExceptionWithError(ex);
            throw;
        }
    }
}
```

## Lokalizacja plików logów

Logi z działania aplikacji zapisywane są do plików na dysku — pierwsze miejsce, gdzie szukać przyczyny
błędu serwera biznesowego, konwersji bazy czy nieudanego testu. Na **macOS** znajdują się w katalogu
`~/Library/Application Support/Soneta/Logs/`, z podziałem po komponencie:

| Wzorzec pliku | Komponent |
|---------------|-----------|
| `server-*.log` | serwer biznesowy (aplikacja Soneta) |
| `dbmgr-*.log` | menedżer baz danych (`dbmgr` — patrz /soneta-tools) |
| `test-*.log` | uruchomienia testów |
| `*-*.log` | pozostałe komponenty wg analogicznego wzorca `<komponent>-*.log` |

```bash
# najnowszy log serwera
ls -t ~/Library/Application\ Support/Soneta/Logs/server-*.log | head -1

# podgląd błędów na żywo
tail -f ~/Library/Application\ Support/Soneta/Logs/server-*.log
```

> Operacje na bazie z wiersza poleceń (`dbmgr`, `buscall`) opisuje skill **/soneta-tools**;
> uruchamianie testów integracyjnych — [integration-tests.md](integration-tests.md).
