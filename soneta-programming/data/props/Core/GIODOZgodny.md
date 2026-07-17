# Pola i właściwości klasy biznesowej: `Soneta.Core.GIODOZgodny`
Nazwa tabeli: `GIODOZgodne`
Opis: Element szczegółowy hosta zgodności GIODO/RODO (IGIODOZgodnyHost). Rejestruje potwierdzenia zgodności z przepisami ochrony danych osobowych - przechowuje operatora, status potwierdzenia i datę zmiany statusu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Host` → `IGIODOZgodnyHost`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataZmiany | `System.DateTime` | bazodanowe | Data | Data zmiany statusu. |
| Host | `Soneta.Core.IGIODOZgodnyHost` | bazodanowe, guided-parent, iface-ref |  | Host, do którego przypisany status zgodności |
| Operator | `Soneta.Business.App.Operator` | bazodanowe | Operator | Operator zmieniający status. |
| Stan | `Soneta.Core.GIODOStatus` | bazodanowe, enum | Status | Status potwierdzenia. |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IGIODOZgodnyHost` | `KontaktOsoba`, `Kontrahent`, `Pracownik`, `UczestnikBase` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### GIODOStatus (`Soneta.Core.GIODOStatus`)
- `GIODO_Rejected` = 0
- `GIODO_Accepted` = 1
