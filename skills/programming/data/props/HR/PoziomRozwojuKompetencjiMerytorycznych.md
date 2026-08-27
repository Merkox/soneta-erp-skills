# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kompetencje.PoziomRozwojuKompetencjiMerytorycznych`
Nazwa tabeli: `ZklPozRozKomMer`
Tytuł: Poziomy rozwoju kompetencji merytorycznych
Opis: Zawiera skale zaawansowania kompetencji specjalistycznych. W profilu kompetencji pozwala określić kompetencje porządne i wymagane dla stanowiska.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| PozPierwEfekt | `bool` | bazodanowe | Poziom pierwszy efektywny |  |
| Priorytet | `int` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` | tylko-odczyt |  |  |
