# Moduł `Place` — tabele biznesowe

- Opis: Moduł płacowy obsługujący naliczanie wynagrodzeń. Zawiera listy płac, składniki wynagrodzenia, elementy wypłat, potrącenia, zasiłki, deklaracje PIT oraz rozliczenia z ZUS i US.
- Tabel: **33**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| BilansOtwarciaPIT | Bilansy otwarcia PIT | `BilansyOtwPIT` |  | root |  |  | WersjaBilansuOtwarciaPIT (2) | [BilansOtwarciaPIT.md](BilansOtwarciaPIT.md) |
| DefinicjaElementu | Definicje elementów wynagrodzenia | `DefElementow` | konfig | root |  |  |  | [DefinicjaElementu.md](DefinicjaElementu.md) |
| DefinicjaElementuRozliczenia |  | `DefElementowRozl` | konfig | root |  |  |  | [DefinicjaElementuRozliczenia.md](DefinicjaElementuRozliczenia.md) |
| DefinicjaListyPlac | Definicje list płac | `DefListPlac` | konfig | root |  | IRightsSource, IDefinicjaDokumentuOA |  | [DefinicjaListyPlac.md](DefinicjaListyPlac.md) |
| DefinicjaPlanowanejListyPłac | Definicje planowanych list płac | `DefPlanListPlac` | konfig | root |  | IDefinicjaDokumentuOA, IRightsSource |  | [DefinicjaPlanowanejListyPłac.md](DefinicjaPlanowanejListyPłac.md) |
| DodatekAutomatyczny | Dodatki automatyczne | `DodAutomatyczne` |  | root |  | IBazaZrodlaWyplaty |  | [DodatekAutomatyczny.md](DodatekAutomatyczny.md) |
| DokumentRozliczeniaKontrahenta | Dokumenty rozliczenia kontrahenta | `DokumentyRozlKon` |  | root |  |  |  | [DokumentRozliczeniaKontrahenta.md](DokumentRozliczeniaKontrahenta.md) |
| DokumentRozliczeniaPracownika | Rozliczenia pracownika | `DokumentyRozlPra` |  | root |  |  |  | [DokumentRozliczeniaPracownika.md](DokumentRozliczeniaPracownika.md) |
| ElementBilansuOtwarciaPIT | Elementy bilansów otwarcia PIT | `ElementyBOPIT` |  | child: Dokument→BilansOtwarciaPIT |  |  |  | [ElementBilansuOtwarciaPIT.md](ElementBilansuOtwarciaPIT.md) |
| ElementRozliczeniaPracownika | Elementy rozliczenia | `ElementyRozlPrac` |  | root |  |  |  | [ElementRozliczeniaPracownika.md](ElementRozliczeniaPracownika.md) |
| KodRSA | Kody na deklaracji RSA | `KodyRSA` | konfig | root |  |  |  | [KodRSA.md](KodRSA.md) |
| KosztAutorski | Koszty autorskie | `KosztyAutorskie` |  | root |  |  |  | [KosztAutorski.md](KosztAutorski.md) |
| ListaPlac | Listy płac | `ListyPlac` |  | root |  | IDokumentKsiegowalny |  | [ListaPlac.md](ListaPlac.md) |
| NieobecnoscERP7 |  | `NieobecnosciERP7` |  |  |  |  |  | [NieobecnoscERP7.md](NieobecnoscERP7.md) |
| OdbiorcaElementu |  | `OdbElementow` |  | child: Definicja→DefinicjaElementu |  |  |  | [OdbiorcaElementu.md](OdbiorcaElementu.md) |
| OświadczenieZusOpieka | Oświadczenia do zasiłku opiekuńczego | `OswiadZusOpieka` |  | root |  |  |  | [OświadczenieZusOpieka.md](OświadczenieZusOpieka.md) |
| PlanowanaListaPłac | Planowane listy płac | `PlanListyPlac` |  | root |  | IDokumentKsiegowalny |  | [PlanowanaListaPłac.md](PlanowanaListaPłac.md) |
| PlanowanaWypłata | Planowane wypłaty | `PlanowaneWyplaty` |  | child: ListaPlac→PlanowanaListaPłac |  | IZrodloOpisuAnalitycznego |  | [PlanowanaWypłata.md](PlanowanaWypłata.md) |
| PlanowanyElementWypłaty | Planowane elementy | `PlanElementyWyp` |  | child: Wyplata→PlanowanaWypłata |  |  |  | [PlanowanyElementWypłaty.md](PlanowanyElementWypłaty.md) |
| PodstawaNieobecnosci |  | `PodstawyNieobec` |  | child: Pracownik→Pracownik |  |  | TypyPodstawNieobecnosci (2) | [PodstawaNieobecnosci.md](PodstawaNieobecnosci.md) |
| PodstawaNieobecnosciOkresowa |  | `PodstawyNieobOkr` |  | child: Pracownik→Pracownik |  |  |  | [PodstawaNieobecnosciOkresowa.md](PodstawaNieobecnosciOkresowa.md) |
| PozycjaPIT | Pozycje na deklaracjach PIT | `PozycjePIT` | konfig | root |  |  |  | [PozycjaPIT.md](PozycjaPIT.md) |
| ProgStazuPracy |  | `ProgiStazuPracy` | konfig | child: Definicja→DefinicjaElementu |  |  |  | [ProgStazuPracy.md](ProgStazuPracy.md) |
| RozliczenieDokKontrahenta | Dokumenty ewidencji rozliczeń kontrahentów | `RozliDokKontr` |  | child: Dokument→DokumentRozliczeniaKontrahenta |  |  |  | [RozliczenieDokKontrahenta.md](RozliczenieDokKontrahenta.md) |
| RozliczenieWynagrodzenia | Rozliczenia wynagrodzenia | `RozliczWynagrodz` |  | child: Host→IRozliczenieWynagrodzeniaHost |  |  |  | [RozliczenieWynagrodzenia.md](RozliczenieWynagrodzenia.md) |
| StornoElementu | Storna elementów | `StornaElementow` |  | child: Stornowany→WypElement |  |  |  | [StornoElementu.md](StornoElementu.md) |
| WynagrodzenieERP7 |  | `WynagrodzeERP7` |  |  |  |  |  | [WynagrodzenieERP7.md](WynagrodzenieERP7.md) |
| WypElement | Elementy wypłaty | `WypElementy` |  | root |  |  | RodzajŹródłaWypłaty (33) | [WypElement.md](WypElement.md) |
| WypSkladnik | Składniki wypłaty | `WypSkladniki` |  | child: Element→WypElement |  |  | RodzajSkładnikaWypłaty (14) | [WypSkladnik.md](WypSkladnik.md) |
| Wyplata | Wypłaty | `Wyplaty` |  | root |  | IDokumentPlatny, IDokumentKsiegowalny, IZrodloOpisuAnalitycznego | TypWyplaty (3) | [Wyplata.md](Wyplata.md) |
| Zaliczka |  | `Zaliczki` |  | root |  | IBazaZrodlaWyplaty, IPowiązanieWypłaty |  | [Zaliczka.md](Zaliczka.md) |
| ZaniechaniePodatkowe | Zaniechania podatkowe | `ZaniechPodatkowe` |  | root |  |  |  | [ZaniechaniePodatkowe.md](ZaniechaniePodatkowe.md) |
| ZasiłekInnyPłatnik | Zasiłki (inny płatnik) | `ZasInnyPlatnik` |  | root |  |  |  | [ZasiłekInnyPłatnik.md](ZasiłekInnyPłatnik.md) |

