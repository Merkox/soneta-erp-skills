# Pola i właściwości klasy biznesowej: `Soneta.Kasa.IdentyfikacjaPlatnika`
Nazwa tabeli: `IdentPlatnikow`
Tytuł: Identyfikacje płatników
Opis: Dane identyfikacyjne płatników używane w bankowości elektronicznej i przelewach. Przechowuje identyfikatory podmiotów kasowych (np. NIP, REGON) z podziałem na typy, umożliwiając jednoznaczne rozpoznawanie płatników przy imporcie wyciągów i generowaniu przelewów.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 1
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Identyfikator | `string` | bazodanowe |  |  |
| Konfiguracja | `MemoText` | bazodanowe, podlista |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe, tylko-odczyt |  |  |
| Podmiot | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| Typ | `Soneta.Kasa.TypIdentyfikatoraPłatnika` (enum) | bazodanowe, tylko-odczyt |  |  |

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
