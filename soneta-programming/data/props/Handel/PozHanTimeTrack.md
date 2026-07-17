# Pola i właściwości klasy biznesowej: `Soneta.Handel.PozHanTimeTrack`
Nazwa tabeli: `PozHanTimeTracks`
Tytuł: TimeTrack pozycji dokumentu handlowego
Opis: Powiązanie pozycji dokumentu handlowego z rekordem czasu pracy (TimeTrack). Umożliwia rozliczanie czasu realizacji na pozycjach dokumentów.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Pozycja | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe | Pozycja dokumenty handlowego |  |
| TimeTrack | `Soneta.Core.TimeTrack` | bazodanowe | Czas realizacji |  |
