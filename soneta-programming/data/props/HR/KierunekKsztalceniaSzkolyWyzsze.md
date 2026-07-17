# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kwalifikacje.KierunekKsztalceniaSzkolyWyzsze`
Nazwa tabeli: `ZklKierKszWyz`
Tytuł: Kierunki kształcenia szkoły wyższe
Opis: Słownik obejmuje kierunki studiów wyższych wraz z ich klasyfikacją. W profilu kwalifikacji umożliwia dopasowanie poziomu i kierunku wykształcenia do wymagań stanowiska.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` |  |  |  |
