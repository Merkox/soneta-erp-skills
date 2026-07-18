# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.HarmonogramWplat`
Nazwa tabeli: `HarmWplat`
Tytuł: Harmonogramy wpłat
Opis: Harmonogramy wpłat ratalnych za szkolenia i składki członkowskie. Definiują terminy, kwoty i typy poszczególnych rat płatności powiązanych ze zgłoszeniami uczestników lub grupami szkoleniowymi.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe | Termin wpłaty | Termin wpłaty. |
| Kwota | `Currency` | bazodanowe |  | Kwota wpłaty. |
| Platnik | `Soneta.CRM.Kontrahent` | bazodanowe | Płatnik |  |
| Proporcja | `double` | bazodanowe |  |  |
| Typ | `Soneta.CzlonkowieSzkolenia.TypWplaty` (enum) | bazodanowe |  |  |
| Zrodlo | `Soneta.CzlonkowieSzkolenia.IZrodloHarmWplaty` | bazodanowe, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Zrodlo | `IZrodloHarmWplaty` | `GrupaSzkol`, `ZgloszenieUczestnik` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypWplaty (`Soneta.CzlonkowieSzkolenia.TypWplaty`)
- `Kwota` = 0 — Kwota
- `Proporcja` = 1
