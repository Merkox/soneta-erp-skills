# Pola i właściwości klasy biznesowej: `Soneta.Core.DefinicjaDokumentuOA`
Nazwa tabeli: `DefDokumentowOA`
Tytuł: Dokument elementu opisu analitycznego
Opis: Element szczegółowy definicji dokumentu (IDefinicjaDokumentuOA). Przechowuje konfigurację opisu analitycznego dla danego typu dokumentu, w tym kategorie budżetu, sposób edycji, przeliczania i kopiowania opisu.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 12
- pola kalkulowane (z klas biznesowych): 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Host | `Soneta.Core.IDefinicjaDokumentuOA` | bazodanowe, iface-ref |  |  |
| OpisAnalityczny | `Soneta.Core.KonfiguracjaOpisuAnalitycznego` | bazodanowe |  |  |
| OpisAnalityczny.CategoryDefinitions | `Soneta.Core.IBudgetCategoryDefinition[]` |  |  |  |
| OpisAnalityczny.DataInicjowania | `Soneta.Core.InicjowanieDatyOpisuAnalitycznego` | bazodanowe, enum |  | Data z jaką będzie inicjowany opis |
| OpisAnalityczny.DefaultCategoryDefinition | `Soneta.Core.IBudgetCategoryDefinition` |  |  |  |
| OpisAnalityczny.IsExtendedBudgeting | `bool` |  |  |  |
| OpisAnalityczny.IsReadOnlyDefaultCategoryDefinition | `bool` |  |  |  |
| OpisAnalityczny.IsReadOnlyPaymentSegment | `bool` |  |  |  |
| OpisAnalityczny.IsVisibleCategorySegment | `bool` |  |  |  |
| OpisAnalityczny.IsVisibleCurrencyInitializeSegment | `bool` |  |  |  |
| OpisAnalityczny.IsVisibleDateSegment | `bool` |  |  |  |
| OpisAnalityczny.IsVisibleEditingSegment | `bool` |  |  |  |
| OpisAnalityczny.IsVisiblePaymentSegment | `bool` |  |  |  |
| OpisAnalityczny.IsVisibleSegment | `bool` |  |  |  |
| OpisAnalityczny.Kategorie | `Soneta.Business.MemoText` | bazodanowe |  | Wybrane kategorie budżetu |
| OpisAnalityczny.Kopiowanie | `Soneta.Core.KopiowanieOpisuAnalitycznego` | bazodanowe |  | Sposób kopiowania opisu analitycznego |
| OpisAnalityczny.Kopiowanie.Cecha | `Soneta.Business.FeatureDefinition` | bazodanowe |  | Cecha warunkująca kopiowania opisu analitycznego |
| OpisAnalityczny.Kopiowanie.MaskaWymiaru | `string` | bazodanowe |  | Maska wymiaru |
| OpisAnalityczny.Kopiowanie.SposobKopiowania | `Soneta.Core.SposobKopiowaniaOpisuAnalitycznego` | bazodanowe, enum |  | Sposób kopiowania opisu analitycznego |
| OpisAnalityczny.Kopiowanie.WgCecha | `Soneta.Business.Key` |  |  |  |
| OpisAnalityczny.KorygowanieRozliczenia | `bool` | bazodanowe |  | Korygowanie rozliczenia budżetu |
| OpisAnalityczny.KwotaInicjowania | `Soneta.Core.SposobInicjowaniaKwotyOpisuAnalitycznego` | bazodanowe, enum |  | Sposób inicjowania kwoty |
| OpisAnalityczny.RodzajEdycji | `Soneta.Core.EdycjaOpisuAnalitycznego` | bazodanowe, enum |  | Rodzaj edycji opisu analitycznego |
| OpisAnalityczny.RodzajPrzeliczania | `Soneta.Core.PrzeliczanieOpisuAnalitycznego` | bazodanowe, enum |  | Rodzaj przeliczania wartości |

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
