# Pola i właściwości klasy biznesowej: `Soneta.Core.ElementStrukturyOrganizacyjnejRef`
Nazwa tabeli: `ElementyStOrgRef`
Tytuł: Zmiany elementów nadrzędnych
Opis: Element szczegółowy elementu struktury organizacyjnej (ElementStrukturyOrganizacyjnej). Rejestruje historię zmian podległości elementu - kolejne przypisania do elementu nadrzędnego z okresem obowiązywania.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Element` → `ElementStrukturyOrganizacyjnej`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Soneta.Types.FromTo` | bazodanowe |  |  |
| EfektywnyOkres | `Soneta.Types.FromTo` |  |  |  |
| Element | `Soneta.Core.ElementStrukturyOrganizacyjnej` | bazodanowe, guided-parent |  |  |
| Nadrzedny | `Soneta.Core.ElementStrukturyOrganizacyjnej` | bazodanowe |  |  |
