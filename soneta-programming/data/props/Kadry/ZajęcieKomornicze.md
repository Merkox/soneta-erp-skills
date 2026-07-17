# Pola i właściwości klasy biznesowej: `Soneta.Kadry.ZajęcieKomornicze`
Nazwa tabeli: `ZajKomornicze`
Tytuł: Zajęcia wynagrodzeń
Opis: Zajęcie komornicze wynagrodzenia pracownika. Rejestruje numer sprawy, rodzaj zajęcia (alimentacyjne, niealimentacyjne), element płacowy do potrącenia, kwotę spłaty, priorytet oraz dane rachunku komornika.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBazaZrodlaWyplaty`

- pola bazodanowe: 15
- pola kalkulowane (z klas biznesowych): 14

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anulowane | `bool` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DataSplaty | `Soneta.Types.Date` | bazodanowe | Data spłaty |  |
| Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Elementy | `Soneta.Business.SubTable<Soneta.Place.WypElement>` |  |  |  |
| ElementyAktywne | `System.Collections.Generic.ICollection<Soneta.Place.WypElement>` |  |  |  |
| Historia | `Soneta.Business.HistorySubTable<Soneta.Kadry.ZajęcieKomorniczeHistoria>` |  |  |  |
| Korekty | `Soneta.Business.SubTable<Soneta.Kadry.KorektaZajęciaKomorniczego>` |  |  |  |
| Kwota | `Soneta.Types.Currency` |  |  |  |
| Last | `Soneta.Kadry.ZajęcieKomorniczeHistoria` |  |  |  |
| NumerSprawy | `string` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| OpisPrzelewu | `string` | bazodanowe |  |  |
| Pozostało | `Soneta.Types.Currency` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| Rodzaj | `Soneta.Kadry.RodzajeZajęciaWynagrodzenia` | bazodanowe, enum |  |  |
| Rozliczenie | `Soneta.Kadry.RozliczenieDodatku` | bazodanowe |  |  |
| Rozliczenie.Odbiorca | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  |  |
| Rozliczenie.RachunekOdbiorcy | `Soneta.Kasa.RachunekBankowyPodmiotu` | bazodanowe |  |  |
| Rozliczenie.WgOdbiorca | `Soneta.Business.Key` |  |  |  |
| Rozliczenie.WgRachunekOdbiorcy | `Soneta.Business.Key` |  |  |  |
| Splacono | `Soneta.Types.Currency` | bazodanowe | Spłacono |  |
| SplataZakonczona | `bool` | bazodanowe | Spłata zakończona |  |
| Stan | `Soneta.Kadry.ZajęcieKomornicze.StanyZajęciaWynagrodzenia` | enum |  |  |
| SąAktywneElementy | `bool` |  |  |  |
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
