# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.KlubUczHist`
Nazwa tabeli: `KlubyUczHist`
Tytuł: Przynależność do klubów
Opis: Historia przynależności uczestników do klubów i kół organizacji. Rejestruje zmiany członkostwa w jednostkach organizacyjnych z datami i akcjami (dołączenie, wystąpienie), umożliwiając śledzenie rotacji członków.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Akcja | `Soneta.CzlonkowieSzkolenia.StanPrzynaleznosci` | bazodanowe, enum |  |  |
| Data | `Soneta.Types.Date` | bazodanowe | Data zmiany | Data zmiany. |
| Nazwa | `string` | bazodanowe |  |  |
| Uczestnik | `Soneta.CzlonkowieSzkolenia.UczestnikBase` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanPrzynaleznosci (`Soneta.CzlonkowieSzkolenia.StanPrzynaleznosci`)
- `Przyjecie` = 0 — Przyjęcie
- `Skreslenie` = 1 — Skreślenie
