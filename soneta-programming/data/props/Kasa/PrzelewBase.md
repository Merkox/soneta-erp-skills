# Pola i właściwości klasy biznesowej: `Soneta.Kasa.PrzelewBase`
Nazwa tabeli: `Przelewy`
Tytuł: Przelewy
Opis: Dokument przelewu bankowego generowany na podstawie płatności i zobowiązań. Zawiera pełne dane przelewu: zleceniodawcę, odbiorcę, rachunki bankowe, kwotę, tytuł oraz informacje o eksporcie online. Obsługuje przelewy krajowe, walutowe, ZUS oraz mechanizm podzielonej płatności (MPP).
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IAdresHost`

- pola bazodanowe: 40
- pola kalkulowane (z klas biznesowych): 30

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AdresOdbiorcy | `Soneta.Core.Adres` |  |  |  |
| AdresZleceniodawcy | `Soneta.Core.Adres` |  |  |  |
| AnulowanyWPaczce | `bool` | bazodanowe | Anulowany w paczce | Status Anulowany w paczce |
| Bufor | `bool` | bazodanowe |  |  |
| CzyWPaczce | `bool` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| DodatkoweDane | `Soneta.Business.SubTable<Soneta.Kasa.DodatkoweDanePrzelewu>` |  |  |  |
| EwidencjaSP | `Soneta.Kasa.RachunekBankowyFirmy` | bazodanowe |  |  |
| Firma | `Soneta.Core.OddzialFirmy` |  |  |  |
| InfOplaconoWkwocie | `Soneta.Types.Currency` | bazodanowe | Opłacono w kwocie |  |
| InfPozostaloDoOplacenia | `Soneta.Types.Currency` |  |  |  |
| IsAdresOdbiorcy | `bool` |  |  |  |
| IsAdresZleceniodawcy | `bool` |  |  |  |
| KodOplaty | `Soneta.Kasa.PrzelewWalutowyKodOplaty` | bazodanowe, enum |  | Kto ponosi koszty przelewu |
| KodStatystyczny | `string` | bazodanowe |  | Kod statystyczny operacji (3-literowy) |
| KodStatystycznyOpis | `Soneta.Business.MemoText` | bazodanowe |  | Objaśnienie kodu statystycznego |
| KodSwiftOdbiorcy | `string` | bazodanowe |  |  |
| KodSwiftZleceniodawcy | `string` | bazodanowe |  |  |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| KwotaVAT | `Soneta.Types.Currency` | bazodanowe |  |  |
| MPP | `Soneta.Kasa.OpisPrzelewu.MPP` |  |  |  |
| MsgId | `string` | bazodanowe | Numer paczki | Identyfikator paczki przelewu |
| NazwaOdbiorcy1 | `string` | bazodanowe |  |  |
| NazwaOdbiorcy2 | `string` | bazodanowe |  |  |
| NazwaZleceniodawcy1 | `string` | bazodanowe |  |  |
| NazwaZleceniodawcy2 | `string` | bazodanowe |  |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| OnlineMgsId | `string` | bazodanowe | Numer komunikatu | Identyfikator komunikatu |
| OnlineStatus | `Soneta.Kasa.BankowoscElektroniczna.StatusPrzelewuOnline` | bazodanowe, enum | Status online | Status przelewu |
| OnlineStatusTxt | `string` | bazodanowe | Status online TXT | Status przelewu tekstowy |
| OnlineTrnsId | `string` | bazodanowe | Numer transakcji | Identyfikator przelewu |
| Opis | `string` |  |  |  |
| PaczkaPrzelewow | `Soneta.Kasa.PaczkaPrzelewow` |  |  |  |
| Podmiot | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  |  |
| Pozycje | `Soneta.Business.LpSubTable<Soneta.Kasa.PozycjaPrzelewu>` |  |  |  |
| PrzelewMaWlasnyOpis | `bool` |  |  |  |
| Rachunek | `Soneta.Kasa.RachunekBankowyPodmiotu` | bazodanowe |  |  |
| RachunekOdbiorcy | `Soneta.Kasa.NumerRachunku` | bazodanowe |  |  |
| RachunekOdbiorcy.CS | `string` | bazodanowe |  |  |
| RachunekOdbiorcy.IBAN | `bool` |  |  |  |
| RachunekOdbiorcy.IsEmpty | `bool` |  |  |  |
| RachunekOdbiorcy.Kierunek | `string` | bazodanowe |  |  |
| RachunekOdbiorcy.Kraj | `string` | bazodanowe |  |  |
| RachunekOdbiorcy.NRB | `bool` |  |  |  |
| RachunekOdbiorcy.Numer | `string` | bazodanowe |  |  |
| RachunekOdbiorcy.NumerF | `string` |  |  |  |
| RachunekOdbiorcy.PKO | `bool` |  |  |  |
| RachunekOdbiorcy.Pełny | `string` |  | Numer rachunku |  |
| RachunekOdbiorcy.PełnyNRB | `string` |  | Numer rachunku |  |
| RachunekOdbiorcy.SEPA | `bool` |  |  |  |
| RachunekZleceniodawcy | `Soneta.Kasa.NumerRachunku` | bazodanowe |  |  |
| Seria | `string` | bazodanowe |  |  |
| Słownie | `string` |  |  |  |
| Typ | `Soneta.Kasa.TypPrzelewu` | bazodanowe, enum |  |  |
| Typ2 | `Soneta.Kasa.TypPrzelewu2` | bazodanowe, enum | Wariant | Wariant przelewu standardowego |
| Tytulem1 | `string` | bazodanowe |  |  |
| Tytulem2 | `string` | bazodanowe |  |  |
| US | `Soneta.Kasa.OpisPrzelewu.US` |  |  |  |
| WeryfikacjaTransakcji | `Soneta.Kasa.IObowiazkowaWeryfikacjaRachunku` |  |  |  |
| ZUS | `Soneta.Kasa.OpisPrzelewu.ZUS` |  |  |  |
| Zatwierdzony | `bool` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Podmiot | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusPrzelewuOnline (`Soneta.Kasa.BankowoscElektroniczna.StatusPrzelewuOnline`)
- `NieDotyczy` = 0
- `Wyslany` = 1 — Wysłany
- `Accepted` = 2 — Zrealizowany
- `AcceptedChanges` = 3 — W realizacji ze zmianami
- `Pending` = 4 — Oczekuje na przetwarzanie
- `Rejected` = 5 — Odrzucony

### PrzelewWalutowyKodOplaty (`Soneta.Kasa.PrzelewWalutowyKodOplaty`)
- `BN1` = 0 — Koszty podzielone (BN1)
- `OUR` = 1 — Koszty ponosi zleceniodawca (OUR)
- `BN2` = 2 — Koszty ponosi kontrahent (BN2)
- `SHA` = 3 — Koszty podzielone (SHA)
- `BEN` = 4 — Koszty ponosi kontrahent (BEN)
- `SLEV` = 5 — Koszty podzielone (SLEV)

### TypPrzelewu (`Soneta.Kasa.TypPrzelewu`)
- `Brak` = 0
- `Standardowy` = 1
- `PrzelewZUS` = 2 — ZUS
- `PrzelewPIT` = 3 — PIT
- `Walutowy` = 4 — Walutowy

### TypPrzelewu2 (`Soneta.Kasa.TypPrzelewu2`)
- `Standardowy` = 0
- `PrzelewZUS` = 1 — Przelew ZUS
- `PrzelewMPP` = 2 — Przelew MPP
- `PrzelewMPPOkres` = 3 — Przelew MPP okresowy
- `ExpressElixir` = 4 — Express Elixir
- `Sepa` = 5 — SEPA
