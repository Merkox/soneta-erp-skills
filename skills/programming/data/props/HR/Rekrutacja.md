# Pola i właściwości klasy biznesowej: `Soneta.HR.Rekrutacja`
Nazwa tabeli: `Rekrutacje`
Opis: Zgłoszenie kandydata w procesie rekrutacji na konkretne stanowisko. Rejestruje dane pracownika-kandydata, jednostkę organizacyjną, źródło rekrutacji oraz stan procesu od zgłoszenia do zatrudnienia.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IŹródłoKartyCharakterystykiPracownika`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anulowana | `bool` | bazodanowe | Nieaktualna |  |
| DataZatrudnienia | `Date` | bazodanowe |  |  |
| DataZgloszenia | `Date` | bazodanowe |  |  |
| Etap | `string` | tylko-odczyt |  |  |
| Etapy | `LpSubTable<Soneta.HR.EtapRekrutacji>` | podlista |  |  |
| KartyKompetencji | `SubTable<Soneta.HR2.KartaKompetencjiPracownika>` | podlista |  |  |
| Odpowiedzialny | `Soneta.Oceny.IOceniający` | bazodanowe, iface-ref |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| OpisLinia | `string` | tylko-odczyt |  |  |
| OpisPierwszaLinia | `string` | tylko-odczyt |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Stan | `Soneta.HR.StanyRekrutacji` (enum) | bazodanowe, tylko-odczyt |  |  |
| Stanowisko | `Soneta.HR.DefinicjaStanowiska` | bazodanowe |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
| Zrodlo | `Soneta.HR2.IŹródłoRekrutacji` | bazodanowe, tylko-odczyt, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Odpowiedzialny | `IOceniający` | `KontaktOsoba`, `Pracownik`, `WykladowcaSzkol` |
| Zrodlo | `IŹródłoRekrutacji` | `OfertaPracy`, `RekrutacjaAplikacja`, `RekrutacjaWakat` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanyRekrutacji (`Soneta.HR.StanyRekrutacji`)
- `Rekrutacja` = 1
- `Nieaktualny` = 2
- `Zatrudniony` = 3
