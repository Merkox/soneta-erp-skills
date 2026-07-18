# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.UslugaZdarzenia`
Nazwa tabeli: `UslugiZdarzenia`
Tytuł: Usługi zdarzenia
Opis: Pozycje usługowe przypisane do zdarzeń nieruchomości (zadań CRM). Przechowuje informacje o usługach, stawkach i ilościach związanych z realizacją konkretnego zdarzenia, np. prac serwisowych czy przeglądów.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Ilosc | `double` | bazodanowe |  |  |
| Stawka | `Currency` | bazodanowe |  |  |
| Usluga | `Soneta.Towary.Towar` | bazodanowe | Usługa |  |
| Zadanie | `Soneta.Zadania.Zadanie` | bazodanowe |  |  |
