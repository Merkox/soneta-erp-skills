# Pola i właściwości klasy biznesowej: `Soneta.CRM.KontrahentOddzialInfo`
Nazwa tabeli: `KontrahOddzial`
Tytuł: Oddział kontrahenta
Opis: Indywidualne parametry handlowe kontrahenta w rozbiciu na oddziały firmy. Umożliwia zdefiniowanie odrębnego sposobu zapłaty i terminu płatności dla tego samego kontrahenta w zależności od oddziału, z którym prowadzi współpracę.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe |  | Indywidualne parametry kontrahenta dla oddziałów. |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| SposobZaplaty | `Soneta.Kasa.FormaPlatnosci` | bazodanowe |  | Sposób zapłaty dla kontrahenta w oddziale. |
| Termin | `int` | bazodanowe |  | Termin płatności dla kontrahenta w oddziale wyrażony w dniach. |
