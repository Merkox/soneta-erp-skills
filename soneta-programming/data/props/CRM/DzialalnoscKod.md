# Pola i właściwości klasy biznesowej: `Soneta.CRM.DzialalnoscKod`
Nazwa tabeli: `DzialalnoscKody`
Tytuł: Wykaz kodów PDK z opisem działalności
Opis: Słownik kodów Polskiej Klasyfikacji Działalności (PKD) z hierarchiczną strukturą sekcji, działów, grup i klas. Służy do klasyfikacji rodzajów działalności gospodarczej kontrahentów zgodnie ze standardem GUS.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dzial | `string` | bazodanowe |  |  |
| DzialalnoscKody | `Soneta.Business.SubTable<Soneta.CRM.KthDzialalnKod>` |  |  |  |
| Grupa | `string` | bazodanowe |  |  |
| Klasa | `string` | bazodanowe |  |  |
| Kod | `string` | bazodanowe |  |  |
| KodFormatowany | `string` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Podstawowa | `bool` | bazodanowe |  |  |
| Sekcja | `string` | bazodanowe |  |  |
| TypDzialalnosci | `Soneta.CRM.TypKoduDzialalnosci` | bazodanowe, enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypKoduDzialalnosci (`Soneta.CRM.TypKoduDzialalnosci`)
- `Inne` = 0 — Inne
- `PKD` = 1 — PKD
- `SIC` = 2 — SIC
