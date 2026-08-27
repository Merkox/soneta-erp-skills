# Moduł `Core` — tabele biznesowe

- Opis: Moduł podstawowy platformy enova365 zawierający wspólne obiekty biznesowe. Obejmuje kontrahentów, adresy, lokalizacje, banki, słowniki, szablony, definicje dokumentów, powiadomienia, załączniki oraz mechanizmy konfiguracji systemu.
- Tabel: **176**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| AdditionRowDesc | Dodatkowe informacje | `AdditionRowDescs` |  | root |  |  |  | [AdditionRowDesc.md](AdditionRowDesc.md) |
| AdresExt | Adres | `Adresy` |  | child: Host→IAdresHost |  |  |  | [AdresExt.md](AdresExt.md) |
| AdresRozszerzonyExt | Adresy rozszerzone | `AdresyRozszerzon` |  | child: Host→AdresExt |  |  |  | [AdresRozszerzonyExt.md](AdresRozszerzonyExt.md) |
| AdresWWW | Adresy WWW | `AdresyWWW` |  | child: Zapis→IAdresyWWWHost |  |  |  | [AdresWWW.md](AdresWWW.md) |
| Aktualnosc | Aktualności | `Aktualnosci` |  | root |  |  |  | [Aktualnosc.md](Aktualnosc.md) |
| CRUApiKey | Klucz API CRU | `CRUApiKeys` |  | root |  |  |  | [CRUApiKey.md](CRUApiKey.md) |
| CRUContract | Dokument CRU | `CRUContracts` |  | root |  |  |  | [CRUContract.md](CRUContract.md) |
| CelKontaktu | Cele kontaktów | `CeleKontaktow` |  |  |  |  |  | [CelKontaktu.md](CelKontaktu.md) |
| CentrumKosztow |  | `CentraKosztow` | konfig | root |  | IElementSlownika |  | [CentrumKosztow.md](CentrumKosztow.md) |
| CodeFile | Dodatkowy kod do kompilacji | `CodeFiles` | konfig | root |  |  |  | [CodeFile.md](CodeFile.md) |
| Comment | Komentarze | `Comments` |  | root |  | IDiscussionItem |  | [Comment.md](Comment.md) |
| DaneKontaktowe | Dane kontaktowe | `DaneKnt` |  | child: Host→IDaneKontaktoweHost |  |  |  | [DaneKontaktowe.md](DaneKontaktowe.md) |
| DaneKontrahenta |  | `DaneKontrahentow` |  | child: Host→IDaneKontrahentaHost |  | IDaneKontaktoweHost |  | [DaneKontrahenta.md](DaneKontrahenta.md) |
| DaneZewn | Dane z systemów zewnętrznych | `DaneZ` |  |  |  |  |  | [DaneZewn.md](DaneZewn.md) |
| DbTuple | Dokumenty dodatkowe | `Tuples` |  | root |  | IŹródłoPowiązaniaStrukturyOrganizacyjnej, IDokument, IManagedRowInfoHost, IPoświadczenieOdbioruHost |  | [DbTuple.md](DbTuple.md) |
| DbTupleDefinition | Definicje dokumentów dodatkowych | `TuplesDefs` | konfig | root |  | IRuntimeRowDefinition, IRightsSource, IManagedRowDefinion, IWizardReferenceHost, ICodeFileHost, ISysNotificationHost, IWfPlugInReferenceHost, IPreviewPageHost | DbTupleDefinitionType (2) | [DbTupleDefinition.md](DbTupleDefinition.md) |
| DbTupleRel | Relacje dokumentów dodatkowych | `TuplesRelations` |  | child: DbTuple→DbTuple |  |  |  | [DbTupleRel.md](DbTupleRel.md) |
| DefDiscussion | Definicje dyskusji | `DefDiscussions` | konfig | root |  | IDiscussionPlugInHost, IRightsSource |  | [DefDiscussion.md](DefDiscussion.md) |
| DefTeczki | Definicje teczek | `DefsTeczek` | konfig | root |  | IRightsSource |  | [DefTeczki.md](DefTeczki.md) |
| DefXmlElem | Elementy definicji XML | `DefsXmlElem` | konfig | root |  |  |  | [DefXmlElem.md](DefXmlElem.md) |
| DefXmlFiltr | Filtry dla komunikatów. | `DefXmlFiltry` |  |  |  |  |  | [DefXmlFiltr.md](DefXmlFiltr.md) |
| DefXmlNag | Definicje XML | `DefsXmlNag` | konfig | root |  |  | SelektorDefXml (15) | [DefXmlNag.md](DefXmlNag.md) |
| DefinicjaDokumentu | Definicje dokumentów | `DefDokumentow` | konfig | root |  | IRightsSource, IDefinicjaKomunikatuEDIHost, IDefinicjaDokumentuOA | TypDokumentu (179) | [DefinicjaDokumentu.md](DefinicjaDokumentu.md) |
| DefinicjaDokumentuOA | Dokument elementu opisu analitycznego | `DefDokumentowOA` | konfig | root |  |  |  | [DefinicjaDokumentuOA.md](DefinicjaDokumentuOA.md) |
| DefinicjaElementuStrukturyOrganizacyjnej | Definicje elementów struktur organizacyjnych | `DefElStrukturOrg` | konfig | root |  |  |  | [DefinicjaElementuStrukturyOrganizacyjnej.md](DefinicjaElementuStrukturyOrganizacyjnej.md) |
| DefinicjaPodzielnikaKosztow | Definicje podzielników kosztów | `DefPodzKosztow` | konfig | root |  |  |  | [DefinicjaPodzielnikaKosztow.md](DefinicjaPodzielnikaKosztow.md) |
| DefinicjaPoświadczeniaOdbioru | Definicje poświadczeń odbioru | `DefPoswOdbioru` | konfig | root |  |  |  | [DefinicjaPoświadczeniaOdbioru.md](DefinicjaPoświadczeniaOdbioru.md) |
| DefinicjaStawkiAkcyzy | Definicje stawek akcyzy | `DefStawekAkcyzy` | konfig | root |  |  |  | [DefinicjaStawkiAkcyzy.md](DefinicjaStawkiAkcyzy.md) |
| DefinicjaStawkiVat | Definicje stawek VAT | `DefStawekVat` | konfig | root |  |  |  | [DefinicjaStawkiVat.md](DefinicjaStawkiVat.md) |
| Discussion | Dyskusje | `Discussions` |  | root |  | IDiscussionItem, IDiscussionPlugInHost |  | [Discussion.md](Discussion.md) |
| DiscussionPlugIn | Rozszerzenia do dyskusji | `DiscPlugIns` | konfig | root |  |  |  | [DiscussionPlugIn.md](DiscussionPlugIn.md) |
| DiscussionPlugInRef | Powiązania rozszerzeń | `DiscPlugInRefs` |  | child: Definition→IDiscussionPlugInHost |  |  | DiscussionPlugInRefType (2) | [DiscussionPlugInRef.md](DiscussionPlugInRef.md) |
| DiscussionPlugInsSet | Zestawy rozszerzeń do dyskusji | `DiscPlugInsSets` | konfig | root |  | ICodeFileHost |  | [DiscussionPlugInsSet.md](DiscussionPlugInsSet.md) |
| DiscussionReaction |  | `DiscusReactions` |  |  |  |  |  | [DiscussionReaction.md](DiscussionReaction.md) |
| DiscussionReadStatus |  | `DisReadStatuses` |  |  |  |  |  | [DiscussionReadStatus.md](DiscussionReadStatus.md) |
| DiscussionRel | Relacje dyskusji | `DiscussionRels` |  | root |  |  |  | [DiscussionRel.md](DiscussionRel.md) |
| DiscussionTopic | Tematy dyskusji | `DiscussionTopics` |  | root |  | IDiscussionItem, ICommentDataHost |  | [DiscussionTopic.md](DiscussionTopic.md) |
| DiscussionUpdate | Aktualizacja dyskusji | `DiscussUpdates` |  | root |  | IDiscussionItem |  | [DiscussionUpdate.md](DiscussionUpdate.md) |
| DiscussionUser | Użytkownicy dyskusji | `DiscussionUsers` |  | root |  |  | PersonKind (3) | [DiscussionUser.md](DiscussionUser.md) |
| DocEwidencjaDbTupleDefExt | Rozszerzenia definicji tupli dla tabeli DokEwidencja | `DEDbTupleDefExts` | konfig | child: DbTupleDefinition→DbTupleDefinition |  |  |  | [DocEwidencjaDbTupleDefExt.md](DocEwidencjaDbTupleDefExt.md) |
| DocPkg | Paczki dokumentów | `DocPkgs` |  | root |  | IDokument |  | [DocPkg.md](DocPkg.md) |
| DocPkgCfg | Kategoria elementu paczki dokumentów | `DocPkgCfgs` | konfig | root |  |  |  | [DocPkgCfg.md](DocPkgCfg.md) |
| DocPkgDef | Definicje paczek dokumentów | `DocPkgDefs` | konfig | root |  |  |  | [DocPkgDef.md](DocPkgDef.md) |
| DocPkgItem | Pozycje paczki dokumentów | `DocPkgItems` |  | root |  |  |  | [DocPkgItem.md](DocPkgItem.md) |
| DocPkgItemProp |  | `DocPkgItemProps` |  | root |  |  |  | [DocPkgItemProp.md](DocPkgItemProp.md) |
| DokEwidencji | Dokument ewidencji | `DokEwidencja` |  | root |  | IDokumentPlatny, IDaneKontrahentaHost, IRaportEwidencjiSP, IDokumentCRM, IKomunikatEDIHost, IEmailElement, IProceduraVATHost, IDigitalizedDocument | TypDokumentu (29) | [DokEwidencji.md](DokEwidencji.md) |
| DokumentPowiazanyDokEwid | Dokumenty powiązane DokEwid | `DokumentyPowiazaneDokEwid` |  |  |  |  |  | [DokumentPowiazanyDokEwid.md](DokumentPowiazanyDokEwid.md) |
| DomyslnyCel | Domyślne cele rodzajów kontaktu | `DomyslneCele` | konfig | root |  |  |  | [DomyslnyCel.md](DomyslnyCel.md) |
| ElemSysWartosc | Wartości ElemSysZewn | `ElemSysWartosci` |  |  |  |  |  | [ElemSysWartosc.md](ElemSysWartosc.md) |
| ElemSysZewn | Elementy systemu zewnętrznego | `ElementySysZewn` |  |  |  |  |  | [ElemSysZewn.md](ElemSysZewn.md) |
| ElemSysZewnRelacje | Relacje elementu zewnętrznego | `ElemSysZewnRel` |  |  |  |  |  | [ElemSysZewnRelacje.md](ElemSysZewnRelacje.md) |
| ElemTeczki | Elementy teczek | `ElemTeczek` |  | child: Teczka→Teczka |  |  |  | [ElemTeczki.md](ElemTeczki.md) |
| ElementPodzielnika | Elementy podzielników | `ElemPodzielnikow` |  | child: Historia→HistoriaPodzielnika |  |  |  | [ElementPodzielnika.md](ElementPodzielnika.md) |
| ElementStrukturyOrganizacyjnej | Elementy struktur organizacyjnych | `ElementyStrOrg` |  | root |  | IPermissionClient, IElementStrukturyOrganizacyjnej |  | [ElementStrukturyOrganizacyjnej.md](ElementStrukturyOrganizacyjnej.md) |
| ElementStrukturyOrganizacyjnejRef | Zmiany elementów nadrzędnych | `ElementyStOrgRef` |  | child: Element→ElementStrukturyOrganizacyjnej |  |  |  | [ElementStrukturyOrganizacyjnejRef.md](ElementStrukturyOrganizacyjnejRef.md) |
| GIODOCelPrzetwarzania | Cele przetwarzania | `GIODOCelePrzetw` | konfig | root |  |  |  | [GIODOCelPrzetwarzania.md](GIODOCelPrzetwarzania.md) |
| GIODODefinicjaOświadczenia | Definicje oświadczeń | `GIODODefOswiadcz` | konfig | root |  | IRightsSource |  | [GIODODefinicjaOświadczenia.md](GIODODefinicjaOświadczenia.md) |
| GIODODefinicjaUprawnienia | Definicje uprawnień | `GIODODefUprawn` | konfig | root |  | IRightsSource |  | [GIODODefinicjaUprawnienia.md](GIODODefinicjaUprawnienia.md) |
| GIODOKategoriaDanychOsobowych | Kategorie danych osobowych | `GIODOKategDnOsob` | konfig | root |  |  |  | [GIODOKategoriaDanychOsobowych.md](GIODOKategoriaDanychOsobowych.md) |
| GIODOKategoriaOdbiorcow | Kategorie odbiorców | `GIODOKategOdb` | konfig | root |  |  |  | [GIODOKategoriaOdbiorcow.md](GIODOKategoriaOdbiorcow.md) |
| GIODOKategoriaOsob | Kategorie osób | `GIODOKategOsob` | konfig | root |  |  |  | [GIODOKategoriaOsob.md](GIODOKategoriaOsob.md) |
| GIODONaruszenie | Naruszenia ochrony danych osobowych | `GIODONaruszenia` |  |  |  | IDokument |  | [GIODONaruszenie.md](GIODONaruszenie.md) |
| GIODOOświadczenie | Oświadczenia | `GIODOOswiadcz` |  | root |  |  |  | [GIODOOświadczenie.md](GIODOOświadczenie.md) |
| GIODOPrzetwarzanie | Czynności przetwarzania | `GIODOPrzetwarz` |  | root |  |  | SelektorPrzetwarzania (2) | [GIODOPrzetwarzanie.md](GIODOPrzetwarzanie.md) |
| GIODOUprawnienie | Uprawnienia | `GIODOUprawnienia` |  | root |  |  |  | [GIODOUprawnienie.md](GIODOUprawnienie.md) |
| GIODOWycofanieOświadczenia |  | `GIODOWycofOsw` | konfig | child: Definicja→GIODODefinicjaOświadczenia |  |  |  | [GIODOWycofanieOświadczenia.md](GIODOWycofanieOświadczenia.md) |
| GIODOWymianaDanych |  | `GIODOWymDanych` |  | root |  |  | GIODOKierunekWymianyDanych (5) | [GIODOWymianaDanych.md](GIODOWymianaDanych.md) |
| GIODOZbiorDanych | Zbiory danych | `GIODOZbiory` |  | root |  |  |  | [GIODOZbiorDanych.md](GIODOZbiorDanych.md) |
| GIODOZbiorKategoria | GIODO przetwarzania - kategoria | `GIODOZbioryKateg` |  |  |  |  |  | [GIODOZbiorKategoria.md](GIODOZbiorKategoria.md) |
| GIODOZgodny |  | `GIODOZgodne` |  | child: Host→IGIODOZgodnyHost |  |  |  | [GIODOZgodny.md](GIODOZgodny.md) |
| HTTPLinkInfo |  | `HTTPLinkInfos` |  | root |  |  |  | [HTTPLinkInfo.md](HTTPLinkInfo.md) |
| HistoriaDanychFirmyBase | Historia danych firmy | `HstDanychFirmy` | konfig | root |  |  | RodzajHistoriiFirmy (2) | [HistoriaDanychFirmyBase.md](HistoriaDanychFirmyBase.md) |
| HistoriaDanychOddziału | Historia danych oddziałów firmy | `HstDanychOddzial` | konfig | root |  |  |  | [HistoriaDanychOddziału.md](HistoriaDanychOddziału.md) |
| HistoriaPodzielnika | Podzielniki kosztów | `HistPodzielnikow` |  | child: Podzielnik→PodzielnikKosztow | historia → PodzielnikKosztow |  |  | [HistoriaPodzielnika.md](HistoriaPodzielnika.md) |
| ImportExportXml | Importy, eksporty XML | `ImpExpXml` |  |  |  |  |  | [ImportExportXml.md](ImportExportXml.md) |
| IsoNumerProcedury | Numery procedur ISO | `IsoNumeryProc` | konfig | child: Procedura→IsoProcedura |  |  |  | [IsoNumerProcedury.md](IsoNumerProcedury.md) |
| IsoProcedura | Procedury ISO | `IsoProcedury` | konfig | root |  |  |  | [IsoProcedura.md](IsoProcedura.md) |
| JednolityPK | Jednolity PK | `JednolitePK` |  | root |  |  |  | [JednolityPK.md](JednolityPK.md) |
| JednolityPKRel | Jednolity PK relacja | `JednolitePKRels` |  |  |  |  |  | [JednolityPKRel.md](JednolityPKRel.md) |
| JobInvokeLog | Logi prac | `JobInvokeLogs` |  |  |  |  |  | [JobInvokeLog.md](JobInvokeLog.md) |
| JobInvokeLogDetail | Szczegółowe logi prac | `JobInvokeLogDets` |  |  |  |  |  | [JobInvokeLogDetail.md](JobInvokeLogDetail.md) |
| KDokDodatkowego | Kategorie dokumentów dodatkowych | `KDokDodatkowych` | konfig | root |  |  |  | [KDokDodatkowego.md](KDokDodatkowego.md) |
| KSeFAwaria | Awarie i przerwy w działaniu KSeF | `KSeFAwarie` |  | root |  |  |  | [KSeFAwaria.md](KSeFAwaria.md) |
| KSeFAwariaKomunikatLatarni | Komunikaty z latarnika KSeF | `KSeFAwarieKomLat` |  |  |  |  |  | [KSeFAwariaKomunikatLatarni.md](KSeFAwariaKomunikatLatarni.md) |
| KSeFIdentWewn | Identyfikatory wewnętrzne KSeF | `KSeFIdentyWewn` | konfig | root |  |  |  | [KSeFIdentWewn.md](KSeFIdentWewn.md) |
| KSeFIdentWewnRola | Role identyfikatorów wewnętrznych KSeF | `KSeFIdentWewnRole` | konfig |  |  |  |  | [KSeFIdentWewnRola.md](KSeFIdentWewnRola.md) |
| KSeFIdentWewnSprzedazMagazyn | Przypisane magazyny dla sprzedaży dla identyfikatora wewnętrznego KSeF | `KSeFIdentWewnSpMg` | konfig |  |  |  |  | [KSeFIdentWewnSprzedazMagazyn.md](KSeFIdentWewnSprzedazMagazyn.md) |
| KSeFIdentWewnSprzedazOddzial | Przypisane oddziały dla sprzedaży dla identyfikatora wewnętrznego KSeF | `KSeFIdentWewnSpOd` | konfig |  |  |  |  | [KSeFIdentWewnSprzedazOddzial.md](KSeFIdentWewnSprzedazOddzial.md) |
| KSeFIdentWewnSprzedazOperator | Przypisani operatorzy dla sprzedaży dla identyfikatora wewnętrznego KSeF | `KSeFIdentWewnSpOp` | konfig |  |  |  |  | [KSeFIdentWewnSprzedazOperator.md](KSeFIdentWewnSprzedazOperator.md) |
| KSeFKomunikat | Komunikaty KSeF | `KSeFKomunikaty` |  | root |  |  |  | [KSeFKomunikat.md](KSeFKomunikat.md) |
| KSeFPackage | Paczki dokumentów wysyłanych do KSeF | `KSeFPackages` |  | root |  |  |  | [KSeFPackage.md](KSeFPackage.md) |
| KSeFPackageElem | Elementy paczek wysyłanych do KSeF | `KSeFPackageElems` |  |  |  |  |  | [KSeFPackageElem.md](KSeFPackageElem.md) |
| KSeFPartList | KSeFZapytaniaOFaktury | `KSeFPartLists` |  |  |  |  |  | [KSeFPartList.md](KSeFPartList.md) |
| KSeFPlik | Pliki KSeF | `KSeFPliki` |  | root |  |  |  | [KSeFPlik.md](KSeFPlik.md) |
| KSeFPodmiot3 | Dane podmiotów trzecich komunikatu KSeF | `KSeFPodmioty3` |  |  |  | IDaneKontrahentaHost |  | [KSeFPodmiot3.md](KSeFPodmiot3.md) |
| KSeFSzablonPolOpcjonalnych | Szablony pól opcjonalnych KSeF | `KSeFSzblPolOp` | konfig | root |  |  |  | [KSeFSzablonPolOpcjonalnych.md](KSeFSzablonPolOpcjonalnych.md) |
| KSeFSzablonPolOpcjonalnychDefXmlNagStatus | Status aktywności szablonu dla definicji eksportu XML | `KSeFSzblPolOpDef` | konfig | root |  |  |  | [KSeFSzablonPolOpcjonalnychDefXmlNagStatus.md](KSeFSzablonPolOpcjonalnychDefXmlNagStatus.md) |
| KSeFSzablonPolOpcjonalnychPozycja | Pozycja szablonu pól opcjonalnych KSeF | `KSeFSzblPolOpPoz` | konfig | root |  |  |  | [KSeFSzablonPolOpcjonalnychPozycja.md](KSeFSzablonPolOpcjonalnychPozycja.md) |
| KSeFSzablonZalacznika | Szablon zalączników KSeF | `KSeFSzblZal` | konfig | root |  |  |  | [KSeFSzablonZalacznika.md](KSeFSzablonZalacznika.md) |
| KSeFSzablonZalacznikaDefXmlNagRelation | Status aktywności szablonu dla definicji eksportu XML | `KSeFSzblZalDefs` | konfig | root |  |  |  | [KSeFSzablonZalacznikaDefXmlNagRelation.md](KSeFSzablonZalacznikaDefXmlNagRelation.md) |
| KSeFSzablonZalacznikaElement | Element szablonu załącznika KSeF | `KSeFSzblZalElem` | konfig | root |  |  |  | [KSeFSzablonZalacznikaElement.md](KSeFSzablonZalacznikaElement.md) |
| KSeFTokenIdentWewnRel | Powiązanie tokenu systemu zewnętrznego z identyfikatorem wewnętrznym KSeF | `KSeFTokIdWewRels` |  |  |  |  |  | [KSeFTokenIdentWewnRel.md](KSeFTokenIdentWewnRel.md) |
| KSeFUPO | KSeF UPO | `KSeFUPOs` |  | root |  |  |  | [KSeFUPO.md](KSeFUPO.md) |
| KSeFZapytanieOFa | Zapytania o faktury KSeF | `KSeFZapytaniaOFa` |  | root |  |  |  | [KSeFZapytanieOFa.md](KSeFZapytanieOFa.md) |
| KodKreskowy | Kody keskowe | `KodyKreskowe` |  | child: Zapis→IKodowany |  |  |  | [KodKreskowy.md](KodKreskowy.md) |
| KodPocztowy | Tabela z kodami pocztowymi oraz odpowiadającymi im miejscowościami | `KodyPocztowe` |  |  |  |  |  | [KodPocztowy.md](KodPocztowy.md) |
| KodPocztowyAU | Tabela z kodami pocztowymi oraz odpowiadającymi im województwami | `KodyPocztoweAU` |  |  |  |  |  | [KodPocztowyAU.md](KodPocztowyAU.md) |
| KomunikatAPI | KomunikatyAPI | `KomunikatyAPI` |  |  |  |  |  | [KomunikatAPI.md](KomunikatAPI.md) |
| Konwersacja |  | `Konwersacje` |  | root |  |  |  | [Konwersacja.md](Konwersacja.md) |
| KrajSME | Kraje SME | `KrajeSME` | konfig | root | historyczna → ProceduraSME |  |  | [KrajSME.md](KrajSME.md) |
| KrajTbl | Kraje | `KrajeTbl` | konfig | root |  |  |  | [KrajTbl.md](KrajTbl.md) |
| Licznik |  | `Liczniki` |  |  |  |  |  | [Licznik.md](Licznik.md) |
| ManagedRowCreator | Kreatory wierszy | `ManagedRowCrts` | konfig | child: Definicja→IManagedRowDefinion |  |  |  | [ManagedRowCreator.md](ManagedRowCreator.md) |
| ManagedRowInfo | Informacja o przetwarzaniu przez proces | `ManagedRowsInfo` |  | child: ManagedRow→IManagedRowInfoHost |  |  |  | [ManagedRowInfo.md](ManagedRowInfo.md) |
| ManagedRowMetrics | Metryki dokumentów | `ManRowsMetrics` |  | child: ManagedRowInfo→ManagedRowInfo |  |  |  | [ManagedRowMetrics.md](ManagedRowMetrics.md) |
| ManagedRowMetricsDefinition | Definicje zapisów w metryce dokumentu | `ManRowMetricDefs` | konfig | root |  |  |  | [ManagedRowMetricsDefinition.md](ManagedRowMetricsDefinition.md) |
| MetrykaOddziałuFirmy | Przyczyny zmiany danych oddziałów firmy | `MetrykiOddzFirmy` | konfig | child: Oddzial→OddzialFirmy |  |  |  | [MetrykaOddziałuFirmy.md](MetrykaOddziałuFirmy.md) |
| Notice | Komunikaty | `Notices` |  | root |  |  |  | [Notice.md](Notice.md) |
| NoticeChannel | Kanały komunikatów | `NoticeChannels` |  | root |  | IRightsSource |  | [NoticeChannel.md](NoticeChannel.md) |
| NoticePermission | Zgody na odbiór powiadomienia | `NoticePerms` |  |  |  |  |  | [NoticePermission.md](NoticePermission.md) |
| NoticeReceipt | Potwierdzenia odbioru | `NoticeReceipts` |  | root |  |  |  | [NoticeReceipt.md](NoticeReceipt.md) |
| ObfuscateDef | Definicje zakresów zaciemniania | `ObfuscateDefs` | konfig | root |  | IRightsSource |  | [ObfuscateDef.md](ObfuscateDef.md) |
| ObfuscateField | Elementy zakresów zaciemniania | `ObfuscateFields` | konfig | child: ObfuscateDef→ObfuscateDef |  |  |  | [ObfuscateField.md](ObfuscateField.md) |
| ObfuscatedData | Zaciemnione dane | `ObfuscatedDatas` |  | root |  |  |  | [ObfuscatedData.md](ObfuscatedData.md) |
| OddzialFirmy | Oddziały firmy | `OddzialyFirmy` | konfig | root |  | IElementSlownika, IRightsSource, IAdresHost, IOddzialFirmy, IElementStrukturyFirmy, IDaneKontaktoweHost, IAdresyWWWHost |  | [OddzialFirmy.md](OddzialFirmy.md) |
| OddzialFirmyRef | Zmiany oddziałów nadrzędnych | `OddzialyFirmyRef` | konfig | child: Oddzial→OddzialFirmy |  | IMetrykaOddziałuFirmyHost |  | [OddzialFirmyRef.md](OddzialFirmyRef.md) |
| OpisPIM | Opisy PIM | `OpisyPIM` |  |  |  |  |  | [OpisPIM.md](OpisPIM.md) |
| ParametrRozlicz | Parametry rozliczeń | `ParametryRozlicz` | konfig |  |  |  |  | [ParametrRozlicz.md](ParametrRozlicz.md) |
| PodzielnikKosztow | Podzielniki kosztów | `PodzielKosztow` |  | child: Zrodlo→IZrodloPodzielnikaKosztow | historyczna → HistoriaPodzielnika |  |  | [PodzielnikKosztow.md](PodzielnikKosztow.md) |
| PowiązanieStrukturyOrganizacyjnej | Powiązania elementyów struktur organizacyjnych | `PowiazaniaStrOrg` |  | child: Zrodlo→IŹródłoPowiązaniaStrukturyOrganizacyjnej |  |  |  | [PowiązanieStrukturyOrganizacyjnej.md](PowiązanieStrukturyOrganizacyjnej.md) |
| PozycjaEwidencjiZbiorczej | Pozycje ewidencji zbiorczych | `PozEwidZbiorczej` |  | child: Ewidencja→DokEwidencji |  |  | TypDokumentu (1) | [PozycjaEwidencjiZbiorczej.md](PozycjaEwidencjiZbiorczej.md) |
| PoświadczenieOdbioru | Poświadczenia odbioru | `PoswiadczOdbioru` |  | child: Dokument→IPoświadczenieOdbioruHost |  |  |  | [PoświadczenieOdbioru.md](PoświadczenieOdbioru.md) |
| ProceduraSME | Procedury SME | `ProcedurySME` | konfig | child: Kraj→KrajSME | historia → KrajSME |  |  | [ProceduraSME.md](ProceduraSME.md) |
| ProceduraVAT | Słownik procedur VAT | `ProceduryVAT` | konfig | root |  |  | TypProceduryVAT (5) | [ProceduraVAT.md](ProceduraVAT.md) |
| RecordSequence | Kolejność rekordów | `RecordSequences` |  |  |  |  |  | [RecordSequence.md](RecordSequence.md) |
| RelProceduraVAT | Powiązania procedur VAT z dokumentami | `RelProceduryVAT` |  | root |  |  |  | [RelProceduraVAT.md](RelProceduraVAT.md) |
| RelacjaDanychZewn | Relacje danych z systemów zewnętrznych | `RelacjeDanychZ` |  |  |  |  |  | [RelacjaDanychZewn.md](RelacjaDanychZewn.md) |
| RelacjaOpisPIM |  | `RelacjeOpisowPIM` |  |  |  |  |  | [RelacjaOpisPIM.md](RelacjaOpisPIM.md) |
| RelacjaZewn | Powiązania obiektów programu z obiektami z systemów zewnętrznych | `RelacjeZewn` |  |  |  |  |  | [RelacjaZewn.md](RelacjaZewn.md) |
| RodzajDokumentuKseF | Słownik rodzajów dokumentów | `RodzajeDokKseF` |  | root |  | IRightsSource |  | [RodzajDokumentuKseF.md](RodzajDokumentuKseF.md) |
| RodzajKomunikatuHost | Rodzaje komunikatów | `RodzajeKomHost` |  |  |  |  |  | [RodzajKomunikatuHost.md](RodzajKomunikatuHost.md) |
| RodzajKontaktu | Rodzaj kontaktu | `RodzajeKontaktow` | konfig | root |  |  |  | [RodzajKontaktu.md](RodzajKontaktu.md) |
| RodzajPodmiot | Podmioty rodzaju dokumentu KSeF | `RodzajePodmioty` |  | root |  |  |  | [RodzajPodmiot.md](RodzajPodmiot.md) |
| RodzajZrodla | Rodzaje źródeł finansowania | `RodzajeZrodel` | konfig | root |  | IElementSlownika |  | [RodzajZrodla.md](RodzajZrodla.md) |
| ScheduleDefinition | Definicje harmonogramów | `ScheduleDefs` | konfig | root |  |  |  | [ScheduleDefinition.md](ScheduleDefinition.md) |
| ScheduleItem | Elementy harmonogramów | `ScheduleItems` |  |  |  |  |  | [ScheduleItem.md](ScheduleItem.md) |
| SkanerKodow | Skaner kodów | `SkaneryKodow` |  | root |  |  |  | [SkanerKodow.md](SkanerKodow.md) |
| SlownikElem | Słownik | `Slowniki` | konfig | root |  |  | SelektorSlownika (1) | [SlownikElem.md](SlownikElem.md) |
| SlownikPIM |  | `SlownikiPIM` |  |  |  |  |  | [SlownikPIM.md](SlownikPIM.md) |
| SlownikZewn | Słownik zewnętrzny | `SlownikiZewn` | konfig | root |  |  |  | [SlownikZewn.md](SlownikZewn.md) |
| SlownikZewnRel | SlownikiZewnRel | `SlownikiZewnRel` |  |  |  |  |  | [SlownikZewnRel.md](SlownikZewnRel.md) |
| StanTeczki | Stany teczek | `StanyTeczek` | konfig | child: Definicja→DefTeczki |  |  |  | [StanTeczki.md](StanTeczki.md) |
| StrukturaOrganizacyjna | Struktury organizacyjne | `StrukturyOrg` | konfig | root |  | IRightsSource, IStrukturaOrganizacyjna |  | [StrukturaOrganizacyjna.md](StrukturaOrganizacyjna.md) |
| Subscription | Subskrypcje | `Subscriptions` |  |  |  |  |  | [Subscription.md](Subscription.md) |
| SubstituteDef | Definicje zastępstw | `SubstituteDefs` | konfig | root |  | IRightsSource |  | [SubstituteDef.md](SubstituteDef.md) |
| SubstituteUser | Zastępstwa | `SubstituteUsers` |  | root |  |  |  | [SubstituteUser.md](SubstituteUser.md) |
| SysZewToken | Autoryzacje systemów zewnętrznych | `SysZewTokeny` | konfig | root |  | IRightsSource |  | [SysZewToken.md](SysZewToken.md) |
| SysZewnImpDef | Elementy definicji pobierania danych | `SysZewnImpDefs` |  |  |  |  |  | [SysZewnImpDef.md](SysZewnImpDef.md) |
| SysZewnStatus |  | `SysZewnStatusy` |  |  |  |  |  | [SysZewnStatus.md](SysZewnStatus.md) |
| SysZewnUsDodatkowa | Lista usług dodatkowych | `SysZewnUsDod` |  |  |  |  |  | [SysZewnUsDodatkowa.md](SysZewnUsDodatkowa.md) |
| SystemZewn | Lista systemów zewnętrznych | `SystemyZewn` | konfig | root |  |  | TypSystemuZewn (11) | [SystemZewn.md](SystemZewn.md) |
| SystemZewnDefXmlNag | Powiązanie systemu zewnętrznego z defnicją XML | `SysZewnDefXmls` | konfig |  |  |  |  | [SystemZewnDefXmlNag.md](SystemZewnDefXmlNag.md) |
| SzablonPIM | Szablony PIM | `SzablonyPIM` | konfig | root |  |  |  | [SzablonPIM.md](SzablonPIM.md) |
| SzablonSlownikaPIM | Szablony słowników PIM | `SzablonySlowPIM` | konfig |  |  |  |  | [SzablonSlownikaPIM.md](SzablonSlownikaPIM.md) |
| Teczka | Teczki | `Teczki` |  | root |  | IPermissionClient |  | [Teczka.md](Teczka.md) |
| TerminalPlatStanowisko | Lista terminali płatniczych przypisanych do stanowiska | `TerminalPlatStan` | konfig |  |  |  |  | [TerminalPlatStanowisko.md](TerminalPlatStanowisko.md) |
| TerminalPlatniczy | Lista terminali płatniczych | `TerminalePlat` | konfig | root |  |  |  | [TerminalPlatniczy.md](TerminalPlatniczy.md) |
| ThreadCategory | Kategoria komunikacji | `ThreadCategories` | konfig |  |  |  |  | [ThreadCategory.md](ThreadCategory.md) |
| TimeTrack | Rejestracja pracy hybrydowej | `TimeTracks` |  | root |  |  |  | [TimeTrack.md](TimeTrack.md) |
| ToDoItem | Elementy do wykonania | `ToDoItems` |  |  |  |  |  | [ToDoItem.md](ToDoItem.md) |
| UIExtension | Definicje XML nagłówków lub stopek dokumentów | `UIExtensions` |  | root |  |  |  | [UIExtension.md](UIExtension.md) |
| WarningDef | Definicje warningów | `WarningDefs` | konfig | root |  |  |  | [WarningDef.md](WarningDef.md) |
| WarningDefRel | Relacje definicji warningów | `WarningDefRels` | konfig | root |  |  |  | [WarningDefRel.md](WarningDefRel.md) |
| ZadanieZewnSynch | Zadania do synchronizacji | `ZadaniaZewnSynch` |  |  |  |  |  | [ZadanieZewnSynch.md](ZadanieZewnSynch.md) |
| ZestawPodzielnikowKosztow | Zestawy podzielników kosztów | `ZestPodzKosztow` | konfig | root |  | IZrodloPodzielnikaKosztow |  | [ZestawPodzielnikowKosztow.md](ZestawPodzielnikowKosztow.md) |
| ZrodloFinansowania | Źródła finansowania | `ZrodlaFinansow` | konfig | root |  | IElementSlownika |  | [ZrodloFinansowania.md](ZrodloFinansowania.md) |

