# Pola i właściwości klasy biznesowej: `Soneta.Samochodowka.Pojazd`
Nazwa tabeli: `Pojazdy`
Opis: Kartoteka pojazdów wykorzystywanych w ewidencji przebiegu. Przechowuje dane rejestracyjne, markę, typ, rodzaj pojazdu oraz przypisanie dysponenta. Służy jako podstawa do rejestracji przejazdów, kosztów eksploatacji i rozliczeń kilometrówki.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IElementSlownika`, `IZasobCRM`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Assets | `Soneta.Business.SubTable` |  |  |  |
| Dysponent | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  | Dysponent pojazdu |
| DysponentAdres | `string` |  |  |  |
| ElementyPodzielnika | `Soneta.Business.SubTable<Soneta.Core.ElementPodzielnika>` |  |  |  |
| HistoriaZmian | `Soneta.Business.HistorySubTable` |  |  |  |
| Marka | `string` | bazodanowe |  | Marka pojadu |
| NrRejestracyjny | `string` | bazodanowe |  | Numer rejestracyjny pojazdu |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Paliwa | `Soneta.Business.SubTable<Soneta.Samochodowka.PaliwoPojazdu>` |  |  |  |
| PowiazaniaKontElementu | `Soneta.Business.SubTable` |  |  |  |
| Rodzaj | `Soneta.Samochodowka.RodzajPojazdu` | bazodanowe, enum |  | Rodzaj pojazdu |
| RodzajSilnika | `Soneta.Samochodowka.EkoRodzajSilnika` | bazodanowe |  | Rodzaj silnika z pojeździe |
| Towary | `Soneta.Business.SubTable` |  |  |  |
| Typ | `Soneta.Samochodowka.TypPojazdu` | bazodanowe, enum |  | Typ pojazdu |
| UsedVehicles | `Soneta.Business.SubTable` |  |  |  |
| VehicleType | `Soneta.Samochodowka.VehicleBusinessType` | bazodanowe, enum |  |  |
| Wycofany | `bool` | bazodanowe |  |  |
| ZasobyCRM | `Soneta.Business.SubTable` |  |  |  |

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
