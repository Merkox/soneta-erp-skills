# Pola i właściwości klasy biznesowej: `Soneta.Core.ElementStrukturyOrganizacyjnej`
Nazwa tabeli: `ElementyStrOrg`
Tytuł: Elementy struktur organizacyjnych
Opis: Konkretny element (węzeł) struktury organizacyjnej, np. dział, zespół, stanowisko. Posiada kod, nazwę, definicję typu, element nadrzędny tworzący hierarchię, okres obowiązywania oraz kontrolę praw dostępu.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IPermissionClient`, `IElementStrukturyOrganizacyjnej`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Config | `Soneta.Core.ElementStrukturyOrganizacyjnej.ElementConfig` | tylko-odczyt |  |  |
| ConfigXml | `MemoText` | bazodanowe, podlista |  |  |
| DataDo | `Date` |  |  |  |
| DataOd | `Date` |  |  |  |
| Definicja | `Soneta.Core.DefinicjaElementuStrukturyOrganizacyjnej` | bazodanowe |  |  |
| EfektywnyOkres | `FromTo` | podlista |  |  |
| Elementy | `SubTable` | podlista |  |  |
| HistoriaPodleglosci | `HistorySubTable<Soneta.Core.ElementStrukturyOrganizacyjnejRef>` | podlista |  |  |
| IsReadOnlyDataDo | `bool` | tylko-odczyt |  |  |
| IsReadOnlyDataOd | `bool` | tylko-odczyt |  |  |
| IsVisibleEfektywnyOkres | `bool` | tylko-odczyt |  |  |
| IsVisibleOkresEx | `bool` | tylko-odczyt |  |  |
| Kod | `string` | bazodanowe |  |  |
| KontrolaPraw | `IRightsSource` | bazodanowe, iface-ref |  |  |
| Nadrzedny | `Soneta.Core.ElementStrukturyOrganizacyjnej` | bazodanowe, tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaPomocnicza | `string` | bazodanowe |  |  |
| ObiektyDoPlanowania | `SubTable` | podlista |  |  |
| ObjectRight | `AccessRights` (enum) | tylko-odczyt |  |  |
| Okres | `FromTo` | bazodanowe, podlista | Okres | Okres obowiązywania elementu struktury organizacyjnej |
| OkresEx | `FromTo` | podlista | Okres |  |
| Permissions | `SubTable<Db.Permissions.RecordPermission>` | podlista |  |  |
| PodelementyWgAktualnosci | `SubTable<Soneta.Core.ElementStrukturyOrganizacyjnejRef>` | podlista |  |  |
| Powiązania | `SubTable<Soneta.Core.PowiązanieStrukturyOrganizacyjnej>` | podlista |  |  |
| Struktura | `Soneta.Core.StrukturaOrganizacyjna` | bazodanowe, tylko-odczyt |  |  |
| SubDrzewo | `System.Collections.Generic.IEnumerable<Soneta.Core.ElementStrukturyOrganizacyjnej>` | podlista |  |  |
| WszystkieElementy | `SubTable` | podlista |  |  |
| WszystkieLiście | `System.Collections.Generic.IEnumerable<Soneta.Core.ElementStrukturyOrganizacyjnej>` | podlista |  |  |
| WszystkieSubElementy | `System.Collections.Generic.IEnumerable<Soneta.Core.ElementStrukturyOrganizacyjnej>` | podlista |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| KontrolaPraw | `IRightsSource` | `BasicDocumentDefinition`, `DBItem`, `DashboardView`, `DataModel`, `DbTupleDefinition`, `DefDiscussion`, `DefDokHandlowego`, `DefKampania`, `DefKategKth`, `DefKoresp`, `DefLeada`, `DefPlanuSprzedazy`, `DefProjektu`, `DefSkladki`, `DefTeczki`, `DefTransakcja`, `DefZadania`, `DefZgloszenia`, `DefinicjaAktualizacjiKalendarza`, `DefinicjaCeny`, `DefinicjaDokumentu`, `DefinicjaFunduszuPozyczkowego`, `DefinicjaListyPlac`, `DefinicjaPlanowanejListyPłac`, `DefinicjaRozliczeniaMediow`, `DefinicjaSlownika`, `DefinicjaSprawyWindykacyjnej`, `DefinicjaZestawieniaCzasu`, `EwidencjaSP`, `ExternalDatabase`, `GIODODefinicjaOświadczenia`, `GIODODefinicjaUprawnienia`, `KategoriaST`, `KategoriaZapotrzebowania`, `KontoPocztowe`, `Magazyn`, `MatterDefinition`, `MiejsceUzytkowania`, `NoticeChannel`, `ObfuscateDef`, `OddzialFirmy`, `PivotView`, `ProWydzial`, `Region`, `ReservationDef`, `RodzajDokumentuKseF`, `StrukturaOrganizacyjna`, `SubstituteDef`, `SysZewToken`, `TicketDefinition`, `TypNieruchomosc`, `TypUrzadzenia`, `WFDefinition`, `Wydzial` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AccessRights (`AccessRights`)
- `Denied` = 0 — Zakaz dostępu
- `ReadOnly` = 1 — Tylko odczyt
- `Granted` = 2 — Pełne prawo
- `NoInit` = 3 — Niezainicjowane
