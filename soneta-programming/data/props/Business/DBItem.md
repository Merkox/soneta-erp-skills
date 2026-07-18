# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.DBItem`
Nazwa tabeli: `DBItems`
Tytuł: Bazy danych
Opis: Baza danych klienta w kontekście biura rachunkowego (PKBR). Przechowuje dane firmy, rodzaj działalności, ustawienia publikacji danych podatkowych i konfigurację pulpitu.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ActivityType | `Db.ActivityType` (enum) | bazodanowe | Rodzaj działalności | Rozdzaj prowadzonej działalności księgowej klienta |
| CalculatedProperties | `Db.DBItem.Extender` | tylko-odczyt | Właściwości wyliczane |  |
| Client | `Db.IDBItemClient` | bazodanowe, iface-ref | Klient | Klient powiązany z bazą danych |
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
| CzyJestDeklaracjaDRARazemDoZapłatyRozliczeniePodatkowe | `bool` | tylko-odczyt |  |  |
| CzyJestDeklaracjaPIT4RozliczeniePodatkowe | `bool` | tylko-odczyt |  |  |
| CzyJestDeklaracjaPIT8ARRozliczeniePodatkowe | `bool` | tylko-odczyt |  |  |
| CzyJestDeklaracjaVATRozliczeniePodatkowe | `bool` | tylko-odczyt |  |  |
| CzyJestZaliczkaCITRozliczeniePodatkowe | `bool` | tylko-odczyt |  |  |
| CzyPrognozaPrzeplywow | `bool` |  |  |  |
| CzyStrukturaWiekowaNaleznosci | `bool` |  |  |  |
| CzyStrukturaWiekowaZobowiazan | `bool` |  |  |  |
| CzyZaliczkaCITKwota | `bool` |  |  |  |
| DBGroupItems | `SubTable<Db.DBGroupItem>` | podlista |  |  |
| DanePobrane | `bool` |  |  |  |
| DeklaracjaDRAFEPRozliczeniePodatkowe | `Currency` | tylko-odczyt |  |  |
| DeklaracjaDRAFunduszeRozliczeniePodatkowe | `Currency` | tylko-odczyt |  |  |
| DeklaracjaDRARazemDoZapłatyRozliczeniePodatkowe | `Currency` | tylko-odczyt |  |  |
| DeklaracjaDRASpołeczneRozliczeniePodatkowe | `Currency` | tylko-odczyt |  |  |
| DeklaracjaDRATerminPlatnosciRozliczeniePodatkowe | `Date` | tylko-odczyt |  |  |
| DeklaracjaDRAZdrowotneRozliczeniePodatkowe | `Currency` | tylko-odczyt |  |  |
| DeklaracjaPIT4RTerminPlatnosciRozliczeniePodatkowe | `Date` | tylko-odczyt |  |  |
| DeklaracjaPIT4RozliczeniePodatkowe | `Currency` | tylko-odczyt |  |  |
| DeklaracjaPIT8ARRozliczeniePodatkowe | `Currency` | tylko-odczyt |  |  |
| DeklaracjaPIT8ARTerminPlatnosciRozliczeniePodatkowe | `Date` | tylko-odczyt |  |  |
| DeklaracjaVATKwotaDoPrzeniesieniaRozliczniePodatkowe | `Currency` | tylko-odczyt |  |  |
| DeklaracjaVATKwotaZwrotuRozliczniePodatkowe | `Currency` | tylko-odczyt |  |  |
| DeklaracjaVATRozliczeniePodatkowe | `Currency` | tylko-odczyt |  |  |
| DeklaracjaVATTerminPlatnosciRozliczeniePodatkowe | `Date` | tylko-odczyt |  |  |
| DeklaracjaVATTerminZwrotuRozliczniePodatkowe | `Date` | tylko-odczyt |  |  |
| FirmName | `string` | bazodanowe | Nazwa firmy | Nazwa firmy |
| GenerowaniePrzelewowPKBR | `bool` | bazodanowe | Generowanie przelewów dostępne w pulpicie BR | Generowanie przelewów dostępne w pulpicie BR |
| IndywidualnyRachunekZUSRozliczeniePodatkowe | `string` | tylko-odczyt |  |  |
| Information | `string` | bazodanowe | Informacje dla klienta | Dodatkowe informacje dla klienta biura rachunkowego |
| IsSelfDBItem | `bool` | tylko-odczyt |  |  |
| LokalizacjaBiura | `object` |  |  |  |
| LokalizacjaBiuraGuid | `System.Guid` | bazodanowe | Lokalizacja biura rachunkowego | Lokalizacja biura rachunkowego |
| MikrorachunekPodatkowyRozliczeniePodatkowe | `string` | tylko-odczyt |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa bazy danych |
| Operators | `System.Collections.IList` | podlista |  |  |
| PolaPodsumowaniaPKBR | `MemoText` | bazodanowe, podlista | Pola podsumowania PKBR | Układ pól na podsumowania pulpitu klienta biura rachunkowego |
| ShowDeklaracjaVatKwotaDoPrzeniesienia | `bool` | tylko-odczyt |  |  |
| ShowDeklaracjaVatKwotaPlatnosci | `bool` | tylko-odczyt |  |  |
| ShowDeklaracjaVatKwotaZwrotu | `bool` | tylko-odczyt |  |  |
| SposobPrzekazywaniaDokumentow | `Db.MethodOfDocumentsDelivering` (enum) | bazodanowe | Sposób przekazywania dokumentów | Sposób przekazywania dokumentów |
| StateStr | `string` | tylko-odczyt | Status bazy danych |  |
| TrybPublikacjiDanychPodatkowych | `Db.TaxDataPublicationMode` (enum) | bazodanowe | Tryb publikacji danych podatkowych | Tryb publikacji danych podatkowych |
| WidocznoscDanychPodatkowychWPulpicie | `Db.TaxDataDashboardVisibilityFor` (enum) | bazodanowe | Widoczność danych podatkowych w pulpicie | Widoczność danych podatkowych w pulpicie |
| WlascicielePIT | `System.Collections.Generic.IList<Db.RozlDBWlascPIT.PIT5Info>` | podlista |  |  |
| WlascicieleRyczalt | `System.Collections.Generic.IList<Db.RozlDBWlascRycz.PITRyczaltInfo>` | podlista |  |  |
| WlascicieleZUS | `System.Collections.Generic.IList<Db.RozlDBWlascZUS.DRAInfo>` | podlista |  |  |
| WyswietlSzczegoly | `bool` |  |  |  |
| WyswietlSzczegolyWlasciciel | `System.Collections.Generic.Dictionary<int, bool>` | podlista |  |  |
| ZaliczkaCITRozliczeniePodatkowe | `Currency` | tylko-odczyt |  |  |
| ZaliczkaCITTerminPlatnosciRozliczeniePodatkowe | `Date` | tylko-odczyt |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Client | `IDBItemClient` | `Kontrahent` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ActivityType (`Db.ActivityType`)
- `KS` = 0 — Księga handlowa
- `KPiR` = 1 — Księga podatkowa
- `Ryczalt` = 2 — Ewidencja ryczałtowa

### MethodOfDocumentsDelivering (`Db.MethodOfDocumentsDelivering`)
- `Standard` = 0 — Standardowo
- `Packages` = 1 — W paczkach

### TaxDataDashboardVisibilityFor (`Db.TaxDataDashboardVisibilityFor`)
- `Wszystkich` = 0
- `ZalogowanegoWlasciciela` = 1 — Zalogowanego właściciela

### TaxDataPublicationMode (`Db.TaxDataPublicationMode`)
- `Nie` = 0
- `Tak` = 1
- `NaZadanie` = 2 — Na żądanie
