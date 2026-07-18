# Pola i właściwości klasy biznesowej: `Soneta.Core.DaneZewn`
Nazwa tabeli: `DaneZ`
Tytuł: Dane z systemów zewnętrznych
Opis: Dane pobrane lub wysłane do systemu zewnętrznego. Przechowuje surowe dane (XML/JSON), kategorię, datę, typ tabeli docelowej, system zewnętrzny i dodatkowe informacje.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dane | `MemoText` | bazodanowe, podlista | Dane zewnętrzne | Dane zewnętrzne |
| Data | `System.DateTime` | bazodanowe | Data | Data |
| Info | `string` | bazodanowe | Info | Dodatkowe informacje |
| Kategoria | `Soneta.Core.KategoriaDanychZewn` (enum) | bazodanowe | KategoriaDanychZewn | Kategoria danych zewnętrznych |
| SystemZewn | `Soneta.Core.SystemZewn` | bazodanowe | System zewnętrzny | Wskazanie na system zewnętrzny |
| Tabela | `string` | bazodanowe | Typ obiektu programu | Typ obiektu programu |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KategoriaDanychZewn (`Soneta.Core.KategoriaDanychZewn`)
- `Brak` = 0 — Brak
- `KSeF` = 1 — KSeF
- `OCR` = 2 — OCR
