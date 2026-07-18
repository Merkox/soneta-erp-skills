# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.RozliczenieKS`
Nazwa tabeli: `RozliczeniaKS`
Tytuł: Rozliczenia księgowe
Opis: Rozliczenie księgowe łączy parę zapisów księgowych (Winien i Ma) w celu ich wzajemnego rozrachunku na kontach rozliczeniowych. Śledzi kwoty operacji i zapisu po obu stronach, obsługuje różnice kursowe oraz powiązanie z dokumentami ewidencji.
Tabela konfiguracyjna: Nie
Implementuje interfejsy: `IRozliczenie`, `IElementKsiegowalny`

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 21
- podlisty: 2
- subrowy: 0
- razem: 23

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` | bazodanowe, tylko-odczyt |  | Ewidencja różnic kursowych |
| KwotaOperacjiMa | `Currency` | bazodanowe, tylko-odczyt |  |  |
| KwotaOperacjiRK | `Currency` | tylko-odczyt |  | Kwota operacji różnicy kursowej |
| KwotaOperacjiWinien | `Currency` | bazodanowe, tylko-odczyt |  |  |
| KwotaRK | `Currency` | tylko-odczyt |  | Kwota różnicy kursowej |
| KwotaRKNetto | `Currency` | tylko-odczyt |  | Kwota różnicy kursowej netto |
| KwotaRKVAT | `Currency` | tylko-odczyt |  | Kwota różnicy kursowej VAT |
| KwotaRozliczeniaZapisu | `Currency` | tylko-odczyt |  |  |
| KwotaZapisuMa | `Currency` | bazodanowe, tylko-odczyt |  |  |
| KwotaZapisuWinien | `Currency` | bazodanowe, tylko-odczyt |  |  |
| RodzajRK | `Soneta.Kasa.RodzajRoznicyKursowej` (enum) | tylko-odczyt |  | Rodzaj rożnicy kursowej |
| RozliczeniaKS | `SubTable<Soneta.Ksiega.RozliczenieKS>` | podlista |  |  |
| Rozliczenie | `Soneta.Ksiega.RozliczenieKS` | tylko-odczyt |  |  |
| RozliczenieSP | `Soneta.Kasa.RozliczenieSP` | tylko-odczyt |  |  |
| RozliczenieZrodlowe | `Soneta.Core.IRozliczenie` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| StatusRK | `Soneta.Kasa.StatusRoznicyKursowej` (enum) | bazodanowe, tylko-odczyt |  | Status różnicy kursowej |
| Typ | `Soneta.Core.TypRozliczeniaKS` (enum) | bazodanowe, tylko-odczyt |  |  |
| TypRK | `Soneta.Kasa.TypRoznicyKursowej` (enum) | tylko-odczyt |  | Typ rożnicy kursowej |
| ZapisMa | `Soneta.Ksiega.ZapisKsiegowy` | bazodanowe, tylko-odczyt |  |  |
| ZapisRK | `Soneta.Ksiega.ZapisKsiegowy` | tylko-odczyt |  | Zapis do rozliczenia RK |
| ZapisWinien | `Soneta.Ksiega.ZapisKsiegowy` | bazodanowe, tylko-odczyt |  |  |
| ZapisyKsiegowe | `SubTable<Soneta.Ksiega.ZapisKsiegowy>` | podlista |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| RozliczenieZrodlowe | `IRozliczenie` | `RozliczenieKS`, `RozliczenieSP` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypRozliczeniaKS (`Soneta.Core.TypRozliczeniaKS`)
- `Brak` = 0
- `RozliczenieSPKS` = 1
- `RozliczenieRK` = 2
- `RozliczenieKsiegowe` = 3

### RodzajRoznicyKursowej (`Soneta.Kasa.RodzajRoznicyKursowej`)
- `Brak` = 0
- `SprzedazZysk` = 1
- `SprzedazStrata` = 2
- `ZakupZysk` = 3
- `ZakupStrata` = 4
- `KompensataZysk` = 5
- `KompensataStrata` = 6
- `PracownicyZysk` = 7
- `PracownicyStrata` = 8
- `WlascicieleZysk` = 9
- `WlascicieleStrata` = 10

### StatusRoznicyKursowej (`Soneta.Kasa.StatusRoznicyKursowej`)
- `Brak` = 0
- `DoZaewidencjonowania` = 1
- `Zaewidencjonowana` = 2

### TypRoznicyKursowej (`Soneta.Kasa.TypRoznicyKursowej`)
- `Brak` = 0
- `Zysk` = 1
- `Strata` = 2
