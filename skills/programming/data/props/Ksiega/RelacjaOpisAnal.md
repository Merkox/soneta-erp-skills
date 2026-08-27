# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.RelacjaOpisAnal`
Nazwa tabeli: `RelacjeOpisAnal`
Tytuł: Relacje opisu analitycznego
Opis: Definicja typu relacji między opisem analitycznym a zapisem księgowym. Określa symbol relacji i regułę kontroli zgodności wartości, umożliwiając sprawdzanie spójności kwot między opisami analitycznymi a powiązanymi zapisami.
Tabela konfiguracyjna: Tak
Guided: root

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
