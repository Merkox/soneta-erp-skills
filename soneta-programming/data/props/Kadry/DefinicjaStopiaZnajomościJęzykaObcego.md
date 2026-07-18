# Pola i właściwości klasy biznesowej: `Soneta.Kadry.DefinicjaStopiaZnajomościJęzykaObcego`
Nazwa tabeli: `DefStZnJObcych`
Tytuł: Definicje stopni znajomości języków obcych
Opis: Słownik stopni znajomości języków obcych (np. podstawowy, średniozaawansowany, biegły). Wykorzystywany do oceny poziomu umiejętności językowych pracownika w mowie i piśmie.
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
