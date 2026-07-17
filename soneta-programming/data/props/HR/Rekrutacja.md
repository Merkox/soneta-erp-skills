# Pola i właściwości klasy biznesowej: `Soneta.HR.Rekrutacja`
Nazwa tabeli: `Rekrutacje`
Opis: Zgłoszenie kandydata w procesie rekrutacji na konkretne stanowisko. Rejestruje dane pracownika-kandydata, jednostkę organizacyjną, źródło rekrutacji oraz stan procesu od zgłoszenia do zatrudnienia.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IŹródłoKartyCharakterystykiPracownika`

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anulowana | `bool` | bazodanowe | Nieaktualna |  |
| DataZatrudnienia | `Soneta.Types.Date` | bazodanowe |  |  |
| DataZgloszenia | `Soneta.Types.Date` | bazodanowe |  |  |
| Etap | `string` |  |  |  |
| Etapy | `Soneta.Business.LpSubTable<Soneta.HR.EtapRekrutacji>` |  |  |  |
| KartyKompetencji | `Soneta.Business.SubTable<Soneta.HR2.KartaKompetencjiPracownika>` |  |  |  |
| Odpowiedzialny | `Soneta.Oceny.IOceniający` | bazodanowe, iface-ref |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| OpisLinia | `string` |  |  |  |
| OpisPierwszaLinia | `string` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Stan | `Soneta.HR.StanyRekrutacji` | bazodanowe, enum |  |  |
| Stanowisko | `Soneta.HR.DefinicjaStanowiska` | bazodanowe |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
| Zrodlo | `Soneta.HR2.IŹródłoRekrutacji` | bazodanowe, iface-ref |  |  |

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
