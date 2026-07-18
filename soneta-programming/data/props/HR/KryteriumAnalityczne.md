# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Wartosciowanie.Konfiguracja.KryteriumAnalityczne`
Nazwa tabeli: `ZklKrytAnality`
Tytuł: Kryteria analityczne
Opis: Zawiera kryteria analityczne służące do szczegółowego grupowania wartościowania  stanowisk. Umożliwia rozbicie grupowanie pozycji.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 3
- podlisty: 0
- subrowy: 0
- razem: 5

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
