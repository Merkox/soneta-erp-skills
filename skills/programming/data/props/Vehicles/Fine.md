# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.Fine`
Nazwa tabeli: `Fines`
Tytuł: Mandaty
Opis: Rejestr mandatów drogowych przypisanych do pojazdów floty. Przechowuje dane o dacie, kwocie, punktach karnych, kierowcy ukaranym mandatem oraz opcjonalnym powiązaniu z konkretnym przejazdem (rezerwacją).
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Amount | `Currency` | bazodanowe | Kwota | Kwota mandatu |
| Date | `System.DateTime` | bazodanowe | Data | Kiedy otrzymano mandat |
| Driver | `IRezerwujacy` | bazodanowe | Kierowca | Kierowca ukarany mandatem |
| Points | `int` | bazodanowe | Punkty karne | Ilość punktów karnych |
| Trip | `Soneta.Vehicles.Reservation` | bazodanowe | Przejazd | Przejazd na którym zarejestrowano mandat |
| Vehicle | `Soneta.Samochodowka.Pojazd` | bazodanowe, tylko-odczyt | Pojazd |  |
