# Pola i właściwości klasy biznesowej: `Soneta.Kadry.OkresWykonywaniaPracyTymczasowej`
Nazwa tabeli: `OkresyPracyTymcz`
Tytuł: Okresy wykonywania pracy tymczasowej
Opis: Element szczegółowy historii zatrudnienia (HistoriaZatrudnieniaBase). Rejestracja okresów wykonywania pracy tymczasowej z podaniem pracodawcy użytkownika i zakresu dat, wymagana dla agencji pracy tymczasowej.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zatrudnienie` → `HistoriaZatrudnieniaBase`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Pracodawca | `Soneta.CRM.Kontrahent` | bazodanowe | Pracodawca użytkownik |  |
| Zatrudnienie | `Soneta.Kadry.HistoriaZatrudnieniaBase` | bazodanowe, guided-parent |  |  |
