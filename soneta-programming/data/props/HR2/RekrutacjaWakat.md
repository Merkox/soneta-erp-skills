# Pola i właściwości klasy biznesowej: `Soneta.HR2.RekrutacjaWakat`
Nazwa tabeli: `RekrutWakaty`
Tytuł: Wakaty
Opis: Zgłoszony wakat na stanowisko w jednostce organizacyjnej. Określa zapotrzebowanie kadrowe, planowaną datę zatrudnienia i liczbę wymaganych pracowników, inicjując proces rekrutacyjny.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IŹródłoRekrutacji`, `IŹródłoKartyOpisuStanowiska`

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| KartyOpisuStanowiska | `Soneta.Business.SubTable<Soneta.HR2.KartaOpisuStanowiskaBase>` |  |  |  |
| Odpowiedzialny | `Soneta.Oceny.IOceniający` | bazodanowe, iface-ref |  |  |
| OfertyPracy | `Soneta.Business.SubTable<Soneta.HR2.OfertaPracy>` |  |  |  |
| PlanowanaDataZatrudnienia | `Soneta.Types.Date` | bazodanowe |  | Planowana data zatrudniania pracowników |
| Stan | `Soneta.HR2.StanZgłoszonegoWakatu` | bazodanowe, enum |  |  |
| Stanowisko | `Soneta.HR.DefinicjaStanowiska` | bazodanowe |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
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
