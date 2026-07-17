# Pola i właściwości klasy biznesowej: `Soneta.Core.DaneZewn`
Nazwa tabeli: `DaneZ`
Tytuł: Dane z systemów zewnętrznych
Opis: Dane pobrane lub wysłane do systemu zewnętrznego. Przechowuje surowe dane (XML/JSON), kategorię, datę, typ tabeli docelowej, system zewnętrzny i dodatkowe informacje.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dane | `Soneta.Business.MemoText` | bazodanowe | Dane zewnętrzne | Dane zewnętrzne |
| Data | `System.DateTime` | bazodanowe | Data | Data |
| Info | `string` | bazodanowe | Info | Dodatkowe informacje |
| Kategoria | `Soneta.Core.KategoriaDanychZewn` | bazodanowe, enum | KategoriaDanychZewn | Kategoria danych zewnętrznych |
| SystemZewn | `Soneta.Core.SystemZewn` | bazodanowe | System zewnętrzny | Wskazanie na system zewnętrzny |
| Tabela | `string` | bazodanowe | Typ obiektu programu | Typ obiektu programu |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KategoriaDanychZewn (`Soneta.Core.KategoriaDanychZewn`)
- `Brak` = 0 — Brak
- `KSeF` = 1 — KSeF
- `OCR` = 2 — OCR
