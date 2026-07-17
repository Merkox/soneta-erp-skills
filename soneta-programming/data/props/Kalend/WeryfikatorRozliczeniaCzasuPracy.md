# Pola i właściwości klasy biznesowej: `Soneta.Kalend.WeryfikatorRozliczeniaCzasuPracy`
Nazwa tabeli: `WerRozCzas`
Tytuł: Weryfikatory dla dokumentów rozliczenia czasu pracy
Opis: Element szczegółowy definicji rozliczenia czasu pracy (DefinicjaRozliczeniaCzasuPracy). Przypisanie weryfikatora do definicji dokumentu rozliczenia, określające typ weryfikacji stosowanej przy zatwierdzaniu dokumentów.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaRozliczeniaCzasuPracy | `Soneta.Kalend.DefinicjaRozliczeniaCzasuPracy` | bazodanowe |  |  |
| DefinicjaWeryfikatora | `Soneta.Kalend.DefinicjaWeryfikatoraRozliczeniaCzasuPracy` | bazodanowe |  |  |
| Typ | `Soneta.Kalend.TypWeryfikacjiRozliczeniaCzasuPracy` | bazodanowe, enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypWeryfikacjiRozliczeniaCzasuPracy (`Soneta.Kalend.TypWeryfikacjiRozliczeniaCzasuPracy`)
- `Warning` = 100 — Ostrzeżenie
- `Error` = 200 — Błąd
