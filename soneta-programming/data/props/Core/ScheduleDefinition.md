# Pola i właściwości klasy biznesowej: `Soneta.Core.Schedule.ScheduleDefinition`
Nazwa tabeli: `ScheduleDefs`
Tytuł: Definicje harmonogramów
Opis: Definicja harmonogramu automatycznego wykonywania zadań. Określa nazwę, powiązane zadanie, cykl wykonania (data, okres, definicja cyklu), typ harmonogramu (cykliczny, folderowy), ścieżki wejściową/wyjściową, priorytet, strategię obsługi wyjątków i instancję harmonogramu.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 32
- pola kalkulowane (zapisywalne): 27
- pola tylko-odczyt: 14
- podlisty: 5
- subrowy: 2
- razem: 80

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AutoActionName | `AutoActionAttribute.AutoActionBase` | bazodanowe | Nazwa metody automatycznej | Określa nazwę metody automatycznej wywoływanej podczas przetwarzania automatycznych akcji harmonogramu |
| CalcFirstInvokeTimeExpression | `string` |  | Pierwsze wywołanie | Wyrażenie określające pierwsze wywołanie harmonogramu zadań. |
| Code | `MemoText` | bazodanowe, podlista | Kod algorytmu | Kod algorytmu kalkulatora definicji cyklu |
| CycleDefinition | `Soneta.Core.DefinicjaCyklu` (subrow) | bazodanowe | Definicja cyklu | Określa definicję cyklu |
| CycleDefinition.AlgorytmCykluInstance | `Soneta.Core.IAlgorytmCyklu` | tylko-odczyt |  | Instancja skompilowanego kalkulatora. |
| CycleDefinition.Czas | `Time` | bazodanowe |  | Określa czas wystąpienia cyklu. |
| CycleDefinition.Czerwiec | `bool` |  |  | Czerwiec - miesiąc wystąpienia cyklu tygodniowego. |
| CycleDefinition.Czwartek | `bool` |  |  | Czwartek - dzień tygodnia wystąpienia cyklu tygodniowego. |
| CycleDefinition.DataKoniecCyklu | `bool` | bazodanowe |  | Data wystąpienia w ostatnim miesiącu/roku okresu |
| CycleDefinition.Dzien | `Date` |  |  | Data rozpoczęcia wykonywania cyklu. |
| CycleDefinition.DzienCzas | `System.DateTime` | tylko-odczyt |  |  |
| CycleDefinition.DzienMiesiaca | `int` |  |  | Dzień w miesiącu wystąpienia cyklu miesięcznego lub rocznego. |
| CycleDefinition.DzienTygodnia | `Soneta.Core.DefinicjaCykluDzienTygodnia` |  |  | W zaawansowanej wersji dzień tygodnia. |
| CycleDefinition.Godzina | `int` |  |  | Godzina wystąpienia cyklu. |
| CycleDefinition.Godziny | `string[]` | podlista |  | Wybrane godziny w trybie godzinowym. |
| CycleDefinition.Grudzien | `bool` |  |  | Grudzień - miesiąc wystąpienia cyklu tygodniowego. |
| CycleDefinition.Interwal | `int` | bazodanowe |  |  |
| CycleDefinition.IsAdvanced | `bool` | tylko-odczyt |  |  |
| CycleDefinition.IsMultiSelect | `bool` | tylko-odczyt |  |  |
| CycleDefinition.IsSingleSelect | `bool` | tylko-odczyt |  |  |
| CycleDefinition.JestAlgorytm | `bool` | tylko-odczyt |  |  |
| CycleDefinition.JestOpcjaZaawansowana | `bool` | tylko-odczyt |  |  |
| CycleDefinition.JestTermin | `bool` | tylko-odczyt |  |  |
| CycleDefinition.KodAlgorytmu | `string` |  |  | Kod algorytmu wyliczania wystąpień cyklu. |
| CycleDefinition.Krotnosc | `int` | bazodanowe |  | Określa ile razy cykl będzie powtórzony. |
| CycleDefinition.Kwiecien | `bool` |  |  | Kwiecień - miesiąc wystąpienia cyklu tygodniowego. |
| CycleDefinition.Lipiec | `bool` |  |  | Lipiec - miesiąc wystąpienia cyklu tygodniowego. |
| CycleDefinition.Listopad | `bool` |  |  | Listopad - miesiąc wystąpienia cyklu tygodniowego. |
| CycleDefinition.Luty | `bool` |  |  | Luty - miesiąc wystąpienia cyklu tygodniowego. |
| CycleDefinition.Maj | `bool` |  |  | Maj - miesiąc wystąpienia cyklu tygodniowego. |
| CycleDefinition.Marzec | `bool` |  |  | Marzec - miesiąc wystąpienia cyklu tygodniowego. |
| CycleDefinition.MiesiacRoku | `Soneta.Core.DefinicjaCykluMiesiacRoku` (enum) |  |  | W zaawansowanej wersji miesiąc w roku. |
| CycleDefinition.MinutaGodziny | `int` |  |  | Minuta w godzinie wystąpienia cyklu godzinowego. |
| CycleDefinition.Niedziela | `bool` |  |  | Niedziela - dzień tygodnia wystąpienia cyklu tygodniowego. |
| CycleDefinition.OkresCyklu | `Soneta.Core.DefinicjaCykluOkresCyklu` (enum) | bazodanowe |  | Określa okres, w którym oczekiwane jest wystąpienie cyklu. |
| CycleDefinition.Options | `Soneta.Core.DefinicjaCykluOptions` (enum) | tylko-odczyt |  |  |
| CycleDefinition.Pazdziernik | `bool` |  |  | Październik - miesiąc wystąpienia cyklu tygodniowego. |
| CycleDefinition.Piatek | `bool` |  |  | Piątek - dzień tygodnia wystąpienia cyklu tygodniowego. |
| CycleDefinition.Podglad | `Soneta.Core.ElementCyklu` | tylko-odczyt |  |  |
| CycleDefinition.Poniedzialek | `bool` |  |  | Poniedziałek - dzień tygodnia wystąpienia cyklu tygodniowego. |
| CycleDefinition.PozycjaDnia | `Soneta.Core.DefinicjaCykluPozycjaDnia` (enum) | bazodanowe |  | Określa pozycję dnia w okresie, w którym oczekiwane jest wystąpienie cyklu. |
| CycleDefinition.PozycjaDniaZaawansowana | `Soneta.Core.DefinicjaCykluPozycjaDniaZaawansowana` (enum) | bazodanowe |  | Określa pozycję dnia w miesiącu, w którym oczekiwane jest wystąpienie cyklu. |
| CycleDefinition.RodzajTerminu | `Soneta.Core.DefinicjaCykluRodzajTerminu` (enum) | bazodanowe |  | Wskazuje na to, czy określono termin cyklu lub termin wynika z opisu cyklu. |
| CycleDefinition.Sierpien | `bool` |  |  | Sierpień - miesiąc wystąpienia cyklu tygodniowego. |
| CycleDefinition.Sobota | `bool` |  |  | Sobota - dzień tygodnia wystąpienia cyklu tygodniowego. |
| CycleDefinition.SposobNaDniWolne | `Soneta.Core.DefinicjaCykluSposobNaDniWolne` (enum) | bazodanowe |  | Określa sposób zachowania, kiedy cykl wystąpi w dniu wolnym. |
| CycleDefinition.Sroda | `bool` |  |  | Środa - dzień tygodnia wystąpienia cyklu tygodniowego. |
| CycleDefinition.Styczen | `bool` |  |  | Styczeń - miesiąc wystąpienia cyklu tygodniowego. |
| CycleDefinition.Termin | `int` | bazodanowe |  | Określa termin wystąpienia cyklu. Wartość w polu nie jest czytelna dla użytkownika. |
| CycleDefinition.Termin2 | `int` | bazodanowe |  | Określa termin wystąpienia cyklu (godziny). Wartość w polu nie jest czytelna dla użytkownika. |
| CycleDefinition.Termin3 | `int` | bazodanowe |  | Określa termin wystąpienia cyklu (minuty w godzinie). Wartość w polu nie jest czytelna dla użytkownika. |
| CycleDefinition.Termin4 | `int` | bazodanowe |  | Określa termin wystąpienia cyklu (dni w miesiącu/roku w kolejności). Wartość w polu nie jest czytelna dla użytkownika. |
| CycleDefinition.Termin5 | `int` | bazodanowe |  | Określa termin wystąpienia cyklu (miesiące w roku w kolejności). Wartość w polu nie jest czytelna dla użytkownika. |
| CycleDefinition.Typ | `Soneta.Core.DefinicjaCykluTyp` (enum) | bazodanowe |  | Określa rodzaj cyklu za pomocą jednostki interwału czasu. |
| CycleDefinition.Wrzesien | `bool` |  |  | Wrzesień - miesiąc wystąpienia cyklu tygodniowego. |
| CycleDefinition.Wtorek | `bool` |  |  | Wtorek - dzień tygodnia wystąpienia cyklu tygodniowego. |
| Date | `Date` | bazodanowe | Data cyklu | Określa datę wystąpienia cyklu |
| DefaultAutoAction | `bool` | bazodanowe | Użyj domyślnej akcji | Określa czy należy użyć domyślnej akcji |
| EndDate | `Date` | bazodanowe | Czas zakończenia | Określa czas zakończenia obowiązywania cyklu |
| ExceptionStrategy | `Soneta.Core.ExceptionStrategyEnum` (enum) | bazodanowe | Strategia obsługi wyjątków | Określa strategię obsługi wyjątków |
| FolderIn | `string` | bazodanowe | Ścieżka wejściowa | Określa ścieżkę, dla której śledzone są pliki |
| FolderOut | `string` | bazodanowe | Ścieżka wyjściowa | Określa ścieżkę, archiwalną dla przetworzonych plików |
| Host | `IScheduleAutoJob` | bazodanowe, tylko-odczyt | Rekord | Określa opcjonalny rekord powiązany |
| HzInstance | `string` | bazodanowe | Nazwa instacji | Określa nazwę instancji harmonogramu zadań |
| Info | `string` | tylko-odczyt |  |  |
| IsExpressionSet | `bool` | tylko-odczyt |  |  |
| IsPageVisible | `bool` | tylko-odczyt |  |  |
| Locked | `bool` | bazodanowe | Definicja zablokowana | Określa czy definicja jest zablokowana |
| Name | `string` | bazodanowe | Nazwa | Nazwa definicji harmonogramu |
| OkresCyklu | `FromTo` | podlista | Okres cyklu | Określa okres obowiązywania cyklu |
| Priority | `int` | bazodanowe | Priorytet | Określa priorytet zadania |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| ScheduleItems | `SubTable<Soneta.Core.Schedule.ScheduleItem>` | podlista |  |  |
| ScheduleType | `Soneta.Core.ScheduleTypeEnum` (enum) | bazodanowe | Typ harmonogramu | Określa typ harmonogramu |
| StartDate | `Date` | bazodanowe | Czas rozpoczęcia | Określa czas rozpoczęcia obowiązywania cyklu |
| TaskDefinition | `Db.TaskDefinition` | bazodanowe | Definicja zadania | Definicja zadania powiązana z definicją harmonogramu |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DefinicjaCykluMiesiacRoku (`Soneta.Core.DefinicjaCykluMiesiacRoku`)
- `styczen` = 0 — styczniu
- `luty` = 1 — lutym
- `marzec` = 2 — marcu
- `kwiecien` = 3 — kwietniu
- `maj` = 4 — maju
- `czerwiec` = 5 — czerwcu
- `lipiec` = 6 — lipcu
- `sierpien` = 7 — sierpniu
- `wrzesien` = 8 — wrześniu
- `pazdziernik` = 9 — październiku
- `listopad` = 10 — listopadzie
- `grudzien` = 11 — grudniu

### DefinicjaCykluOkresCyklu (`Soneta.Core.DefinicjaCykluOkresCyklu`)
- `Poprzedni` = -1 — w poprzednim okresie
- `Biezacy` = 0 — w okresie fakturowanym
- `Nastepny` = 1 — w następnym okresie

### DefinicjaCykluOptions (`Soneta.Core.DefinicjaCykluOptions`)
- `None` = 0
- `IsRequired` = 1
- `HideOnce` = 256
- `HideDaily` = 512
- `HideWeekly` = 1024
- `HideMonthly` = 2048
- `HideYearly` = 4096
- `OnceOnly` = 466432
- `MultiSelect` = 8192
- `IsAdvanced` = 16384
- `HideMinutly` = 65536
- `HideHourly` = 131072
- `HideAlgorithm` = 262144

### DefinicjaCykluPozycjaDnia (`Soneta.Core.DefinicjaCykluPozycjaDnia`)
- `Pierwszy` = 0 — pierwszy
- `Ostatni` = 100 — ostatni

### DefinicjaCykluPozycjaDniaZaawansowana (`Soneta.Core.DefinicjaCykluPozycjaDniaZaawansowana`)
- `Pierwszy` = 0 — pierwszy(a)
- `Drugi` = 1 — drugi(a)
- `Trzeci` = 2 — trzeci(a)
- `Czwarty` = 3 — czwarty(a)
- `Ostatni` = 4 — ostatni(a)

### DefinicjaCykluRodzajTerminu (`Soneta.Core.DefinicjaCykluRodzajTerminu`)
- `Wskazany` = 0 — Wskazany
- `WgOpisu` = 1
- `OpcjaZaawansowana` = 2

### DefinicjaCykluSposobNaDniWolne (`Soneta.Core.DefinicjaCykluSposobNaDniWolne`)
- `None` = 0 — Jak w dniu roboczym
- `Pomin` = 1 — Pomiń cykl
- `Zastap` = 2
- `ZastapNastepnymWBiezacym` = 69890 — Zastąp następnym dniem roboczym w fakturowanym okresie
- `ZastapPoprzednimWBiezacym` = 70146 — Zastąp poprzednim dniem roboczym w fakturowanym okresie
- `ZastapNastepnymWPrzyszlym` = 135426 — Zastąp następnym dniem roboczym w następnym okresie
- `ZastapPoprzednimWPoprzednim` = 266754 — Zastąp poprzednim dniem roboczym w poprzednim okresie
- `NastepnyDzien` = 256
- `PoprzedniDzien` = 512
- `DzienRoboczy` = 4096
- `BiezacyOkres` = 65536
- `NastepnyOkres` = 131072
- `PoprzedniOkres` = 262144

### DefinicjaCykluTyp (`Soneta.Core.DefinicjaCykluTyp`)
- `Brak` = 0 — Brak
- `Jednorazowy` = 1
- `Minutowy` = 300
- `Godzinowy` = 400
- `Dzienny` = 500
- `Tygodniowy` = 600
- `Miesieczny` = 700
- `Roczny` = 800
- `Algorytm` = 999999

### ExceptionStrategyEnum (`Soneta.Core.ExceptionStrategyEnum`)
- `Retry` = 0 — Zaloguj błąd i ponawiaj przetwarzanie
- `Avoid` = 1 — Zaloguj błąd i zaprzestań przetwarzanie zadania

### ScheduleTypeEnum (`Soneta.Core.ScheduleTypeEnum`)
- `UseCycleDefinition` = 0 — Zgodnie z harmonogramem
- `UseFileWatcher` = 1 — Wystąpienie pliku
