# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.PlanowanieZasobow.Dokumenty.DokumentPlanowaniaZasobow`
Nazwa tabeli: `DokPlanZasob`
Tytuł: Dokumenty planowania zasobów
Opis: Nagłówek dokumentu planowania zasobów w module ZKL. Określa nazwę, okres planowania oraz datę dokumentu, grupując pozycje planistyczne przypisane do stanowisk i jednostek organizacyjnych.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 3
- subrowy: 0
- razem: 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataDokumentu | `Date` | bazodanowe | Data dokumentu |  |
| DataPrzeliczenia | `Date` | bazodanowe, tylko-odczyt | Data przeliczenia | Data ostatniego przeliczenia dokumentu czynnością Przelicz |
| DefinicjaDokumentu | `Soneta.HR.ZKL.PlanowanieZasobow.Definicje.DefinicjaPlanowaniaZasobow` | bazodanowe, tylko-odczyt | Definicja dokumentu |  |
| Korygowany | `Soneta.HR.ZKL.PlanowanieZasobow.Dokumenty.DokumentPlanowaniaZasobow` | bazodanowe, tylko-odczyt | Koryguje dokument | Dokument korygowany przez tę korektę (wymagany dla definicji oznaczonej jako korekta) |
| Nazwa | `string` | bazodanowe | Nazwa dokumentu |  |
| Okres | `FromTo` | bazodanowe, podlista | Okres planowania |  |
| Opis | `MemoText` | bazodanowe, podlista | Opis |  |
| Pozycje | `SubTable<Soneta.HR.ZKL.PlanowanieZasobow.Dokumenty.PozycjaDokumentuPlanowaniaZasobow>` | podlista |  |  |
| StatusDokumentu | `Soneta.HR.ZKL.Enums.StatusDokumentuPlanowaniaZasobow` (enum) | bazodanowe | Status |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe, tylko-odczyt | Jednostka organizacyjna |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusDokumentuPlanowaniaZasobow (`Soneta.HR.ZKL.Enums.StatusDokumentuPlanowaniaZasobow`)
- `None` = 0 — Brak
- `Roboczy` = 10 — Roboczy
- `Przetwarzany` = 20 — Przetwarzany
- `Zatwierdzony` = 30 — Zatwierdzony
- `Odrzucony` = 40 — Odrzucony
- `WRealizacji` = 50 — W realizacji
- `Anulowany` = 60 — Anulowany
- `Zrealizowany` = 70 — Zrealizowany
- `Niezrealizowany` = 80 — Niezrealizowany
