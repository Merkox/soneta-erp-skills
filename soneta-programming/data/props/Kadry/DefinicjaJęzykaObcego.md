# Pola i właściwości klasy biznesowej: `Soneta.Kadry.DefinicjaJęzykaObcego`
Nazwa tabeli: `DefJezykowObcych`
Tytuł: Definicje języków obcych
Opis: Słownik języków obcych dostępnych do ewidencji w kartotece pracownika (np. angielski, niemiecki, francuski). Wykorzystywany przy rejestracji znajomości języków obcych pracowników.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` | tylko-odczyt |  |  |
