# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.StnPracSrTrwalyRel`
Nazwa tabeli: `StnPracSrTrwRel`
Tytuł: Relacje stanowisk do środków trwałych
Opis: Tabela powiązań stanowisk pracy ze środkami trwałymi i wyposażeniem. Umożliwia ewidencję sprzętu przypisanego do konkretnego stanowiska z określeniem ilości, np. monitor, biurko, krzesło.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Ilosc | `int` | bazodanowe | Ilość |  |
| SrodekTrwaly | `Soneta.SrodkiTrwale.SrodekTrwalyBase` | bazodanowe |  |  |
| StanowiskoPracy | `Soneta.RealEstate.Models.Database.StanowiskoPracy` | bazodanowe |  |  |
