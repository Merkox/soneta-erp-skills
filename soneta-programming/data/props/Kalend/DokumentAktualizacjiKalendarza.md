# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DokumentAktualizacjiKalendarza`
Nazwa tabeli: `DokAktKalendarzy`
Tytuł: Dokumenty aktualizacji kalendarzy
Opis: Dokument aktualizacji kalendarza pracy. Służy do zbiorczego wprowadzania zmian w planie pracy lub ewidencji czasu pracy pracowników, z określonym okresem, stanem zatwierdzenia, numerem i powiązaniem ze strukturą organizacyjną.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IŹródłoPowiązaniaStrukturyOrganizacyjnej`, `IDokumentAktualizacjiKalendarza`, `IDokument`

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 21

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DataZatwierdzenia | `System.DateTime` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaAktualizacjiKalendarza` | bazodanowe |  |  |
| DniKalendarzaHistorie | `Soneta.Business.SubTable<Soneta.Kalend.DzienKalendarzaHistoria>` |  |  |  |
| DniPracyHistorie | `Soneta.Business.SubTable<Soneta.Kalend.DzienPracyHistoria>` |  |  |  |
| ElementStrukturyFirmy | `Soneta.Core.IElementStrukturyFirmy` | bazodanowe, iface-ref |  |  |
| Kalkulator | `Soneta.Kalend.KalkulatorDokumentuAktualizacji` |  |  |  |
| Nazwa | `string` |  |  |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| ObiektyDoPlanowania | `Soneta.Business.SubTable<Soneta.Kalend.ObiektAktualizacjiKalendarza>` |  |  |  |
| ObiektyPozycjiCzasu | `System.Collections.Generic.IEnumerable<Soneta.Kalend.PozycjaObiektuAktualizacjiCzasu>` |  |  |  |
| ObiektyPozycjiPlanowania | `System.Collections.Generic.IEnumerable<Soneta.Kalend.PozycjaObiektuAktualizacjiKalendarza>` |  |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` |  |  |  |
| Odpowiedzialny | `Soneta.Kalend.IOdpowiedzialnyZaDAK` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Powiazanie | `Soneta.Kalend.PowiązanieDokumentu` | bazodanowe |  |  |
| Powiazanie.ElementStrukturyFirmy | `Soneta.Core.IElementStrukturyFirmy` | iface-ref |  |  |
| Powiazanie.ElementStrukturyOrganizacyjnej | `Soneta.Core.ElementStrukturyOrganizacyjnej` |  |  |  |
| Powiazanie.IsValid | `bool` |  |  |  |
| Powiazanie.WgStrukturaFirmy | `bool` |  |  |  |
| Powiazanie.WgStrukturaOrganizacyjna | `bool` |  |  |  |
| PowiązaniaStrOrg | `Soneta.Business.SubTable<Soneta.Core.PowiązanieStrukturyOrganizacyjnej>` |  |  |  |
| PozycjeCzas | `Soneta.Business.SubTable<Soneta.Kalend.PozycjaAktualizacjiCzasu>` |  |  |  |
| PozycjePlan | `Soneta.Business.SubTable<Soneta.Kalend.PozycjaAktualizacjiKalendarza>` |  |  |  |
| Rodzaj | `Soneta.Kalend.RodzajAktualizacjiKalendarza` | bazodanowe, enum |  |  |
| Seria | `string` | bazodanowe |  |  |
| Stan | `Soneta.Kalend.StanyDokumentuAktulizacjiKalendarza` | bazodanowe, enum |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` |  |  |  |
| Zrodlo | `Soneta.Kalend.IZrodloPlanu` | iface-ref |  |  |

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
