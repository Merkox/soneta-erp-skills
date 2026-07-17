# Pola i właściwości klasy biznesowej: `Soneta.BI.SerializationViewRange`
Nazwa tabeli: `SerialViewRanges`
Tytuł: Zakresy utrwalania list
Opis: Zakres czasowy i filtrujący dla procesu utrwalania listy. Powiązany z definicją utrwalania (SerializationViewDefinition), przechowuje datę uruchomienia, nazwę zakresu oraz warunki filtrowania danych przy serializacji widoku.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Date | `System.DateTime` | bazodanowe | Data utrwalania | Data i godzina rozpoczęcia utrwalania. |
| Definition | `Soneta.BI.SerializationViewDefinition` | bazodanowe |  | Definicja utrwalania listy dla danego zakresu |
| FilterText | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Name | `string` | bazodanowe | Nazwa zakresu |  |
