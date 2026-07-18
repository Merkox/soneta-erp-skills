# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Budzetowanie.BudzetObrot`
Nazwa tabeli: `BudzetObroty`
Tytuł: Plany i realizacje na pozycjach budżetu.
Opis: Element szczegółowy pozycji budżetu (PozycjaBudzProj). Agreguje kwoty i ilości planowanych oraz zrealizowanych przychodów i kosztów na pozycji budżetowej w rozbiciu na daty i typy obrotów.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pozycja` → `PozycjaBudzProj`

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe | Data | Określa datę. |
| IloscKoszt | `Amount` | bazodanowe | Ilość kosztu | Określa ilość dla kosztu. |
| IloscPrzychod | `Amount` | bazodanowe | Ilość przychodu | Określa ilość dla przychodu. |
| KwotaKoszt | `Currency` | bazodanowe | Kwota kosztu | Określa kwotę dla kosztu. |
| KwotaPrzychod | `Currency` | bazodanowe | Kwota przychodu | Określa kwotę dla przychodu. |
| Pozycja | `Soneta.Zadania.Budzetowanie.PozycjaBudzProj` | bazodanowe, guided-parent |  | Określna pozycję budżetu, dla której tworzony obrót. |
| Typ | `Soneta.Zadania.Budzetowanie.TypObrotuBudzetu` (enum) | bazodanowe | Typ obrotu budżetu | Określa typ obrotu budżetu. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypObrotuBudzetu (`Soneta.Zadania.Budzetowanie.TypObrotuBudzetu`)
- `Realizacja` = 0
- `Plan` = 1
