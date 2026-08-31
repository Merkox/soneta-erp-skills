# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.OpisStanowiska.Odpowiedzialnosci.Odpowiedzialnosc`
Nazwa tabeli: `ZklKtgOdp`
Tytuł: Katalog odpowiedzialności
Opis: Definiuje kategorie odpowiedzialności (np. za bezpieczeństwo, decyzje, finanse) przypisywanych do stanowisk. Każda kategoria grupuje hierarchię stopni odpowiedzialności.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`, `IPozycjaKonfiguratora`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| Stopnie | `SubTable<Soneta.HR.ZKL.OpisStanowiska.Odpowiedzialnosci.StopienOdpowiedzialnosci>` | podlista |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` | tylko-odczyt |  |  |
