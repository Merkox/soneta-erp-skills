# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.ObrotKsiegowyBase`
Nazwa tabeli: `ObrotyKsiegowe`
Tytuł: Obrót księgowy
Opis: Zagregowany obrót księgowy konta za dany okres. Przechowuje skumulowane wartości obrotów Winien i Ma (zatwierdzonych i buforowych), narastająco i za okres, oraz salda. Służy do szybkiego wyliczania stanów kont bez konieczności sumowania poszczególnych zapisów.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 17
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| IndexObr | `Soneta.Ksiega.IndexObrotu` | bazodanowe, enum | Index obrotu |  |
| IsEmpty | `bool` |  |  |  |
| Konto | `Soneta.Ksiega.KontoBase` | bazodanowe |  |  |
| Ma | `decimal` | bazodanowe |  |  |
| MaB | `decimal` | bazodanowe |  |  |
| NMa | `decimal` | bazodanowe |  |  |
| NMaB | `decimal` | bazodanowe |  |  |
| NWn | `decimal` | bazodanowe |  |  |
| NWnB | `decimal` | bazodanowe |  |  |
| Okres | `Soneta.Ksiega.OkresObrachunkowy` | bazodanowe |  |  |
| SaldoMa | `decimal` | bazodanowe |  |  |
| SaldoMaB | `decimal` | bazodanowe |  |  |
| SaldoWn | `decimal` | bazodanowe |  |  |
| SaldoWnB | `decimal` | bazodanowe |  |  |
| Typ | `Soneta.Ksiega.TypObrotu` | bazodanowe, enum |  |  |
| Wn | `decimal` | bazodanowe |  |  |
| WnB | `decimal` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### IndexObrotu (`Soneta.Ksiega.IndexObrotu`)
- `Standard` = 1
- `Zamkniecie` = 2

### TypObrotu (`Soneta.Ksiega.TypObrotu`)
- `Księgowy` = 0 — Księgowy
- `Podatkowy` = 1
