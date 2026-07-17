# Pola i właściwości klasy biznesowej: `Soneta.Core.OddzialFirmyRef`
Nazwa tabeli: `OddzialyFirmyRef`
Tytuł: Zmiany oddziałów nadrzędnych
Opis: Element szczegółowy oddziału firmy (OddzialFirmy). Przechowuje historię zmian podległości oddziału - rejestruje kolejne przypisania do oddziału nadrzędnego z okresem obowiązywania.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Oddzial` → `OddzialFirmy`
Implementuje interfejsy: `IMetrykaOddziałuFirmyHost`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Soneta.Types.FromTo` | bazodanowe |  |  |
| EfektywnyOkres | `Soneta.Types.FromTo` |  |  |  |
| Nadrzedny | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe, guided-parent |  |  |
| Przyczyna | `string` |  |  |  |
