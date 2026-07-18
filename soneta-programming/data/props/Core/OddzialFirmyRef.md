# Pola i właściwości klasy biznesowej: `Soneta.Core.OddzialFirmyRef`
Nazwa tabeli: `OddzialyFirmyRef`
Tytuł: Zmiany oddziałów nadrzędnych
Opis: Element szczegółowy oddziału firmy (OddzialFirmy). Przechowuje historię zmian podległości oddziału - rejestruje kolejne przypisania do oddziału nadrzędnego z okresem obowiązywania.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Oddzial` → `OddzialFirmy`
Implementuje interfejsy: `IMetrykaOddziałuFirmyHost`

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 2
- podlisty: 2
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista |  |  |
| EfektywnyOkres | `FromTo` | podlista |  |  |
| Nadrzedny | `Soneta.Core.OddzialFirmy` | bazodanowe, tylko-odczyt |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Przyczyna | `string` |  |  |  |
