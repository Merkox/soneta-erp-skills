# Pola i właściwości klasy biznesowej: `Soneta.Kadry.CzynnikSzkodliwyPracownika`
Nazwa tabeli: `CzynnSzkodPrac`
Tytuł: Czynniki szkodliwe pracownika
Opis: Przypisanie czynnika szkodliwego do pracownika z oznaczeniem okresu narażenia. Służy do ewidencji warunków pracy pracownika na potrzeby BHP, medycyny pracy i sprawozdawczości.
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
| DefinicjaCzynnikowSzkodliwych | `Soneta.Kadry.DefinicjaCzynnikowSzkodliwych` | bazodanowe | Definicja czynników szkodliwych |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
