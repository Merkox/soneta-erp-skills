# Pola i właściwości klasy biznesowej: `Soneta.Kadry.DodHistoria`
Nazwa tabeli: `DodHistorie`
Tytuł: Historie dodatków
Opis: Element szczegółowy dodatku (Dodatek). Wersja historyczna dodatku do wynagrodzenia rejestrująca element płacowy, okres obowiązywania, podstawę, ułamek, czas i dane rozliczeniowe (odbiorca, rachunek) w kolejnych okresach aktualności.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dodatek` → `Dodatek`
Historia: Tak — zapis historyczny tabeli `Dodatek`

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 5
- podlisty: 5
- subrowy: 1
- razem: 20

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista |  |  |
| Czas | `Time` | bazodanowe |  |  |
| CzasText | `string` | tylko-odczyt |  |  |
| Dni | `int` | bazodanowe |  |  |
| Dodatek | `Soneta.Kadry.Dodatek` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| EfektywnyOkres | `FromTo` | podlista |  |  |
| Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Parent | `Row` | tylko-odczyt |  |  |
| Podstawa | `Currency` | bazodanowe |  |  |
| PodstawaText | `string` | tylko-odczyt |  |  |
| Procent | `Percent` |  |  |  |
| ProcentText | `string` | tylko-odczyt |  |  |
| Rozliczenie | `Soneta.Kadry.RozliczenieDodatku` (subrow) | bazodanowe |  |  |
| Rozliczenie.Odbiorca | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  |  |
| Rozliczenie.RachunekOdbiorcy | `Soneta.Kasa.RachunekBankowyPodmiotu` | bazodanowe |  |  |
| Rozliczenie.WgOdbiorca | `Key` | podlista |  |  |
| Rozliczenie.WgRachunekOdbiorcy | `Key` | podlista |  |  |
| Ulamek | `Fraction` | bazodanowe |  |  |
| Wspolczynnik | `decimal` |  | Współczynnik |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Rozliczenie.Odbiorca | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |
