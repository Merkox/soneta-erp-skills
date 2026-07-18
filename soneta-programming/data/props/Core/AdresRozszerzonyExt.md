# Pola i właściwości klasy biznesowej: `Soneta.Core.AdresRozszerzonyExt`
Nazwa tabeli: `AdresyRozszerzon`
Tytuł: Adresy rozszerzone
Opis: Element szczegółowy adresu (AdresExt). Przechowuje rozszerzone dane adresowe wykraczające poza standardowy format, np. departament, piętro, dzielnica, prowincja.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Host` → `AdresExt`

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 1
- razem: 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AdresRozszerzony | `Soneta.Core.AdresRozszerzony` (subrow) | bazodanowe |  |  |
| AdresRozszerzony.AdresRozszerzonyExt | `Soneta.Core.AdresRozszerzonyExt` | tylko-odczyt |  |  |
| AdresRozszerzony.Departament | `string` | bazodanowe | Departament | Departament |
| AdresRozszerzony.Dzielnica | `string` | bazodanowe | Dzielnica | Dzielnica |
| AdresRozszerzony.NazwaBudynku | `string` | bazodanowe | NazwaBudynku | NazwaBudynku |
| AdresRozszerzony.Pietro | `string` | bazodanowe | Pietro | Pietro |
| AdresRozszerzony.Prowincja | `string` | bazodanowe | Prowincja | Prowincja |
| AdresRozszerzony.SkrytkaPocztowa | `string` | bazodanowe | SkrytkaPocztowa | SkrytkaPocztowa |
| AdresRozszerzony.Wydzial | `string` | bazodanowe | Wydzial | Wydzial |
| Host | `Soneta.Core.AdresExt` | bazodanowe, tylko-odczyt, guided-parent |  |  |
