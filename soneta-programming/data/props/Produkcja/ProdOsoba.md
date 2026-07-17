# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.ProdOsoba`
Nazwa tabeli: `ProdOsobyR`
Tytuł: Osoby wykonujące operacje produkcyjne
Opis: Rzeczywiste osoby produkcyjne reprezentujące konkretnych pracowników wykonujących operacje na hali produkcyjnej. Powiązane z kartoteką pracowniczą, umożliwiają rejestrowanie meldunków, śledzenie czasu pracy i rozliczanie wynagrodzenia akordowego.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IProdOsoba`, `IProdZasob`

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Określa zablokowanie osoby rzeczywistej. Zablokowane osoby nie będą wyświetlane na listach wyboru. |
| Imie | `string` | bazodanowe |  | Imię pracownika. |
| ImieNazwisko | `string` |  | Imię nazwisko | Imię i nazwisko pracownika. |
| JestPracownik | `bool` | bazodanowe |  | Określa czy przypisany jest pracownik z KiP. |
| KodPracownika | `string` |  | Kod pracownika | Kod przypisanego pracownika. |
| Kompetencje | `Soneta.Business.SubTable<Soneta.Produkcja.ProdOsobaKompetencja>` |  |  |  |
| Nazwisko | `string` | bazodanowe |  | Nazwisko pracownika. |
| Operator | `Soneta.Business.App.Operator` | bazodanowe |  | Określa przypisanego operatora. |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  | Symbol, skrócona nazwa osoby. |
