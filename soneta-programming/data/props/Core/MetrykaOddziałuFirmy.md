# Pola i właściwości klasy biznesowej: `Soneta.Core.MetrykaOddziałuFirmy`
Nazwa tabeli: `MetrykiOddzFirmy`
Tytuł: Przyczyny zmiany danych oddziałów firmy
Opis: Element szczegółowy oddziału firmy (OddzialFirmy). Rejestruje metrykę zmian danych oddziału - przechowuje datę zmiany, przyczynę oraz powiązanie z rekordem historycznym, którego zmiana dotyczy.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Oddzial` → `OddzialFirmy`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe | Data zmiany |  |
| Host | `Soneta.Core.IMetrykaOddziałuFirmyHost` | bazodanowe, iface-ref |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe, guided-parent |  |  |
| Przyczyna | `string` | bazodanowe | Przyczyna zmiany |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IMetrykaOddziałuFirmyHost` | `OddzialFirmyRef` |
