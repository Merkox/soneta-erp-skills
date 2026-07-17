# Pola i właściwości klasy biznesowej: `Soneta.Oceny.ArkuszOdpowiedz`
Nazwa tabeli: `ArkuszeOdp`
Opis: Odpowiedź zaznaczona w pozycji arkusza oceny przy skalach wielowyborowych. Rejestruje poszczególne zaznaczenia elementów skali przez oceniającego, umożliwiając wybór wielu wartości dla jednego kryterium.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Ocena | `Soneta.Oceny.ElementSkaliOcen` | bazodanowe |  |  |
| PozycjaArkusza | `Soneta.Oceny.OcenaPozycjaArkusza` | bazodanowe |  |  |
