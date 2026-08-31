# Pola i właściwości klasy biznesowej: `Soneta.Business.FeatureSetRelation`
Nazwa tabeli: `FSRels`
Tytuł: Powiązania obiektów z definicjami zestawów pól
Opis: Powiązanie konkretnego obiektu biznesowego z definicją zestawu pól. Umożliwia przypisanie zestawu cech do wybranego obiektu nadrzędnego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `FeatureSetDefinition` → `FeatureSetDefinition`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| FeatureSetDefinition | `FeatureSetDefinition` | bazodanowe, guided-parent | Definicja zestawu pól | Definicja zestawu pól |
| Host | `Db.IFeatureSetRelationHost` | bazodanowe, tylko-odczyt | Obiekt nadrzędny | Obiekt, do którego przypisana jest definicja zestawu pól |
