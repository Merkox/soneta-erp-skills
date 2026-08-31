# Pola i właściwości klasy biznesowej: `Soneta.HR2.RekrutacjaWakat`
Nazwa tabeli: `RekrutWakaty`
Tytuł: Wakaty
Opis: Zgłoszony wakat na stanowisko w jednostce organizacyjnej. Określa zapotrzebowanie kadrowe, planowaną datę zatrudnienia i liczbę wymaganych pracowników, inicjując proces rekrutacyjny.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IŹródłoRekrutacji`, `IŹródłoKartyOpisuStanowiska`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  |  |
| KartyOpisuStanowiska | `SubTable<Soneta.HR2.KartaOpisuStanowiskaBase>` | podlista |  |  |
| Odpowiedzialny | `Soneta.Oceny.IOceniający` | bazodanowe, iface-ref |  |  |
| OfertyPracy | `SubTable<Soneta.HR2.OfertaPracy>` | podlista |  |  |
| PlanowanaDataZatrudnienia | `Date` | bazodanowe |  | Planowana data zatrudniania pracowników |
| Stan | `Soneta.HR2.StanZgłoszonegoWakatu` (enum) | bazodanowe |  |  |
| Stanowisko | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, tylko-odczyt |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe, tylko-odczyt | Jednostka organizacyjna |  |
| Zapotrzebowanie | `int` | bazodanowe |  |  |
| Zatrudnieni | `int` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Odpowiedzialny | `IOceniający` | `KontaktOsoba`, `Pracownik`, `WykladowcaSzkol` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanZgłoszonegoWakatu (`Soneta.HR2.StanZgłoszonegoWakatu`)
- `Zgłoszony` = 1 — Zgłoszony
- `RekrutacjaZakończona` = 2
- `Anulowany` = 3
