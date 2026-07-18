# Pola i właściwości klasy biznesowej: `Soneta.Kalend.WeryfikatorRozliczeniaCzasuPracy`
Nazwa tabeli: `WerRozCzas`
Tytuł: Weryfikatory dla dokumentów rozliczenia czasu pracy
Opis: Element szczegółowy definicji rozliczenia czasu pracy (DefinicjaRozliczeniaCzasuPracy). Przypisanie weryfikatora do definicji dokumentu rozliczenia, określające typ weryfikacji stosowanej przy zatwierdzaniu dokumentów.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaRozliczeniaCzasuPracy | `Soneta.Kalend.DefinicjaRozliczeniaCzasuPracy` | bazodanowe, tylko-odczyt |  |  |
| DefinicjaWeryfikatora | `Soneta.Kalend.DefinicjaWeryfikatoraRozliczeniaCzasuPracy` | bazodanowe, tylko-odczyt |  |  |
| Typ | `Soneta.Kalend.TypWeryfikacjiRozliczeniaCzasuPracy` (enum) | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypWeryfikacjiRozliczeniaCzasuPracy (`Soneta.Kalend.TypWeryfikacjiRozliczeniaCzasuPracy`)
- `Warning` = 100 — Ostrzeżenie
- `Error` = 200 — Błąd
