# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DokumentAktualizacjiKalendarza`
Nazwa tabeli: `DokAktKalendarzy`
Tytuł: Dokumenty aktualizacji kalendarzy
Opis: Dokument aktualizacji kalendarza pracy. Służy do zbiorczego wprowadzania zmian w planie pracy lub ewidencji czasu pracy pracowników, z określonym okresem, stanem zatwierdzenia, numerem i powiązaniem ze strukturą organizacyjną.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IŹródłoPowiązaniaStrukturyOrganizacyjnej`, `IDokumentAktualizacjiKalendarza`, `IDokument`
Selektor: pole `Rodzaj` (`Soneta.Kalend.RodzajAktualizacjiKalendarza`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  |  |
| DataZatwierdzenia | `System.DateTime` | bazodanowe, tylko-odczyt |  |  |
| Definicja | `Soneta.Kalend.DefinicjaAktualizacjiKalendarza` | bazodanowe, tylko-odczyt |  |  |
| DniKalendarzaHistorie | `SubTable<Soneta.Kalend.DzienKalendarzaHistoria>` | podlista |  |  |
| DniPracyHistorie | `SubTable<Soneta.Kalend.DzienPracyHistoria>` | podlista |  |  |
| ElementStrukturyFirmy | `Soneta.Core.IElementStrukturyFirmy` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| Kalkulator | `Soneta.Kalend.KalkulatorDokumentuAktualizacji` | tylko-odczyt |  |  |
| Nazwa | `string` | tylko-odczyt |  |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| ObiektyDoPlanowania | `SubTable<Soneta.Kalend.ObiektAktualizacjiKalendarza>` | podlista |  |  |
| ObiektyPozycjiCzasu | `System.Collections.Generic.IEnumerable<Soneta.Kalend.PozycjaObiektuAktualizacjiCzasu>` | podlista |  |  |
| ObiektyPozycjiPlanowania | `System.Collections.Generic.IEnumerable<Soneta.Kalend.PozycjaObiektuAktualizacjiKalendarza>` | podlista |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | tylko-odczyt |  |  |
| Odpowiedzialny | `Soneta.Kalend.IOdpowiedzialnyZaDAK` | bazodanowe |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Powiazanie | `Soneta.Kalend.PowiązanieDokumentu` (subrow) | bazodanowe |  |  |
| Powiazanie.ElementStrukturyFirmy | `Soneta.Core.IElementStrukturyFirmy` | iface-ref |  |  |
| Powiazanie.ElementStrukturyOrganizacyjnej | `Soneta.Core.ElementStrukturyOrganizacyjnej` |  |  |  |
| Powiazanie.IsValid | `bool` | tylko-odczyt |  |  |
| Powiazanie.WgStrukturaFirmy | `bool` | tylko-odczyt |  |  |
| Powiazanie.WgStrukturaOrganizacyjna | `bool` | tylko-odczyt |  |  |
| PowiązaniaStrOrg | `SubTable<Soneta.Core.PowiązanieStrukturyOrganizacyjnej>` | podlista |  |  |
| PozycjeCzas | `SubTable<Soneta.Kalend.PozycjaAktualizacjiCzasu>` | podlista |  |  |
| PozycjePlan | `SubTable<Soneta.Kalend.PozycjaAktualizacjiKalendarza>` | podlista |  |  |
| Rodzaj | `Soneta.Kalend.RodzajAktualizacjiKalendarza` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| Seria | `string` | bazodanowe |  |  |
| Stan | `Soneta.Kalend.StanyDokumentuAktulizacjiKalendarza` (enum) | bazodanowe, tylko-odczyt |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | tylko-odczyt |  |  |
| Zrodlo | `Soneta.Kalend.IZrodloPlanu` | iface-ref |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Rodzaj`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `AktualizacjaPlanuPracy` | 1 | `Soneta.Kalend.DokumentAktualizacjiKalendarza.PlanuPracy` | Dokument aktualizacji planu pracy |
| `WprowadzanieCzasuPracy` | 2 | `Soneta.Kalend.DokumentAktualizacjiKalendarza.CzasuPracy` | Dokument aktualizacji czasu pracy |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| ElementStrukturyFirmy | `IElementStrukturyFirmy` | `OddzialFirmy`, `Wydzial` |
| Powiazanie.ElementStrukturyFirmy | `IElementStrukturyFirmy` | `OddzialFirmy`, `Wydzial` |
| Zrodlo | `IZrodloPlanu` | `Pracownik`, `Umowa`, `UmowaZewnetrzna` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajAktualizacjiKalendarza (`Soneta.Kalend.RodzajAktualizacjiKalendarza`)
- `AktualizacjaPlanuPracy` = 1
- `WprowadzanieCzasuPracy` = 2

### StanyDokumentuAktulizacjiKalendarza (`Soneta.Kalend.StanyDokumentuAktulizacjiKalendarza`)
- `Wypełniany` = 1
- `DoAkceptacji` = 2
- `Zatwierdzony` = 3
- `Anulowany` = 4
