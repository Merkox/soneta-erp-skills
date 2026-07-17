# Pola i właściwości klasy biznesowej: `Soneta.Towary.SchematTowar`
Nazwa tabeli: `SchematyTowary`
Tytuł: Schematy opakowań/gratisów towarów
Opis: Element szczegółowy schematu opakowań/gratisów (SchemOpakowan). Przypisuje schemat opakowań/gratisów do konkretnego towaru, określając czy jest domyślny dla dokumentów przychodowych lub rozchodowych. Umożliwia stosowanie alternatywnych schematów opakowań dla tego samego towaru w zależności od kierunku obrotu oraz konfigurację stawki VAT i rabatowania kaucji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `SchematOpakowan` → `SchemOpakowan`

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DomyslnyPrzychod | `bool` | bazodanowe |  | Określa, czy dany schamat jest domyślnym dla dokumentów przychodowych.  |
| DomyslnyRozchod | `bool` | bazodanowe |  | Określa, czy dany schamat jest domyślnym dla dokumentów rozchodowych.  |
| Ilosc | `Soneta.Towary.Quantity` | bazodanowe | Ilość | Ilość towaru. |
| RabatKaucji | `bool` | bazodanowe |  | Określa, czy pozycja o rodzaju systemu kaucyjnego Plastik, Metal lub Szkło utworzona przy użyciu schematu ma podlegać rabatowaniu. |
| SchematOpakowan | `Soneta.Towary.SchemOpakowan` | bazodanowe, guided-parent |  | Alternatywny schemat dla towaru. |
| StawkaVatDlaOpakowania | `Soneta.Towary.StawkaVatDlaOpakowania` | bazodanowe, enum | Stawka VAT na opakowaniu | Stawka VAT na opakowaniu. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar do którego przypisany jest alternatywny schemat. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StawkaVatDlaOpakowania (`Soneta.Towary.StawkaVatDlaOpakowania`)
- `WgPozycji` = 0 — Wg pozycji towaru do opakowania
- `WgKartyTowarowejOpakowania` = 1 — Wg kartoteki towarowej opakowania
