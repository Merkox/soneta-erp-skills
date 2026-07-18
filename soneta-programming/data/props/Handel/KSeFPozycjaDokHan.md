# Pola i właściwości klasy biznesowej: `Soneta.Handel.KSeFPozycjaDokHan`
Nazwa tabeli: `KSeFPozDokHan`
Tytuł: Dane KSeF przypisane do pozycji dokumentu handlowego
Opis: Tabela przechowuje dodatkowe dane KSeF przypisane do pozycji dokumentów handlowych. Zawiera informacje o stawce VAT niepodlegającej opodatkowaniu (NP) przekazywanej do Krajowego Systemu e-Faktur.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pozycja` → `PozycjaDokHandlowego`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Pozycja | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe, tylko-odczyt, guided-parent |  | Pozycja dokumentu handlowego. |
| StawkaVat0 | `Soneta.Handel.KSeFStawkaVat0` (enum) | bazodanowe | Stawka VAT 0% | Określa typ sprzedaży 0% VAT przekazywany do KSeF. |
| StawkaVatNP | `Soneta.Handel.KSeFStawkaVatNP` (enum) | bazodanowe | Stawka VAT NP | Określa typ sprzedaży niepodlegającej opodatkowaniu VAT przekazywany do KSeF. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KSeFStawkaVat0 (`Soneta.Handel.KSeFStawkaVat0`)
- `Brak` = 0
- `KR` = 1 — 0 KR
- `WDT` = 2 — 0 WDT
- `EX` = 3 — 0 EX

### KSeFStawkaVatNP (`Soneta.Handel.KSeFStawkaVatNP`)
- `Brak` = 0
- `NPI` = 1 — NP I
- `NPII` = 2 — NP II
