# Pola i właściwości klasy biznesowej: `Soneta.Core.KodKreskowy`
Nazwa tabeli: `KodyKreskowe`
Tytuł: Kody keskowe
Opis: Element szczegółowy obiektu kodowalnego (IKodowany). Przechowuje kody kreskowe i inne kody identyfikacyjne przypisane do obiektów w systemie (towarów, dokumentów itp.), z informacją o typie i podtypie kodu, jednostce oraz statusie domyślności.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zapis` → `IKodowany`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Jednostka | `Soneta.Business.GuidedRow` | bazodanowe |  | Jednostka przypisana do danego kodu. |
| Kod | `string` | bazodanowe |  | Kod (może być kreskowy) do szybkiego wyszukiwania obiektów w programie. |
| KodWlasnyObcy | `Soneta.Core.KodWlasnyObcy` | enum |  |  |
| KodyKontrahenta | `Soneta.Business.SubTable` |  |  |  |
| Obcy | `bool` | bazodanowe | Kod kontrahenta | Określa kod, który stosowany jest przez danego kontrahenta. |
| PodTypKodu | `Soneta.Core.PodTypKodu` | bazodanowe, enum | Rodzaj kodu |  |
| TypKodu | `Soneta.Core.TypKodu` | bazodanowe, enum |  |  |
| Zapis | `Soneta.Core.IKodowany` | bazodanowe, guided-parent, iface-ref |  | Zapis, do którego przypisany jest dany kod kreskowy |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Zapis | `IKodowany` | `DokumentHandlowy`, `GrupaDostaw`, `KontaktOsoba`, `Kontrahent`, `Operacja`, `SrodekTrwalyBase`, `Towar`, `Urzadzenie`, `Wyposazenie` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KodWlasnyObcy (`Soneta.Core.KodWlasnyObcy`)
- `Wlasny` = 0
- `Obcy` = 1

### PodTypKodu (`Soneta.Core.PodTypKodu`)
- `None` = 0
- `EAN13` = 1
- `PrefixEAN13` = 2 — Prefix EAN13
- `Inny` = 3

### TypKodu (`Soneta.Core.TypKodu`)
- `KodKreskowy` = 0
- `EMail` = 1
- `Alfanumeryczny` = 2
