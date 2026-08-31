# Pola i właściwości klasy biznesowej: `Soneta.Handel.DaneEUDR`
Nazwa tabeli: `DanePozEUDR`
Tytuł: Dane pozycji dokumentów EUDR
Opis: Dane dotyczące zgodności z rozporządzeniem o wylesianiu (EUDR). Zawiera szczegóły o numerze weryfikacyjnym produktów oraz statusie weryfikacji due diligence.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DDS | `string` | bazodanowe | DDS | Oświadczenie o należytej staranności. |
| Host | `Soneta.Handel.IDaneEUDRHost` | bazodanowe, tylko-odczyt | Host |  |
| NumerWeryfikacyjny | `string` | bazodanowe | Numer weryfikacyjny |  |
