# Pola i właściwości klasy biznesowej: `Soneta.HR.KategoriaPracownika`
Nazwa tabeli: `KatPrac`
Tytuł: Kategorie pracowników
Opis: Tabela słownikowa przechowuje zdefiniowane kategorie pracowników, obejmujące nazwę kategorii oraz przypisane jej dolne i górne granice punktowe. Dane te służą do jednoznacznej klasyfikacji pracowników.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| PunktyDo | `decimal` | bazodanowe | Punkty do |  |
| PunktyOd | `decimal` | bazodanowe | Punkty od |  |
