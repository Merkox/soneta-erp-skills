# Pola i właściwości klasy biznesowej: `Soneta.HR2.KartaRealizacjiCelu`
Nazwa tabeli: `KartyReazCelPrac`
Tytuł: Karty realizacji celu
Opis: Karta realizacji celów okresowych pracownika na określony dzień. Grupuje oceny realizacji poszczególnych celów, stanowiąc dokument podsumowujący wyniki pracy za dany okres.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 1
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Realizacje | `SubTable<Soneta.HR2.RealizacjaCelu>` | podlista |  |  |
