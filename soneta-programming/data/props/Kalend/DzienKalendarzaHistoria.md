# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DzienKalendarzaHistoria`
Nazwa tabeli: `DniKalendHist`
Opis: Element szczegółowy dokumentu aktualizacji kalendarza (IDokumentAktualizacjiKalendarza). Historyczny zapis dnia kalendarza powiązany ze źródłem planu, przechowujący definicję dnia, normę czasu pracy oraz datę aktualizacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `DokumentAktualizacji` → `IDokumentAktualizacjiKalendarza`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Time` | tylko-odczyt |  |  |
| Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| DataAktualizacji | `System.DateTime` | bazodanowe, tylko-odczyt |  |  |
| Definicja | `Soneta.Kalend.DefinicjaDnia` | bazodanowe |  |  |
| DokumentAktualizacji | `Soneta.Kalend.IDokumentAktualizacjiKalendarza` | bazodanowe, tylko-odczyt, guided-parent, iface-ref |  |  |
| DzienPo | `Soneta.Kalend.IStrefowy` | tylko-odczyt |  |  |
| Lp | `int` | bazodanowe, tylko-odczyt |  |  |
| OdGodziny | `Time` | tylko-odczyt | Od |  |
| Praca | `Soneta.Kalend.CzasPracy` (subrow) | bazodanowe |  |  |
| Praca.Czas | `Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Time` |  |  |  |
| Praca.OdGodziny | `Time` | bazodanowe |  |  |
| RuchomyCzasPracy | `bool` | tylko-odczyt |  |  |
| Strefy | `SubTable<Soneta.Kalend.StrefaKalendarzaHistoria>` | podlista |  |  |
| TolerancjaWe | `Time` | bazodanowe |  |  |
| ZrodloPlanu | `Soneta.Kalend.IZrodloPlanu` | bazodanowe, tylko-odczyt, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| DokumentAktualizacji | `IDokumentAktualizacjiKalendarza` | `DokumentAktualizacjiKalendarza`, `PUEDokumentEZLA`, `RozliczenieCzasuPracy`, `WniosekPracyZdalnej`, `WniosekUrlopowy` |
| ZrodloPlanu | `IZrodloPlanu` | `Pracownik`, `Umowa`, `UmowaZewnetrzna` |
