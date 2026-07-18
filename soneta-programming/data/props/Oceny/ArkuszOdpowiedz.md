# Pola i właściwości klasy biznesowej: `Soneta.Oceny.ArkuszOdpowiedz`
Nazwa tabeli: `ArkuszeOdp`
Opis: Odpowiedź zaznaczona w pozycji arkusza oceny przy skalach wielowyborowych. Rejestruje poszczególne zaznaczenia elementów skali przez oceniającego, umożliwiając wybór wielu wartości dla jednego kryterium.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Ocena | `Soneta.Oceny.ElementSkaliOcen` | bazodanowe, tylko-odczyt |  |  |
| PozycjaArkusza | `Soneta.Oceny.OcenaPozycjaArkusza` | bazodanowe, tylko-odczyt |  |  |
