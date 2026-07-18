# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.ObrotKsiegowyBase`
Nazwa tabeli: `ObrotyKsiegowe`
Tytuł: Obrót księgowy
Opis: Zagregowany obrót księgowy konta za dany okres. Przechowuje skumulowane wartości obrotów Winien i Ma (zatwierdzonych i buforowych), narastająco i za okres, oraz salda. Służy do szybkiego wyliczania stanów kont bez konieczności sumowania poszczególnych zapisów.
Tabela konfiguracyjna: Nie
Selektor: pole `Typ` (`Soneta.Ksiega.TypObrotu`) — wiele typów w jednej tabeli, podtypów: 2

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
| Typ | `Soneta.Ksiega.TypObrotu` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| Wn | `decimal` | bazodanowe, tylko-odczyt |  |  |
| WnB | `decimal` | bazodanowe, tylko-odczyt |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Księgowy` | 0 | `Soneta.Ksiega.ObrotKsiegowy` | Obrot księgowy |
| `Podatkowy` | 1 | `Soneta.Ksiega.ObrotPodatkowy` | Obrot podatkowy |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### IndexObrotu (`Soneta.Ksiega.IndexObrotu`)
- `Standard` = 1
- `Zamkniecie` = 2

### TypObrotu (`Soneta.Ksiega.TypObrotu`)
- `Księgowy` = 0 — Księgowy
- `Podatkowy` = 1
