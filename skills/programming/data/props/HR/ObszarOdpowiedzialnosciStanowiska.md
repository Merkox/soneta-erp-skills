# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.OpisStanowiska.Odpowiedzialnosci.ObszarOdpowiedzialnosciStanowiska`
Nazwa tabeli: `ZklObszOdp`
Tytuł: Obszary odpowiedzialności stanowiska
Opis: Element szczegółowy definicji stanowiska (DefinicjaStanowiska). Przypisuje stopień odpowiedzialności z katalogu odpowiedzialności do stanowiska, umożliwiając ustrukturyzowany opis obszarów odpowiedzialności przypisanych do roli.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Stanowisko` → `DefinicjaStanowiska`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Odpowiedzialnosc | `Soneta.HR.ZKL.OpisStanowiska.Odpowiedzialnosci.Odpowiedzialnosc` | bazodanowe | Odpowiedzialność |  |
| Okres | `FromTo` | bazodanowe, podlista | Okres obowiązywania |  |
| Stanowisko | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Stopien | `Soneta.HR.ZKL.OpisStanowiska.Odpowiedzialnosci.StopienOdpowiedzialnosci` | bazodanowe | Stopień odpowiedzialności |  |
