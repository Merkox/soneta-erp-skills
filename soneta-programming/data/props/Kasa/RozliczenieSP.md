# Pola i właściwości klasy biznesowej: `Soneta.Kasa.RozliczenieSP`
Nazwa tabeli: `RozliczeniaSP`
Tytuł: Rozliczenia
Opis: Rozliczenie powiązujące płatność (należność/zobowiązanie) z zapłatą (wpłatą/wypłatą). Rejestruje fakt skompensowania kwot dokumentu i zapłaty, przechowując daty, kwoty cząstkowe, stan noty odsetkowej oraz informacje o różnicach kursowych KPiR.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IRozliczenie`

- pola bazodanowe: 17
- pola kalkulowane (z klas biznesowych): 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DataKsi | `Soneta.Types.Date` | bazodanowe |  | Data odnośnego rozliczenia księgowego lub MAX w przypadku braku takiego rozliczenia |
| DataOgraniczeniaNaliczaniaOdsetek | `Soneta.Types.Date` | bazodanowe |  | Górna (do) data ograniczenia naliczania odsetek. |
| DataOgraniczeniaNaliczaniaOdsetekOd | `Soneta.Types.Date` | bazodanowe |  | Dolna (od) data ograniczenia naliczania odsetek. |
| Dokument | `Soneta.Kasa.IRozliczalny` | bazodanowe, iface-ref |  |  |
| EwidencjaRK | `Soneta.Core.DokEwidencji` | bazodanowe |  | Dokument ewidencji różnicy kursowej KPiR. |
| InnePlatnosci | `Soneta.Business.SubTable` |  |  |  |
| KwotaDokumentu | `Soneta.Types.Currency` | bazodanowe |  |  |
| KwotaRK | `Soneta.Types.Currency` | bazodanowe |  | Kwota różnicy kursowej KPiR. |
| KwotaZaplaty | `Soneta.Types.Currency` | bazodanowe |  |  |
| NaglowkiRozliczeniaVAT | `Soneta.Business.SubTable` |  |  |  |
| Podmiot | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  |  |
| PomijajWRKV | `bool` | bazodanowe |  |  |
| PozycjeDokRozlicz | `Soneta.Business.SubTable<Soneta.Kasa.PozycjaDokRozlicz>` |  |  |  |
| RozliczeniaKS | `Soneta.Business.SubTable` |  |  |  |
| RozliczeniaOA | `Soneta.Business.SubTable` |  |  |  |
| RozliczenieKS | `Soneta.Core.IRozliczenieKS` |  |  |  |
| RozliczenieSPKS | `Soneta.Core.IRozliczenie` | iface-ref |  |  |
| RozliczenieSPKS2 | `Soneta.Kasa.IRozliczenieSPKS` |  |  |  |
| RozniceKursoweSilver | `bool` |  |  |  |
| StanNoty | `Soneta.Kasa.StanNotyOdsetkowej` | bazodanowe, enum |  |  |
| StatusRK | `Soneta.Kasa.StatusRoznicyKursowejESP` | bazodanowe, enum |  | Status różnicy kursowej KPiR. |
| Termin | `Soneta.Types.Date` |  |  |  |
| TypRK | `Soneta.Kasa.TypRoznicyKursowej` | bazodanowe, enum |  | Typ (kierunek) różnicy kursowej KPiR. |
| Zaplata | `Soneta.Kasa.IRozliczalny` | bazodanowe, iface-ref |  |  |
| Zwloka | `int` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Dokument | `IRozliczalny` | `Platnosc`, `Zaplata` |
| Podmiot | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |
| RozliczenieSPKS | `IRozliczenie` | `RozliczenieKS`, `RozliczenieSP` |
| Zaplata | `IRozliczalny` | `Platnosc`, `Zaplata` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanNotyOdsetkowej (`Soneta.Kasa.StanNotyOdsetkowej`)
- `NieDotyczy` = 1
- `NieNaliczaj` = 2
- `Naliczaj` = 3
- `Naliczona` = 4

### StatusRoznicyKursowejESP (`Soneta.Kasa.StatusRoznicyKursowejESP`)
- `NaliczanieWylaczone` = 0 — Naliczanie wyłączone
- `NieDotyczy` = 1 — Nie dotyczy
- `Naliczona` = 2 — Naliczona
- `DoZaewidencjonowania` = 3 — Do zaewidencjonowania
- `Zaewidencjonowana` = 4 — Zaewidencjonowana
- `DaneNiekompletne` = 5 — Dane niekompletne

### TypRoznicyKursowej (`Soneta.Kasa.TypRoznicyKursowej`)
- `Brak` = 0
- `Zysk` = 1
- `Strata` = 2
