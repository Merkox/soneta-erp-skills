# Pola i właściwości klasy biznesowej: `Soneta.Core.ElementStrukturyOrganizacyjnej`
Nazwa tabeli: `ElementyStrOrg`
Tytuł: Elementy struktur organizacyjnych
Opis: Konkretny element (węzeł) struktury organizacyjnej, np. dział, zespół, stanowisko. Posiada kod, nazwę, definicję typu, element nadrzędny tworzący hierarchię, okres obowiązywania oraz kontrolę praw dostępu.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IPermissionClient`, `IElementStrukturyOrganizacyjnej`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 20

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Config | `Soneta.Core.ElementStrukturyOrganizacyjnej.ElementConfig` |  |  |  |
| ConfigXml | `Soneta.Business.MemoText` | bazodanowe |  |  |
| DataDo | `Soneta.Types.Date` |  |  |  |
| DataOd | `Soneta.Types.Date` |  |  |  |
| Definicja | `Soneta.Core.DefinicjaElementuStrukturyOrganizacyjnej` | bazodanowe |  |  |
| EfektywnyOkres | `Soneta.Types.FromTo` |  |  |  |
| Elementy | `Soneta.Business.SubTable` |  |  |  |
| HistoriaPodleglosci | `Soneta.Business.HistorySubTable<Soneta.Core.ElementStrukturyOrganizacyjnejRef>` |  |  |  |
| IsReadOnlyDataDo | `bool` |  |  |  |
| IsReadOnlyDataOd | `bool` |  |  |  |
| IsVisibleEfektywnyOkres | `bool` |  |  |  |
| IsVisibleOkresEx | `bool` |  |  |  |
| Kod | `string` | bazodanowe |  |  |
| KontrolaPraw | `Soneta.Business.IRightsSource` | bazodanowe, iface-ref |  |  |
| Nadrzedny | `Soneta.Core.ElementStrukturyOrganizacyjnej` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaPomocnicza | `string` | bazodanowe |  |  |
| ObiektyDoPlanowania | `Soneta.Business.SubTable` |  |  |  |
| ObjectRight | `Soneta.Business.AccessRights` | enum |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe | Okres | Okres obowiązywania elementu struktury organizacyjnej |
| OkresEx | `Soneta.Types.FromTo` |  | Okres |  |
| Permissions | `Soneta.Business.SubTable<Soneta.Business.Db.Permissions.RecordPermission>` |  |  |  |
| PodelementyWgAktualnosci | `Soneta.Business.SubTable<Soneta.Core.ElementStrukturyOrganizacyjnejRef>` |  |  |  |
| Powiązania | `Soneta.Business.SubTable<Soneta.Core.PowiązanieStrukturyOrganizacyjnej>` |  |  |  |
| Struktura | `Soneta.Core.StrukturaOrganizacyjna` | bazodanowe |  |  |
| SubDrzewo | `System.Collections.Generic.IEnumerable<Soneta.Core.ElementStrukturyOrganizacyjnej>` |  |  |  |
| WszystkieElementy | `Soneta.Business.SubTable` |  |  |  |
| WszystkieLiście | `System.Collections.Generic.IEnumerable<Soneta.Core.ElementStrukturyOrganizacyjnej>` |  |  |  |
| WszystkieSubElementy | `System.Collections.Generic.IEnumerable<Soneta.Core.ElementStrukturyOrganizacyjnej>` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| KontrolaPraw | `IRightsSource` | `BasicDocumentDefinition`, `DBItem`, `DashboardView`, `DataModel`, `DbTupleDefinition`, `DefDiscussion`, `DefDokHandlowego`, `DefKampania`, `DefKategKth`, `DefKoresp`, `DefLeada`, `DefPlanuSprzedazy`, `DefProjektu`, `DefSkladki`, `DefTeczki`, `DefTransakcja`, `DefZadania`, `DefZgloszenia`, `DefinicjaAktualizacjiKalendarza`, `DefinicjaCeny`, `DefinicjaDokumentu`, `DefinicjaFunduszuPozyczkowego`, `DefinicjaListyPlac`, `DefinicjaPlanowanejListyPłac`, `DefinicjaRozliczeniaMediow`, `DefinicjaSlownika`, `DefinicjaSprawyWindykacyjnej`, `DefinicjaZestawieniaCzasu`, `EwidencjaSP`, `ExternalDatabase`, `GIODODefinicjaOświadczenia`, `GIODODefinicjaUprawnienia`, `KategoriaST`, `KategoriaZapotrzebowania`, `KontoPocztowe`, `Magazyn`, `MatterDefinition`, `MiejsceUzytkowania`, `NoticeChannel`, `ObfuscateDef`, `OddzialFirmy`, `PivotView`, `ProWydzial`, `Region`, `ReservationDef`, `RodzajDokumentuKseF`, `StrukturaOrganizacyjna`, `SubstituteDef`, `SysZewToken`, `TicketDefinition`, `TypNieruchomosc`, `TypUrzadzenia`, `WFDefinition`, `Wydzial` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AccessRights (`Soneta.Business.AccessRights`)
- `Denied` = 0 — Zakaz dostępu
- `ReadOnly` = 1 — Tylko odczyt
- `Granted` = 2 — Pełne prawo
- `NoInit` = 3 — Niezainicjowane
