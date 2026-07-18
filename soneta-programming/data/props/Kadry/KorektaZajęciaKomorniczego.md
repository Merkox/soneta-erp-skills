# Pola i właściwości klasy biznesowej: `Soneta.Kadry.KorektaZajęciaKomorniczego`
Nazwa tabeli: `KorektyZajKomor`
Tytuł: Korekty zajęć komorniczych
Opis: Korekta zajęcia komorniczego umożliwiająca zarejestrowanie dodatkowej wpłaty, zwrotu lub zmiany kwoty potrącenia. Zawiera rodzaj korekty, datę, kwotę, element rozliczeniowy oraz numer dokumentu korygującego.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBazaZrodlaWyplaty`

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 4
- subrowy: 1
- razem: 16

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  | Data korekty |
| Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Elementy | `SubTable<Soneta.Place.WypElement>` | podlista | Elementy wynagrodzenia |  |
| NumerDokumentu | `string` | bazodanowe |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  | Informacja o korekcie zajęcia komorniczego |
| OpisPrzelewu | `string` | bazodanowe |  |  |
| Rodzaj | `Soneta.Kadry.RodzajeKorektZajęćKomorniczych` (enum) | bazodanowe, tylko-odczyt |  |  |
| Rozliczenie | `Soneta.Kadry.RozliczenieDodatku` (subrow) | bazodanowe |  |  |
| Rozliczenie.Odbiorca | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  |  |
| Rozliczenie.RachunekOdbiorcy | `Soneta.Kasa.RachunekBankowyPodmiotu` | bazodanowe |  |  |
| Rozliczenie.WgOdbiorca | `Key` | podlista |  |  |
| Rozliczenie.WgRachunekOdbiorcy | `Key` | podlista |  |  |
| Rozliczone | `bool` | tylko-odczyt |  |  |
| Spłacona | `bool` | tylko-odczyt |  |  |
| Wartosc | `Currency` | bazodanowe |  | Kwota do rozliczenia |
| Zajecie | `Soneta.Kadry.ZajęcieKomornicze` | bazodanowe, tylko-odczyt |  |  |

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
