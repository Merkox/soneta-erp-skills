# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.ProdZasob`
Nazwa tabeli: `ProdZasobyR`
Tytuł: Produkcyjne zasoby rzeczywiste
Opis: Rzeczywiste zasoby produkcyjne reprezentujące konkretne maszyny, stanowiska robocze i narzędzia dostępne w zakładzie. Przechowują informacje o stanie, dostępności i kalendarzu pracy zasobu, umożliwiając przydzielanie ich do zleceń produkcyjnych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IProdZasob`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Określa zablokowanie zasobu. Zablokowane zasoby nie będą wyświetlane na listach wyboru. |
| Nazwa | `string` | bazodanowe | Nazwa | Pełna nazwa zasobu rzeczywistego. |
| Opis | `MemoText` | bazodanowe, podlista | Opis | Opis zasobu rzeczywistego. |
| RelacjeZasobu | `SubTable<Soneta.Produkcja.ProdZasobRelacja>` | podlista |  |  |
| Symbol | `string` | bazodanowe | Symbol | Symbol, skrócona nazwa zasobu. |
| WzorcoweZasobyProdukcyjne | `SubTable<Soneta.Produkcja.ProdZasobRelacja>` | podlista |  |  |
| Wzorcowy | `bool` | tylko-odczyt |  | Określa czy zasób jest wzorcowy. |
| ZasobyCRM | `SubTable<Soneta.Produkcja.RelacjaProdZasobCRM>` | podlista |  |  |
