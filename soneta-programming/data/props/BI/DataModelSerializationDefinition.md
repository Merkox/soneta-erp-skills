# Pola i właściwości klasy biznesowej: `Soneta.BI.DataModelSerializationDefinition`
Nazwa tabeli: `SerialModelDefs`
Tytuł: Definicja serializatora modeli danych
Opis: Definicja serializatora powiązanego bezpośrednio z modelem danych BI. Określa tabelę docelową, do której utrwalane są wyniki modelu analitycznego, oraz listę baz danych objętych procesem serializacji w trybie wielobazowym.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DBItemsText | `MemoText` | bazodanowe, podlista | Bazy danych |  |
| Model | `Soneta.BI.DataModel` | bazodanowe | Model danych |  |
| Name | `string` | bazodanowe | Nazwa |  |
| SerializationTable | `Soneta.BI.TableDefinition` | bazodanowe | Definicja tabeli |  |
