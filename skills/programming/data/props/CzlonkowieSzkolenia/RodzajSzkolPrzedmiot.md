# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.RodzajSzkolPrzedmiot`
Nazwa tabeli: `RdzSzPrzedmioty`
Tytuł: Przedmioty
Opis: Przypisanie przedmiotów do rodzaju szkolenia. Określa program kursu przez wskazanie przedmiotów z liczbą godzin i przypisaniem do modułu szkoleniowego.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| IloscGodzin | `double` | bazodanowe | Liczba godzin | Liczba godzin w ramach całego szkolenia |
| Modul | `Soneta.CzlonkowieSzkolenia.ModulSzkol` | bazodanowe | Moduł szkoleniowy | Moduł z którym powiązany jest przedmiot. |
| PrzedmiotSzkol | `Soneta.CzlonkowieSzkolenia.PrzedmiotSzkol` | bazodanowe |  |  |
| RodzajSzkol | `Soneta.CzlonkowieSzkolenia.RodzajSzkol` | bazodanowe |  |  |
