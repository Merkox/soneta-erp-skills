# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.OpisStanowiska.Odpowiedzialnosci.ObszarOdpowiedzialnosciPracownikaZkl`
Nazwa tabeli: `ZklObszOdpPrac`
Tytuł: Obszary odpowiedzialności pracownika
Opis: Tabela służy do ewidencjonowania zakresu obowiązków, przypisanych ról oraz odpowiedzialności poszczególnych pracowników w ramach organizacji. Umożliwia ona określenie kompetencji, odpowiedzialności za procesy biznesowe oraz wspiera przejrzystość struktury organizacyjnej i zarządzanie zasobami.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Odpowiedzialnosc | `Soneta.HR.ZKL.OpisStanowiska.Odpowiedzialnosci.Odpowiedzialnosc` | bazodanowe | Odpowiedzialność |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe | Okres obowiązywania |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, guided-parent |  |  |
| Stopien | `Soneta.HR.ZKL.OpisStanowiska.Odpowiedzialnosci.StopienOdpowiedzialnosci` | bazodanowe | Stopień odpowiedzialności |  |
