# Pola i właściwości klasy biznesowej: `Soneta.Business.FeatureTransferDefinition`
Nazwa tabeli: `FeatureTrDefs`
Tytuł: Definicje transferu cechy
Opis: Określa reguły przenoszenia wartości cech między powiązanymi obiektami biznesowymi. Umożliwia synchronizację cech z obiektu nadrzędnego na podrzędny.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| FeatureDefinition | `Soneta.Business.FeatureDefinition` | bazodanowe | Definicja cechy | Definicja cechy |
| Host | `Soneta.Business.App.IFeatureTransferHost` | bazodanowe |  |  |
| Lp | `int` | bazodanowe |  | Liczba porządkowa definicji transferu cech |
| Synchronize | `bool` | bazodanowe | Synchronizuj | Flaga wskazująca, czy cecha ma być synchronizowana |
| TableName | `string` | bazodanowe | Klasa | Klasa definicji cechy |
