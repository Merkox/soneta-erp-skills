# Pola i właściwości klasy biznesowej: `Soneta.HR.KategoriaPracownika`
Nazwa tabeli: `KatPrac`
Tytuł: Kategorie pracowników
Opis: Tabela słownikowa przechowuje zdefiniowane kategorie pracowników, obejmujące nazwę kategorii oraz przypisane jej dolne i górne granice punktowe. Dane te służą do jednoznacznej klasyfikacji pracowników.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| PunktyDo | `decimal` | bazodanowe | Punkty do |  |
| PunktyOd | `decimal` | bazodanowe | Punkty od |  |
