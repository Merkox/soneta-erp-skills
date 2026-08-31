# Pola i właściwości klasy biznesowej: `Soneta.Kadry.ZajęcieKomornicze`
Nazwa tabeli: `ZajKomornicze`
Tytuł: Zajęcia wynagrodzeń
Opis: Zajęcie komornicze wynagrodzenia pracownika. Rejestruje numer sprawy, rodzaj zajęcia (alimentacyjne, niealimentacyjne), element płacowy do potrącenia, kwotę spłaty, priorytet oraz dane rachunku komornika.
Tabela konfiguracyjna: Nie
Guided: root
Historyczna: Tak — wersje (historia) w tabeli `ZajęcieKomorniczeHistoria`
Implementuje interfejsy: `IBazaZrodlaWyplaty`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anulowane | `bool` | bazodanowe, tylko-odczyt |  |  |
| Data | `Date` | bazodanowe |  |  |
| DataSplaty | `Date` | bazodanowe | Data spłaty |  |
| Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Elementy | `SubTable<Soneta.Place.WypElement>` | podlista |  |  |
| ElementyAktywne | `System.Collections.Generic.ICollection<Soneta.Place.WypElement>` | podlista |  |  |
| Historia | `HistorySubTable<Soneta.Kadry.ZajęcieKomorniczeHistoria>` | podlista |  |  |
| Korekty | `SubTable<Soneta.Kadry.KorektaZajęciaKomorniczego>` | podlista |  |  |
| Last | `Soneta.Kadry.ZajęcieKomorniczeHistoria` | tylko-odczyt |  |  |
| NumerSprawy | `string` | bazodanowe |  |  |
| Okres | `FromTo` | podlista |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| OpisPrzelewu | `string` | bazodanowe |  |  |
| Pozostało | `Currency` | tylko-odczyt |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| Rodzaj | `Soneta.Kadry.RodzajeZajęciaWynagrodzenia` (enum) | bazodanowe |  |  |
| Rozliczenie | `Soneta.Kadry.RozliczenieDodatku` (subrow) | bazodanowe |  |  |
| Rozliczenie.Odbiorca | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  |  |
| Rozliczenie.RachunekOdbiorcy | `Soneta.Kasa.RachunekBankowyPodmiotu` | bazodanowe |  |  |
| Rozliczenie.WgOdbiorca | `Key` | podlista |  |  |
| Rozliczenie.WgRachunekOdbiorcy | `Key` | podlista |  |  |
| Splacono | `Currency` | bazodanowe, tylko-odczyt | Spłacono |  |
| SplataZakonczona | `bool` | bazodanowe | Spłata zakończona |  |
| Stan | `Soneta.Kadry.ZajęcieKomornicze.StanyZajęciaWynagrodzenia` (enum) | tylko-odczyt |  |  |
| SąAktywneElementy | `bool` | tylko-odczyt |  |  |
| _Element | `Soneta.Place.DefinicjaElementu` |  |  |  |
| _Komornik | `Soneta.CRM.Kontrahent` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Rozliczenie.Odbiorca | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajeZajęciaWynagrodzenia (`Soneta.Kadry.RodzajeZajęciaWynagrodzenia`)
- `Kwota` = 0
- `KwotaMiesięczna` = 1

### StanyZajęciaWynagrodzenia (`Soneta.Kadry.ZajęcieKomornicze.StanyZajęciaWynagrodzenia`)
- `Wprowadzone` = 0 — Wprowadzone
- `Anulowane` = 1
