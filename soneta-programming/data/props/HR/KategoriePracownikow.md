# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kwalifikacje.KategoriePracownikow`
Nazwa tabeli: `ZklKatPrac`
Tytuł: Kategorie pracowników
Opis: Tabela słownikowa przechowuje zdefiniowane kategorie pracowników, obejmujące nazwę kategorii oraz przypisane jej dolne i górne granice punktowe wartościowania. Dane te służą do jednoznacznej klasyfikacji stanowisk, wspierając procesy wartościowania pracy.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| PoziomDo | `decimal` | bazodanowe | Do |  |
| PoziomOd | `decimal` | bazodanowe | Od |  |
| Priorytet | `int` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` | tylko-odczyt |  |  |
