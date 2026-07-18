# Pola i właściwości klasy biznesowej: `Soneta.Kalend.RegulaDostepnosci`
Nazwa tabeli: `RegulyDostep`
Tytuł: Reguły dostępności
Opis: Tabela przechowuje reguły dostępności i niedostępności przypisane do zasobów (hostów) w kalendarzu. Każda reguła określa rodzaj dostępności, okres obowiązywania, godziny, cykl powtarzania oraz opis tekstowy.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 25
- pola kalkulowane (zapisywalne): 29
- pola tylko-odczyt: 11
- podlisty: 3
- subrowy: 1
- razem: 69

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CalyDzien | `bool` |  |  |  |
| Cykl | `Soneta.Core.DefinicjaCyklu` (subrow) | bazodanowe | Definicja cyklu | Określa definicję cyklu |
| Cykl.AlgorytmCykluInstance | `Soneta.Core.IAlgorytmCyklu` | tylko-odczyt |  | Instancja skompilowanego kalkulatora. |
| Cykl.Czas | `Time` | bazodanowe |  | Określa czas wystąpienia cyklu. |
| Cykl.Czerwiec | `bool` |  |  | Czerwiec - miesiąc wystąpienia cyklu tygodniowego. |
| Cykl.Czwartek | `bool` |  |  | Czwartek - dzień tygodnia wystąpienia cyklu tygodniowego. |
| Cykl.DataKoniecCyklu | `bool` | bazodanowe |  | Data wystąpienia w ostatnim miesiącu/roku okresu |
| Cykl.Dzien | `Date` |  |  | Data rozpoczęcia wykonywania cyklu. |
| Cykl.DzienCzas | `System.DateTime` | tylko-odczyt |  |  |
| Cykl.DzienMiesiaca | `int` |  |  | Dzień w miesiącu wystąpienia cyklu miesięcznego lub rocznego. |
| Cykl.DzienTygodnia | `Soneta.Core.DefinicjaCykluDzienTygodnia` |  |  | W zaawansowanej wersji dzień tygodnia. |
| Cykl.Godzina | `int` |  |  | Godzina wystąpienia cyklu. |
| Cykl.Godziny | `string[]` | podlista |  | Wybrane godziny w trybie godzinowym. |
| Cykl.Grudzien | `bool` |  |  | Grudzień - miesiąc wystąpienia cyklu tygodniowego. |
| Cykl.Interwal | `int` | bazodanowe |  |  |
| Cykl.IsAdvanced | `bool` | tylko-odczyt |  |  |
| Cykl.IsMultiSelect | `bool` | tylko-odczyt |  |  |
| Cykl.IsSingleSelect | `bool` | tylko-odczyt |  |  |
| Cykl.JestAlgorytm | `bool` | tylko-odczyt |  |  |
| Cykl.JestOpcjaZaawansowana | `bool` | tylko-odczyt |  |  |
| Cykl.JestTermin | `bool` | tylko-odczyt |  |  |
| Cykl.KodAlgorytmu | `string` |  |  | Kod algorytmu wyliczania wystąpień cyklu. |
| Cykl.Krotnosc | `int` | bazodanowe |  | Określa ile razy cykl będzie powtórzony. |
| Cykl.Kwiecien | `bool` |  |  | Kwiecień - miesiąc wystąpienia cyklu tygodniowego. |
| Cykl.Lipiec | `bool` |  |  | Lipiec - miesiąc wystąpienia cyklu tygodniowego. |
| Cykl.Listopad | `bool` |  |  | Listopad - miesiąc wystąpienia cyklu tygodniowego. |
| Cykl.Luty | `bool` |  |  | Luty - miesiąc wystąpienia cyklu tygodniowego. |
| Cykl.Maj | `bool` |  |  | Maj - miesiąc wystąpienia cyklu tygodniowego. |
| Cykl.Marzec | `bool` |  |  | Marzec - miesiąc wystąpienia cyklu tygodniowego. |
| Cykl.MiesiacRoku | `Soneta.Core.DefinicjaCykluMiesiacRoku` (enum) |  |  | W zaawansowanej wersji miesiąc w roku. |
| Cykl.MinutaGodziny | `int` |  |  | Minuta w godzinie wystąpienia cyklu godzinowego. |
| Cykl.Niedziela | `bool` |  |  | Niedziela - dzień tygodnia wystąpienia cyklu tygodniowego. |
| Cykl.OkresCyklu | `Soneta.Core.DefinicjaCykluOkresCyklu` (enum) | bazodanowe |  | Określa okres, w którym oczekiwane jest wystąpienie cyklu. |
| Cykl.Options | `Soneta.Core.DefinicjaCykluOptions` (enum) | tylko-odczyt |  |  |
| Cykl.Pazdziernik | `bool` |  |  | Październik - miesiąc wystąpienia cyklu tygodniowego. |
| Cykl.Piatek | `bool` |  |  | Piątek - dzień tygodnia wystąpienia cyklu tygodniowego. |
| Cykl.Podglad | `Soneta.Core.ElementCyklu` | tylko-odczyt |  |  |
| Cykl.Poniedzialek | `bool` |  |  | Poniedziałek - dzień tygodnia wystąpienia cyklu tygodniowego. |
| Cykl.PozycjaDnia | `Soneta.Core.DefinicjaCykluPozycjaDnia` (enum) | bazodanowe |  | Określa pozycję dnia w okresie, w którym oczekiwane jest wystąpienie cyklu. |
| Cykl.PozycjaDniaZaawansowana | `Soneta.Core.DefinicjaCykluPozycjaDniaZaawansowana` (enum) | bazodanowe |  | Określa pozycję dnia w miesiącu, w którym oczekiwane jest wystąpienie cyklu. |
| Cykl.RodzajTerminu | `Soneta.Core.DefinicjaCykluRodzajTerminu` (enum) | bazodanowe |  | Wskazuje na to, czy określono termin cyklu lub termin wynika z opisu cyklu. |
| Cykl.Sierpien | `bool` |  |  | Sierpień - miesiąc wystąpienia cyklu tygodniowego. |
| Cykl.Sobota | `bool` |  |  | Sobota - dzień tygodnia wystąpienia cyklu tygodniowego. |
| Cykl.SposobNaDniWolne | `Soneta.Core.DefinicjaCykluSposobNaDniWolne` (enum) | bazodanowe |  | Określa sposób zachowania, kiedy cykl wystąpi w dniu wolnym. |
| Cykl.Sroda | `bool` |  |  | Środa - dzień tygodnia wystąpienia cyklu tygodniowego. |
| Cykl.Styczen | `bool` |  |  | Styczeń - miesiąc wystąpienia cyklu tygodniowego. |
| Cykl.Termin | `int` | bazodanowe |  | Określa termin wystąpienia cyklu. Wartość w polu nie jest czytelna dla użytkownika. |
| Cykl.Termin2 | `int` | bazodanowe |  | Określa termin wystąpienia cyklu (godziny). Wartość w polu nie jest czytelna dla użytkownika. |
| Cykl.Termin3 | `int` | bazodanowe |  | Określa termin wystąpienia cyklu (minuty w godzinie). Wartość w polu nie jest czytelna dla użytkownika. |
| Cykl.Termin4 | `int` | bazodanowe |  | Określa termin wystąpienia cyklu (dni w miesiącu/roku w kolejności). Wartość w polu nie jest czytelna dla użytkownika. |
| Cykl.Termin5 | `int` | bazodanowe |  | Określa termin wystąpienia cyklu (miesiące w roku w kolejności). Wartość w polu nie jest czytelna dla użytkownika. |
| Cykl.Typ | `Soneta.Core.DefinicjaCykluTyp` (enum) | bazodanowe |  | Określa rodzaj cyklu za pomocą jednostki interwału czasu. |
| Cykl.Wrzesien | `bool` |  |  | Wrzesień - miesiąc wystąpienia cyklu tygodniowego. |
| Cykl.Wtorek | `bool` |  |  | Wtorek - dzień tygodnia wystąpienia cyklu tygodniowego. |
| Czas | `Time` | bazodanowe | Czas |  |
| Czynnosc | `Soneta.Kalend.CzynnoscNaObiekcieDoPlanowania` | bazodanowe |  |  |
| Data | `Date` | bazodanowe | Data cyklu | Określa datę wystąpienia cyklu |
| DataDecyzji | `Date` | bazodanowe |  |  |
| GodzinaDo | `Time` |  |  |  |
| GodzinaOd | `Time` | bazodanowe | Od godziny |  |
| Host | `Soneta.Kalend.IDostepnoscHost` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| IsCykl | `bool` |  |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Opis | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe | Priorytet | Określa priorytet dostępności |
| Rodzaj | `Soneta.Kalend.RodzajDostepnosci` (enum) | bazodanowe |  | Określa rodzaj dostępność/niedostępność |
| Stan | `Soneta.Kalend.StanRegulyDostepnosci` (enum) | bazodanowe |  |  |
| Wyjatki | `SubTable<Soneta.Kalend.WyjatekRegulyDostepnosci>` | podlista |  |  |
| Zatwierdzajacy | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IDostepnoscHost` | `Pracownik`, `Umowa`, `UmowaZewnetrzna` |

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

### RodzajDostepnosci (`Soneta.Kalend.RodzajDostepnosci`)
- `Dostepny` = 1 — Dostępny
- `Niedostepny` = 2 — Niedostępny

### StanRegulyDostepnosci (`Soneta.Kalend.StanRegulyDostepnosci`)
- `Wypełniana` = 1
- `DoAkceptacji` = 2
- `Zatwierdzona` = 3
- `Anulowana` = 4
- `Odrzucona` = 5
