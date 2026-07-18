# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.OpisStanowiska.ZasobyINarzedzia.Benefit`
Nazwa tabeli: `ZklBenefity`
Tytuł: Benefity
Opis: Słownik obsługuje katalog benefitów oferowanych pracownikom na danym stanowisku lub w danej organizacji. Jest wykorzystywany w opisie ogólnym stanowiska.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` | tylko-odczyt |  |  |
