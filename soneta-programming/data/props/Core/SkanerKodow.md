# Pola i właściwości klasy biznesowej: `Soneta.Core.SkanerKodow`
Nazwa tabeli: `SkaneryKodow`
Tytuł: Skaner kodów
Opis: Konfiguracja skanera kodów kreskowych. Określa nazwę skanera, kody i nazwy prefiksu/sufiksu używane do identyfikacji danych ze skanera oraz flagę domyślności.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Domyslny | `bool` | bazodanowe | Domyślny |  |
| Nazwa | `string` | bazodanowe |  | Nazwa skanera kodów kreskowych. |
| PrefixKod | `int` | bazodanowe |  |  |
| PrefixNazwa | `string` | bazodanowe |  |  |
| SuffixKod | `int` | bazodanowe |  |  |
| SuffixNazwa | `string` | bazodanowe |  |  |
