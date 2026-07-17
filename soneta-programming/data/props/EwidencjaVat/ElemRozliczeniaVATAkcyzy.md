# Pola i właściwości klasy biznesowej: `Soneta.EwidencjaVat.ElemRozliczeniaVATAkcyzy`
Nazwa tabeli: `EleRozliczenVATT`
Tytuł: Elementy rozliczen VAT
Opis: Element szczegółowy nagłówka rozliczenia VAT (NagRozliczeniaVATAkcyzy). Pozycja rozliczenia VAT powiązana z konkretnym elementem ewidencji VAT, zawierająca stawkę, kwoty netto/VAT/brutto, parametry odliczeń i rodzaj zakupu. Umożliwia szczegółowe śledzenie rozliczenia poszczególnych pozycji podatkowych.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Naglowek` → `NagRozliczeniaVATAkcyzy`

- pola bazodanowe: 35
- pola kalkulowane (z klas biznesowych): 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Akcyza | `Soneta.Types.Currency` |  |  |  |
| Brutto | `Soneta.Types.Currency` | bazodanowe |  | Wartość rozlczenia brutto |
| Data | `Soneta.Types.Date` | bazodanowe |  | Data powstania obowiązku podatkowego VAT |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| DzialalnoscGosp | `Soneta.EwidencjaVat.DzialalnoscGospodarcza` | bazodanowe, enum | Działalność gosp | Czy zakupy na cel działalności gospodarczej |
| Element | `Soneta.EwidencjaVat.ElemEwidencjiVATAkcyzy` | bazodanowe |  | Rozliczany element ewidencji VAT  |
| Ewidencja | `Soneta.Core.DokEwidencji` |  |  |  |
| Grupa | `Soneta.Core.GrupaElementuVAT` | bazodanowe, enum | Grupa | Grupa elementu VAT |
| Lp | `int` | bazodanowe |  | Liczba porządkowa elementu w nagłówku |
| Naglowek | `Soneta.EwidencjaVat.NagRozliczeniaVATAkcyzy` | bazodanowe, guided-parent |  | Nagłówek rozliczenia VAT |
| Nalezny | `bool` |  |  |  |
| Naliczony | `bool` |  |  |  |
| Netto | `Soneta.Types.Currency` | bazodanowe |  | Wartość rozliczenia netto |
| NumerDokumentu | `string` | bazodanowe |  |  |
| NumerEwidencji | `string` | bazodanowe |  |  |
| Odliczenia | `Soneta.EwidencjaVat.OdliczeniaVAT` | bazodanowe, enum |  | Odliczenia VAT związane z tą pozycją |
| ParametryRozliczen | `Soneta.Core.ParametrRozlicz` | bazodanowe | Parametry rozliczeń | Powiązane parametry rozliczeń |
| PodlegaPSD | `bool` | bazodanowe | Podlega PSD | Podlega podatkowi od sprzedaży detalicznej |
| Podmiot | `Soneta.Core.IPodmiot` | bazodanowe, iface-ref |  |  |
| ProceduraSME | `bool` | bazodanowe | Procedura SME | Procedura SME |
| Rodzaj | `Soneta.EwidencjaVat.RodzajZakupuVAT` | bazodanowe, enum |  | Rodzaj zakupu związany z tą pozycją |
| RodzajPodmiotu | `Soneta.Core.RodzajPodmiotu` | bazodanowe, enum |  | Rodzaj podmiotu |
| StatusPodmiotu | `Soneta.Core.StatusPodmiotu` | bazodanowe, enum |  | Status podmiotu |
| Stawka | `Soneta.Core.StawkaVat` | bazodanowe |  |  |
| Stawka.Kraj | `Soneta.Core.KrajTbl` | bazodanowe |  |  |
| Stawka.Obnizona | `bool` | bazodanowe |  |  |
| Stawka.Procent | `Soneta.Types.Percent` | bazodanowe |  |  |
| Stawka.Status | `Soneta.Core.StatusStawkiVat` | bazodanowe, enum |  |  |
| Stawka.WgKraj | `Soneta.Business.Key` |  |  |  |
| Stawka.WymagaSWW | `bool` |  |  |  |
| Stawka.Zrodlowa | `Soneta.Types.Percent` | bazodanowe |  |  |
| StawkaAkcyzy | `Soneta.Core.StawkaAkcyzy` | bazodanowe |  |  |
| StawkaAkcyzy.Grupa | `string` | bazodanowe |  | Grupa wyrobów |
| StawkaAkcyzy.Pozycja | `int` | bazodanowe |  | Pozycja tabeli stawek |
| StawkaAkcyzy.Procent | `Soneta.Types.Percent` | bazodanowe |  |  |
| StawkaAkcyzy.Symbol | `string` | bazodanowe |  | Symbol - np. SWW |
| StawkaAkcyzy.Typ | `Soneta.Core.TypStawkiAkcyzy` | bazodanowe, enum |  |  |
| StawkaAkcyzy.TypGrupy | `Soneta.Core.TypGrupyAkcyzy` | bazodanowe, enum |  | Typ grupy wyrobów |
| StrukturaSprzedazyNie | `bool` | bazodanowe |  | Nie uwzględniaj w liczeniu struktury sprzedaży |
| TypEwidencji | `Soneta.EwidencjaVat.TypEwidencjiVAT` | bazodanowe, enum |  | Typ ewidencji VAT |
| VAT | `Soneta.Types.Currency` | bazodanowe |  | Wartość rozliczenia podatku VAT |
| VATKoszt | `Soneta.Types.Currency` |  |  |  |
| VATKosztWsp | `Soneta.Types.Currency` |  |  |  |
| VATOdliczenia | `Soneta.Types.Currency` |  |  |  |
| VATOdliczeniaWsp | `Soneta.Types.Currency` |  |  |  |
| WartoscEur | `Soneta.EwidencjaVat.INettoVATBrutto` |  | Wartości w Eur |  |
| WartoscKsi | `Soneta.EwidencjaVat.INettoVATBrutto` |  | Wartości księgowe |  |

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
