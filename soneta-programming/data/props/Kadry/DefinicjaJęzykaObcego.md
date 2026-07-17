# Pola i właściwości klasy biznesowej: `Soneta.Kadry.DefinicjaJęzykaObcego`
Nazwa tabeli: `DefJezykowObcych`
Tytuł: Definicje języków obcych
Opis: Słownik języków obcych dostępnych do ewidencji w kartotece pracownika (np. angielski, niemiecki, francuski). Wykorzystywany przy rejestracji znajomości języków obcych pracowników.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` |  |  |  |
