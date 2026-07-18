# Pola i właściwości klasy biznesowej: `Soneta.CRM.KthDzialalnKod`
Nazwa tabeli: `KthDzialalnKody`
Tytuł: Wykaz działalności kontrahentów
Opis: Przypisanie kodów PKD do kontrahenta. Umożliwia rejestrację wszystkich kodów działalności kontrahenta pobranych z rejestru REGON, z oznaczeniem kodu przeważającego.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DzialalnoscKod | `Soneta.CRM.DzialalnoscKod` | bazodanowe |  |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
| Przewazajace | `bool` | bazodanowe | Przeważające | Informuje czy dane pkd jest przeważające |
