# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.OpisStanowiska.Odpowiedzialnosci.StopienOdpowiedzialnosci`
Nazwa tabeli: `ZklStopOdp`
Tytuł: Stopnie odpowiedzialności
Opis: Zawiera stopnie (poziomy) odpowiedzialności w ramach poszczególnych kategorii katalogu odpowiedzialności. Wykorzystywany w opisie stanowiska do określenia poziomu odpowiedzialności.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Definicja | `string` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Odpowiedzialnosc | `Soneta.HR.ZKL.OpisStanowiska.Odpowiedzialnosci.Odpowiedzialnosc` | bazodanowe | Odpowiedzialność |  |
| Priorytet | `int` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` |  |  |  |
