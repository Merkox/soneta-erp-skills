# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.VehicleService`
Nazwa tabeli: `VehicleServices`
Tytuł: Usługa pojazdu
Opis: Przypisanie usług (towarów) do pojazdów wraz z cenami. Służy do konfiguracji cyklicznych opłat i usług powiązanych z eksploatacją konkretnego pojazdu, np. myjnia, wymiana oleju, parking.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Price | `Currency` | bazodanowe | Cena |  |
| Service | `Soneta.Towary.Towar` | bazodanowe |  |  |
| Vehicle | `Soneta.Samochodowka.Pojazd` | bazodanowe | Pojazd |  |
