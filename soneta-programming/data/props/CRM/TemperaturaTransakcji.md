# Pola i właściwości klasy biznesowej: `Soneta.CRM.Config.TemperaturaTransakcji`
Nazwa tabeli: `TempTran`
Tytuł: Temperatury transakcji
Opis: Element szczegółowy definicji transakcji CRM (TemperaturaTransakcji). Definiuje poziomy gotowości transakcji do zamknięcia (np. zimna, ciepła, gorąca) w ramach definicji, wspierając ocenę szans sprzedażowych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Zablokowany | Określa zablokowanie wpisu. Zablokowane wpisy nie będą wyświetlane w liście wyboru temperatury. |
| Definicja | `Soneta.CRM.Config.DefTransakcja` | bazodanowe |  | Definicja transakcji, do której jest przypisana temperatura |
| Kod | `string` |  |  |  |
| Kolor | `string` | bazodanowe | Kolor | Kolor dla temperatury |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa temperatury w ramach transakcji. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa temperatury transakcji |
