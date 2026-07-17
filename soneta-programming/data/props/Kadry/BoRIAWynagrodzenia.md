# Pola i właściwości klasy biznesowej: `Soneta.Kadry.BoRIAWynagrodzenia`
Nazwa tabeli: `BosRIAWynagrodz`
Tytuł: Bilansy otwarcia RIA - wynagrodzenia
Opis: Bilans otwarcia rocznej informacji o zatrudnieniu (RIA) w zakresie wynagrodzeń. Rejestruje podstawy składek emerytalnych, rentowych i wypadkowych za dany rok, wymagane przy sporządzaniu informacji ZUS RIA.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe |  |  |
| EmerytalnoRentowe | `decimal` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Rok | `int` | bazodanowe |  |  |
| Wypadkowe | `decimal` | bazodanowe |  |  |
| ZaOkrZasilkow | `decimal` | bazodanowe |  |  |
| ZaRok | `int` | bazodanowe |  |  |
| Zatwierdzony | `bool` |  |  |  |
