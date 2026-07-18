# Pola i właściwości klasy biznesowej: `Soneta.Core.ElementStrukturyOrganizacyjnejRef`
Nazwa tabeli: `ElementyStOrgRef`
Tytuł: Zmiany elementów nadrzędnych
Opis: Element szczegółowy elementu struktury organizacyjnej (ElementStrukturyOrganizacyjnej). Rejestruje historię zmian podległości elementu - kolejne przypisania do elementu nadrzędnego z okresem obowiązywania.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Element` → `ElementStrukturyOrganizacyjnej`

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 2
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista |  |  |
| EfektywnyOkres | `FromTo` | podlista |  |  |
| Element | `Soneta.Core.ElementStrukturyOrganizacyjnej` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Nadrzedny | `Soneta.Core.ElementStrukturyOrganizacyjnej` | bazodanowe, tylko-odczyt |  |  |
