# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.RozliczenieKS`
Nazwa tabeli: `RozliczeniaKS`
Tytuł: Rozliczenia księgowe
Opis: Rozliczenie księgowe łączy parę zapisów księgowych (Winien i Ma) w celu ich wzajemnego rozrachunku na kontach rozliczeniowych. Śledzi kwoty operacji i zapisu po obu stronach, obsługuje różnice kursowe oraz powiązanie z dokumentami ewidencji.
Tabela konfiguracyjna: Nie
Implementuje interfejsy: `IRozliczenie`, `IElementKsiegowalny`

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` | bazodanowe |  | Ewidencja różnic kursowych |
| KwotaOperacjiMa | `Soneta.Types.Currency` | bazodanowe |  |  |
| KwotaOperacjiRK | `Soneta.Types.Currency` |  |  | Kwota operacji różnicy kursowej |
| KwotaOperacjiWinien | `Soneta.Types.Currency` | bazodanowe |  |  |
| KwotaRK | `Soneta.Types.Currency` |  |  | Kwota różnicy kursowej |
| KwotaRKNetto | `Soneta.Types.Currency` |  |  | Kwota różnicy kursowej netto |
| KwotaRKVAT | `Soneta.Types.Currency` |  |  | Kwota różnicy kursowej VAT |
| KwotaRozliczeniaZapisu | `Soneta.Types.Currency` |  |  |  |
| KwotaZapisuMa | `Soneta.Types.Currency` | bazodanowe |  |  |
| KwotaZapisuWinien | `Soneta.Types.Currency` | bazodanowe |  |  |
| RodzajRK | `Soneta.Kasa.RodzajRoznicyKursowej` | enum |  | Rodzaj rożnicy kursowej |
| RozliczeniaKS | `Soneta.Business.SubTable<Soneta.Ksiega.RozliczenieKS>` |  |  |  |
| Rozliczenie | `Soneta.Ksiega.RozliczenieKS` |  |  |  |
| RozliczenieSP | `Soneta.Kasa.RozliczenieSP` |  |  |  |
| RozliczenieZrodlowe | `Soneta.Core.IRozliczenie` | bazodanowe, iface-ref |  |  |
| StatusRK | `Soneta.Kasa.StatusRoznicyKursowej` | bazodanowe, enum |  | Status różnicy kursowej |
| Typ | `Soneta.Core.TypRozliczeniaKS` | bazodanowe, enum |  |  |
| TypRK | `Soneta.Kasa.TypRoznicyKursowej` | enum |  | Typ rożnicy kursowej |
| ZapisMa | `Soneta.Ksiega.ZapisKsiegowy` | bazodanowe |  |  |
| ZapisRK | `Soneta.Ksiega.ZapisKsiegowy` |  |  | Zapis do rozliczenia RK |
| ZapisWinien | `Soneta.Ksiega.ZapisKsiegowy` | bazodanowe |  |  |
| ZapisyKsiegowe | `Soneta.Business.SubTable<Soneta.Ksiega.ZapisKsiegowy>` |  |  |  |

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
