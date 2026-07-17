# Pola i właściwości klasy biznesowej: `Soneta.CRM.Opiekun`
Nazwa tabeli: `Opiekunowie`
Tytuł: Opiekunowie kontrahentów
Opis: Przypisanie opiekuna (operatora) do kontrahenta w określonej roli i okresie. Umożliwia zarządzanie odpowiedzialnością za relacje z klientami, z uwzględnieniem oddziałów firmy i typów opieki.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe | Aktywny | Określa czy opiekun jest aktywny. |
| DataDo | `Soneta.Types.Date` | bazodanowe | Data zakończenia opieki | Określa datę zakończenia kampanii |
| DataOd | `Soneta.Types.Date` | bazodanowe | Data rozpoczęcia opieki | Określa datę rozpoczęcia opieki. |
| IsVisibleKontakty | `bool` |  |  |  |
| Kontakty | `Soneta.Business.ViewInfo` |  |  |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe |  | Kontrahent, do którego przypisany jest opiekun. |
| OddzialFirmy | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Określa oddział firmy, do którego przypisany jest opiekun. |
| Operator | `Soneta.Business.App.Operator` | bazodanowe |  |  |
| Rola | `Soneta.CRM.Config.RolaOpiekun` | bazodanowe | Rola opiekuna | Rola opiekuna |
| Typ | `Soneta.CRM.TypOpiekuna` | bazodanowe, enum | Typ opiekuna | Określa typ opiekuna. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypOpiekuna (`Soneta.CRM.TypOpiekuna`)
- `Glówny` = 0 — Główny
- `Zastępca` = 1
