# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.StnPracSrTrwalyRel`
Nazwa tabeli: `StnPracSrTrwRel`
Tytuł: Relacje stanowisk do środków trwałych
Opis: Tabela powiązań stanowisk pracy ze środkami trwałymi i wyposażeniem. Umożliwia ewidencję sprzętu przypisanego do konkretnego stanowiska z określeniem ilości, np. monitor, biurko, krzesło.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Ilosc | `int` | bazodanowe | Ilość |  |
| SrodekTrwaly | `Soneta.SrodkiTrwale.SrodekTrwalyBase` | bazodanowe |  |  |
| StanowiskoPracy | `Soneta.RealEstate.Models.Database.StanowiskoPracy` | bazodanowe |  |  |
