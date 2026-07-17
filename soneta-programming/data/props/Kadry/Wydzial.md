# Pola i właściwości klasy biznesowej: `Soneta.Kadry.Wydzial`
Nazwa tabeli: `Wydzialy`
Tytuł: Jednostki organizacyjne
Opis: Struktura organizacyjna firmy – wydziały, działy, sekcje. Każda jednostka posiada kod, nazwę, kategorię, powiązanie z nadrzędną jednostką, centrum kosztów i oddziałem firmy, a także konfigurację blokad edycji i limitów pracy zdalnej.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`, `IElementStrukturyFirmy`, `IElementSlownika`

- pola bazodanowe: 35
- pola kalkulowane (z klas biznesowych): 35

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AgencjaPT | `Soneta.Kadry.AgencjaPracyTymczasowejWdz` | bazodanowe |  |  |
| AgencjaPT.KlientAgencji | `bool` | bazodanowe |  |  |
| AgencjaPT.Pracodawca | `Soneta.CRM.Kontrahent` | bazodanowe | Pracodawca użytkownik |  |
| AgencjaPT.WgPracodawca | `Soneta.Business.Key` |  |  |  |
| AgencjaPT.WydziałKlienta | `Soneta.Kadry.Wydzial` |  |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| BlokadaKadry | `Soneta.Kadry.DefinicjaBlokady` | bazodanowe |  |  |
| BlokadaKadry.Aktywna | `bool` | bazodanowe |  |  |
| BlokadaKadry.Dzien | `int` | bazodanowe |  |  |
| BlokadaKadry.JezeliWolnyDzien | `Soneta.Kadry.TypJeżeliWolnyDzień` | bazodanowe, enum |  |  |
| BlokadaKadry.OdKonca | `bool` | bazodanowe |  |  |
| BlokadaKadry.OpoznienieMies | `int` | bazodanowe |  |  |
| BlokadaKadry.OpóźnienieBlokady | `Soneta.Kadry.OpóźnienieBlokady` | enum |  |  |
| BlokadaPlace | `Soneta.Kadry.DefinicjaBlokady` | bazodanowe |  |  |
| BlokadaWeb | `Soneta.Kadry.DefinicjaBlokady` | bazodanowe |  |  |
| CentrumKosztow | `Soneta.Core.CentrumKosztow` | bazodanowe |  |  |
| Definicja | `Soneta.Kadry.DefinicjaWydziału` | bazodanowe | Kategoria |  |
| DeklaracjeElementuStruktury | `Soneta.Business.SubTable` |  |  |  |
| DokumentyAktualizacjiElementuStruktury | `Soneta.Business.SubTable<Soneta.Kalend.DokumentAktualizacjiKalendarza>` |  |  |  |
| DostępnePodwydzialy | `object` |  |  |  |
| ElementyPodzielnika | `Soneta.Business.SubTable<Soneta.Core.ElementPodzielnika>` |  |  |  |
| GUS | `Soneta.Kadry.StatystykaGUSWdz` | bazodanowe |  |  |
| GUS.Dzialalnosc | `string` | bazodanowe |  | Opis rodzaju działalności |
| GUS.Gmina | `string` | bazodanowe |  | Gmina |
| GUS.MiastoWies | `Soneta.Kadry.MiastoWieś` | bazodanowe, enum |  |  |
| Gotowka | `Soneta.Kasa.EwidencjaSP` | bazodanowe |  | Kasa, z której wypłacane są wynagrodzenia w gotówce |
| GotówkaZKasy | `Soneta.Kasa.EwidencjaSP` |  |  |  |
| HistoriaPodleglosci | `Soneta.Business.HistorySubTable<Soneta.Kadry.WydzialRef>` |  |  |  |
| HistoriaZmian | `Soneta.Business.HistorySubTable<Soneta.Kadry.HistoriaDanychWydziału>` |  |  |  |
| IndywidualnyLimitNadgodz | `bool` | bazodanowe |  |  |
| IndywidualnyLimitPZ | `bool` | bazodanowe |  |  |
| Kod | `string` | bazodanowe |  |  |
| Last | `Soneta.Kadry.HistoriaDanychWydziału` |  |  |  |
| LimitNadgodz | `int` | bazodanowe |  |  |
| LimitPZ | `int` | bazodanowe |  |  |
| ListaPlac | `bool` | bazodanowe |  |  |
| Metryka | `Soneta.Business.SubTable<Soneta.Kadry.MetrykaWydziału>` |  |  |  |
| Nadrzedny | `Soneta.Kadry.Wydzial` | bazodanowe |  |  |
| NadrzędnyWgDaty | `Soneta.Kadry.Wydzial.NadrzędnyManager` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaPomocnicza | `string` | bazodanowe |  |  |
| ObjectRight | `Soneta.Business.AccessRights` | enum |  |  |
| ObszarFunkcjonalny | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.ObszarFunkcjonalny` | bazodanowe |  |  |
| OcenyElementuStruktury | `Soneta.Business.SubTable<Soneta.Oceny.OcenaRealizacja>` |  |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Podwydzialy | `Soneta.Business.SubTable<Soneta.Kadry.Wydzial>` |  |  |  |
| PodwydziałyWgAktualnosci | `Soneta.Business.SubTable<Soneta.Kadry.WydzialRef>` |  |  |  |
| PodwydziałyWgDaty | `Soneta.Kadry.Wydzial.PodwydziałyManager` |  |  |  |
| PowiazaniaKontElementu | `Soneta.Business.SubTable` |  |  |  |
| Przelew | `Soneta.Kasa.EwidencjaSP` | bazodanowe |  | Rachunek bankowy, z którego realizowane są przelewy za wynagrodzenia |
| PrzelewZRachunku | `Soneta.Kasa.EwidencjaSP` |  |  |  |
| RozliczaPFRON | `bool` |  |  |  |
| RozliczaPIT | `bool` |  |  |  |
| RozliczaPPK | `bool` |  |  |  |
| RozliczaZUS | `bool` |  |  |  |
| SegmentKodu | `string` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  |  |
| TypLimituPZ | `Soneta.Kalend.TypLimituPracyZdalnej` | bazodanowe, enum |  |  |
| Wakaty | `Soneta.Business.SubTable<Soneta.HR2.RekrutacjaWakat>` |  |  |  |
| WszystkiePodwydziały | `System.Collections.ICollection` |  |  |  |
| WydziałPFRON | `Soneta.Kadry.Wydzial` |  |  |  |
| WydziałPIT | `Soneta.Kadry.Wydzial` |  |  |  |
| WydziałPPK | `Soneta.Kadry.Wydzial` |  |  |  |
| WydziałZUS | `Soneta.Kadry.Wydzial` |  |  |  |
| WydziałyPFRON | `Soneta.Types.Set<Soneta.Kadry.Wydzial>` |  |  |  |
| WydziałyPIT | `Soneta.Types.Set<Soneta.Kadry.Wydzial>` |  |  |  |
| WydziałyPPK | `Soneta.Types.Set<Soneta.Kadry.Wydzial>` |  |  |  |
| WydziałyZUS | `Soneta.Types.Set<Soneta.Kadry.Wydzial>` |  |  |  |
| Zgody | `Soneta.Business.SubTable<Soneta.Kadry.ZgodaNaEdycję>` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AccessRights (`Soneta.Business.AccessRights`)
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
