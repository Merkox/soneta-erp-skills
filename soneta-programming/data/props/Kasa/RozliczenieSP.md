# Pola i właściwości klasy biznesowej: `Soneta.Kasa.RozliczenieSP`
Nazwa tabeli: `RozliczeniaSP`
Tytuł: Rozliczenia
Opis: Rozliczenie powiązujące płatność (należność/zobowiązanie) z zapłatą (wpłatą/wypłatą). Rejestruje fakt skompensowania kwot dokumentu i zapłaty, przechowując daty, kwoty cząstkowe, stan noty odsetkowej oraz informacje o różnicach kursowych KPiR.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IRozliczenie`

- pola bazodanowe (zapisywalne): 8
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 13
- podlisty: 5
- subrowy: 0
- razem: 26

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe |  |  |
| Data | `Date` | bazodanowe |  |  |
| DataKsi | `Date` | bazodanowe, tylko-odczyt |  | Data odnośnego rozliczenia księgowego lub MAX w przypadku braku takiego rozliczenia |
| DataOgraniczeniaNaliczaniaOdsetek | `Date` | bazodanowe |  | Górna (do) data ograniczenia naliczania odsetek. |
| DataOgraniczeniaNaliczaniaOdsetekOd | `Date` | bazodanowe |  | Dolna (od) data ograniczenia naliczania odsetek. |
| Dokument | `Soneta.Kasa.IRozliczalny` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| EwidencjaRK | `Soneta.Core.DokEwidencji` | bazodanowe, tylko-odczyt |  | Dokument ewidencji różnicy kursowej KPiR. |
| InnePlatnosci | `SubTable` | podlista |  |  |
| KwotaDokumentu | `Currency` | bazodanowe |  |  |
| KwotaRK | `Currency` | bazodanowe, tylko-odczyt |  | Kwota różnicy kursowej KPiR. |
| KwotaZaplaty | `Currency` | bazodanowe |  |  |
| NaglowkiRozliczeniaVAT | `SubTable` | podlista |  |  |
| Podmiot | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| PomijajWRKV | `bool` | bazodanowe |  |  |
| PozycjeDokRozlicz | `SubTable<Soneta.Kasa.PozycjaDokRozlicz>` | podlista |  |  |
| RozliczeniaKS | `SubTable` | podlista |  |  |
| RozliczeniaOA | `SubTable` | podlista |  |  |
| RozliczenieKS | `Soneta.Core.IRozliczenieKS` | tylko-odczyt |  |  |
| RozliczenieSPKS2 | `Soneta.Kasa.IRozliczenieSPKS` | tylko-odczyt |  |  |
| RozniceKursoweSilver | `bool` | tylko-odczyt |  |  |
| StanNoty | `Soneta.Kasa.StanNotyOdsetkowej` (enum) | bazodanowe |  |  |
| StatusRK | `Soneta.Kasa.StatusRoznicyKursowejESP` (enum) | bazodanowe, tylko-odczyt |  | Status różnicy kursowej KPiR. |
| Termin | `Date` | tylko-odczyt |  |  |
| TypRK | `Soneta.Kasa.TypRoznicyKursowej` (enum) | bazodanowe, tylko-odczyt |  | Typ (kierunek) różnicy kursowej KPiR. |
| Zaplata | `Soneta.Kasa.IRozliczalny` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| Zwloka | `int` | bazodanowe, tylko-odczyt |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Dokument | `IRozliczalny` | `Platnosc`, `Zaplata` |
| Podmiot | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |
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
