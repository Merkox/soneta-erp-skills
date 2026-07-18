# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kwalifikacje.TytulZawodowyStopienNaukowy`
Nazwa tabeli: `ZklTytZwdStNauk`
Tytuł: Tytuły zawodowe i stopnie naukowe
Opis: Słownik obejmuje tytuły zawodowe oraz stopnie naukowe. W profilu kwalifikacji wspiera określenie wymagań poziomu wykształcenia i specjalizacji.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` | tylko-odczyt |  |  |
