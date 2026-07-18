# Pola i właściwości klasy biznesowej: `Soneta.EwidencjaVat.ElemEwidencjiVATAkcyzy`
Nazwa tabeli: `EleEwidencjiVATT`
Tytuł: Elementy ewidencji VAT
Opis: Element szczegółowy nagłówka ewidencji VAT (NagEwidencjiVATAkcyzy). Reprezentuje pojedynczą pozycję VAT/akcyzy ze stawką, kwotami netto/VAT/brutto, parametrami odliczeń, rodzajem zakupu i działalnością gospodarczą. Obsługuje opis analityczny, KPiR, strukturę sprzedaży oraz moment powstania obowiązku podatkowego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Naglowek` → `NagEwidencjiVATAkcyzy`
Implementuje interfejsy: `IZrodloOpisuAnalitycznego`
Selektor: pole `Typ` (`Soneta.EwidencjaVat.TypEwidencjiVAT`) — wiele typów w jednej tabeli, podtypów: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Akcyza | `Currency` |  |  |  |
| Brutto | `Currency` | bazodanowe |  | Wartość brutto |
| Bufor | `bool` | tylko-odczyt |  |  |
| DataPowstania | `Date` | bazodanowe |  | Data powstania obow. pod. VAT |
| DataZaewidencjonowania | `Date` | bazodanowe, tylko-odczyt |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe, tylko-odczyt |  |  |
| DefinicjaPowstaniaObowiazku | `Soneta.EwidencjaVat.DefinicjaPowstaniaObowiazkuVAT` | bazodanowe |  | Definicja momentu powstania obowiązku podatkowego VAT |
| DefinicjaStawki | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe |  | Definicja stawki VAT |
| DefinicjaStawkiAkcyzy | `Soneta.Core.DefinicjaStawkiAkcyzy` | bazodanowe |  |  |
| DoRozliczeniaBrutto | `Currency` | tylko-odczyt |  |  |
| DoRozliczeniaNetto | `Currency` | tylko-odczyt |  |  |
| DoRozliczeniaPodatek | `Currency` | tylko-odczyt |  |  |
| DzialalnoscGosp | `Soneta.EwidencjaVat.DzialalnoscGospodarcza` (enum) | bazodanowe | Działalność gosp | Czy zakupy na cel działalności gospodarczej |
| ElementyRozliczeniaVAT | `SubTable<Soneta.EwidencjaVat.ElemRozliczeniaVATAkcyzy>` | podlista |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` | tylko-odczyt |  |  |
| Grupa | `Soneta.Core.GrupaElementuVAT` (enum) | bazodanowe | Grupa | Grupa elementu VAT |
| Kolumna | `Soneta.EwidencjaVat.NrKolumnyKPiR` (enum) | bazodanowe |  | Nr kolumany w KPiR |
| KolumnaRyczałt | `Soneta.EwidencjaVat.ElemEwidencjiVATAkcyzy.KolumnaKPiRRyczałt` (enum) |  |  |  |
| KolumnaSprzedaż | `Soneta.EwidencjaVat.ElemEwidencjiVATAkcyzy.KolumnaKPiRSprzedaż` (enum) |  |  |  |
| KolumnaZakup | `Soneta.EwidencjaVat.ElemEwidencjiVATAkcyzy.KolumnaKPiRZakup` (enum) |  |  |  |
| Korekta | `bool` | tylko-odczyt |  |  |
| Koszty | `Soneta.EwidencjaVat.ElemEwidencjiVATAkcyzy.KosztyCalculator` | tylko-odczyt |  |  |
| Lp | `int` | bazodanowe |  | Liczba porządkowa elementu w nagłówku |
| NKUP | `Percent` | bazodanowe |  | Część niebędąca kosztem uzyskania przychodu |
| Naglowek | `Soneta.EwidencjaVat.NagEwidencjiVATAkcyzy` | bazodanowe, tylko-odczyt, guided-parent |  | Nagłówek elementu ewidencji VAT |
| Netto | `Currency` | bazodanowe |  | Wartość netto |
| Numer | `string` | bazodanowe, tylko-odczyt |  |  |
| NumerDokumentu | `string` | bazodanowe, tylko-odczyt |  | Numer dokumentu |
| Odliczenia | `Soneta.EwidencjaVat.OdliczeniaVAT` (enum) | bazodanowe |  | Odliczenia VAT związane z tą pozycją |
| OkresRozliczenia | `string` | tylko-odczyt |  |  |
| OpisAnalityczny | `SubTable` | podlista |  |  |
| OpisDodatkowy | `string` | bazodanowe |  | Dodatkowy opis elementu vat/akcyzy |
| ParametryRozliczen | `Soneta.Core.ParametrRozlicz` | bazodanowe | Parametry rozliczeń | Powiązane parametry rozliczeń |
| Podatek | `Currency` |  |  |  |
| PodlegaPSD | `bool` | bazodanowe | Podlega PSD | Podlega podatkowi od sprzedaży detalicznej |
| Podmiot | `Soneta.Core.IPodmiot` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| PowstanieObowiazku | `Soneta.EwidencjaVat.PowstanieObowiazkuVAT` (subrow) | bazodanowe |  |  |
| PowstanieObowiazku.IloscDniWarunku | `int` | bazodanowe |  |  |
| PowstanieObowiazku.Kasowe | `Soneta.EwidencjaVat.RozliczenieKasoweVAT` (enum) | bazodanowe |  |  |
| PowstanieObowiazku.Memorialowe | `Soneta.EwidencjaVat.RozliczenieMemorialoweVAT` (enum) | bazodanowe |  |  |
| PowstanieObowiazku.Warunek | `Soneta.EwidencjaVat.WarunekRozliczeniaVAT` (enum) | bazodanowe |  |  |
| PowstanieObowiazku.WarunekPrawoOdliczenia | `bool` | bazodanowe | Prawo odliczenia | Prawo odliczenia VAT, jeżeli rozliczony przez wypełnienie warunku |
| PowstanieObowiazku.Zasada | `Soneta.EwidencjaVat.ZasadaRozliczaniaVAT` (enum) | bazodanowe |  |  |
| ProceduraSME | `bool` | bazodanowe | Procedura SME | Procedura SME |
| Rodzaj | `Soneta.EwidencjaVat.RodzajZakupuVAT` (enum) | bazodanowe |  | Rodzaj zakupu związany z tą pozycją |
| RodzajPodmiotu | `Soneta.Core.RodzajPodmiotu` (enum) | bazodanowe |  | Rodzaj podmiotu |
| RodzajSprzedazy | `Soneta.EwidencjaVat.RodzajSprzedazyVAT` (enum) |  |  |  |
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
| Typ | `Soneta.EwidencjaVat.TypEwidencjiVAT` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| VAT | `Currency` | bazodanowe |  | Wartość podatku |
| WartoscEur | `Soneta.EwidencjaVat.INettoVATBrutto` | tylko-odczyt | Wartości w Eur |  |
| WartoscKsi | `Soneta.EwidencjaVat.INettoVATBrutto` | tylko-odczyt | Wartości księgowe |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Sprzedaż` | 1 | `Soneta.EwidencjaVat.ElemEwidencjiVATSprzedaz` | Element ewidencji VAT - sprzedaż |
| `Zakup` | 2 | `Soneta.EwidencjaVat.ElemEwidencjiVATZakup` | Element ewidencji VAT - zakup |
| `SprzedażAkcyza` | 3 | `Soneta.EwidencjaVat.ElemEwidencjiAkcyzySprzedaz` | Element ewidencji akcyzy - sprzedaż |
| `ZakupAkcyza` | 4 | `Soneta.EwidencjaVat.ElemEwidencjiAkcyzyZakup` | Element ewidencji akcyzy - zakup |

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

### KolumnaKPiRRyczałt (`Soneta.EwidencjaVat.ElemEwidencjiVATAkcyzy.KolumnaKPiRRyczałt`)
- `NieDotyczy` = 0
- `Stawka1` = 101 — 17,00% (20,00% do 31.12.2020) Stawka 1
- `Stawka2` = 102 — 15,00% (17,00% do 31.12.2020) Stawka 2
- `Stawka3` = 103 — 8,50% Stawka 3
- `Stawka4` = 104 — 5,50% Stawka 4
- `Stawka5` = 105 — 3,00% Stawka 5
- `Stawka6` = 106 — 10,00% Stawka 6
- `Stawka7` = 107 — 2,00% Stawka 7
- `Stawka8` = 108 — 12,50% Stawka 8
- `Stawka9` = 109 — 14,00% Stawka 9
- `Stawka10` = 110 — 12,00% Stawka 10

### KolumnaKPiRSprzedaż (`Soneta.EwidencjaVat.ElemEwidencjiVATAkcyzy.KolumnaKPiRSprzedaż`)
- `NieDotyczy` = 0
- `Sprzedaż` = 7 — Sprzedaż
- `PozostałePrzychody` = 8 — Pozostałe przychody

### KolumnaKPiRZakup (`Soneta.EwidencjaVat.ElemEwidencjiVATAkcyzy.KolumnaKPiRZakup`)
- `NieDotyczy` = 0
- `ZakupTowarów` = 10 — Zakup towarów
- `KosztyUboczne` = 11 — Koszty uboczne
- `ReprezentacjaIReklama` = 12 — Reprezentacja i reklama
- `PozostałeKoszty` = 14 — Pozostałe koszty
- `Zaszłości` = 16 — Zaszłości
- `BadaniaIRozwój` = 17 — Badania i rozwój

### NrKolumnyKPiR (`Soneta.EwidencjaVat.NrKolumnyKPiR`)
- `NieDotyczy` = 0
- `Sprzedaż` = 7 — Sprzedaż
- `PozostałePrzychody` = 8 — Pozostałe przychody
- `ZakupTowarów` = 10 — Zakup towarów
- `KosztyUboczne` = 11 — Koszty uboczne
- `ReprezentacjaIReklama` = 12 — Reprezentacja i reklama
- `Wynagrodzenia` = 13 — Wynagrodzenia
- `PozostałeKoszty` = 14 — Pozostałe koszty
- `Zaszłości` = 16 — Zaszłości
- `BadaniaIRozwój` = 17 — Badania i rozwój
- `Remanent` = 99 — Remanent
- `Ryczałt1` = 101 — Ryczałt 1
- `Ryczałt2` = 102 — Ryczałt 2
- `Ryczałt3` = 103 — Ryczałt 3
- `Ryczałt4` = 104 — Ryczałt 4
- `Ryczałt5` = 105 — Ryczałt 5
- `Ryczałt6` = 106 — Ryczałt 6
- `Ryczałt7` = 107 — Ryczałt 7
- `Ryczałt8` = 108 — Ryczałt 8
- `Ryczałt9` = 109 — Ryczałt 9
- `Ryczałt10` = 110 — Ryczałt 10

### OdliczeniaVAT (`Soneta.EwidencjaVat.OdliczeniaVAT`)
- `Tak` = 0 — Tak
- `Nie` = 1 — Nie
- `Warunkowo` = 2 — Warunkowo

### RodzajSprzedazyVAT (`Soneta.EwidencjaVat.RodzajSprzedazyVAT`)
- `Towar` = 0 — Towar
- `Usługi` = 5 — Usługi
- `NabywcaPodatnik` = 7 — Nabywca podatnik - towar
- `UsługiNP` = 10 — Usługi NP
- `VATMarza` = 11 — VAT Marża
- `NabywcaPodatnikUsluga` = 12 — Nabywca podatnik - usługi
- `SpisZNatury` = 13 — Spis z natury
- `KasyRejestrujace` = 14 — Kasy rejestrujące
- `WntSrodkowTransportu` = 15 — WNT śr. transportu
- `WntPaliw` = 16 — WNT paliw
- `SystemKaucyjny` = 19 — System kaucyjny

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

### RozliczenieKasoweVAT (`Soneta.EwidencjaVat.RozliczenieKasoweVAT`)
- `CząstkowoPrzyRozliczeniach` = 0 — Cząstkowo Przy Rozliczeniach
- `PoCałkowitymRozliczeniu` = 1 — Po Całkowitym Rozliczeniu

### RozliczenieMemorialoweVAT (`Soneta.EwidencjaVat.RozliczenieMemorialoweVAT`)
- `WgDatyZaewidencjonowania` = 0 — Wg Daty Zaewidencjonowania
- `WgDatyWplywu` = 1 — Wg Daty Wpływu
- `WgDatyWystawienia` = 2 — Wg Daty Wystawienia
- `WgDatyOperacji` = 3 — Wg Daty Operacji
- `WgTerminuPłatności` = 4 — Wg Terminu Płatności
- `WgDowolnejDaty` = 5 — Wg Dowolnej Daty

### TypEwidencjiVAT (`Soneta.EwidencjaVat.TypEwidencjiVAT`)
- `Brak` = 0 — Brak
- `Sprzedaż` = 1 — Należny
- `Zakup` = 2 — Naliczony
- `SprzedażAkcyza` = 3 — Sprzedaż akcyza
- `ZakupAkcyza` = 4 — Zakup akcyza

### WarunekRozliczeniaVAT (`Soneta.EwidencjaVat.WarunekRozliczeniaVAT`)
- `Brak` = 0 — Brak
- `DniOdDatyWplywu` = 1 — Dni Od Daty Wpływu
- `DniOdDatyWystawienia` = 2 — Dni Od Daty Wystawienia
- `DniOdDatyOperacji` = 3 — Dni Od Daty Operacji
- `DniOdDatyZaewidencjonowania` = 4 — Dni Od Daty Zaewidencjonowania
- `TerminPłatności` = 5 — Termin Płatności
- `DowolnaData` = 6 — Dowolna Data
- `DniaNastępnegoMiesiącaWgDatyOperacji` = 7 — Dnia Następnego Miesiąca Wg Daty Operacji

### ZasadaRozliczaniaVAT (`Soneta.EwidencjaVat.ZasadaRozliczaniaVAT`)
- `Memoriałowa` = 0 — Memoriałowa
- `Kasowa` = 1 — Kasowa
