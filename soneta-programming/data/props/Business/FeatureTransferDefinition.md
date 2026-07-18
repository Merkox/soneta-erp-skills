# Pola i właściwości klasy biznesowej: `Soneta.Business.FeatureTransferDefinition`
Nazwa tabeli: `FeatureTrDefs`
Tytuł: Definicje transferu cechy
Opis: Określa reguły przenoszenia wartości cech między powiązanymi obiektami biznesowymi. Umożliwia synchronizację cech z obiektu nadrzędnego na podrzędny.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| FeatureDefinition | `FeatureDefinition` | bazodanowe | Definicja cechy | Definicja cechy |
| Host | `App.IFeatureTransferHost` | bazodanowe, tylko-odczyt |  |  |
| Lp | `int` | bazodanowe |  | Liczba porządkowa definicji transferu cech |
| Synchronize | `bool` | bazodanowe | Synchronizuj | Flaga wskazująca, czy cecha ma być synchronizowana |
| TableName | `string` | bazodanowe, tylko-odczyt | Klasa | Klasa definicji cechy |
