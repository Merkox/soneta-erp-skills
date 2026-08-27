# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Wartosciowanie.Konfiguracja.KryteriumAnalityczne`
Nazwa tabeli: `ZklKrytAnality`
Tytuł: Kryteria analityczne
Opis: Zawiera kryteria analityczne służące do szczegółowego grupowania wartościowania  stanowisk. Umożliwia rozbicie grupowanie pozycji.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| KryteriumSyntetyczne | `Soneta.HR.ZKL.Wartosciowanie.Konfiguracja.KryteriumSyntetyczne` | bazodanowe, tylko-odczyt | Kryterium syntetyczne |  |
| Nazwa | `string` | tylko-odczyt |  |  |
| PozycjaKonfiguratora | `Soneta.HR.IPozycjaKonfiguratora` | bazodanowe, iface-ref | Pozycja konfiguratora |  |
| Slownik | `Soneta.HR.IZklSlownik` |  |  |  |
| SlownikType | `string` | bazodanowe, tylko-odczyt |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| PozycjaKonfiguratora | `IPozycjaKonfiguratora` | `DefinicjaSzkolenia`, `DefinicjaSzkoleniaBHP`, `DefinicjaUprawnienia`, `KompetencjaMerytoryczna`, `KompetencjaUniwersalna`, `Odpowiedzialnosc` |
