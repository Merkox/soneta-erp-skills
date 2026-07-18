# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.ObrotKsiegowyBase`
Nazwa tabeli: `ObrotyKsiegowe`
Tytuł: Obrót księgowy
Opis: Zagregowany obrót księgowy konta za dany okres. Przechowuje skumulowane wartości obrotów Winien i Ma (zatwierdzonych i buforowych), narastająco i za okres, oraz salda. Służy do szybkiego wyliczania stanów kont bez konieczności sumowania poszczególnych zapisów.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 18
- podlisty: 0
- subrowy: 0
- razem: 18

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| IndexObr | `Soneta.Ksiega.IndexObrotu` (enum) | bazodanowe, tylko-odczyt | Index obrotu |  |
| IsEmpty | `bool` | tylko-odczyt |  |  |
| Konto | `Soneta.Ksiega.KontoBase` | bazodanowe, tylko-odczyt |  |  |
| Ma | `decimal` | bazodanowe, tylko-odczyt |  |  |
| MaB | `decimal` | bazodanowe, tylko-odczyt |  |  |
| NMa | `decimal` | bazodanowe, tylko-odczyt |  |  |
| NMaB | `decimal` | bazodanowe, tylko-odczyt |  |  |
| NWn | `decimal` | bazodanowe, tylko-odczyt |  |  |
| NWnB | `decimal` | bazodanowe, tylko-odczyt |  |  |
| Okres | `Soneta.Ksiega.OkresObrachunkowy` | bazodanowe, tylko-odczyt |  |  |
| SaldoMa | `decimal` | bazodanowe, tylko-odczyt |  |  |
| SaldoMaB | `decimal` | bazodanowe, tylko-odczyt |  |  |
| SaldoWn | `decimal` | bazodanowe, tylko-odczyt |  |  |
| SaldoWnB | `decimal` | bazodanowe, tylko-odczyt |  |  |
| Typ | `Soneta.Ksiega.TypObrotu` (enum) | bazodanowe, tylko-odczyt |  |  |
| Wn | `decimal` | bazodanowe, tylko-odczyt |  |  |
| WnB | `decimal` | bazodanowe, tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### IndexObrotu (`Soneta.Ksiega.IndexObrotu`)
- `Standard` = 1
- `Zamkniecie` = 2

### TypObrotu (`Soneta.Ksiega.TypObrotu`)
- `Księgowy` = 0 — Księgowy
- `Podatkowy` = 1
