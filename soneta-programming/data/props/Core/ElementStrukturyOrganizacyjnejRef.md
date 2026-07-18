# Pola i właściwości klasy biznesowej: `Soneta.Core.ElementStrukturyOrganizacyjnejRef`
Nazwa tabeli: `ElementyStOrgRef`
Tytuł: Zmiany elementów nadrzędnych
Opis: Element szczegółowy elementu struktury organizacyjnej (ElementStrukturyOrganizacyjnej). Rejestruje historię zmian podległości elementu - kolejne przypisania do elementu nadrzędnego z okresem obowiązywania.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Element` → `ElementStrukturyOrganizacyjnej`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista |  |  |
| EfektywnyOkres | `FromTo` | podlista |  |  |
| Element | `Soneta.Core.ElementStrukturyOrganizacyjnej` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Nadrzedny | `Soneta.Core.ElementStrukturyOrganizacyjnej` | bazodanowe, tylko-odczyt |  |  |
