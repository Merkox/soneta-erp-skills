# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.ZestawienieKS`
Nazwa tabeli: `ZestawieniaKS`
Tytuł: Zestawienia księgowe
Opis: Zestawienie księgowe to konfigurowalna definicja raportu opartego na danych z planu kont i zapisów księgowych. Pozwala definiować strukturę wierszy (pozycji) i kolumn z wyrażeniami obliczeniowymi, obsługuje ochronę struktury, numerację pozycji oraz generowanie wyników dla pulpitu klienta biura rachunkowego.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IPozycjaZestawieniaRoot`

- pola bazodanowe: 18
- pola kalkulowane (z klas biznesowych): 23

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Zablokowana | Blokada zestawienia |
| BlokadaDodKolumn | `bool` | bazodanowe | Blokada dodawania kolumn | Blokada możliwości dodawania kolumn |
| BlokadaDodPozycji | `bool` | bazodanowe | Blokada dodawania pozycji | Blokada możliwości dodawania pozycji |
| ClassName | `string` |  |  |  |
| DefaultFileName | `string` |  |  |  |
| DefaultIdentifier | `string` |  |  |  |
| DefaultProject | `Soneta.Business.Compiler.RuntimeProject` |  |  |  |
| DekretyZamkniecia | `Soneta.Ksiega.DekretyZamknieciaOpcja` | bazodanowe, enum |  |  |
| DlaPulpituKB | `bool` | bazodanowe | Prezentuj zapisane wyniki w Pulpicie Klienta Biura Rachunkowego |  |
| Documents | `System.Collections.Generic.IEnumerable<Soneta.Business.Compiler.IRuntimeDocument>` |  |  |  |
| GeneratedCode | `Soneta.Business.MemoText` | bazodanowe |  |  |
| HasCachedCode | `bool` |  |  |  |
| Kod | `string` |  |  |  |
| Kolumny | `Soneta.Business.SubTable<Soneta.Ksiega.KolumnaZestKS>` |  |  |  |
| LiczSumyZWyrazenia | `bool` | bazodanowe | Sumy liczone są z wyrażenia |  |
| Nazwa | `string` | bazodanowe |  |  |
| Numeracja | `string` | bazodanowe |  |  |
| OchronaWl | `bool` | bazodanowe |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  | Oddział firmy |
| Poziom1 | `Soneta.Ksiega.TypNumeracji` | enum |  |  |
| Poziom10 | `Soneta.Ksiega.TypNumeracji` | enum |  |  |
| Poziom2 | `Soneta.Ksiega.TypNumeracji` | enum |  |  |
| Poziom3 | `Soneta.Ksiega.TypNumeracji` | enum |  |  |
| Poziom4 | `Soneta.Ksiega.TypNumeracji` | enum |  |  |
| Poziom5 | `Soneta.Ksiega.TypNumeracji` | enum |  |  |
| Poziom6 | `Soneta.Ksiega.TypNumeracji` | enum |  |  |
| Poziom7 | `Soneta.Ksiega.TypNumeracji` | enum |  |  |
| Poziom8 | `Soneta.Ksiega.TypNumeracji` | enum |  |  |
| Poziom9 | `Soneta.Ksiega.TypNumeracji` | enum |  |  |
| Pozycje | `Soneta.Business.SubTable<Soneta.Ksiega.PozycjaZestKS>` |  |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| SubPozycje | `Soneta.Business.SubTable<Soneta.Ksiega.PozycjaZestKS>` |  |  |  |
| Symbol | `string` | bazodanowe |  |  |
| TypDefinicji | `Soneta.Ksiega.TypDefinicjiZestawienia` | bazodanowe, enum |  |  |
| TypJednostki | `Soneta.Ksiega.TypJednostkiKsiegowy` | bazodanowe, enum |  |  |
| Wielooddzialowosc | `bool` |  |  |  |
| Wyniki | `Soneta.Business.SubTable<Soneta.Ksiega.WynikZestKS>` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DekretyZamknieciaOpcja (`Soneta.Ksiega.DekretyZamknieciaOpcja`)
- `Domyslnie` = 0 — Domyślnie
- `Tak` = 1
- `Nie` = 2

### TypDefinicjiZestawienia (`Soneta.Ksiega.TypDefinicjiZestawienia`)
- `Uzytkownika` = 0 — Użytkownika
- `CIT2` = 10
- `CIT8` = 20 — CIT8
- `CIT8ZK` = 21 — CIT8 ZK
- `PIT5` = 30 — PIT5
- `PIT5KPiR` = 31 — PIT5 KPiR
- `PIT5L` = 32 — PIT5L
- `PIT5LKPiR` = 33 — PIT5L KPiR
- `RWKPiR` = 40 — RW KPiR
- `BudzetBudzet` = 41 — Budżet
- `BudzetRB28` = 42 — Budżet RB28
- `BilansMikro` = 100 — Bilans mikro
- `BilansMala` = 101 — Bilans mała
- `BilansInna` = 102 — Bilans inna
- `BilansOP` = 103 — Bilans OP
- `BilansSkonsolid` = 104 — Bilans skonsolidowana
- `RachPrzepMBInna` = 120 — Rach przepł. MB inna
- `RachPrzepMBSkonsolid` = 121 — Rach przepł. MB skonsolidowana
- `RachPrzepMPInna` = 122 — Rach przepł. MP inna
- `RachPrzepMPSkonsolid` = 123 — Rach przepł. MP skonsolidowana
- `RZiSMikro` = 130 — RZiS mikro
- `RZiSOP` = 131 — RZiS OP
- `RZiSPorMala` = 140 — RZiS porówn. mała
- `RZiSPorInna` = 141 — RZiS porówn. inna
- `RZiSPorSkonsolid` = 142 — RZiS porówn. skonsolidowana
- `RZiSPorMalaOd2024` = 143 — RZiS porówn. mała od 2024
- `RZiSPorInnaOd2024` = 144 — RZiS porówn. inna od 2024
- `RZiSPorSkonsolidOd2024` = 145 — RZiS porówn. skonsolidowana od 2024
- `RZiSKalkMala` = 150 — RZiS kalk. mała
- `RZiSKalkInna` = 151 — RZiS kalk. inna
- `RZiSKalkSkonsolid` = 152 — RZiS kalk. skonsolidowana
- `RZiSKalkMalaOd2024` = 153 — RZiS kalk. mała od 2024
- `RZiSKalkInnaOd2024` = 154 — RZiS kalk. inna od 2024
- `RZiSKalkSkonsolidOd2024` = 155 — RZiS kalk. skonsolidowana od 2024
- `ZZwKWInna` = 160 — ZZwKW inna
- `ZZwKWSkonsolid` = 161 — ZZwKW skonsolidowana
- `RPD` = 170 — Rozliczenie podatku dochodowego
- `F03` = 180 — Sprawozdanie F 03
- `BilansASI` = 190 — Bilans ASI
- `RZiSPorASI` = 191 — RZiS porówn. ASI
- `RZiSKalASI` = 192 — RZiS kalk. ASI

### TypJednostkiKsiegowy (`Soneta.Ksiega.TypJednostkiKsiegowy`)
- `Nieokreslona` = 0 — Nieokreślony
- `Inna` = 1
- `Mala` = 2 — Mała
- `Mikro` = 3
- `OP` = 4 — OP
- `Skonsolidowana` = 5
- `ASI` = 6

### TypNumeracji (`Soneta.Ksiega.TypNumeracji`)
- `_` = 0 — (brak)
- `_1` = 1 — 1,2,3...
- `_A` = 2 — A,B,C...
- `_a` = 3 — a,b,c...
- `_X` = 4 — I,II,III...
- `_x` = 5 — i,ii,iii...
