# Moduł `Towary` — tabele biznesowe

- Opis: Moduł kartoteki towarów i usług obsługujący ewidencję asortymentu, jednostek miar z przelicznikami, cenników (w tym cen indywidualnych, grupowych, progowych i promocji okresowych) oraz kodów kreskowych. Definiuje schematy opakowań, zamienniki towarowe, komplety produkcyjne, klasyfikacje CN/CPV/BDO/SUP oraz mechanizmy rabatowania i wyceny.
- Tabel: **27**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| Cena | Ceny | `Ceny` |  | child: Towar→Towar |  |  |  | [Cena.md](Cena.md) |
| CenaGrupowa |  | `CenyGrupowe` |  | root |  |  |  | [CenaGrupowa.md](CenaGrupowa.md) |
| CenaIndywidualna |  | `CenyIndywidualne` |  | child: Towar→Towar |  |  |  | [CenaIndywidualna.md](CenaIndywidualna.md) |
| CenaProgowa | Ceny progowe | `CenyProgowe` |  | child: Towar→Towar |  |  |  | [CenaProgowa.md](CenaProgowa.md) |
| DefinicjaCeny | Definicje cen | `DefinicjeCen` | konfig | root |  | IRightsSource |  | [DefinicjaCeny.md](DefinicjaCeny.md) |
| DostawcaTowaru | Dostawcy towaru | `DostawcyTowaru` |  | child: Towar→Towar |  |  |  | [DostawcaTowaru.md](DostawcaTowaru.md) |
| ElemOpakowan | Elementy schematów opakowań/gratisów | `ElemyOpakowan` |  | child: Schemat→SchemOpakowan |  |  |  | [ElemOpakowan.md](ElemOpakowan.md) |
| ElementKompletu | Elementy kompletów | `ElemKompletow` |  | root |  |  |  | [ElementKompletu.md](ElementKompletu.md) |
| Jednostka | Jednostki | `Jednostki` | konfig | root |  |  |  | [Jednostka.md](Jednostka.md) |
| KodBDO |  | `KodyBDO` |  | root |  |  |  | [KodBDO.md](KodBDO.md) |
| KodCN |  | `KodyCN` |  | root |  |  |  | [KodCN.md](KodCN.md) |
| KodCPV |  | `KodyCPV` |  | root |  |  |  | [KodCPV.md](KodCPV.md) |
| KodSUP |  | `KodySUP` |  | root |  |  |  | [KodSUP.md](KodSUP.md) |
| KodTwrKontrahent | Kod towaru | `KodyTwrKontrah` |  |  |  |  |  | [KodTwrKontrahent.md](KodTwrKontrahent.md) |
| PrzecenaOkresowa |  | `PrzecenyOkres` |  | root |  |  | CelPrzecenyOkresowej (2) | [PrzecenaOkresowa.md](PrzecenaOkresowa.md) |
| PrzecenaOkresowaTowaru |  | `PrzecenyOkresTwr` |  |  |  |  |  | [PrzecenaOkresowaTowaru.md](PrzecenaOkresowaTowaru.md) |
| PrzecenaOkresowaTowaruSchematGratisow |  | `PrzOkresTwrSchGr` |  |  |  |  |  | [PrzecenaOkresowaTowaruSchematGratisow.md](PrzecenaOkresowaTowaruSchematGratisow.md) |
| Przelicznik |  | `Przeliczniki` | konfig | child: Wyliczana→Jednostka |  |  |  | [Przelicznik.md](Przelicznik.md) |
| PrzelicznikTowaru |  | `PrzelTow` |  | child: Towar→Towar |  |  |  | [PrzelicznikTowaru.md](PrzelicznikTowaru.md) |
| SchemOpakowan | Schematy opakowań/gratisów | `SchemyOpakowan` |  | root |  |  |  | [SchemOpakowan.md](SchemOpakowan.md) |
| SchematTowar | Schematy opakowań/gratisów towarów | `SchematyTowary` |  | child: SchematOpakowan→SchemOpakowan |  |  |  | [SchematTowar.md](SchematTowar.md) |
| Towar |  | `Towary` |  | root |  | IElementSlownika, IElementSlownikZewnRel, IKodowany, IAdresyWWWHost |  | [Towar.md](Towar.md) |
| TowarEcommerce | Dane Ecommerce | `TowaryEcommerce` |  |  |  |  |  | [TowarEcommerce.md](TowarEcommerce.md) |
| TowarMagazynInfo |  | `TowarMagazyn` |  | child: Towar→Towar |  |  |  | [TowarMagazynInfo.md](TowarMagazynInfo.md) |
| TowarUlubiony | Ulubione towary | `TowaryUlubione` |  | child: Zapis→ITowaryUlubioneHost |  |  |  | [TowarUlubiony.md](TowarUlubiony.md) |
| WariantTowaru | Warianty towaru | `WariantyTowaru` |  |  |  |  |  | [WariantTowaru.md](WariantTowaru.md) |
| ZamiennikTowaru |  | `ZamiennikiTowaru` |  | child: Towar→Towar |  |  |  | [ZamiennikTowaru.md](ZamiennikTowaru.md) |

