# Pola i właściwości klasy biznesowej: `Soneta.Core.JednolityPKRel`
Nazwa tabeli: `JednolitePKRels`
Tytuł: Jednolity PK relacja
Opis: Relacje pomiędzy plikami JPK. Tabela przechowuje informacje powiązań pomiędzy plikami JPK. Wykorzystywana jest do wyświetlenia na pliku nadzrędnym informacji na podstawie jakich podrzędnych powstał plik oraz blokowania usuwania plików podrzędnych.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Child | `Soneta.Core.JednolityPK` | bazodanowe |  |  |
| Parent | `Soneta.Core.JednolityPK` | bazodanowe, tylko-odczyt |  |  |
