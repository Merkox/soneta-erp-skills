# Pola i właściwości klasy biznesowej: `Soneta.Core.MetrykaOddziałuFirmy`
Nazwa tabeli: `MetrykiOddzFirmy`
Tytuł: Przyczyny zmiany danych oddziałów firmy
Opis: Element szczegółowy oddziału firmy (OddzialFirmy). Rejestruje metrykę zmian danych oddziału - przechowuje datę zmiany, przyczynę oraz powiązanie z rekordem historycznym, którego zmiana dotyczy.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Oddzial` → `OddzialFirmy`

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe, tylko-odczyt | Data zmiany |  |
| Host | `Soneta.Core.IMetrykaOddziałuFirmyHost` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Przyczyna | `string` | bazodanowe, tylko-odczyt | Przyczyna zmiany |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IMetrykaOddziałuFirmyHost` | `OddzialFirmyRef` |
