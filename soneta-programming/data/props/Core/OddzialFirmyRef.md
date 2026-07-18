# Pola i właściwości klasy biznesowej: `Soneta.Core.OddzialFirmyRef`
Nazwa tabeli: `OddzialyFirmyRef`
Tytuł: Zmiany oddziałów nadrzędnych
Opis: Element szczegółowy oddziału firmy (OddzialFirmy). Przechowuje historię zmian podległości oddziału - rejestruje kolejne przypisania do oddziału nadrzędnego z okresem obowiązywania.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Oddzial` → `OddzialFirmy`
Implementuje interfejsy: `IMetrykaOddziałuFirmyHost`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista |  |  |
| EfektywnyOkres | `FromTo` | podlista |  |  |
| Nadrzedny | `Soneta.Core.OddzialFirmy` | bazodanowe, tylko-odczyt |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Przyczyna | `string` |  |  |  |
