# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Wartosciowanie.Konfiguracja.KryteriumAnalityczne`
Nazwa tabeli: `ZklKrytAnality`
Tytuł: Kryteria analityczne
Opis: Zawiera kryteria analityczne służące do szczegółowego grupowania wartościowania  stanowisk. Umożliwia rozbicie grupowanie pozycji.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| KryteriumSyntetyczne | `Soneta.HR.ZKL.Wartosciowanie.Konfiguracja.KryteriumSyntetyczne` | bazodanowe | Kryterium syntetyczne |  |
| Nazwa | `string` |  |  |  |
| PozycjaKonfiguratora | `Soneta.HR.IPozycjaKonfiguratora` | bazodanowe, iface-ref | Pozycja konfiguratora |  |
| Slownik | `Soneta.HR.IZklSlownik` |  |  |  |
| SlownikType | `string` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| PozycjaKonfiguratora | `IPozycjaKonfiguratora` | `DefinicjaSzkolenia`, `DefinicjaSzkoleniaBHP`, `DefinicjaUprawnienia`, `KompetencjaMerytoryczna`, `KompetencjaUniwersalna`, `Odpowiedzialnosc` |
