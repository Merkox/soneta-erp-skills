# Pola i właściwości klasy biznesowej: `Soneta.Kadry.DefinicjaNagrodyKary`
Nazwa tabeli: `DefNagrodKar`
Tytuł: Definicje nagród lub kar
Opis: Słownik definicji nagród i kar pracowniczych. Określa typ (nagroda/kara), nazwę, powiązany element płacowy do rozliczenia oraz domyślną kwotę nagrody lub kary.
Tabela konfiguracyjna: Tak
Guided: root
Selektor: pole `Typ` (`Soneta.Kadry.TypNagrodyKary`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Kwota | `Currency` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Typ | `Soneta.Kadry.TypNagrodyKary` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Nagroda` | 1 | `Soneta.Kadry.DefinicjaNagrody` | Definicja nagrody |
| `Kara` | 2 | `Soneta.Kadry.DefinicjaKary` | Definicja kary |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypNagrodyKary (`Soneta.Kadry.TypNagrodyKary`)
- `Nagroda` = 1
- `Kara` = 2
