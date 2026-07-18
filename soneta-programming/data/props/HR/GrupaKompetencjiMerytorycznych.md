# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kompetencje.GrupaKompetencjiMerytorycznych`
Nazwa tabeli: `ZklKtgKmpMery`
Tytuł: Katalog kompetencji merytorycznych
Opis: Tabela grupuje kompetencje merytoryczne w logiczne obszary specjalistyczne. Ułatwia zarządzanie dużą liczbą kompetencji w organizacji.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 1
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Kompetencje | `SubTable<Soneta.HR.ZKL.Slowniki.Kompetencje.KompetencjaMerytoryczna>` | podlista |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` | tylko-odczyt |  |  |
