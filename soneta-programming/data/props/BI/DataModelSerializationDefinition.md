# Pola i właściwości klasy biznesowej: `Soneta.BI.DataModelSerializationDefinition`
Nazwa tabeli: `SerialModelDefs`
Tytuł: Definicja serializatora modeli danych
Opis: Definicja serializatora powiązanego bezpośrednio z modelem danych BI. Określa tabelę docelową, do której utrwalane są wyniki modelu analitycznego, oraz listę baz danych objętych procesem serializacji w trybie wielobazowym.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DBItemsText | `Soneta.Business.MemoText` | bazodanowe | Bazy danych |  |
| Model | `Soneta.BI.DataModel` | bazodanowe | Model danych |  |
| Name | `string` | bazodanowe | Nazwa |  |
| SerializationTable | `Soneta.BI.TableDefinition` | bazodanowe | Definicja tabeli |  |
