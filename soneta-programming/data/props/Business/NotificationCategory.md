# Pola i właściwości klasy biznesowej: `Soneta.Business.NotificationCategory`
Nazwa tabeli: `NotifiCategories`
Tytuł: NotificationCategory
Opis: Kategoria grupująca powiadomienia systemowe. Określa nazwę, opis i ikonę kategorii wyświetlanej w interfejsie użytkownika.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Description | `MemoText` | bazodanowe, podlista | Opis |  |
| IconItem | `IconLookupTools.IconItem` |  | Ikona |  |
| IconName | `string` | bazodanowe | Ikona | Nazwa wyświetlanej ikony |
| Name | `string` | bazodanowe | Nazwa |  |
