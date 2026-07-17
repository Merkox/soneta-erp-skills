# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.UslugaZdarzenia`
Nazwa tabeli: `UslugiZdarzenia`
Tytuł: Usługi zdarzenia
Opis: Pozycje usługowe przypisane do zdarzeń nieruchomości (zadań CRM). Przechowuje informacje o usługach, stawkach i ilościach związanych z realizacją konkretnego zdarzenia, np. prac serwisowych czy przeglądów.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Ilosc | `double` | bazodanowe |  |  |
| Stawka | `Soneta.Types.Currency` | bazodanowe |  |  |
| Usluga | `Soneta.Towary.Towar` | bazodanowe | Usługa |  |
| Zadanie | `Soneta.Zadania.Zadanie` | bazodanowe |  |  |
