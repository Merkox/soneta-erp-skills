# Pola i właściwości klasy biznesowej: `Soneta.Core.GIODO.GIODOZbiorDanych`
Nazwa tabeli: `GIODOZbiory`
Tytuł: Zbiory danych
Opis: Zbiór danych osobowych w rejestrze RODO. Zawiera symbol, nazwę, typ (własny/powierzony), administratora danych, cel przetwarzania, kategorię osób, informacje o przekazaniu do państw trzecich, sposób przetwarzania, systemy komputerowe, lokalizację i środki bezpieczeństwa.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Administrator | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref | Adminstrator danych | Adminstrator danych osobowych |
| AdministratorDanychOsobowych | `string` |  |  |  |
| CelPrzetwarzania | `Soneta.Core.GIODOCelPrzetwarzania` | bazodanowe | Cel przetwarzania | Cel przetwarzania |
| CzynnosciPrzetwarzania | `Soneta.Business.SubTable` |  |  |  |
| GIODOUdostępnienia | `Soneta.Business.SubTable<Soneta.Core.GIODOWymianaDanych>` |  |  |  |
| InspektorDanychOsobowych | `string` |  |  |  |
| KategoriaOsob | `Soneta.Core.GIODO.GIODOKategoriaOsob` | bazodanowe | Kategorie osób | Kategorie osób, których dane dotyczą |
| Kategorie | `Soneta.Business.SubTable<Soneta.Core.GIODO.GIODOZbiorKategoria>` |  |  |  |
| KategorieCzynnosciPrzetwarzania | `Soneta.Business.SubTable` |  |  |  |
| KategorieDanychOsobowychTekst | `string` |  |  |  |
| KategorieOdbiorcowTekst | `string` |  |  |  |
| Lokalizacja | `string` | bazodanowe | Lokalizacja zbioru | Lokalizacja zbioru danych |
| Naruszenia | `Soneta.Business.SubTable<Soneta.Core.GIODO.GIODONaruszenie>` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa zbioru danych | Nazwa zbioru danych |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| Odpowiedzialny | `string` | bazodanowe | Odpowiedzialny | Odpowiedzialny za zbiór danych |
| OpisSrodkowBezp | `Soneta.Business.MemoText` | bazodanowe | Opis środków bezpieczeństwa | Opis technicznych i organizacyjnych środków bezpieczeństwa |
| Panstwa | `string` | bazodanowe | Przekazanie danych do państwa trzeciego | Przekazanie danych do państwa trzeciego lub organizacji międzynarodowej |
| PlanUsuniecie | `string` | bazodanowe | Planowane usunięcie | Planowane usunięcie zbioru |
| Przetwarzania | `Soneta.Business.SubTable<Soneta.Core.GIODO.GIODOPrzetwarzanie>` |  |  |  |
| SposobPrzetwarzania | `string` | bazodanowe |  | Sposób przetwarzania (papierowy/elektroniczny) |
| Symbol | `string` | bazodanowe | Symbol | Unikatowy symbol zbioru danych |
| SystemyKomp | `string` | bazodanowe | Aplikacja komputerowa | Nazwa aplikacji komputerowej wykorzystywanej do przetwarzania |
| Typ | `Soneta.Core.GIODO.TypZbioruDanych` | bazodanowe, enum |  | Typ zbioru danych własny/powierzony |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Administrator | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypZbioruDanych (`Soneta.Core.GIODO.TypZbioruDanych`)
- `Brak` = 0 — Razem
- `ZbiórWłasny` = 1
- `ZbiórPowierzony` = 2
