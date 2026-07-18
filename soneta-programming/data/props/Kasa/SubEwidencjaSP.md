# Pola i właściwości klasy biznesowej: `Soneta.Kasa.SubEwidencjaSP`
Nazwa tabeli: `SubEwidencjeSP`
Tytuł: Subewidencje
Opis: Powiązanie ewidencji nadrzędnej z podrzędną dla danego sposobu zapłaty. Umożliwia automatyczne przekierowanie operacji kasowych do właściwej subewidencji na podstawie wybranego sposobu zapłaty, np. oddzielenie operacji kartowych od gotówkowych.
Tabela konfiguracyjna: Tak

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nadrzedna | `Soneta.Kasa.EwidencjaSP` | bazodanowe, tylko-odczyt | Nadrzędna |  |
| Podrzedna | `Soneta.Kasa.EwidencjaSP` | bazodanowe | Podrzędna |  |
| SposobZaplaty | `Soneta.Kasa.SposobZaplaty` | bazodanowe | Sposób zapłaty |  |
