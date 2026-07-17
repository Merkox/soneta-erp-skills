# Pola i właściwości klasy biznesowej: `Soneta.Kadry.DefinicjaNagrodyKary`
Nazwa tabeli: `DefNagrodKar`
Tytuł: Definicje nagród lub kar
Opis: Słownik definicji nagród i kar pracowniczych. Określa typ (nagroda/kara), nazwę, powiązany element płacowy do rozliczenia oraz domyślną kwotę nagrody lub kary.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Typ | `Soneta.Kadry.TypNagrodyKary` | bazodanowe, enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypNagrodyKary (`Soneta.Kadry.TypNagrodyKary`)
- `Nagroda` = 1
- `Kara` = 2
