# Pola i właściwości klasy biznesowej: `Soneta.Core.DefXmlFiltr`
Nazwa tabeli: `DefXmlFiltry`
Tytuł: Filtry dla komunikatów.
Opis: Filtr danych stosowany przy komunikatach XML. Przechowuje wyrażenie filtrujące przypisane do konkretnego operatora i definicji XML dla wskazanej tabeli danych, ograniczając zakres przetwarzanych rekordów.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Core.DefXmlNag` | bazodanowe |  | Definicja, do której przypisano filtr. |
| Filtr | `string` | bazodanowe | Filtr. |  |
| Operator | `App.Operator` | bazodanowe |  | Operator, do którego przypisano filtr. |
| Tabela | `string` | bazodanowe | Tabela danych |  |
