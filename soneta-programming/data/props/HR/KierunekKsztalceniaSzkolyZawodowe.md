# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kwalifikacje.KierunekKsztalceniaSzkolyZawodowe`
Nazwa tabeli: `ZklKierKszZwd`
Tytuł: Kierunki kształcenia szkoły zawodowe
Opis: Słownik obejmuje kierunki nauczania charakterystyczne dla kształcenia zawodowego. W profilu kwalifikacji umożliwia dopasowanie poziomu i kierunku wykształcenia do wymagań stanowiska.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` | tylko-odczyt |  |  |
