# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.OpisStanowiska.ZasobyINarzedzia.WyposazenieStanowiska`
Nazwa tabeli: `ZklWypStanow`
Tytuł: Wyposażenie stanowiska
Opis: Zawiera listę narzędzi, sprzętu i zasobów przypisanych do stanowiska. W opisie ogólnym pozwala określić wymagane wyposażenie stanowiska.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` | tylko-odczyt |  |  |
