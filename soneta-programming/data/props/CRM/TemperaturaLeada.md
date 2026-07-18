# Pola i właściwości klasy biznesowej: `Soneta.CRM.Config.TemperaturaLeada`
Nazwa tabeli: `TempLeadow`
Tytuł: Temperatury leadów
Opis: Element szczegółowy definicji leada CRM (TemperaturaLeada). Definiuje poziomy gotowości leada do zakupu (np. zimny, ciepły, gorący) w ramach definicji, wspierając ocenę szans sprzedażowych.
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
| Definicja | `Soneta.CRM.Config.DefLeada` | bazodanowe, tylko-odczyt |  | Definicja leada, do której jest przypisana jest temperatura |
| Kod | `string` | tylko-odczyt |  |  |
| Kolor | `string` | bazodanowe | Kolor | Kolor temperatury |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa temperatury w ramach leada. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa temperatury leada |
