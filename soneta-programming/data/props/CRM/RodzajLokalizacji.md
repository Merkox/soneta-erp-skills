# Pola i właściwości klasy biznesowej: `Soneta.CRM.RodzajLokalizacji`
Nazwa tabeli: `RodzajeLok`
Tytuł: Rodzaje lokalizacji
Opis: Przypisanie rodzaju (typu) do lokalizacji kontrahenta, np. magazyn, biuro, punkt odbioru. Umożliwia klasyfikację lokalizacji według słownikowych rodzajów oraz oznaczenie rodzaju domyślnego.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Domyslny | `bool` | bazodanowe | Domyślny | Wskazuje na domyślny rodzaj w ramach kontrahenta. |
| Lokalizacja | `Soneta.CRM.Lokalizacja` | bazodanowe | Lokalizacja | Lokalizacja |
| Rodzaj | `Soneta.Core.SlownikElem` | bazodanowe | Rodzaj | Rodzaj lokalizacji |
