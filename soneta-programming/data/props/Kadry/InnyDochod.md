# Pola i właściwości klasy biznesowej: `Soneta.Kadry.InnyDochod`
Nazwa tabeli: `InneDochody`
Tytuł: Inne dochody
Opis: Element szczegółowy pracownika (Pracownik). Rejestracja dodatkowych dochodów pracownika uzyskiwanych poza bieżącym zatrudnieniem w poszczególnych miesiącach, uwzględnianych przy obliczaniu przekroczenia podstawy składek ZUS.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dochod | `decimal` | bazodanowe | Dochód |  |
| Miesiac | `int` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| RokMiesiac | `YearMonth` |  |  |  |
