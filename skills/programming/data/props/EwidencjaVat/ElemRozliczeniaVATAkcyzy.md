# Pola i właściwości klasy biznesowej: `Soneta.EwidencjaVat.ElemRozliczeniaVATAkcyzy`
Nazwa tabeli: `EleRozliczenVATT`
Tytuł: Elementy rozliczen VAT
Opis: Element szczegółowy nagłówka rozliczenia VAT (NagRozliczeniaVATAkcyzy). Pozycja rozliczenia VAT powiązana z konkretnym elementem ewidencji VAT, zawierająca stawkę, kwoty netto/VAT/brutto, parametry odliczeń i rodzaj zakupu. Umożliwia szczegółowe śledzenie rozliczenia poszczególnych pozycji podatkowych.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Naglowek` → `NagRozliczeniaVATAkcyzy`
Selektor: pole `TypEwidencji` (`Soneta.EwidencjaVat.TypEwidencjiVAT`) — wiele typów w jednej tabeli, podtypów: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Akcyza | `Currency` | tylko-odczyt |  |  |
| Brutto | `Currency` | bazodanowe |  | Wartość rozlczenia brutto |
| Data | `Date` | bazodanowe |  | Data powstania obowiązku podatkowego VAT |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe, tylko-odczyt |  |  |
| DzialalnoscGosp | `Soneta.EwidencjaVat.DzialalnoscGospodarcza` (enum) | bazodanowe | Działalność gosp | Czy zakupy na cel działalności gospodarczej |
| Element | `Soneta.EwidencjaVat.ElemEwidencjiVATAkcyzy` | bazodanowe, tylko-odczyt |  | Rozliczany element ewidencji VAT  |
| Ewidencja | `Soneta.Core.DokEwidencji` | tylko-odczyt |  |  |
| Grupa | `Soneta.Core.GrupaElementuVAT` (enum) | bazodanowe | Grupa | Grupa elementu VAT |
| Lp | `int` | bazodanowe |  | Liczba porządkowa elementu w nagłówku |
| Naglowek | `Soneta.EwidencjaVat.NagRozliczeniaVATAkcyzy` | bazodanowe, tylko-odczyt, guided-parent |  | Nagłówek rozliczenia VAT |
| Nalezny | `bool` | tylko-odczyt |  |  |
| Naliczony | `bool` | tylko-odczyt |  |  |
| Netto | `Currency` | bazodanowe |  | Wartość rozliczenia netto |
| NumerDokumentu | `string` | bazodanowe, tylko-odczyt |  |  |
| NumerEwidencji | `string` | bazodanowe |  |  |
| Odliczenia | `Soneta.EwidencjaVat.OdliczeniaVAT` (enum) | bazodanowe |  | Odliczenia VAT związane z tą pozycją |
| ParametryRozliczen | `Soneta.Core.ParametrRozlicz` | bazodanowe | Parametry rozliczeń | Powiązane parametry rozliczeń |
| PodlegaPSD | `bool` | bazodanowe | Podlega PSD | Podlega podatkowi od sprzedaży detalicznej |
| Podmiot | `Soneta.Core.IPodmiot` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| ProceduraSME | `bool` | bazodanowe | Procedura SME | Procedura SME |
| Rodzaj | `Soneta.EwidencjaVat.RodzajZakupuVAT` (enum) | bazodanowe |  | Rodzaj zakupu związany z tą pozycją |
| RodzajPodmiotu | `Soneta.Core.RodzajPodmiotu` (enum) | bazodanowe |  | Rodzaj podmiotu |
| StatusPodmiotu | `Soneta.Core.StatusPodmiotu` (enum) | bazodanowe |  | Status podmiotu |
| Stawka | `Soneta.Core.StawkaVat` (subrow) | bazodanowe |  |  |
| Stawka.Kraj | `Soneta.Core.KrajTbl` | bazodanowe |  |  |
| Stawka.Obnizona | `bool` | bazodanowe |  |  |
| Stawka.Procent | `Percent` | bazodanowe |  |  |
| Stawka.Status | `Soneta.Core.StatusStawkiVat` (enum) | bazodanowe |  |  |
| Stawka.WgKraj | `Key` | podlista |  |  |
| Stawka.WymagaSWW | `bool` | tylko-odczyt |  |  |
| Stawka.Zrodlowa | `Percent` | bazodanowe |  |  |
| StawkaAkcyzy | `Soneta.Core.StawkaAkcyzy` (subrow) | bazodanowe |  |  |
| StawkaAkcyzy.Grupa | `string` | bazodanowe |  | Grupa wyrobów |
| StawkaAkcyzy.Pozycja | `int` | bazodanowe |  | Pozycja tabeli stawek |
| StawkaAkcyzy.Procent | `Percent` | bazodanowe |  |  |
| StawkaAkcyzy.Symbol | `string` | bazodanowe |  | Symbol - np. SWW |
| StawkaAkcyzy.Typ | `Soneta.Core.TypStawkiAkcyzy` (enum) | bazodanowe |  |  |
| StawkaAkcyzy.TypGrupy | `Soneta.Core.TypGrupyAkcyzy` (enum) | bazodanowe |  | Typ grupy wyrobów |
| StrukturaSprzedazyNie | `bool` | bazodanowe |  | Nie uwzględniaj w liczeniu struktury sprzedaży |
| TypEwidencji | `Soneta.EwidencjaVat.TypEwidencjiVAT` (enum) | bazodanowe, tylko-odczyt, selektor |  | Typ ewidencji VAT |
| VAT | `Currency` | bazodanowe |  | Wartość rozliczenia podatku VAT |
| VATKoszt | `Currency` | tylko-odczyt |  |  |
| VATKosztWsp | `Currency` | tylko-odczyt |  |  |
| VATOdliczenia | `Currency` | tylko-odczyt |  |  |
| VATOdliczeniaWsp | `Currency` | tylko-odczyt |  |  |
| WartoscEur | `Soneta.EwidencjaVat.INettoVATBrutto` | tylko-odczyt | Wartości w Eur |  |
| WartoscKsi | `Soneta.EwidencjaVat.INettoVATBrutto` | tylko-odczyt | Wartości księgowe |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `TypEwidencji`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Sprzedaż` | 1 | `Soneta.EwidencjaVat.ElemRozliczeniaVATSprzedaz` | Element rozliczenia VAT - sprzedaż |
| `Zakup` | 2 | `Soneta.EwidencjaVat.ElemRozliczeniaVATZakup` | Element rozliczenia VAT - zakup |
| `SprzedażAkcyza` | 3 | `Soneta.EwidencjaVat.ElemRozliczeniaAkcyzySprzedaz` | Element rozliczenia akcyzy - sprzedaż |
| `ZakupAkcyza` | 4 | `Soneta.EwidencjaVat.ElemRozliczeniaAkcyzyZakup` | Element rozliczenia akcyzy - zakup |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Podmiot | `IPodmiot` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### GrupaElementuVAT (`Soneta.Core.GrupaElementuVAT`)
- `Brak` = 0 — -
- `MPP` = 1 — MPP

### RodzajPodmiotu (`Soneta.Core.RodzajPodmiotu`)
- `Krajowy` = 0
- `Eksportowy` = 1
- `EksportowyPodróżny` = 2
- `Unijny` = 3
- `UnijnyTrójstronny` = 4
- `BezVAT` = 5 — Bez VAT

### StatusPodmiotu (`Soneta.Core.StatusPodmiotu`)
- `PodmiotGospodarczy` = 0
- `Finalny` = 1

### StatusStawkiVat (`Soneta.Core.StatusStawkiVat`)
- `Opodatkowana` = 0 — Opodatkowana
- `Zaniżona` = 1
- `Zwolniona` = 2
- `NiePodlega` = 3
- `Brak` = 4

### TypGrupyAkcyzy (`Soneta.Core.TypGrupyAkcyzy`)
- `Brak` = 0 — Brak
- `WyrobySpirytusowe` = 1
- `WyrobyWiniarskie` = 2
- `Piwa` = 3
- `PaliwaSilnikowe` = 4
- `SamochodyOsobowe` = 5
- `WyrobyTytoniowe` = 6
- `PozostałeWyrobyAkcyzowe` = 7
- `EnergiaElektryczna` = 8

### TypStawkiAkcyzy (`Soneta.Core.TypStawkiAkcyzy`)
- `Procentowa` = 0 — Procentowa
- `Kwotowa` = 1
- `Zwolniona` = 2

### DzialalnoscGospodarcza (`Soneta.EwidencjaVat.DzialalnoscGospodarcza`)
- `Tak` = 0 — Tak
- `Nie` = 1 — Nie
- `CelMieszany` = 2 — Cel mieszany

### OdliczeniaVAT (`Soneta.EwidencjaVat.OdliczeniaVAT`)
- `Tak` = 0 — Tak
- `Nie` = 1 — Nie
- `Warunkowo` = 2 — Warunkowo

### RodzajZakupuVAT (`Soneta.EwidencjaVat.RodzajZakupuVAT`)
- `Towar` = 0 — Towar
- `Inne` = 1 — Inne
- `ŚrodkiTrwałe` = 2 — Środki trwałe
- `ŚrodkiTransportu` = 3 — Środki transportu
- `Nieruchomości` = 4 — Nieruchomości
- `Usługi` = 5 — Usługi
- `Paliwo` = 6 — Paliwo
- `NabywcaPodatnik` = 7 — Nabywca podatnik - towar
- `Leasing` = 8 — Leasing
- `ŚrodkiTrwałeVATRocznie` = 9 — Środki trwałe - VAT rok
- `UsługiNP` = 10 — Usługi NP
- `VATMarza` = 11 — VAT Marża
- `NabywcaPodatnikUsluga` = 12 — Nabywca podatnik - usługi
- `SpisZNatury` = 13 — Spis z natury
- `KasyRejestrujace` = 14 — Kasy rejestrujące
- `WntSrodkowTransportu` = 15 — WNT śr. transportu
- `WntPaliw` = 16 — WNT paliw
- `KorektaST` = 17 — Korekta - śr. trwałe
- `KorektaPozostale` = 18 — Korekta - pozostałe
- `SystemKaucyjny` = 19 — System kaucyjny

### TypEwidencjiVAT (`Soneta.EwidencjaVat.TypEwidencjiVAT`)
- `Brak` = 0 — Brak
- `Sprzedaż` = 1 — Należny
- `Zakup` = 2 — Naliczony
- `SprzedażAkcyza` = 3 — Sprzedaż akcyza
- `ZakupAkcyza` = 4 — Zakup akcyza
