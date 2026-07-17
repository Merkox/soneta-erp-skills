# Pola i właściwości klasy biznesowej: `Soneta.Business.NotificationCategory`
Nazwa tabeli: `NotifiCategories`
Tytuł: NotificationCategory
Opis: Kategoria grupująca powiadomienia systemowe. Określa nazwę, opis i ikonę kategorii wyświetlanej w interfejsie użytkownika.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Description | `Soneta.Business.MemoText` | bazodanowe | Opis |  |
| IconItem | `Soneta.Business.IconLookupTools.IconItem` |  | Ikona |  |
| IconName | `string` | bazodanowe | Ikona | Nazwa wyświetlanej ikony |
| Name | `string` | bazodanowe | Nazwa |  |
