# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.Kwalifikacyjny.ProfilKwalifikacyjny`
Nazwa tabeli: `ZklProfilKwal`
Tytuł: Profile kwalifikacji
Opis: Opisuje zestaw kwalifikacji wymaganych na stanowisku. Umożliwia kompleksową ewidencję oraz opis kwalifikacji formalnych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 21
- pola kalkulowane (z klas biznesowych): 21

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DoswGrupaOperatorNiezbedne | `Soneta.HR.ZKL.Enums.OperatorWymagan` | bazodanowe, enum | Doświadczenie w grupie stanowisk - operator (niezbędne) |  |
| DoswGrupaOperatorPozadane | `Soneta.HR.ZKL.Enums.OperatorWymagan` | bazodanowe, enum | Doświadczenie w grupie stanowisk - operator (pożądane) |  |
| DoswOperatorNiezbedne | `Soneta.HR.ZKL.Enums.OperatorWymagan` | bazodanowe, enum | Doświadczenie - operator (niezbędne) |  |
| DoswOperatorPozadane | `Soneta.HR.ZKL.Enums.OperatorWymagan` | bazodanowe, enum | Doświadczenie - operator (pożądane) |  |
| DoswiadczenieGrupa | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaDoswiadczeniaProfiluGrupa>` |  |  |  |
| DoswiadczenieGrupyNiezbedne | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaDoswiadczeniaProfiluGrupa>` |  |  |  |
| DoswiadczenieGrupyPozadane | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaDoswiadczeniaProfiluGrupa>` |  |  |  |
| DoswiadczenieObszar | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaDoswiadczeniaProfiluObszar>` |  |  |  |
| DoswiadczenieObszarNiezbedne | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaDoswiadczeniaProfiluObszar>` |  |  |  |
| DoswiadczenieObszarPozadane | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaDoswiadczeniaProfiluObszar>` |  |  |  |
| Host | `Soneta.HR.DefinicjaStanowiska` | bazodanowe |  |  |
| ItOperatorNiezbedne | `Soneta.HR.ZKL.Enums.OperatorWymagan` | bazodanowe, enum | Systemy IT - operator (niezbędne) |  |
| ItOperatorPozadane | `Soneta.HR.ZKL.Enums.OperatorWymagan` | bazodanowe, enum | Systemy IT - operator (pożądane) |  |
| JezykiObce | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaJezykowObcychProfilu>` |  |  |  |
| JezykiObceNiezbedne | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaJezykowObcychProfilu>` |  |  |  |
| JezykiObcePozadane | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaJezykowObcychProfilu>` |  |  |  |
| JezykiOperatorNiezbedne | `Soneta.HR.ZKL.Enums.OperatorWymagan` | bazodanowe, enum | Języki obce - operator (niezbędne) |  |
| JezykiOperatorPozadane | `Soneta.HR.ZKL.Enums.OperatorWymagan` | bazodanowe, enum | Języki obce - operator (pożądane) |  |
| KwalOperatorNiezbedne | `Soneta.HR.ZKL.Enums.OperatorWymagan` | bazodanowe, enum | Kwalifikacje - operator (niezbędne) |  |
| KwalOperatorPozadane | `Soneta.HR.ZKL.Enums.OperatorWymagan` | bazodanowe, enum | Kwalifikacje - operator (pożądane) |  |
| KwalifikacjeZawodowe | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaKwalifikacjiZawodowychProfilu>` |  |  |  |
| KwalifikacjeZawodoweNiezbedne | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaKwalifikacjiZawodowychProfilu>` |  |  |  |
| KwalifikacjeZawodowePozadane | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaKwalifikacjiZawodowychProfilu>` |  |  |  |
| MaszynyIUrzadzenia | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaMaszynIUrzadzenProfilu>` |  |  |  |
| MaszynyIUrzadzeniaNiezbedne | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaMaszynIUrzadzenProfilu>` |  |  |  |
| MaszynyIUrzadzeniaPozadane | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaMaszynIUrzadzenProfilu>` |  |  |  |
| MaszynyOperatorNiezbedne | `Soneta.HR.ZKL.Enums.OperatorWymagan` | bazodanowe, enum | Maszyny i urządzenia - operator (niezbędne) |  |
| MaszynyOperatorPozadane | `Soneta.HR.ZKL.Enums.OperatorWymagan` | bazodanowe, enum | Maszyny i urządzenia - operator (pożądane) |  |
| Nazwa | `string` | bazodanowe | Nazwa profilu |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe | Okres obowiązywania |  |
| StatusProfilu | `Soneta.HR.ZKL.Enums.StatusProfilu` | bazodanowe, enum |  |  |
| SystemyIT | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaSystemowITProfilu>` |  |  |  |
| SystemyITNiezbedne | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaSystemowITProfilu>` |  |  |  |
| SystemyITPozadane | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaSystemowITProfilu>` |  |  |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe |  |  |
| WyksztOperatorNiezbedne | `Soneta.HR.ZKL.Enums.OperatorWymagan` | bazodanowe, enum | Wykształcenie - operator (niezbędne) |  |
| WyksztOperatorPozadane | `Soneta.HR.ZKL.Enums.OperatorWymagan` | bazodanowe, enum | Wykształcenie - operator (pożądane) |  |
| WyksztPoziomNiezbedne | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.PoziomWyksztalcenia` | bazodanowe | Wykształcenie - poziom (niezbędne) |  |
| WyksztPoziomPozadane | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.PoziomWyksztalcenia` | bazodanowe | Wykształcenie - poziom (pożądane) |  |
| Wyksztalcenie | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaWyksztalceniaProfilu>` |  |  |  |
| WyksztalcenieNiezbedne | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaWyksztalceniaProfilu>` |  |  |  |
| WyksztalceniePozadane | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaWyksztalceniaProfilu>` |  |  |  |

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
