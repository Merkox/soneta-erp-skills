# Pola i właściwości klasy biznesowej: `Soneta.Core.DefinicjaDokumentuOA`
Nazwa tabeli: `DefDokumentowOA`
Tytuł: Dokument elementu opisu analitycznego
Opis: Element szczegółowy definicji dokumentu (IDefinicjaDokumentuOA). Przechowuje konfigurację opisu analitycznego dla danego typu dokumentu, w tym kategorie budżetu, sposób edycji, przeliczania i kopiowania opisu.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 8
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 10
- podlisty: 3
- subrowy: 2
- razem: 24

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Host | `Soneta.Core.IDefinicjaDokumentuOA` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| OpisAnalityczny | `Soneta.Core.KonfiguracjaOpisuAnalitycznego` (subrow) | bazodanowe |  |  |
| OpisAnalityczny.CategoryDefinitions | `Soneta.Core.IBudgetCategoryDefinition[]` | podlista |  |  |
| OpisAnalityczny.DataInicjowania | `Soneta.Core.InicjowanieDatyOpisuAnalitycznego` (enum) | bazodanowe |  | Data z jaką będzie inicjowany opis |
| OpisAnalityczny.DefaultCategoryDefinition | `Soneta.Core.IBudgetCategoryDefinition` |  |  |  |
| OpisAnalityczny.IsExtendedBudgeting | `bool` | tylko-odczyt |  |  |
| OpisAnalityczny.IsReadOnlyDefaultCategoryDefinition | `bool` | tylko-odczyt |  |  |
| OpisAnalityczny.IsReadOnlyPaymentSegment | `bool` | tylko-odczyt |  |  |
| OpisAnalityczny.IsVisibleCategorySegment | `bool` | tylko-odczyt |  |  |
| OpisAnalityczny.IsVisibleCurrencyInitializeSegment | `bool` | tylko-odczyt |  |  |
| OpisAnalityczny.IsVisibleDateSegment | `bool` | tylko-odczyt |  |  |
| OpisAnalityczny.IsVisibleEditingSegment | `bool` | tylko-odczyt |  |  |
| OpisAnalityczny.IsVisiblePaymentSegment | `bool` | tylko-odczyt |  |  |
| OpisAnalityczny.IsVisibleSegment | `bool` | tylko-odczyt |  |  |
| OpisAnalityczny.Kategorie | `MemoText` | bazodanowe, podlista |  | Wybrane kategorie budżetu |
| OpisAnalityczny.Kopiowanie | `Soneta.Core.KopiowanieOpisuAnalitycznego` (subrow) | bazodanowe |  | Sposób kopiowania opisu analitycznego |
| OpisAnalityczny.Kopiowanie.Cecha | `FeatureDefinition` | bazodanowe |  | Cecha warunkująca kopiowania opisu analitycznego |
| OpisAnalityczny.Kopiowanie.MaskaWymiaru | `string` | bazodanowe |  | Maska wymiaru |
| OpisAnalityczny.Kopiowanie.SposobKopiowania | `Soneta.Core.SposobKopiowaniaOpisuAnalitycznego` (enum) | bazodanowe |  | Sposób kopiowania opisu analitycznego |
| OpisAnalityczny.Kopiowanie.WgCecha | `Key` | podlista |  |  |
| OpisAnalityczny.KorygowanieRozliczenia | `bool` | bazodanowe |  | Korygowanie rozliczenia budżetu |
| OpisAnalityczny.KwotaInicjowania | `Soneta.Core.SposobInicjowaniaKwotyOpisuAnalitycznego` (enum) | bazodanowe |  | Sposób inicjowania kwoty |
| OpisAnalityczny.RodzajEdycji | `Soneta.Core.EdycjaOpisuAnalitycznego` (enum) | bazodanowe |  | Rodzaj edycji opisu analitycznego |
| OpisAnalityczny.RodzajPrzeliczania | `Soneta.Core.PrzeliczanieOpisuAnalitycznego` (enum) | bazodanowe |  | Rodzaj przeliczania wartości |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IDefinicjaDokumentuOA` | `DefDokHandlowego`, `DefinicjaDokumentu`, `DefinicjaListyPlac`, `DefinicjaPlanowanejListyPłac` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### EdycjaOpisuAnalitycznego (`Soneta.Core.EdycjaOpisuAnalitycznego`)
- `Brak` = 0
- `Zawsze` = 1
- `NaZatwierdzonym` = 2

### InicjowanieDatyOpisuAnalitycznego (`Soneta.Core.InicjowanieDatyOpisuAnalitycznego`)
- `DatyWystawienia` = 0 — Daty wystawienia
- `DatyOperacji` = 1 — Daty operacji
- `DatyOtrzymania` = 2 — Daty otrzymania

### PrzeliczanieOpisuAnalitycznego (`Soneta.Core.PrzeliczanieOpisuAnalitycznego`)
- `Brak` = 0
- `NaBiezaco` = 1 — Na bieżąco

### SposobInicjowaniaKwotyOpisuAnalitycznego (`Soneta.Core.SposobInicjowaniaKwotyOpisuAnalitycznego`)
- `WartoscNetto` = 0 — Wartość netto
- `WartoscBrutto` = 1 — Wartość brutto
- `WartoscVAT` = 2 — Wartość VAT
- `Zerowa` = 3
- `WgCenZakupu` = 4

### SposobKopiowaniaOpisuAnalitycznego (`Soneta.Core.SposobKopiowaniaOpisuAnalitycznego`)
- `Brak` = 0
- `Wszystkie` = 1
- `WgMaskiWymiaru` = 2
- `WgCechy` = 3
