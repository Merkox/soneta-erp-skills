# Pola i właściwości klasy biznesowej: `Soneta.Kalend.PozycjaAktualizacjiCzasu`
Nazwa tabeli: `PozAktCzasu`
Tytuł: Źródła kalendarza na dokumentach aktualizacji kalendarzy
Opis: Pozycja aktualizacji ewidencji czasu pracy na dokumencie aktualizacji kalendarza. Łączy źródło planu (pracownika/umowę) z dokumentem aktualizacji, umożliwiając śledzenie zmian w ewidencji czasu pracy.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktualizacjeCzasu | `Soneta.Business.SubTable<Soneta.Kalend.DzienPracyAktualizacja>` |  |  |  |
| Dokument | `Soneta.Kalend.DokumentAktualizacjiKalendarza` | bazodanowe |  |  |
| Nazwa | `string` |  |  |  |
| ObiektyAktualizacji | `Soneta.Business.SubTable<Soneta.Kalend.PozycjaObiektuAktualizacjiCzasu>` |  |  |  |
| ZrodloPlanu | `Soneta.Kalend.IZrodloPlanu` | bazodanowe, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| ZrodloPlanu | `IZrodloPlanu` | `Pracownik`, `Umowa`, `UmowaZewnetrzna` |
