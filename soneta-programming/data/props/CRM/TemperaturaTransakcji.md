# Pola i właściwości klasy biznesowej: `Soneta.CRM.Config.TemperaturaTransakcji`
Nazwa tabeli: `TempTran`
Tytuł: Temperatury transakcji
Opis: Element szczegółowy definicji transakcji CRM (TemperaturaTransakcji). Definiuje poziomy gotowości transakcji do zamknięcia (np. zimna, ciepła, gorąca) w ramach definicji, wspierając ocenę szans sprzedażowych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Zablokowany | Określa zablokowanie wpisu. Zablokowane wpisy nie będą wyświetlane w liście wyboru temperatury. |
| Definicja | `Soneta.CRM.Config.DefTransakcja` | bazodanowe, tylko-odczyt |  | Definicja transakcji, do której jest przypisana temperatura |
| Kod | `string` | tylko-odczyt |  |  |
| Kolor | `string` | bazodanowe | Kolor | Kolor dla temperatury |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa temperatury w ramach transakcji. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa temperatury transakcji |
