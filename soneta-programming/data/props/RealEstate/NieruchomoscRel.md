# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.NieruchomoscRel`
Nazwa tabeli: `NieruchomosciRel`
Tytuł: Relacje nieruchomości
Opis: Tabela powiązań między nieruchomościami pozwalająca na definiowanie wzajemnych relacji między obiektami. Umożliwia modelowanie zależności takich jak sąsiedztwo, współdzielenie infrastruktury czy powiązania funkcjonalne między nieruchomościami.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nieruchomosc | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe |  |  |
| NieruchomoscPowiazana | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe |  |  |
