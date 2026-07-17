# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.OpisStanowiska.Odpowiedzialnosci.Odpowiedzialnosc`
Nazwa tabeli: `ZklKtgOdp`
Tytuł: Katalog odpowiedzialności
Opis: Definiuje kategorie odpowiedzialności (np. za bezpieczeństwo, decyzje, finanse) przypisywanych do stanowisk. Każda kategoria grupuje hierarchię stopni odpowiedzialności.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`, `IPozycjaKonfiguratora`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| Stopnie | `Soneta.Business.SubTable<Soneta.HR.ZKL.OpisStanowiska.Odpowiedzialnosci.StopienOdpowiedzialnosci>` |  |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` |  |  |  |
