# Pola i właściwości klasy biznesowej: `Soneta.Kasa.Platnosc`
Nazwa tabeli: `Platnosci`
Tytuł: Płatności
Opis: Płatność (należność lub zobowiązanie) powstająca z dokumentu płatnego, np. faktury. Reprezentuje kwotę do uregulowania z terminem płatności, sposobem zapłaty i ewidencją ŚP. Podlega rozliczaniu z zapłatami, windykacji, naliczaniu odsetek oraz obsłudze not odsetkowych i mechanizmu podzielonej płatności (MPP).
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IRozliczalny`, `IElementKsiegowalny`, `IZrodloOpisuAnalitycznego`

- pola bazodanowe: 44
- pola kalkulowane (z klas biznesowych): 41

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Automatyczne | `bool` | bazodanowe |  |  |
| BlokadaPrzelewow | `bool` | bazodanowe | Blokada przelewów |  |
| Bufor | `bool` | bazodanowe |  |  |
| CzyNaleznosc | `bool` |  |  |  |
| CzyZobowiazanie | `bool` |  |  |  |
| DataDokumentu | `Soneta.Types.Date` | bazodanowe |  |  |
| DataRozliczenia | `Soneta.Types.Date` | bazodanowe |  |  |
| DoRozliczenia | `Soneta.Types.Currency` |  |  |  |
| Dokument | `Soneta.Kasa.IDokumentPlatny` | bazodanowe, iface-ref |  |  |
| Dokumenty | `Soneta.Business.SubTable<Soneta.Kasa.RozliczenieSP>` |  |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` |  |  |  |
| EwidencjaSP | `Soneta.Kasa.EwidencjaSP` | bazodanowe |  |  |
| HistoriaWindykacji | `Soneta.Business.SubTable<Soneta.Windykacja.Windykacja>` |  |  |  |
| Info | `int` | bazodanowe |  |  |
| KSeFIlosc | `int` | bazodanowe | Ilość | Podaje się ilość np. dni, od której liczony jest termin płatności za fakturę (np. 14). |
| KSeFJednostka | `string` | bazodanowe | Jednostka | Podaje się jednostkę czasu, w której liczony jest termin płatności za fakturę (np. dzień, tydzień itp.) |
| KSeFOpis | `string` | bazodanowe |  | Opis rachunku KSeF |
| KSeFZdarzeniePoczatkowe | `string` | bazodanowe | Zdarzenie początkowe | Podaje się zdarzenie początkowe, od którego liczony jest termin płatności za fakturę (np. wystawienie faktury). |
| Kierunek | `Soneta.Core.KierunekPlatnosci` | bazodanowe, enum |  |  |
| KonfiguracjaElementuOpisuAnalitycznego | `Soneta.Core.KonfiguracjaElementuOpisuAnalitycznego` |  |  |  |
| KorektyPlatnosci | `Soneta.Business.SubTable<Soneta.Kasa.Platnosc>` |  |  |  |
| KsiegujZbiorczo | `bool` | bazodanowe |  |  |
| Kurs | `double` | bazodanowe |  |  |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| KwotaKsiegi | `Soneta.Types.Currency` | bazodanowe |  |  |
| KwotaMPP | `Soneta.Types.Currency` | bazodanowe | Kwota VAT/MPP |  |
| KwotaRozliczona | `Soneta.Types.Currency` | bazodanowe |  |  |
| MozliweMechanizmyMPP | `bool` |  |  |  |
| NaglowkiRozliczeniaVAT | `Soneta.Business.SubTable` |  |  |  |
| Należność | `Soneta.Types.Currency` |  |  |  |
| NieWindykowac | `bool` | bazodanowe |  | Wyłącza płatność z procesu windykacji |
| NumerDokumentu | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| OpisAnalityczny | `Soneta.Business.SubTable` |  |  |  |
| OpisyPowiazane | `Soneta.Business.SubTable` |  |  |  |
| PlatnoscKorygowana | `Soneta.Kasa.Platnosc` | bazodanowe |  | Płatność korygowana |
| PoTerminie | `Soneta.Types.Currency` |  |  |  |
| Podmiot | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  |  |
| PozycjeDokRozlicz | `Soneta.Business.SubTable<Soneta.Kasa.PozycjaDokRozlicz>` |  |  |  |
| PozycjePrzelewu | `Soneta.Business.SubTable<Soneta.Kasa.PozycjaPrzelewu>` |  |  |  |
| PreliminarzPoz | `Soneta.Kasa.PreliminarzPozycja` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| Przelano | `Soneta.Types.Currency` |  |  |  |
| Rachunek | `Soneta.Kasa.RachunekBankowyPodmiotu` | bazodanowe |  |  |
| RachunekWirtualny | `string` | bazodanowe |  |  |
| RachunekWirtualnyUI | `string` |  |  |  |
| RodzajSkladkiZUS | `Soneta.Kasa.RodzajSkladkiZUS` | bazodanowe, enum |  |  |
| Rozliczana | `bool` | bazodanowe |  |  |
| Rozliczenia | `System.Collections.IList` |  |  |  |
| RozliczoneDokumenty | `string` |  |  |  |
| Rozliczono | `bool` |  |  |  |
| Rozrachunki | `Soneta.Business.SubTable<Soneta.Kasa.RozrachunekIdx>` |  |  |  |
| SkrocenieTerminu | `Soneta.Types.Date` |  |  |  |
| SposobZaplaty | `Soneta.Kasa.SposobZaplaty` | bazodanowe |  |  |
| SprawaWindykacyjna | `Soneta.Windykacja.SprawaWindykacyjna` |  |  |  |
| StanNoty | `Soneta.Kasa.PlatnoscStanNoty` | bazodanowe, enum |  | Stan płatności z punktu widzenia naliczania not odsetkowych |
| StanRozliczenia | `Soneta.Kasa.StanRozliczenia` | enum |  |  |
| StornoPlatnosci | `bool` | bazodanowe |  | Storno płatności przez dokument korekty |
| Słownie | `string` |  |  |  |
| TabelaKursowa | `Soneta.Waluty.TabelaKursowa` | bazodanowe |  |  |
| Termin | `Soneta.Types.Date` | bazodanowe |  |  |
| TerminDni | `int` |  | Termin |  |
| TerminLiczonyOd | `Soneta.Types.Date` | bazodanowe |  | Data odniesienia do wyliczenia terminu płatności |
| TerminPlanowany | `Soneta.Types.Date` | bazodanowe |  |  |
| TerminPlanowanyDni | `int` |  | Termin planowany - dni |  |
| TerminPlanowanyDniOdTerminu | `int` |  | Termin planowany - dni od terminu |  |
| TerminZleDlugi | `Soneta.Types.Date` |  |  |  |
| Typ | `Soneta.Kasa.TypRozrachunku` | enum |  |  |
| TypPrzelewu | `Soneta.Kasa.TypPrzelewu` | bazodanowe, enum |  |  |
| US | `Soneta.Kasa.OpisPrzelewu.US` |  |  |  |
| WeryfikacjaTransakcji | `Soneta.Kasa.IWeryfikacjaTransakcji` |  |  |  |
| Windykacja | `Soneta.Windykacja.WindykacjaInfo` | bazodanowe |  |  |
| Windykacja.Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Windykacja.Stan | `Soneta.Windykacja.StanWindykacji` | bazodanowe |  |  |
| Windykacja.Termin | `Soneta.Types.Date` | bazodanowe |  |  |
| Windykacja.WgStan | `Soneta.Business.Key` |  |  |  |
| WysylajNipWPodmiocieTrzecimKSeF | `bool` | bazodanowe | Czy wysyłać NIP w podmiocie trzecim dla roli płatnika. | Czy wysyłać NIP w podmiocie trzecim dla roli płatnika. |
| ZUS | `Soneta.Kasa.OpisPrzelewu.ZUS` |  |  |  |
| ZapisyKsiegowe | `Soneta.Business.SubTable` |  |  |  |
| Zaplaty | `Soneta.Business.SubTable<Soneta.Kasa.RozliczenieSP>` |  |  |  |
| Zatwierdzona | `bool` |  |  |  |
| Zobowiązanie | `Soneta.Types.Currency` |  |  |  |
| Zrealizowane | `bool` |  |  |  |
| Zwrot | `bool` |  |  |  |
| ZwrotInfo | `Soneta.Kasa.InformacjaOZwrocie` | bazodanowe, enum |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Dokument | `IDokumentPlatny` | `Deklaracja`, `DokEwidencji`, `DokRozliczBase`, `DokumentHandlowy`, `Skladka`, `Wyplata` |
| Podmiot | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KierunekPlatnosci (`Soneta.Core.KierunekPlatnosci`)
- `Brak` = 0
- `Przychod` = 1 — Przychód
- `Rozchod` = 2 — Rozchód

### InformacjaOZwrocie (`Soneta.Kasa.InformacjaOZwrocie`)
- `Zwrot` = -1
- `Nieokreslona` = 0
- `Dokument` = 1

### PlatnoscStanNoty (`Soneta.Kasa.PlatnoscStanNoty`)
- `WymagaInicjalizacji` = 0
- `NieNaliczaj` = 1 — Nie naliczaj
- `Naliczaj` = 2
- `NieDotyczy` = 3
- `RozliczonoWTerminie` = 4
- `RozliczonoStandardowe` = 5 — Rozliczono (standardowe)
- `RozliczonoPoTerminie` = 6

### RodzajSkladkiZUS (`Soneta.Kasa.RodzajSkladkiZUS`)
- `NieDotyczy` = 0
- `Zbiorcza` = 1
- `UbSpoleczne` = 2 — Ub. społeczne
- `UbZdrowotne` = 3 — Ub. zdrowotne
- `FP` = 4 — FP i FGŚP
- `FEP` = 5 — FEP

### StanRozliczenia (`Soneta.Kasa.StanRozliczenia`)
- `Nierozliczony` = 0
- `Czesciowo` = 1 — Częściowo
- `Calkowicie` = 2 — Rozliczony
- `NiePodlega` = 3

### TypPrzelewu (`Soneta.Kasa.TypPrzelewu`)
- `Brak` = 0
- `Standardowy` = 1
- `PrzelewZUS` = 2 — ZUS
- `PrzelewPIT` = 3 — PIT
- `Walutowy` = 4 — Walutowy

### TypRozrachunku (`Soneta.Kasa.TypRozrachunku`)
- `Należność` = 10
- `Zobowiązanie` = 11
- `Wpłata` = 20
- `Wypłata` = 21
