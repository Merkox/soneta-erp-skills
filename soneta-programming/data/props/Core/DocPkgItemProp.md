# Pola i właściwości klasy biznesowej: `Soneta.Core.DocPkgItemProp`
Nazwa tabeli: `DocPkgItemProps`
Opis: Tabela przechowuje właściwości elementów paczek dokumentów. Każdy wpis identyfikuje obiekt programu przez GUID i typ tabeli, umożliwiając rozszerzanie metadanych pozycji paczki o dodatkowe powiązania.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ItemGuid | `System.Guid` | bazodanowe | Identyfikator obiektu programu | Wskazanie na obiekt programu |
| ItemTable | `string` | bazodanowe | Typ obiektu programu | Typ obiektu programu |
