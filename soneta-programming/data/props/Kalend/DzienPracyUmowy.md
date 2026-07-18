# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DzienPracyUmowy`
Nazwa tabeli: `DniPracyUmowy`
Tytuł: Dni pracy umowy
Opis: Element szczegółowy umowy z kalendarzem (IUmowaZKalendarzem). Ewidencja pojedynczego dnia pracy w ramach umowy zewnętrznej, zawierająca datę, godziny pracy oraz status zgodności z danymi RCP.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Umowa` → `IUmowaZKalendarzem`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 5
- podlisty: 1
- subrowy: 1
- razem: 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Time` | tylko-odczyt |  |  |
| Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| OdGodziny | `Time` | tylko-odczyt |  |  |
| Praca | `Soneta.Kalend.CzasPracy` (subrow) | bazodanowe |  |  |
| Praca.Czas | `Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Time` |  |  |  |
| Praca.OdGodziny | `Time` | bazodanowe |  |  |
| RcpOK | `bool` | bazodanowe |  | Informacja o stanie rekordu po imporcie z RCP |
| RównoważnyCzasPracy | `bool` | tylko-odczyt |  |  |
| Strefy | `SubTable<Soneta.Kalend.StrefaPracyUmowy>` | podlista |  |  |
| Umowa | `Soneta.Kalend.IUmowaZKalendarzem` | bazodanowe, tylko-odczyt, guided-parent, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Umowa | `IUmowaZKalendarzem` | `Umowa`, `UmowaZewnetrzna` |
