# Pola i właściwości klasy biznesowej: `Soneta.BI.SerializationDefinition`
Nazwa tabeli: `SerializeDefs`
Tytuł: Definicja serializatora danych biznesowych
Opis: Definicja serializatora danych biznesowych łącząca zestaw danych z tabelą docelową. Umożliwia utrwalanie (zapis) wyników generowania danych BI do wskazanej tabeli bazodanowej, zapewniając trwałe przechowywanie wyników analiz.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataSet | `Soneta.BI.DataSetDefinition` | bazodanowe | Definicja zestawu danych |  |
| Name | `string` | bazodanowe | Nazwa |  |
| SerializationTable | `Soneta.BI.TableDefinition` | bazodanowe | Definicja tabeli |  |
