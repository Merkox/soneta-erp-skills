# Pola i właściwości klasy biznesowej: `Soneta.Kasa.DodatkoweDanePrzelewu`
Nazwa tabeli: `DodDanePrzelewow`
Tytuł: Dodatkowe dane przelewów
Opis: Element szczegółowy przelewu (PrzelewBase) przechowujący rozszerzone dane identyfikacyjne kontrahenta. Zawiera informacje o osobie fizycznej lub prawnej wymagane przez niektóre formaty przelewów zagranicznych, takie jak typ identyfikatora, dane adresowe i dane urodzeniowe.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Przelew` → `PrzelewBase`

- pola bazodanowe (zapisywalne): 10
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 13

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataUrodzenia | `Date` | bazodanowe |  | Data urodzenia osoby fizycznej |
| Kraj | `Soneta.Core.KrajTbl` | bazodanowe |  | Kraj urodzenia osoby fizycznej |
| Miejscowosc | `string` | bazodanowe |  | Miejscowość urodzenia osoby fizycznej |
| Nazwa | `string` | bazodanowe |  | Nazwa/Imię i nazwisko |
| Numer | `string` | bazodanowe |  | Numer identyfikatora |
| OsobaFizyczna | `bool` | bazodanowe |  | Typ danych |
| OsobaPrawna | `bool` |  |  |  |
| Przelew | `Soneta.Kasa.PrzelewBase` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| RodzajIdentyfikacji | `Soneta.Kasa.RodzajIdentyfikacjiKontrahentaPrzelewu` (enum) | bazodanowe |  | Rodzaj identyfikacji |
| Typ | `Soneta.Kasa.TypDanychDodatkowych` (enum) | bazodanowe, tylko-odczyt |  | Typ dodatkowych danych |
| TypIdentyfikatora | `Soneta.Kasa.TypIdenPodPrzel` | bazodanowe |  | Typ identyfikatora |
| Wojewodztwo | `string` | bazodanowe |  | Województwo urodzenia osoby fizycznej |
| Wystawca | `string` | bazodanowe |  | Wystawca identyfikatora |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajIdentyfikacjiKontrahentaPrzelewu (`Soneta.Kasa.RodzajIdentyfikacjiKontrahentaPrzelewu`)
- `Nieokreslony` = 0
- `DataMiejsceUrodzenia` = 1 — Data i miejsce urodzenia
- `Dokument` = 2
- `BIC` = 3
- `Identyfikator` = 4

### TypDanychDodatkowych (`Soneta.Kasa.TypDanychDodatkowych`)
- `Nieokreslony` = 0
- `Zleceniodawca` = 1
- `Odbiorca` = 2
- `PierwotnyZleceniodawca` = 3
- `OstatecznyOdbiorca` = 4
