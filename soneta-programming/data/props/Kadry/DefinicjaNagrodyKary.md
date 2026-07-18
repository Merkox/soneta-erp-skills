# Pola i właściwości klasy biznesowej: `Soneta.Kadry.DefinicjaNagrodyKary`
Nazwa tabeli: `DefNagrodKar`
Tytuł: Definicje nagród lub kar
Opis: Słownik definicji nagród i kar pracowniczych. Określa typ (nagroda/kara), nazwę, powiązany element płacowy do rozliczenia oraz domyślną kwotę nagrody lub kary.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Kwota | `Currency` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Typ | `Soneta.Kadry.TypNagrodyKary` (enum) | bazodanowe, tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypNagrodyKary (`Soneta.Kadry.TypNagrodyKary`)
- `Nagroda` = 1
- `Kara` = 2
