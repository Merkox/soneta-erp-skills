# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.Kwalifikacyjny.TypPotwierdzenia`
Nazwa tabeli: `ZklTypPotwier`
Tytuł: Typy potwierdzeń
Opis: Zawiera formy dokumentów i potwierdzeń kwalifikacji, np. certyfikaty czy zaświadczenia. W profilu kwalifikacji daje możliwość określenia jakie potwierdzenia są wymagane dla danej kwalifikacji.
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
