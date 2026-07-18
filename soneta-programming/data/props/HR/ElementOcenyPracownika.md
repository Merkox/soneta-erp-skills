# Pola i właściwości klasy biznesowej: `Soneta.HR.ElementOcenyPracownika`
Nazwa tabeli: `ElementyOcenPrac`
Tytuł: Kryteria
Opis: Element szczegółowy oceny pracownika (IOcenaPracownika). Przechowuje wartość przypisaną do konkretnego kryterium w ramach oceny, umożliwiając szczegółowe punktowanie poszczególnych aspektów pracy.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Ocena` → `IOcenaPracownika`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualny | `bool` | tylko-odczyt |  |  |
| Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| Definicja | `Soneta.HR.DefElementuOcenyPracownika` | bazodanowe |  |  |
| ElementWartość | `Soneta.HR.WartośćElementuOcenyPracownika` |  | Nazwa wartości |  |
| Ocena | `Soneta.HR.IOcenaPracownika` | bazodanowe, tylko-odczyt, guided-parent, iface-ref |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Typ | `Soneta.HR.TypyElementowOceny` (enum) | bazodanowe, tylko-odczyt |  |  |
| Wartosc | `decimal` | bazodanowe | Wartość |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Ocena | `IOcenaPracownika` | `EtapRekrutacji`, `OcenaPracownika`, `UkończoneSzkolenie`, `WniosekOSzkolenie` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypyElementowOceny (`Soneta.HR.TypyElementowOceny`)
- `Historyczny` = 1 — Historyczny
- `Aktualny` = 2
