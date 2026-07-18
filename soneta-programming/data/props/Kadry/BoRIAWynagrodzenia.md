# Pola i właściwości klasy biznesowej: `Soneta.Kadry.BoRIAWynagrodzenia`
Nazwa tabeli: `BosRIAWynagrodz`
Tytuł: Bilansy otwarcia RIA - wynagrodzenia
Opis: Bilans otwarcia rocznej informacji o zatrudnieniu (RIA) w zakresie wynagrodzeń. Rejestruje podstawy składek emerytalnych, rentowych i wypadkowych za dany rok, wymagane przy sporządzaniu informacji ZUS RIA.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe |  |  |
| EmerytalnoRentowe | `decimal` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Rok | `int` | bazodanowe |  |  |
| Wypadkowe | `decimal` | bazodanowe |  |  |
| ZaOkrZasilkow | `decimal` | bazodanowe |  |  |
| ZaRok | `int` | bazodanowe |  |  |
| Zatwierdzony | `bool` |  |  |  |
