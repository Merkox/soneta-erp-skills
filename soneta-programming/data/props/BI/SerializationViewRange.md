# Pola i właściwości klasy biznesowej: `Soneta.BI.SerializationViewRange`
Nazwa tabeli: `SerialViewRanges`
Tytuł: Zakresy utrwalania list
Opis: Zakres czasowy i filtrujący dla procesu utrwalania listy. Powiązany z definicją utrwalania (SerializationViewDefinition), przechowuje datę uruchomienia, nazwę zakresu oraz warunki filtrowania danych przy serializacji widoku.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Date | `System.DateTime` | bazodanowe, tylko-odczyt | Data utrwalania | Data i godzina rozpoczęcia utrwalania. |
| Definition | `Soneta.BI.SerializationViewDefinition` | bazodanowe, tylko-odczyt |  | Definicja utrwalania listy dla danego zakresu |
| FilterText | `MemoText` | bazodanowe, podlista |  |  |
| Name | `string` | bazodanowe, tylko-odczyt | Nazwa zakresu |  |
