# Pola i właściwości klasy biznesowej: `Soneta.Kadry.OkresWykonywaniaPracyTymczasowej`
Nazwa tabeli: `OkresyPracyTymcz`
Tytuł: Okresy wykonywania pracy tymczasowej
Opis: Element szczegółowy historii zatrudnienia (HistoriaZatrudnieniaBase). Rejestracja okresów wykonywania pracy tymczasowej z podaniem pracodawcy użytkownika i zakresu dat, wymagana dla agencji pracy tymczasowej.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zatrudnienie` → `HistoriaZatrudnieniaBase`

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 1
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Pracodawca | `Soneta.CRM.Kontrahent` | bazodanowe | Pracodawca użytkownik |  |
| Zatrudnienie | `Soneta.Kadry.HistoriaZatrudnieniaBase` | bazodanowe, tylko-odczyt, guided-parent |  |  |
