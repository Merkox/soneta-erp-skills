# Pola i właściwości klasy biznesowej: `Soneta.Kalend.PozycjaAktualizacjiKalendarza`
Nazwa tabeli: `PozAktKalend`
Tytuł: Źródła kalendarza na dokumentach aktualizacji kalendarzy
Opis: Pozycja aktualizacji planu pracy na dokumencie aktualizacji kalendarza. Łączy źródło planu (pracownika/umowę) z dokumentem aktualizacji, umożliwiając śledzenie zmian w kalendarzu planu pracy.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktualizacjeKalendarza | `SubTable<Soneta.Kalend.DzienKalendarzaAktualizacja>` | podlista |  |  |
| Dokument | `Soneta.Kalend.DokumentAktualizacjiKalendarza` | bazodanowe, tylko-odczyt |  |  |
| Nazwa | `string` | tylko-odczyt |  |  |
| ObiektyAktualizacji | `SubTable<Soneta.Kalend.PozycjaObiektuAktualizacjiKalendarza>` | podlista |  |  |
| ZrodloPlanu | `Soneta.Kalend.IZrodloPlanu` | bazodanowe, tylko-odczyt, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| ZrodloPlanu | `IZrodloPlanu` | `Pracownik`, `Umowa`, `UmowaZewnetrzna` |
