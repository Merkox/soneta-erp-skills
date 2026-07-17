# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DzienPracyUmowy`
Nazwa tabeli: `DniPracyUmowy`
Tytuł: Dni pracy umowy
Opis: Element szczegółowy umowy z kalendarzem (IUmowaZKalendarzem). Ewidencja pojedynczego dnia pracy w ramach umowy zewnętrznej, zawierająca datę, godziny pracy oraz status zgodności z danymi RCP.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Umowa` → `IUmowaZKalendarzem`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.Time` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| OdGodziny | `Soneta.Types.Time` |  |  |  |
| Praca | `Soneta.Kalend.CzasPracy` | bazodanowe |  |  |
| Praca.Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Soneta.Types.Time` |  |  |  |
| Praca.OdGodziny | `Soneta.Types.Time` | bazodanowe |  |  |
| RcpOK | `bool` | bazodanowe |  | Informacja o stanie rekordu po imporcie z RCP |
| RównoważnyCzasPracy | `bool` |  |  |  |
| Strefy | `Soneta.Business.SubTable<Soneta.Kalend.StrefaPracyUmowy>` |  |  |  |
| Umowa | `Soneta.Kalend.IUmowaZKalendarzem` | bazodanowe, guided-parent, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Umowa | `IUmowaZKalendarzem` | `Umowa`, `UmowaZewnetrzna` |
