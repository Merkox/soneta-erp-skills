# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.ProdProdukt`
Nazwa tabeli: `ProdProdukty`
Tytuł: Parametry towarów
Opis: Konfigurowalne parametry produkcyjne towaru przypisujące domyślną technologię wytworzenia i magazyn rozchodów surowców. Umożliwia szybkie tworzenie zleceń produkcyjnych z predefiniowaną technologią oraz automatyczne kierowanie rozchodów surowcowych do właściwego magazynu.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| MagazynRozchodow | `Soneta.Magazyny.Magazyn` | bazodanowe | Magazyn rozchodów | Określa domyślny magazyn rozchodów. |
| Technologia | `Soneta.Produkcja.Technologia` | bazodanowe |  | Określa technologię domyślną. |
| Towar | `Soneta.Towary.Towar` | bazodanowe | Towar | Określa parametryzowany towar. |
