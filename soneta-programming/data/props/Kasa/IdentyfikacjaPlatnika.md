# Pola i właściwości klasy biznesowej: `Soneta.Kasa.IdentyfikacjaPlatnika`
Nazwa tabeli: `IdentPlatnikow`
Tytuł: Identyfikacje płatników
Opis: Dane identyfikacyjne płatników używane w bankowości elektronicznej i przelewach. Przechowuje identyfikatory podmiotów kasowych (np. NIP, REGON) z podziałem na typy, umożliwiając jednoznaczne rozpoznawanie płatników przy imporcie wyciągów i generowaniu przelewów.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Identyfikator | `string` | bazodanowe |  |  |
| Konfiguracja | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| Podmiot | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  |  |
| Typ | `Soneta.Kasa.TypIdentyfikatoraPłatnika` | bazodanowe, enum |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Podmiot | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypIdentyfikatoraPłatnika (`Soneta.Kasa.TypIdentyfikatoraPłatnika`)
- `Opis` = 1
- `NumerRachunku` = 2
