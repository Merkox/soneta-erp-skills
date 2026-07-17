# Pola i właściwości klasy biznesowej: `Soneta.BI.DashboardItemFieldAppearance`
Nazwa tabeli: `DashBrdItemFApps`
Tytuł: Wyglądy pól elementów wizualizacji
Opis: Element szczegółowy definicji wizualizacji (DashboardItemDefinition). Konfiguruje wygląd warunkowy pola na kafelku BI — przypisuje zestaw przedziałów danych i paletę kolorów do wskazanego pola, umożliwiając kolorowanie wartości w zależności od zakresu.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DashboardItem` → `DashboardItemDefinition`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AppearanceSet | `Soneta.BI.AppearanceSetDefinition` | bazodanowe |  |  |
| AppearanceType | `Soneta.BI.AppearanceType` | bazodanowe, enum | Sposób przypisania wyglądu | Sposób przypisania wyglądu do wizualizacji |
| DashboardItem | `Soneta.BI.DashboardItemDefinition` | bazodanowe, guided-parent |  |  |
| DataSpanSet | `Soneta.BI.DataSpanSetDefinition` | bazodanowe |  |  |
| Field | `Soneta.BI.FieldDefinition` | bazodanowe |  |  |
| Reference | `Soneta.BI.DashboardItemDefinition` | bazodanowe | Referencja | Referencyjny element wizualizacji |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AppearanceType (`Soneta.BI.AppearanceType`)
- `Direct` = 1 — Przypisanie bezpośrednie
- `Set` = 2 — Przypisanie zestawu danych
- `Reference` = 3 — Referencja
