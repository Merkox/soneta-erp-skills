# Pola i właściwości klasy biznesowej: `Soneta.Kadry.DodHistoria`
Nazwa tabeli: `DodHistorie`
Tytuł: Historie dodatków
Opis: Element szczegółowy dodatku (Dodatek). Wersja historyczna dodatku do wynagrodzenia rejestrująca element płacowy, okres obowiązywania, podstawę, ułamek, czas i dane rozliczeniowe (odbiorca, rachunek) w kolejnych okresach aktualności.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dodatek` → `Dodatek`

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| CzasText | `string` |  |  |  |
| Dni | `int` | bazodanowe |  |  |
| Dodatek | `Soneta.Kadry.Dodatek` | bazodanowe, guided-parent |  |  |
| EfektywnyOkres | `Soneta.Types.FromTo` |  |  |  |
| Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Parent | `Soneta.Business.Row` |  |  |  |
| Podstawa | `Soneta.Types.Currency` | bazodanowe |  |  |
| PodstawaText | `string` |  |  |  |
| Procent | `Soneta.Types.Percent` |  |  |  |
| ProcentText | `string` |  |  |  |
| Rozliczenie | `Soneta.Kadry.RozliczenieDodatku` | bazodanowe |  |  |
| Rozliczenie.Odbiorca | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  |  |
| Rozliczenie.RachunekOdbiorcy | `Soneta.Kasa.RachunekBankowyPodmiotu` | bazodanowe |  |  |
| Rozliczenie.WgOdbiorca | `Soneta.Business.Key` |  |  |  |
| Rozliczenie.WgRachunekOdbiorcy | `Soneta.Business.Key` |  |  |  |
| Ulamek | `Soneta.Types.Fraction` | bazodanowe |  |  |
| Wspolczynnik | `decimal` |  | Współczynnik |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Rozliczenie.Odbiorca | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |
