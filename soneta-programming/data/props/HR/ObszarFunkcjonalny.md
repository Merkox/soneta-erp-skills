# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kwalifikacje.ObszarFunkcjonalny`
Nazwa tabeli: `ZklObszrFunk`
Tytuł: Obszary funkcjonalne
Opis: Słownik opisuje główne obszary działalności funkcjonalnej organizacji, np. IT, finanse czy produkcja. Wykorzystywany w opisie ogólnym stanowiska i profilu kwalifikacji do osadzenia roli w strukturze firmy.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` |  |  |  |
