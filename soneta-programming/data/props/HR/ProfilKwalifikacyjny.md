# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.Kwalifikacyjny.ProfilKwalifikacyjny`
Nazwa tabeli: `ZklProfilKwal`
Tytuł: Profile kwalifikacji
Opis: Opisuje zestaw kwalifikacji wymaganych na stanowisku. Umożliwia kompleksową ewidencję oraz opis kwalifikacji formalnych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 17
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 23
- subrowy: 0
- razem: 42

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DoswGrupaOperatorNiezbedne | `Soneta.HR.ZKL.Enums.OperatorWymagan` (enum) | bazodanowe | Doświadczenie w grupie stanowisk - operator (niezbędne) |  |
| DoswGrupaOperatorPozadane | `Soneta.HR.ZKL.Enums.OperatorWymagan` (enum) | bazodanowe | Doświadczenie w grupie stanowisk - operator (pożądane) |  |
| DoswOperatorNiezbedne | `Soneta.HR.ZKL.Enums.OperatorWymagan` (enum) | bazodanowe | Doświadczenie - operator (niezbędne) |  |
| DoswOperatorPozadane | `Soneta.HR.ZKL.Enums.OperatorWymagan` (enum) | bazodanowe | Doświadczenie - operator (pożądane) |  |
| DoswiadczenieGrupa | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaDoswiadczeniaProfiluGrupa>` | podlista |  |  |
| DoswiadczenieGrupyNiezbedne | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaDoswiadczeniaProfiluGrupa>` | podlista |  |  |
| DoswiadczenieGrupyPozadane | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaDoswiadczeniaProfiluGrupa>` | podlista |  |  |
| DoswiadczenieObszar | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaDoswiadczeniaProfiluObszar>` | podlista |  |  |
| DoswiadczenieObszarNiezbedne | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaDoswiadczeniaProfiluObszar>` | podlista |  |  |
| DoswiadczenieObszarPozadane | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaDoswiadczeniaProfiluObszar>` | podlista |  |  |
| Host | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, tylko-odczyt |  |  |
| ItOperatorNiezbedne | `Soneta.HR.ZKL.Enums.OperatorWymagan` (enum) | bazodanowe | Systemy IT - operator (niezbędne) |  |
| ItOperatorPozadane | `Soneta.HR.ZKL.Enums.OperatorWymagan` (enum) | bazodanowe | Systemy IT - operator (pożądane) |  |
| JezykiObce | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaJezykowObcychProfilu>` | podlista |  |  |
| JezykiObceNiezbedne | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaJezykowObcychProfilu>` | podlista |  |  |
| JezykiObcePozadane | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaJezykowObcychProfilu>` | podlista |  |  |
| JezykiOperatorNiezbedne | `Soneta.HR.ZKL.Enums.OperatorWymagan` (enum) | bazodanowe | Języki obce - operator (niezbędne) |  |
| JezykiOperatorPozadane | `Soneta.HR.ZKL.Enums.OperatorWymagan` (enum) | bazodanowe | Języki obce - operator (pożądane) |  |
| KwalOperatorNiezbedne | `Soneta.HR.ZKL.Enums.OperatorWymagan` (enum) | bazodanowe | Kwalifikacje - operator (niezbędne) |  |
| KwalOperatorPozadane | `Soneta.HR.ZKL.Enums.OperatorWymagan` (enum) | bazodanowe | Kwalifikacje - operator (pożądane) |  |
| KwalifikacjeZawodowe | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaKwalifikacjiZawodowychProfilu>` | podlista |  |  |
| KwalifikacjeZawodoweNiezbedne | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaKwalifikacjiZawodowychProfilu>` | podlista |  |  |
| KwalifikacjeZawodowePozadane | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaKwalifikacjiZawodowychProfilu>` | podlista |  |  |
| MaszynyIUrzadzenia | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaMaszynIUrzadzenProfilu>` | podlista |  |  |
| MaszynyIUrzadzeniaNiezbedne | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaMaszynIUrzadzenProfilu>` | podlista |  |  |
| MaszynyIUrzadzeniaPozadane | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaMaszynIUrzadzenProfilu>` | podlista |  |  |
| MaszynyOperatorNiezbedne | `Soneta.HR.ZKL.Enums.OperatorWymagan` (enum) | bazodanowe | Maszyny i urządzenia - operator (niezbędne) |  |
| MaszynyOperatorPozadane | `Soneta.HR.ZKL.Enums.OperatorWymagan` (enum) | bazodanowe | Maszyny i urządzenia - operator (pożądane) |  |
| Nazwa | `string` | bazodanowe | Nazwa profilu |  |
| Okres | `FromTo` | bazodanowe, podlista | Okres obowiązywania |  |
| StatusProfilu | `Soneta.HR.ZKL.Enums.StatusProfilu` (enum) | bazodanowe, tylko-odczyt |  |  |
| SystemyIT | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaSystemowITProfilu>` | podlista |  |  |
| SystemyITNiezbedne | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaSystemowITProfilu>` | podlista |  |  |
| SystemyITPozadane | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaSystemowITProfilu>` | podlista |  |  |
| Uwagi | `MemoText` | bazodanowe, podlista |  |  |
| WyksztOperatorNiezbedne | `Soneta.HR.ZKL.Enums.OperatorWymagan` (enum) | bazodanowe | Wykształcenie - operator (niezbędne) |  |
| WyksztOperatorPozadane | `Soneta.HR.ZKL.Enums.OperatorWymagan` (enum) | bazodanowe | Wykształcenie - operator (pożądane) |  |
| WyksztPoziomNiezbedne | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.PoziomWyksztalcenia` | bazodanowe | Wykształcenie - poziom (niezbędne) |  |
| WyksztPoziomPozadane | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.PoziomWyksztalcenia` | bazodanowe | Wykształcenie - poziom (pożądane) |  |
| Wyksztalcenie | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaWyksztalceniaProfilu>` | podlista |  |  |
| WyksztalcenieNiezbedne | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaWyksztalceniaProfilu>` | podlista |  |  |
| WyksztalceniePozadane | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaWyksztalceniaProfilu>` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### OperatorWymagan (`Soneta.HR.ZKL.Enums.OperatorWymagan`)
- `None` = 0 — Brak
- `And` = 10 — ORAZ
- `Or` = 20 — LUB

### StatusProfilu (`Soneta.HR.ZKL.Enums.StatusProfilu`)
- `None` = 0 — Brak
- `Roboczy` = 10 — Roboczy
- `Zatwierdzony` = 20 — Zatwierdzony
- `WRealizacji` = 30 — W realizacji
