# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.DBItem`
Nazwa tabeli: `DBItems`
Tytuł: Bazy danych
Opis: Baza danych klienta w kontekście biura rachunkowego (PKBR). Przechowuje dane firmy, rodzaj działalności, ustawienia publikacji danych podatkowych i konfigurację pulpitu.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 54

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ActivityType | `Soneta.Business.Db.ActivityType` | bazodanowe, enum | Rodzaj działalności | Rozdzaj prowadzonej działalności księgowej klienta |
| CalculatedProperties | `Soneta.Business.Db.DBItem.Extender` |  | Właściwości wyliczane |  |
| Client | `Soneta.Business.Db.IDBItemClient` | bazodanowe, iface-ref | Klient | Klient powiązany z bazą danych |
| CzyDeklaracjaDRAFEP | `bool` |  |  |  |
| CzyDeklaracjaDRAFundusze | `bool` |  |  |  |
| CzyDeklaracjaDRARazemDoZapłaty | `bool` |  |  |  |
| CzyDeklaracjaDRASpołeczne | `bool` |  |  |  |
| CzyDeklaracjaDRAZdrowotne | `bool` |  |  |  |
| CzyDeklaracjaPIT4RKwota | `bool` |  |  |  |
| CzyDeklaracjaPIT8ARKwota | `bool` |  |  |  |
| CzyDeklaracjaVATKwota | `bool` |  |  |  |
| CzyDeklaracjeDRAWlascicieli | `bool` |  |  |  |
| CzyDeklaracjePIT5Wlascicieli | `bool` |  |  |  |
| CzyDeklaracjePITRyczaltWlascicieli | `bool` |  |  |  |
| CzyJestDeklaracjaDRARazemDoZapłatyRozliczeniePodatkowe | `bool` |  |  |  |
| CzyJestDeklaracjaPIT4RozliczeniePodatkowe | `bool` |  |  |  |
| CzyJestDeklaracjaPIT8ARRozliczeniePodatkowe | `bool` |  |  |  |
| CzyJestDeklaracjaVATRozliczeniePodatkowe | `bool` |  |  |  |
| CzyJestZaliczkaCITRozliczeniePodatkowe | `bool` |  |  |  |
| CzyPrognozaPrzeplywow | `bool` |  |  |  |
| CzyStrukturaWiekowaNaleznosci | `bool` |  |  |  |
| CzyStrukturaWiekowaZobowiazan | `bool` |  |  |  |
| CzyZaliczkaCITKwota | `bool` |  |  |  |
| DBGroupItems | `Soneta.Business.SubTable<Soneta.Business.Db.DBGroupItem>` |  |  |  |
| DanePobrane | `bool` |  |  |  |
| DeklaracjaDRAFEPRozliczeniePodatkowe | `Soneta.Types.Currency` |  |  |  |
| DeklaracjaDRAFunduszeRozliczeniePodatkowe | `Soneta.Types.Currency` |  |  |  |
| DeklaracjaDRARazemDoZapłatyRozliczeniePodatkowe | `Soneta.Types.Currency` |  |  |  |
| DeklaracjaDRASpołeczneRozliczeniePodatkowe | `Soneta.Types.Currency` |  |  |  |
| DeklaracjaDRATerminPlatnosciRozliczeniePodatkowe | `Soneta.Types.Date` |  |  |  |
| DeklaracjaDRAZdrowotneRozliczeniePodatkowe | `Soneta.Types.Currency` |  |  |  |
| DeklaracjaPIT4RTerminPlatnosciRozliczeniePodatkowe | `Soneta.Types.Date` |  |  |  |
| DeklaracjaPIT4RozliczeniePodatkowe | `Soneta.Types.Currency` |  |  |  |
| DeklaracjaPIT8ARRozliczeniePodatkowe | `Soneta.Types.Currency` |  |  |  |
| DeklaracjaPIT8ARTerminPlatnosciRozliczeniePodatkowe | `Soneta.Types.Date` |  |  |  |
| DeklaracjaVATKwotaDoPrzeniesieniaRozliczniePodatkowe | `Soneta.Types.Currency` |  |  |  |
| DeklaracjaVATKwotaZwrotuRozliczniePodatkowe | `Soneta.Types.Currency` |  |  |  |
| DeklaracjaVATRozliczeniePodatkowe | `Soneta.Types.Currency` |  |  |  |
| DeklaracjaVATTerminPlatnosciRozliczeniePodatkowe | `Soneta.Types.Date` |  |  |  |
| DeklaracjaVATTerminZwrotuRozliczniePodatkowe | `Soneta.Types.Date` |  |  |  |
| FirmName | `string` | bazodanowe | Nazwa firmy | Nazwa firmy |
| GenerowaniePrzelewowPKBR | `bool` | bazodanowe | Generowanie przelewów dostępne w pulpicie BR | Generowanie przelewów dostępne w pulpicie BR |
| IndywidualnyRachunekZUSRozliczeniePodatkowe | `string` |  |  |  |
| Information | `string` | bazodanowe | Informacje dla klienta | Dodatkowe informacje dla klienta biura rachunkowego |
| IsSelfDBItem | `bool` |  |  |  |
| LokalizacjaBiura | `object` |  |  |  |
| LokalizacjaBiuraGuid | `System.Guid` | bazodanowe | Lokalizacja biura rachunkowego | Lokalizacja biura rachunkowego |
| MikrorachunekPodatkowyRozliczeniePodatkowe | `string` |  |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa bazy danych |
| Operators | `System.Collections.IList` |  |  |  |
| PolaPodsumowaniaPKBR | `Soneta.Business.MemoText` | bazodanowe | Pola podsumowania PKBR | Układ pól na podsumowania pulpitu klienta biura rachunkowego |
| ShowDeklaracjaVatKwotaDoPrzeniesienia | `bool` |  |  |  |
| ShowDeklaracjaVatKwotaPlatnosci | `bool` |  |  |  |
| ShowDeklaracjaVatKwotaZwrotu | `bool` |  |  |  |
| SposobPrzekazywaniaDokumentow | `Soneta.Business.Db.MethodOfDocumentsDelivering` | bazodanowe, enum | Sposób przekazywania dokumentów | Sposób przekazywania dokumentów |
| StateStr | `string` |  | Status bazy danych |  |
| TrybPublikacjiDanychPodatkowych | `Soneta.Business.Db.TaxDataPublicationMode` | bazodanowe, enum | Tryb publikacji danych podatkowych | Tryb publikacji danych podatkowych |
| WidocznoscDanychPodatkowychWPulpicie | `Soneta.Business.Db.TaxDataDashboardVisibilityFor` | bazodanowe, enum | Widoczność danych podatkowych w pulpicie | Widoczność danych podatkowych w pulpicie |
| WlascicielePIT | `System.Collections.Generic.IList<Soneta.Business.Db.RozlDBWlascPIT.PIT5Info>` |  |  |  |
| WlascicieleRyczalt | `System.Collections.Generic.IList<Soneta.Business.Db.RozlDBWlascRycz.PITRyczaltInfo>` |  |  |  |
| WlascicieleZUS | `System.Collections.Generic.IList<Soneta.Business.Db.RozlDBWlascZUS.DRAInfo>` |  |  |  |
| WyswietlSzczegoly | `bool` |  |  |  |
| WyswietlSzczegolyWlasciciel | `System.Collections.Generic.Dictionary<int, bool>` |  |  |  |
| ZaliczkaCITRozliczeniePodatkowe | `Soneta.Types.Currency` |  |  |  |
| ZaliczkaCITTerminPlatnosciRozliczeniePodatkowe | `Soneta.Types.Date` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Client | `IDBItemClient` | `Kontrahent` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ActivityType (`Soneta.Business.Db.ActivityType`)
- `KS` = 0 — Księga handlowa
- `KPiR` = 1 — Księga podatkowa
- `Ryczalt` = 2 — Ewidencja ryczałtowa

### MethodOfDocumentsDelivering (`Soneta.Business.Db.MethodOfDocumentsDelivering`)
- `Standard` = 0 — Standardowo
- `Packages` = 1 — W paczkach

### TaxDataDashboardVisibilityFor (`Soneta.Business.Db.TaxDataDashboardVisibilityFor`)
- `Wszystkich` = 0
- `ZalogowanegoWlasciciela` = 1 — Zalogowanego właściciela

### TaxDataPublicationMode (`Soneta.Business.Db.TaxDataPublicationMode`)
- `Nie` = 0
- `Tak` = 1
- `NaZadanie` = 2 — Na żądanie
