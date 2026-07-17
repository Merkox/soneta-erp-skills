# Pola i właściwości klasy biznesowej: `Soneta.CRM.Config.PriorytetLeada`
Nazwa tabeli: `PriorytetyLeadow`
Tytuł: Priorytety leadów
Opis: Element szczegółowy definicji leada CRM (PriorytetLeada). Definiuje poziomy ważności leadów (np. niski, średni, wysoki) w ramach definicji, umożliwiając priorytetyzację działań sprzedażowych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Zablokowany | Określa zablokowanie stanu. Zablokowane stany nie będą wyświetlane w liście wyboru. |
| Definicja | `Soneta.CRM.Config.DefLeada` | bazodanowe |  | Definicja leada, do której jest przypisany jest priorytet |
| Kod | `string` |  |  |  |
| Kolor | `string` | bazodanowe | Kolor | Kolor stanu |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa priorytetu w ramach leada. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa priorytetu leada |
