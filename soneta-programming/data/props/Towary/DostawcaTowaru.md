# Pola i właściwości klasy biznesowej: `Soneta.Towary.DostawcaTowaru`
Nazwa tabeli: `DostawcyTowaru`
Tytuł: Dostawcy towaru
Opis: Element szczegółowy towaru (Towar). Przypisuje kontrahenta-dostawcę do towaru z oznaczeniem, czy jest dostawcą domyślnym oraz szacowanym czasem dostawy w dniach. Umożliwia prowadzenie listy zatwierdzonych dostawców towaru i automatyzację generowania zamówień zakupowych.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Towar` → `Towar`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzasDostawy | `int` | bazodanowe | Czas dostawy (dni) | Czas dostawcy (dni). |
| Domyslny | `bool` | bazodanowe | Domyślny | Określa czy dostaca jest domyślny. |
| Dostawca | `Soneta.CRM.Kontrahent` | bazodanowe | Dostawca | Dostawca towaru |
| Towar | `Soneta.Towary.Towar` | bazodanowe, guided-parent | Towar | Towar do którego przypisany jest dostawca |
