# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kwalifikacje.DodatkowaKwalifikacjaZawodowa`
Nazwa tabeli: `ZklDodKwalZwd`
Tytuł: Dodatkowe kwalifikacje zawodowe
Opis: Słownik obejmuje certyfikaty, uprawnienia i kwalifikacje dodatkowe, niewynikające bezpośrednio z wykształcenia formalnego. W profilu kwalifikacji pozwala rozszerzyć opis kwalifikacji wymaganych lub rekomendowanych.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` | tylko-odczyt |  |  |
