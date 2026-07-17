# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DzienPracyHistoria`
Nazwa tabeli: `DniPracyHist`
Tytuł: Historia dni pracy
Opis: Element szczegółowy dokumentu aktualizacji kalendarza (IDokumentAktualizacjiKalendarza). Historyczny zapis dnia ewidencji czasu pracy powiązany ze źródłem planu, przechowujący datę, godziny pracy, status RCP oraz datę aktualizacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `DokumentAktualizacji` → `IDokumentAktualizacjiKalendarza`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.Time` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DataAktualizacji | `System.DateTime` | bazodanowe |  |  |
| DokumentAktualizacji | `Soneta.Kalend.IDokumentAktualizacjiKalendarza` | bazodanowe, guided-parent, iface-ref |  |  |
| DzienPo | `Soneta.Kalend.IStrefowy` |  |  |  |
| Lp | `int` | bazodanowe |  |  |
| OdGodziny | `Soneta.Types.Time` |  |  |  |
| Praca | `Soneta.Kalend.CzasPracy` | bazodanowe |  |  |
| Praca.Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Soneta.Types.Time` |  |  |  |
| Praca.OdGodziny | `Soneta.Types.Time` | bazodanowe |  |  |
| RcpOK | `bool` | bazodanowe |  |  |
| Strefy | `Soneta.Business.SubTable<Soneta.Kalend.StrefaPracyHistoria>` |  |  |  |
| ZrodloPlanu | `Soneta.Kalend.IZrodloPlanu` | bazodanowe, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| DokumentAktualizacji | `IDokumentAktualizacjiKalendarza` | `DokumentAktualizacjiKalendarza`, `PUEDokumentEZLA`, `RozliczenieCzasuPracy`, `WniosekPracyZdalnej`, `WniosekUrlopowy` |
| ZrodloPlanu | `IZrodloPlanu` | `Pracownik`, `Umowa`, `UmowaZewnetrzna` |
