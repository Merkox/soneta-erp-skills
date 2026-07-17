# Pola i właściwości klasy biznesowej: `Soneta.Handel.DaneEUDR`
Nazwa tabeli: `DanePozEUDR`
Tytuł: Dane pozycji dokumentów EUDR
Opis: Dane dotyczące zgodności z rozporządzeniem o wylesianiu (EUDR). Zawiera szczegóły o numerze weryfikacyjnym produktów oraz statusie weryfikacji due diligence.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DDS | `string` | bazodanowe | DDS | Oświadczenie o należytej staranności. |
| Host | `Soneta.Handel.IDaneEUDRHost` | bazodanowe | Host |  |
| NumerWeryfikacyjny | `string` | bazodanowe | Numer weryfikacyjny |  |
