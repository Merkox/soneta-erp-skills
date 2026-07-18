# Pola i właściwości klasy biznesowej: `Soneta.Samochodowka.Pojazd`
Nazwa tabeli: `Pojazdy`
Opis: Kartoteka pojazdów wykorzystywanych w ewidencji przebiegu. Przechowuje dane rejestracyjne, markę, typ, rodzaj pojazdu oraz przypisanie dysponenta. Służy jako podstawa do rejestracji przejazdów, kosztów eksploatacji i rozliczeń kilometrówki.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IElementSlownika`, `IZasobCRM`

- pola bazodanowe (zapisywalne): 8
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 9
- subrowy: 0
- razem: 18

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Assets | `SubTable` | podlista |  |  |
| Dysponent | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  | Dysponent pojazdu |
| DysponentAdres | `string` | tylko-odczyt |  |  |
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| HistoriaZmian | `HistorySubTable` | podlista |  |  |
| Marka | `string` | bazodanowe |  | Marka pojadu |
| NrRejestracyjny | `string` | bazodanowe |  | Numer rejestracyjny pojazdu |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| Paliwa | `SubTable<Soneta.Samochodowka.PaliwoPojazdu>` | podlista |  |  |
| PowiazaniaKontElementu | `SubTable` | podlista |  |  |
| Rodzaj | `Soneta.Samochodowka.RodzajPojazdu` (enum) | bazodanowe |  | Rodzaj pojazdu |
| RodzajSilnika | `Soneta.Samochodowka.EkoRodzajSilnika` | bazodanowe |  | Rodzaj silnika z pojeździe |
| Towary | `SubTable` | podlista |  |  |
| Typ | `Soneta.Samochodowka.TypPojazdu` (enum) | bazodanowe |  | Typ pojazdu |
| UsedVehicles | `SubTable` | podlista |  |  |
| VehicleType | `Soneta.Samochodowka.VehicleBusinessType` (enum) | bazodanowe |  |  |
| Wycofany | `bool` | bazodanowe |  |  |
| ZasobyCRM | `SubTable` | podlista |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Dysponent | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajPojazdu (`Soneta.Samochodowka.RodzajPojazdu`)
- `Prywatny` = 1 — Samochód prywatny
- `Firmowy` = 2 — Samochód firmowy
- `Inny` = 3

### TypPojazdu (`Soneta.Samochodowka.TypPojazdu`)
- `Brak` = 0
- `SamochódDo900` = 1
- `SamochódPonad900` = 2
- `Motocykl` = 3
- `Motorower` = 4

### VehicleBusinessType (`Soneta.Samochodowka.VehicleBusinessType`)
- `Standard` = 1
