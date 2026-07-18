# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kwalifikacje.ObslugaMaszynIUrzadzen`
Nazwa tabeli: `ZklObsMaszUrz`
Tytuł: Obsługa maszyn i urządzeń
Opis: Definiuje typy maszyn i urządzeń, których obsługa wymaga określonych umiejętności lub uprawnień. W profilu kwalifikacji umożliwia dokładne określenie umiejętności technicznych.
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
