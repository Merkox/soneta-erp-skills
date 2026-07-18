# Pola i właściwości klasy biznesowej: `Soneta.CRM.DefKategKth`
Nazwa tabeli: `DefKategoriiKth`
Tytuł: Definicje kategorii kontrahentów
Opis: Definicja kategorii służącej do klasyfikacji kontrahentów. Umożliwia tworzenie własnych grup kontrahentów, opcjonalnie wyświetlanych jako foldery, co ułatwia filtrowanie i segmentację bazy klientów.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa definicji kategorii |
| Opis | `string` | bazodanowe | Opis | Pole pozwalające dodać krótki opis kategorii, pobierane następnie do Description folderu.  |
| PokazJakoFolder | `bool` | bazodanowe | Pokaż jako folder | Czy definicja będzie wyświetlana jako osobna kategoria w folderze. |
