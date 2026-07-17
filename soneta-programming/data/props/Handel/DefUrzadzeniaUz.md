# Pola i właściwości klasy biznesowej: `Soneta.Handel.DefUrzadzeniaUz`
Nazwa tabeli: `DefUrzadzenUz`
Tytuł: Definicje urządzeń użytkowanych
Opis: Konfigurowalna definicja typu urządzenia użytkowanego. Zawiera symbol, nazwę oraz definicję formularza opisującego parametry urządzenia.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Blokada definicji. Zablokowane definicje urządzeń nie będą wyświetlane w liście wyboru. |
| DefFormatki | `Soneta.Business.MemoText` | bazodanowe |  | Określa definicję formularza urządzenia w postaci XML. |
| Nazwa | `string` | bazodanowe |  | Pełna nazwa definicji urządzenia, wykorzystywana do wyszukiwania definicji. |
| Symbol | `string` | bazodanowe |  | Skrótowa nazwa definicji urządzenia wykorzystywana do wyszukiwania definicji. |
