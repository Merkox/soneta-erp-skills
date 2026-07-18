# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.ProdOsoba`
Nazwa tabeli: `ProdOsobyR`
Tytuł: Osoby wykonujące operacje produkcyjne
Opis: Rzeczywiste osoby produkcyjne reprezentujące konkretnych pracowników wykonujących operacje na hali produkcyjnej. Powiązane z kartoteką pracowniczą, umożliwiają rejestrowanie meldunków, śledzenie czasu pracy i rozliczanie wynagrodzenia akordowego.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IProdOsoba`, `IProdZasob`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Określa zablokowanie osoby rzeczywistej. Zablokowane osoby nie będą wyświetlane na listach wyboru. |
| Imie | `string` | bazodanowe |  | Imię pracownika. |
| ImieNazwisko | `string` | tylko-odczyt | Imię nazwisko | Imię i nazwisko pracownika. |
| JestPracownik | `bool` | bazodanowe |  | Określa czy przypisany jest pracownik z KiP. |
| KodPracownika | `string` | tylko-odczyt | Kod pracownika | Kod przypisanego pracownika. |
| Kompetencje | `SubTable<Soneta.Produkcja.ProdOsobaKompetencja>` | podlista |  |  |
| Nazwisko | `string` | bazodanowe |  | Nazwisko pracownika. |
| Operator | `App.Operator` | bazodanowe |  | Określa przypisanego operatora. |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  | Symbol, skrócona nazwa osoby. |
