# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.Kwalifikacyjny.TypPotwierdzenia`
Nazwa tabeli: `ZklTypPotwier`
Tytuł: Typy potwierdzeń
Opis: Zawiera formy dokumentów i potwierdzeń kwalifikacji, np. certyfikaty czy zaświadczenia. W profilu kwalifikacji daje możliwość określenia jakie potwierdzenia są wymagane dla danej kwalifikacji.
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
