# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DzienKalendarzaHistoria`
Nazwa tabeli: `DniKalendHist`
Opis: Element szczegółowy dokumentu aktualizacji kalendarza (IDokumentAktualizacjiKalendarza). Historyczny zapis dnia kalendarza powiązany ze źródłem planu, przechowujący definicję dnia, normę czasu pracy oraz datę aktualizacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `DokumentAktualizacji` → `IDokumentAktualizacjiKalendarza`

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.Time` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DataAktualizacji | `System.DateTime` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaDnia` | bazodanowe |  |  |
| DokumentAktualizacji | `Soneta.Kalend.IDokumentAktualizacjiKalendarza` | bazodanowe, guided-parent, iface-ref |  |  |
| DzienPo | `Soneta.Kalend.IStrefowy` |  |  |  |
| Lp | `int` | bazodanowe |  |  |
| OdGodziny | `Soneta.Types.Time` |  | Od |  |
| Praca | `Soneta.Kalend.CzasPracy` | bazodanowe |  |  |
| Praca.Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Soneta.Types.Time` |  |  |  |
| Praca.OdGodziny | `Soneta.Types.Time` | bazodanowe |  |  |
| RuchomyCzasPracy | `bool` |  |  |  |
| Strefy | `Soneta.Business.SubTable<Soneta.Kalend.StrefaKalendarzaHistoria>` |  |  |  |
| TolerancjaWe | `Soneta.Types.Time` | bazodanowe |  |  |
| ZrodloPlanu | `Soneta.Kalend.IZrodloPlanu` | bazodanowe, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| DokumentAktualizacji | `IDokumentAktualizacjiKalendarza` | `DokumentAktualizacjiKalendarza`, `PUEDokumentEZLA`, `RozliczenieCzasuPracy`, `WniosekPracyZdalnej`, `WniosekUrlopowy` |
| ZrodloPlanu | `IZrodloPlanu` | `Pracownik`, `Umowa`, `UmowaZewnetrzna` |
