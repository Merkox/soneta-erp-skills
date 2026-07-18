# Pola i właściwości klasy biznesowej: `Soneta.Core.ManagedRowInfo`
Nazwa tabeli: `ManagedRowsInfo`
Tytuł: Informacja o przetwarzaniu przez proces
Opis: Element szczegółowy hosta zarządzanego wiersza (IManagedRowInfoHost). Przechowuje informację o stanie przetwarzania obiektu przez proces workflow (np. w toku, zaakceptowany, odrzucony).
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `ManagedRow` → `IManagedRowInfoHost`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ManagedRow | `Soneta.Core.IManagedRowInfoHost` | bazodanowe, tylko-odczyt, guided-parent, iface-ref |  |  |
| ManagedState | `Soneta.Core.ManagedRowStates` (enum) | bazodanowe, tylko-odczyt |  |  |
| Metryka | `LpSubTable<Soneta.Core.ManagedRowMetrics>` | podlista |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| ManagedRow | `IManagedRowInfoHost` | `BadanieLekarskie`, `DbTuple`, `HistoriaZatrudnieniaBase`, `RozliczenieCzasuPracy`, `Zadanie` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ManagedRowStates (`Soneta.Core.ManagedRowStates`)
- `Pending` = 1 — Wprowadzany
- `Active` = 2 — Przetwarzany
- `Finished` = 3 — Zakończony
- `Abandoned` = 4 — Porzucony
- `Removed` = 5 — Usunięty
