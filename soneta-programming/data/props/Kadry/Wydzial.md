# Pola i właściwości klasy biznesowej: `Soneta.Kadry.Wydzial`
Nazwa tabeli: `Wydzialy`
Tytuł: Jednostki organizacyjne
Opis: Struktura organizacyjna firmy – wydziały, działy, sekcje. Każda jednostka posiada kod, nazwę, kategorię, powiązanie z nadrzędną jednostką, centrum kosztów i oddziałem firmy, a także konfigurację blokad edycji i limitów pracy zdalnej.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`, `IElementStrukturyFirmy`, `IElementSlownika`

- pola bazodanowe (zapisywalne): 28
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 17
- podlisty: 19
- subrowy: 5
- razem: 70

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AgencjaPT | `Soneta.Kadry.AgencjaPracyTymczasowejWdz` (subrow) | bazodanowe |  |  |
| AgencjaPT.KlientAgencji | `bool` | bazodanowe |  |  |
| AgencjaPT.Pracodawca | `Soneta.CRM.Kontrahent` | bazodanowe | Pracodawca użytkownik |  |
| AgencjaPT.WgPracodawca | `Key` | podlista |  |  |
| AgencjaPT.WydziałKlienta | `Soneta.Kadry.Wydzial` | tylko-odczyt |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| BlokadaKadry | `Soneta.Kadry.DefinicjaBlokady` (subrow) | bazodanowe |  |  |
| BlokadaKadry.Aktywna | `bool` | bazodanowe |  |  |
| BlokadaKadry.Dzien | `int` | bazodanowe |  |  |
| BlokadaKadry.JezeliWolnyDzien | `Soneta.Kadry.TypJeżeliWolnyDzień` (enum) | bazodanowe |  |  |
| BlokadaKadry.OdKonca | `bool` | bazodanowe |  |  |
| BlokadaKadry.OpoznienieMies | `int` | bazodanowe |  |  |
| BlokadaKadry.OpóźnienieBlokady | `Soneta.Kadry.OpóźnienieBlokady` (enum) |  |  |  |
| BlokadaPlace | `Soneta.Kadry.DefinicjaBlokady` (subrow) | bazodanowe |  |  |
| BlokadaWeb | `Soneta.Kadry.DefinicjaBlokady` (subrow) | bazodanowe |  |  |
| CentrumKosztow | `Soneta.Core.CentrumKosztow` | bazodanowe |  |  |
| Definicja | `Soneta.Kadry.DefinicjaWydziału` | bazodanowe | Kategoria |  |
| DeklaracjeElementuStruktury | `SubTable` | podlista |  |  |
| DokumentyAktualizacjiElementuStruktury | `SubTable<Soneta.Kalend.DokumentAktualizacjiKalendarza>` | podlista |  |  |
| DostępnePodwydzialy | `object` | tylko-odczyt |  |  |
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| GUS | `Soneta.Kadry.StatystykaGUSWdz` (subrow) | bazodanowe |  |  |
| GUS.Dzialalnosc | `string` | bazodanowe |  | Opis rodzaju działalności |
| GUS.Gmina | `string` | bazodanowe |  | Gmina |
| GUS.MiastoWies | `Soneta.Kadry.MiastoWieś` (enum) | bazodanowe |  |  |
| Gotowka | `Soneta.Kasa.EwidencjaSP` | bazodanowe |  | Kasa, z której wypłacane są wynagrodzenia w gotówce |
| GotówkaZKasy | `Soneta.Kasa.EwidencjaSP` | tylko-odczyt |  |  |
| HistoriaPodleglosci | `HistorySubTable<Soneta.Kadry.WydzialRef>` | podlista |  |  |
| HistoriaZmian | `HistorySubTable<Soneta.Kadry.HistoriaDanychWydziału>` | podlista |  |  |
| IndywidualnyLimitNadgodz | `bool` | bazodanowe |  |  |
| IndywidualnyLimitPZ | `bool` | bazodanowe |  |  |
| Kod | `string` | bazodanowe |  |  |
| Last | `Soneta.Kadry.HistoriaDanychWydziału` | tylko-odczyt |  |  |
| LimitNadgodz | `int` | bazodanowe |  |  |
| LimitPZ | `int` | bazodanowe |  |  |
| ListaPlac | `bool` | bazodanowe |  |  |
| Metryka | `SubTable<Soneta.Kadry.MetrykaWydziału>` | podlista |  |  |
| Nadrzedny | `Soneta.Kadry.Wydzial` | bazodanowe, tylko-odczyt |  |  |
| NadrzędnyWgDaty | `Soneta.Kadry.Wydzial.NadrzędnyManager` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaPomocnicza | `string` | bazodanowe |  |  |
| ObjectRight | `AccessRights` (enum) | tylko-odczyt |  |  |
| ObszarFunkcjonalny | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.ObszarFunkcjonalny` | bazodanowe |  |  |
| OcenyElementuStruktury | `SubTable<Soneta.Oceny.OcenaRealizacja>` | podlista |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Podwydzialy | `SubTable<Soneta.Kadry.Wydzial>` | podlista |  |  |
| PodwydziałyWgAktualnosci | `SubTable<Soneta.Kadry.WydzialRef>` | podlista |  |  |
| PodwydziałyWgDaty | `Soneta.Kadry.Wydzial.PodwydziałyManager` | tylko-odczyt |  |  |
| PowiazaniaKontElementu | `SubTable` | podlista |  |  |
| Przelew | `Soneta.Kasa.EwidencjaSP` | bazodanowe |  | Rachunek bankowy, z którego realizowane są przelewy za wynagrodzenia |
| PrzelewZRachunku | `Soneta.Kasa.EwidencjaSP` | tylko-odczyt |  |  |
| RozliczaPFRON | `bool` | tylko-odczyt |  |  |
| RozliczaPIT | `bool` | tylko-odczyt |  |  |
| RozliczaPPK | `bool` | tylko-odczyt |  |  |
| RozliczaZUS | `bool` | tylko-odczyt |  |  |
| SegmentKodu | `string` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  |  |
| TypLimituPZ | `Soneta.Kalend.TypLimituPracyZdalnej` (enum) | bazodanowe |  |  |
| Wakaty | `SubTable<Soneta.HR2.RekrutacjaWakat>` | podlista |  |  |
| WszystkiePodwydziały | `System.Collections.ICollection` | podlista |  |  |
| WydziałPFRON | `Soneta.Kadry.Wydzial` | tylko-odczyt |  |  |
| WydziałPIT | `Soneta.Kadry.Wydzial` | tylko-odczyt |  |  |
| WydziałPPK | `Soneta.Kadry.Wydzial` | tylko-odczyt |  |  |
| WydziałZUS | `Soneta.Kadry.Wydzial` | tylko-odczyt |  |  |
| WydziałyPFRON | `Set<Soneta.Kadry.Wydzial>` | podlista |  |  |
| WydziałyPIT | `Set<Soneta.Kadry.Wydzial>` | podlista |  |  |
| WydziałyPPK | `Set<Soneta.Kadry.Wydzial>` | podlista |  |  |
| WydziałyZUS | `Set<Soneta.Kadry.Wydzial>` | podlista |  |  |
| Zgody | `SubTable<Soneta.Kadry.ZgodaNaEdycję>` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AccessRights (`AccessRights`)
- `Denied` = 0 — Zakaz dostępu
- `ReadOnly` = 1 — Tylko odczyt
- `Granted` = 2 — Pełne prawo
- `NoInit` = 3 — Niezainicjowane

### MiastoWieś (`Soneta.Kadry.MiastoWieś`)
- `Miasto` = 0 — Miasto
- `Wieś` = 1

### OpóźnienieBlokady (`Soneta.Kadry.OpóźnienieBlokady`)
- `WybranyMiesiąc` = 0
- `NastępnyMiesiąc` = 1
- `_2` = 2 — +2
- `_3` = 3 — +3

### TypJeżeliWolnyDzień (`Soneta.Kadry.TypJeżeliWolnyDzień`)
- `WybranyDzień` = 0 — Wybranego dnia
- `PoprzedniRoboczy` = 1 — Poprzedniego dnia roboczego
- `NastepnyRoboczy` = 2 — Następnego dnia roboczego

### TypLimituPracyZdalnej (`Soneta.Kalend.TypLimituPracyZdalnej`)
- `Roczny` = 0
- `Miesieczny` = 1 — Miesięczny
- `Tygodniowy` = 2
- `Kwartalny` = 3
- `Półroczny` = 4
