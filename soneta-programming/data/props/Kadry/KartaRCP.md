# Pola i właściwości klasy biznesowej: `Soneta.Kadry.KartaRCP`
Nazwa tabeli: `KartyRCP`
Tytuł: Karty RCP
Opis: Karta rejestracji czasu pracy (RCP) przypisana do pracownika. Zawiera numer karty magnetycznej lub identyfikatora oraz okres jej ważności, wykorzystywana do ewidencji wejść i wyjść z zakładu pracy.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Numer | `string` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
