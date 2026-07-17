# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.PlanowanieZasobow.Dokumenty.PozycjaDokumentuPlanowaniaZasobow`
Nazwa tabeli: `PozDokPlanZasob`
Tytuł: Pozycje dokumentów planowania zasobów
Opis: Element szczegółowy dokumentu planowania zasobów (DokumentPlanowaniaZasobow). Określa planowaną ilość etatów dla konkretnego stanowiska i jednostki organizacyjnej w zadanym okresie.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dokument` → `DokumentPlanowaniaZasobow`

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataPrzeliczeniaWykonania | `Soneta.Types.Date` | bazodanowe | Data przeliczenia wykonania |  |
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe | Definicja stanowiska |  |
| Dokument | `Soneta.HR.ZKL.PlanowanieZasobow.Dokumenty.DokumentPlanowaniaZasobow` | bazodanowe, guided-parent |  |  |
| Ilosc | `Soneta.Types.Fraction` | bazodanowe | Ilość |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe | Okres pozycji |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
| Wykonanie | `Soneta.Types.Fraction` | bazodanowe | Wykonanie |  |
