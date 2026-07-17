# Pola i właściwości klasy biznesowej: `Soneta.Kadry.KorektaZajęciaKomorniczego`
Nazwa tabeli: `KorektyZajKomor`
Tytuł: Korekty zajęć komorniczych
Opis: Korekta zajęcia komorniczego umożliwiająca zarejestrowanie dodatkowej wpłaty, zwrotu lub zmiany kwoty potrącenia. Zawiera rodzaj korekty, datę, kwotę, element rozliczeniowy oraz numer dokumentu korygującego.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBazaZrodlaWyplaty`

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  | Data korekty |
| Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Elementy | `Soneta.Business.SubTable<Soneta.Place.WypElement>` |  | Elementy wynagrodzenia |  |
| NumerDokumentu | `string` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Informacja o korekcie zajęcia komorniczego |
| OpisPrzelewu | `string` | bazodanowe |  |  |
| Rodzaj | `Soneta.Kadry.RodzajeKorektZajęćKomorniczych` | bazodanowe, enum |  |  |
| Rozliczenie | `Soneta.Kadry.RozliczenieDodatku` | bazodanowe |  |  |
| Rozliczenie.Odbiorca | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  |  |
| Rozliczenie.RachunekOdbiorcy | `Soneta.Kasa.RachunekBankowyPodmiotu` | bazodanowe |  |  |
| Rozliczenie.WgOdbiorca | `Soneta.Business.Key` |  |  |  |
| Rozliczenie.WgRachunekOdbiorcy | `Soneta.Business.Key` |  |  |  |
| Rozliczone | `bool` |  |  |  |
| Spłacona | `bool` |  |  |  |
| Wartosc | `Soneta.Types.Currency` | bazodanowe |  | Kwota do rozliczenia |
| Zajecie | `Soneta.Kadry.ZajęcieKomornicze` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Rozliczenie.Odbiorca | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajeKorektZajęćKomorniczych (`Soneta.Kadry.RodzajeKorektZajęćKomorniczych`)
- `ZwrotNadpłaty` = 1
- `UznanieNadpłaty` = 2
- `RozliczenieDepozytu` = 3
