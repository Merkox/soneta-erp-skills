# Moduł `Ksiega` — tabele biznesowe

- Opis: Moduł księgowości obsługujący pełną rachunkowość firmy: plan kont, zapisy księgowe, dekrety, dzienniki i okresy obrachunkowe. Zapewnia mechanizmy predekretacji za pomocą schematów księgowych, rozliczenia księgowe, opisy analityczne z podzielnikami kosztów, zestawienia księgowe oraz sprawozdania finansowe (bilans, RZiS, rachunek przepływów). Obsługuje również KPiR, kręgi kosztów, słowniki analityczne, matryce dokumentów i rozliczenia złych długów.
- Tabel: **42**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| DBIPKBRHist | Historia zmian statusów okresów rozliczeniowych PKBR | `DBIPKBRHists` | konfig | child: DBItemPKBROkRoz→DBItemPKBROkRoz |  |  |  | [DBIPKBRHist.md](DBIPKBRHist.md) |
| DBItemPKBROkRoz | Status okresów rozliczeniowych PKBR | `DBItemPKBROkRozs` | konfig | root |  |  |  | [DBItemPKBROkRoz.md](DBItemPKBROkRoz.md) |
| DefinicjaAnalityki | Definicje analityk | `DefAnalityk` |  | child: Konto→KontoBase |  |  | TypDefinicjiAnalityki (2) | [DefinicjaAnalityki.md](DefinicjaAnalityki.md) |
| DefinicjaKregu | Definicje kręgów | `DefinicjeKregow` | konfig | root |  |  |  | [DefinicjaKregu.md](DefinicjaKregu.md) |
| DefinicjaSlownika | Definicje słowników | `DefSlownikow` | konfig | root |  | IRightsSource |  | [DefinicjaSlownika.md](DefinicjaSlownika.md) |
| DekretBase | Dziennik księgowy | `Dziennik` |  | root |  |  | TypDziennika (2) | [DekretBase.md](DekretBase.md) |
| ElemDefinicjiSlownika | Elementy definicji słowników | `ElemDefSlownikow` | konfig | child: Definicja→DefinicjaSlownika |  |  |  | [ElemDefinicjiSlownika.md](ElemDefinicjiSlownika.md) |
| ElemOpisuAnalZapRel | Opis analityczny relacje | `OpisAnalZapRel` |  | child: ZapisKsiegowy→ZapisKsiegowy |  |  |  | [ElemOpisuAnalZapRel.md](ElemOpisuAnalZapRel.md) |
| ElemOpisuAnalitycznego | Opis analityczny | `OpisAnalityczny` |  | child: Ewidencja→DokEwidencji |  |  | TypOpisuAnalitycznego (2) | [ElemOpisuAnalitycznego.md](ElemOpisuAnalitycznego.md) |
| ElemSlownika | Elementy słowników | `ElemSlownikow` |  | root |  | IElementSlownika |  | [ElemSlownika.md](ElemSlownika.md) |
| GrupaKont | Grupy kont | `GrupyKont` | konfig | root |  |  | TypGrupyKont (2) | [GrupaKont.md](GrupaKont.md) |
| JednostkaSprawozdaniaKS | Jednostki sprawozdania | `JednostkiSprawKS` |  | child: Sprawozdanie→SprawozdanieKS |  | IPozycjaSprawozdaniaRoot, IAdresHost |  | [JednostkaSprawozdaniaKS.md](JednostkaSprawozdaniaKS.md) |
| KolumnaWynikuZestKS | Kolumny wyników zestawień księgowych | `KolumnyWynZestKS` |  | child: Wynik→WynikZestKS |  |  |  | [KolumnaWynikuZestKS.md](KolumnaWynikuZestKS.md) |
| KolumnaZestKS | Kolumny zestawień księgowych | `KolumnyZestKS` | konfig | child: Zestawienie→ZestawienieKS |  |  |  | [KolumnaZestKS.md](KolumnaZestKS.md) |
| KomorkaWynikuZestKS | Komórki wyników zestawień księgowych | `KomorkiWynZestKS` |  | child: Wynik→WynikZestKS |  |  |  | [KomorkaWynikuZestKS.md](KomorkaWynikuZestKS.md) |
| KontoBase | Konto | `Konta` |  | root |  |  | RodzajKonta (3) | [KontoBase.md](KontoBase.md) |
| MatrycaBase | Matryce dokumentów i zapłat | `Matryce` | konfig | root |  |  | TypDokumentu (4) | [MatrycaBase.md](MatrycaBase.md) |
| MatrycaPodmiot | MatrycePodmioty | `MatrycePodmioty` |  |  |  |  |  | [MatrycaPodmiot.md](MatrycaPodmiot.md) |
| ObrotKsiegowyBase | Obrót księgowy | `ObrotyKsiegowe` |  |  |  |  | TypObrotu (2) | [ObrotKsiegowyBase.md](ObrotKsiegowyBase.md) |
| OkresObrachunkowy | Okresy obrachunkowe | `OkresyObrach` | konfig | root |  |  | TypOkresuObrachunkowego (3) | [OkresObrachunkowy.md](OkresObrachunkowy.md) |
| PodokresObrachunkowy | Podokresy obrachunkowe | `PodokresyObrach` | konfig | child: OkresKs→OkresObrachunkowy |  |  |  | [PodokresObrachunkowy.md](PodokresObrachunkowy.md) |
| PowiazanieKontaBase | Powiązania kont | `PowiazaniaKont` |  | child: Konto→KontoBase |  |  | TypPowiazania (2) | [PowiazanieKontaBase.md](PowiazanieKontaBase.md) |
| PozGrupyKont | Pozycje grup kont | `PozGrupyKontT` | konfig | child: Grupa→GrupaKont |  |  |  | [PozGrupyKont.md](PozGrupyKont.md) |
| PozycjaDefKregu | Definicje definicji kręgów | `PozycjeDefKregow` | konfig | child: Definicja→DefinicjaKregu |  |  |  | [PozycjaDefKregu.md](PozycjaDefKregu.md) |
| PozycjaSchematuKsiegowego | Pozycje schematów księgowych | `PozSchemKsiegT` | konfig | child: Schemat→SchematKsiegowy |  |  | TypDokumentu (27) | [PozycjaSchematuKsiegowego.md](PozycjaSchematuKsiegowego.md) |
| PozycjaSprawozdaniaKS | Pozycje sprawozdań księgowych | `PozycjeSprawKS` |  | child: RootPoz→IPozycjaSprawozdaniaRoot |  | IPozycjaSprawozdaniaRoot | TypPozycjiSprawozdzaniaKS (6) | [PozycjaSprawozdaniaKS.md](PozycjaSprawozdaniaKS.md) |
| PozycjaWynikuZestKS | Pozycje wyników zestawień księgowych | `PozycjeWynZestKS` |  | child: Wynik→WynikZestKS |  |  |  | [PozycjaWynikuZestKS.md](PozycjaWynikuZestKS.md) |
| PozycjaZestKS | Pozycje zestawień księgowych | `PozycjeZestKS` | konfig | child: Zestawienie→ZestawienieKS |  | IPozycjaZestawieniaRoot |  | [PozycjaZestKS.md](PozycjaZestKS.md) |
| RelacjaOpisAnal | Relacje opisu analitycznego | `RelacjeOpisAnal` | konfig | root |  |  |  | [RelacjaOpisAnal.md](RelacjaOpisAnal.md) |
| RozliczenieKS | Rozliczenia księgowe | `RozliczeniaKS` |  |  |  | IRozliczenie, IElementKsiegowalny | TypRozliczeniaKS (3) | [RozliczenieKS.md](RozliczenieKS.md) |
| RozliczenieOA | Rozliczenie opisu analitycznego | `RozliczeniaOA` |  |  |  |  |  | [RozliczenieOA.md](RozliczenieOA.md) |
| SchematKsiegowy | Schematy księgowe | `SchematyKsiegowe` | konfig | root |  |  | TypDokumentu (27) | [SchematKsiegowy.md](SchematKsiegowy.md) |
| SchematPodz | Schemat podziałowy | `SchematyPodz` | konfig | root |  | ISchematPodziałowy |  | [SchematPodz.md](SchematPodz.md) |
| SchematPodzElem | Element schematu podziałowego | `SchematPodzElems` | konfig | root |  |  |  | [SchematPodzElem.md](SchematPodzElem.md) |
| SprawozdanieKS | Sprawozdania księgowe | `SprawozdaniaKS` |  | root |  | IPozycjaSprawozdaniaRoot | RodzajSprawozdaniaKS (12) | [SprawozdanieKS.md](SprawozdanieKS.md) |
| WynikZestKS | Wyniki zestawień księgowych | `WynikiZestKS` |  | root |  |  |  | [WynikZestKS.md](WynikZestKS.md) |
| ZapisKsiegowy | Zapisy księgowe | `ZapisyKsiegowe` |  | child: Dekret→DekretBase |  | IElementKsiegowalny | TypZapisu (2) | [ZapisKsiegowy.md](ZapisKsiegowy.md) |
| ZestawienieKS | Zestawienia księgowe | `ZestawieniaKS` | konfig | root |  | IPozycjaZestawieniaRoot |  | [ZestawienieKS.md](ZestawienieKS.md) |
| ZleDlugiDokument | Dokumenty ZD | `ZDDokumenty` |  | root |  | IDokument | TypDokumentu (1) | [ZleDlugiDokument.md](ZleDlugiDokument.md) |
| ZleDlugiPozycja | Pozycje ZD | `ZDPozycje` |  | child: Dokument→ZleDlugiDokument |  |  | TypPozycjiZleDlugi (2) | [ZleDlugiPozycja.md](ZleDlugiPozycja.md) |
| ZleDlugiPozycjaKorekty | Korekty cząstkowe ZD | `ZDPozycjeKorekty` |  | child: Korekta→ZleDlugiPozycja |  |  |  | [ZleDlugiPozycjaKorekty.md](ZleDlugiPozycjaKorekty.md) |
| ZnacznikKonta | Znaczniki kont | `ZnacznikiKont` | konfig | root |  |  | TypZnacznikaKonta (9) | [ZnacznikKonta.md](ZnacznikKonta.md) |

