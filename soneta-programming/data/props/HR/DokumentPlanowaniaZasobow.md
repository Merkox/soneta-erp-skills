# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.PlanowanieZasobow.Dokumenty.DokumentPlanowaniaZasobow`
Nazwa tabeli: `DokPlanZasob`
Tytuł: Dokumenty planowania zasobów
Opis: Nagłówek dokumentu planowania zasobów w module ZKL. Określa nazwę, okres planowania oraz datę dokumentu, grupując pozycje planistyczne przypisane do stanowisk i jednostek organizacyjnych.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataDokumentu | `Soneta.Types.Date` | bazodanowe | Data dokumentu |  |
| DataPrzeliczenia | `Soneta.Types.Date` | bazodanowe | Data przeliczenia | Data ostatniego przeliczenia dokumentu czynnością Przelicz |
| DefinicjaDokumentu | `Soneta.HR.ZKL.PlanowanieZasobow.Definicje.DefinicjaPlanowaniaZasobow` | bazodanowe | Definicja dokumentu |  |
| Korygowany | `Soneta.HR.ZKL.PlanowanieZasobow.Dokumenty.DokumentPlanowaniaZasobow` | bazodanowe | Koryguje dokument | Dokument korygowany przez tę korektę (wymagany dla definicji oznaczonej jako korekta) |
| Nazwa | `string` | bazodanowe | Nazwa dokumentu |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe | Okres planowania |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis |  |
| Pozycje | `Soneta.Business.SubTable<Soneta.HR.ZKL.PlanowanieZasobow.Dokumenty.PozycjaDokumentuPlanowaniaZasobow>` |  |  |  |
| StatusDokumentu | `Soneta.HR.ZKL.Enums.StatusDokumentuPlanowaniaZasobow` | bazodanowe, enum | Status |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |

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
