# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Budzetowanie.BudzetObrot`
Nazwa tabeli: `BudzetObroty`
Tytuł: Plany i realizacje na pozycjach budżetu.
Opis: Element szczegółowy pozycji budżetu (PozycjaBudzProj). Agreguje kwoty i ilości planowanych oraz zrealizowanych przychodów i kosztów na pozycji budżetowej w rozbiciu na daty i typy obrotów.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pozycja` → `PozycjaBudzProj`

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe | Data | Określa datę. |
| IloscKoszt | `Soneta.Types.Amount` | bazodanowe | Ilość kosztu | Określa ilość dla kosztu. |
| IloscPrzychod | `Soneta.Types.Amount` | bazodanowe | Ilość przychodu | Określa ilość dla przychodu. |
| KwotaKoszt | `Soneta.Types.Currency` | bazodanowe | Kwota kosztu | Określa kwotę dla kosztu. |
| KwotaPrzychod | `Soneta.Types.Currency` | bazodanowe | Kwota przychodu | Określa kwotę dla przychodu. |
| Pozycja | `Soneta.Zadania.Budzetowanie.PozycjaBudzProj` | bazodanowe, guided-parent |  | Określna pozycję budżetu, dla której tworzony obrót. |
| Typ | `Soneta.Zadania.Budzetowanie.TypObrotuBudzetu` | bazodanowe, enum | Typ obrotu budżetu | Określa typ obrotu budżetu. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypObrotuBudzetu (`Soneta.Zadania.Budzetowanie.TypObrotuBudzetu`)
- `Realizacja` = 0
- `Plan` = 1
