# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.PlanowanieZasobow.Dokumenty.PozycjaDokumentuPlanowaniaZasobow`
Nazwa tabeli: `PozDokPlanZasob`
Tytuł: Pozycje dokumentów planowania zasobów
Opis: Element szczegółowy dokumentu planowania zasobów (DokumentPlanowaniaZasobow). Określa planowaną ilość etatów dla konkretnego stanowiska i jednostki organizacyjnej w zadanym okresie.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dokument` → `DokumentPlanowaniaZasobow`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataPrzeliczeniaWykonania | `Date` | bazodanowe | Data przeliczenia wykonania |  |
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe | Definicja stanowiska |  |
| Dokument | `Soneta.HR.ZKL.PlanowanieZasobow.Dokumenty.DokumentPlanowaniaZasobow` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Ilosc | `Fraction` | bazodanowe | Ilość |  |
| Okres | `FromTo` | bazodanowe, podlista | Okres pozycji |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
| Wykonanie | `Fraction` | bazodanowe | Wykonanie |  |
