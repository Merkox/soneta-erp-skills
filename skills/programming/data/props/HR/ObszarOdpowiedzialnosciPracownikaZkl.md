# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.OpisStanowiska.Odpowiedzialnosci.ObszarOdpowiedzialnosciPracownikaZkl`
Nazwa tabeli: `ZklObszOdpPrac`
Tytuł: Obszary odpowiedzialności pracownika
Opis: Tabela służy do ewidencjonowania zakresu obowiązków, przypisanych ról oraz odpowiedzialności poszczególnych pracowników w ramach organizacji. Umożliwia ona określenie kompetencji, odpowiedzialności za procesy biznesowe oraz wspiera przejrzystość struktury organizacyjnej i zarządzanie zasobami.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Odpowiedzialnosc | `Soneta.HR.ZKL.OpisStanowiska.Odpowiedzialnosci.Odpowiedzialnosc` | bazodanowe | Odpowiedzialność |  |
| Okres | `FromTo` | bazodanowe, podlista | Okres obowiązywania |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Stopien | `Soneta.HR.ZKL.OpisStanowiska.Odpowiedzialnosci.StopienOdpowiedzialnosci` | bazodanowe | Stopień odpowiedzialności |  |
