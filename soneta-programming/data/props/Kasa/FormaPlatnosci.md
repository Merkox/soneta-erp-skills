# Pola i właściwości klasy biznesowej: `Soneta.Kasa.FormaPlatnosci`
Nazwa tabeli: `FormyPlatnosci`
Tytuł: Definicje płatności
Opis: Definicja formy płatności łącząca sposób zapłaty z ewidencją środków pieniężnych i domyślnym terminem. Stosowana jako szablon przy tworzeniu płatności na dokumentach handlowych, określa jak i gdzie ma być regulowane zobowiązanie.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| EwidencjaSP | `Soneta.Kasa.EwidencjaSP` | bazodanowe |  |  |
| KSeFIlosc | `int` | bazodanowe | Ilość | Dane domyślne przenoszone na płatność. Podaje się ilość np. dni, od której liczony jest termin płatności za fakturę (np. 14). |
| KSeFJednostka | `string` | bazodanowe | Jednostka | Dane domyślne przenoszone na płatność. Podaje się jednostkę czasu, w której liczony jest termin płatności za fakturę (np. dzień, tydzień itp.) |
| KSeFZdarzeniePoczatkowe | `string` | bazodanowe | Zdarzenie początkowe | Dane domyślne przenoszone na płatność. Podaje się zdarzenie początkowe, od którego liczony jest termin płatności za fakturę (np. wystawienie faktury). |
| Nazwa | `string` | bazodanowe |  |  |
| SposobZaplaty | `Soneta.Kasa.SposobZaplaty` | bazodanowe |  |  |
| Termin | `int` | bazodanowe |  |  |
