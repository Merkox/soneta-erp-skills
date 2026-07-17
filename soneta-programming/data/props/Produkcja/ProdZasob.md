# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.ProdZasob`
Nazwa tabeli: `ProdZasobyR`
Tytuł: Produkcyjne zasoby rzeczywiste
Opis: Rzeczywiste zasoby produkcyjne reprezentujące konkretne maszyny, stanowiska robocze i narzędzia dostępne w zakładzie. Przechowują informacje o stanie, dostępności i kalendarzu pracy zasobu, umożliwiając przydzielanie ich do zleceń produkcyjnych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IProdZasob`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Określa zablokowanie zasobu. Zablokowane zasoby nie będą wyświetlane na listach wyboru. |
| Nazwa | `string` | bazodanowe | Nazwa | Pełna nazwa zasobu rzeczywistego. |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis | Opis zasobu rzeczywistego. |
| RelacjeZasobu | `Soneta.Business.SubTable<Soneta.Produkcja.ProdZasobRelacja>` |  |  |  |
| Symbol | `string` | bazodanowe | Symbol | Symbol, skrócona nazwa zasobu. |
| WzorcoweZasobyProdukcyjne | `Soneta.Business.SubTable<Soneta.Produkcja.ProdZasobRelacja>` |  |  |  |
| Wzorcowy | `bool` |  |  | Określa czy zasób jest wzorcowy. |
| ZasobyCRM | `Soneta.Business.SubTable<Soneta.Produkcja.RelacjaProdZasobCRM>` |  |  |  |
