# Pola i właściwości klasy biznesowej: `Soneta.Kalend.PozycjaAktualizacjiCzasu`
Nazwa tabeli: `PozAktCzasu`
Tytuł: Źródła kalendarza na dokumentach aktualizacji kalendarzy
Opis: Pozycja aktualizacji ewidencji czasu pracy na dokumencie aktualizacji kalendarza. Łączy źródło planu (pracownika/umowę) z dokumentem aktualizacji, umożliwiając śledzenie zmian w ewidencji czasu pracy.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 2
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktualizacjeCzasu | `SubTable<Soneta.Kalend.DzienPracyAktualizacja>` | podlista |  |  |
| Dokument | `Soneta.Kalend.DokumentAktualizacjiKalendarza` | bazodanowe, tylko-odczyt |  |  |
| Nazwa | `string` | tylko-odczyt |  |  |
| ObiektyAktualizacji | `SubTable<Soneta.Kalend.PozycjaObiektuAktualizacjiCzasu>` | podlista |  |  |
| ZrodloPlanu | `Soneta.Kalend.IZrodloPlanu` | bazodanowe, tylko-odczyt, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| ZrodloPlanu | `IZrodloPlanu` | `Pracownik`, `Umowa`, `UmowaZewnetrzna` |
