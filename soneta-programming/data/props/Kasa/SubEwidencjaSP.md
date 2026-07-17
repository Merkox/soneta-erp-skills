# Pola i właściwości klasy biznesowej: `Soneta.Kasa.SubEwidencjaSP`
Nazwa tabeli: `SubEwidencjeSP`
Tytuł: Subewidencje
Opis: Powiązanie ewidencji nadrzędnej z podrzędną dla danego sposobu zapłaty. Umożliwia automatyczne przekierowanie operacji kasowych do właściwej subewidencji na podstawie wybranego sposobu zapłaty, np. oddzielenie operacji kartowych od gotówkowych.
Tabela konfiguracyjna: Tak

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nadrzedna | `Soneta.Kasa.EwidencjaSP` | bazodanowe | Nadrzędna |  |
| Podrzedna | `Soneta.Kasa.EwidencjaSP` | bazodanowe | Podrzędna |  |
| SposobZaplaty | `Soneta.Kasa.SposobZaplaty` | bazodanowe | Sposób zapłaty |  |
