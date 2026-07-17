# Pola i właściwości klasy biznesowej: `Soneta.HR2.KartaRealizacjiCelu`
Nazwa tabeli: `KartyReazCelPrac`
Tytuł: Karty realizacji celu
Opis: Karta realizacji celów okresowych pracownika na określony dzień. Grupuje oceny realizacji poszczególnych celów, stanowiąc dokument podsumowujący wyniki pracy za dany okres.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Realizacje | `Soneta.Business.SubTable<Soneta.HR2.RealizacjaCelu>` |  |  |  |
