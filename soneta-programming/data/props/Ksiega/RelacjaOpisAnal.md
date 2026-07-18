# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.RelacjaOpisAnal`
Nazwa tabeli: `RelacjeOpisAnal`
Tytuł: Relacje opisu analitycznego
Opis: Definicja typu relacji między opisem analitycznym a zapisem księgowym. Określa symbol relacji i regułę kontroli zgodności wartości, umożliwiając sprawdzanie spójności kwot między opisami analitycznymi a powiązanymi zapisami.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| KontrolaZgodnosciWartosci | `Soneta.Ksiega.KontrolaZgodnosciWartosci` (enum) | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KontrolaZgodnosciWartosci (`Soneta.Ksiega.KontrolaZgodnosciWartosci`)
- `KontrolaZgodnosciWartosci` = 0 — Kontrola zgodności wartości
- `KontrolaZgodnosciWartosciBezwzględnych` = 10 — Kontrola zgodności wartości bezwzględnych
