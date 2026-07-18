# Pola i właściwości klasy biznesowej: `Soneta.Kasa.Platnosc`
Nazwa tabeli: `Platnosci`
Tytuł: Płatności
Opis: Płatność (należność lub zobowiązanie) powstająca z dokumentu płatnego, np. faktury. Reprezentuje kwotę do uregulowania z terminem płatności, sposobem zapłaty i ewidencją ŚP. Podlega rozliczaniu z zapłatami, windykacji, naliczaniu odsetek oraz obsłudze not odsetkowych i mechanizmu podzielonej płatności (MPP).
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IRozliczalny`, `IElementKsiegowalny`, `IZrodloOpisuAnalitycznego`

- pola bazodanowe (zapisywalne): 36
- pola kalkulowane (zapisywalne): 5
- pola tylko-odczyt: 30
- podlisty: 13
- subrowy: 1
- razem: 85

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Automatyczne | `bool` | bazodanowe, tylko-odczyt |  |  |
| BlokadaPrzelewow | `bool` | bazodanowe | Blokada przelewów |  |
| Bufor | `bool` | bazodanowe |  |  |
| CzyNaleznosc | `bool` | tylko-odczyt |  |  |
| CzyZobowiazanie | `bool` | tylko-odczyt |  |  |
| DataDokumentu | `Date` | bazodanowe |  |  |
| DataRozliczenia | `Date` | bazodanowe, tylko-odczyt |  |  |
| DoRozliczenia | `Currency` | tylko-odczyt |  |  |
| Dokument | `Soneta.Kasa.IDokumentPlatny` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| Dokumenty | `SubTable<Soneta.Kasa.RozliczenieSP>` | podlista |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` | tylko-odczyt |  |  |
| EwidencjaSP | `Soneta.Kasa.EwidencjaSP` | bazodanowe |  |  |
| HistoriaWindykacji | `SubTable<Soneta.Windykacja.Windykacja>` | podlista |  |  |
| Info | `int` | bazodanowe, tylko-odczyt |  |  |
| KSeFIlosc | `int` | bazodanowe | Ilość | Podaje się ilość np. dni, od której liczony jest termin płatności za fakturę (np. 14). |
| KSeFJednostka | `string` | bazodanowe | Jednostka | Podaje się jednostkę czasu, w której liczony jest termin płatności za fakturę (np. dzień, tydzień itp.) |
| KSeFOpis | `string` | bazodanowe |  | Opis rachunku KSeF |
| KSeFZdarzeniePoczatkowe | `string` | bazodanowe | Zdarzenie początkowe | Podaje się zdarzenie początkowe, od którego liczony jest termin płatności za fakturę (np. wystawienie faktury). |
| Kierunek | `Soneta.Core.KierunekPlatnosci` (enum) | bazodanowe, tylko-odczyt |  |  |
| KonfiguracjaElementuOpisuAnalitycznego | `Soneta.Core.KonfiguracjaElementuOpisuAnalitycznego` | tylko-odczyt |  |  |
| KorektyPlatnosci | `SubTable<Soneta.Kasa.Platnosc>` | podlista |  |  |
| KsiegujZbiorczo | `bool` | bazodanowe |  |  |
| Kurs | `double` | bazodanowe |  |  |
| Kwota | `Currency` | bazodanowe |  |  |
| KwotaKsiegi | `Currency` | bazodanowe |  |  |
| KwotaMPP | `Currency` | bazodanowe | Kwota VAT/MPP |  |
| KwotaRozliczona | `Currency` | bazodanowe, tylko-odczyt |  |  |
| MozliweMechanizmyMPP | `bool` | tylko-odczyt |  |  |
| NaglowkiRozliczeniaVAT | `SubTable` | podlista |  |  |
| Należność | `Currency` | tylko-odczyt |  |  |
| NieWindykowac | `bool` | bazodanowe |  | Wyłącza płatność z procesu windykacji |
| NumerDokumentu | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| OpisAnalityczny | `SubTable` | podlista |  |  |
| OpisyPowiazane | `SubTable` | podlista |  |  |
| PlatnoscKorygowana | `Soneta.Kasa.Platnosc` | bazodanowe |  | Płatność korygowana |
| PoTerminie | `Currency` | tylko-odczyt |  |  |
| Podmiot | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  |  |
| PozycjeDokRozlicz | `SubTable<Soneta.Kasa.PozycjaDokRozlicz>` | podlista |  |  |
| PozycjePrzelewu | `SubTable<Soneta.Kasa.PozycjaPrzelewu>` | podlista |  |  |
| PreliminarzPoz | `Soneta.Kasa.PreliminarzPozycja` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| Przelano | `Currency` | tylko-odczyt |  |  |
| Rachunek | `Soneta.Kasa.RachunekBankowyPodmiotu` | bazodanowe |  |  |
| RachunekWirtualny | `string` | bazodanowe |  |  |
| RachunekWirtualnyUI | `string` | tylko-odczyt |  |  |
| RodzajSkladkiZUS | `Soneta.Kasa.RodzajSkladkiZUS` (enum) | bazodanowe |  |  |
| Rozliczana | `bool` | bazodanowe |  |  |
| Rozliczenia | `System.Collections.IList` | podlista |  |  |
| RozliczoneDokumenty | `string` | tylko-odczyt |  |  |
| Rozliczono | `bool` | tylko-odczyt |  |  |
| Rozrachunki | `SubTable<Soneta.Kasa.RozrachunekIdx>` | podlista |  |  |
| SkrocenieTerminu | `Date` | tylko-odczyt |  |  |
| SposobZaplaty | `Soneta.Kasa.SposobZaplaty` | bazodanowe |  |  |
| SprawaWindykacyjna | `Soneta.Windykacja.SprawaWindykacyjna` | tylko-odczyt |  |  |
| StanNoty | `Soneta.Kasa.PlatnoscStanNoty` (enum) | bazodanowe |  | Stan płatności z punktu widzenia naliczania not odsetkowych |
| StanRozliczenia | `Soneta.Kasa.StanRozliczenia` (enum) | tylko-odczyt |  |  |
| StornoPlatnosci | `bool` | bazodanowe |  | Storno płatności przez dokument korekty |
| Słownie | `string` | tylko-odczyt |  |  |
| TabelaKursowa | `Soneta.Waluty.TabelaKursowa` | bazodanowe |  |  |
| Termin | `Date` | bazodanowe |  |  |
| TerminDni | `int` |  | Termin |  |
| TerminLiczonyOd | `Date` | bazodanowe, tylko-odczyt |  | Data odniesienia do wyliczenia terminu płatności |
| TerminPlanowany | `Date` | bazodanowe |  |  |
| TerminPlanowanyDni | `int` |  | Termin planowany - dni |  |
| TerminPlanowanyDniOdTerminu | `int` |  | Termin planowany - dni od terminu |  |
| TerminZleDlugi | `Date` | tylko-odczyt |  |  |
| Typ | `Soneta.Kasa.TypRozrachunku` (enum) | tylko-odczyt |  |  |
| TypPrzelewu | `Soneta.Kasa.TypPrzelewu` (enum) | bazodanowe |  |  |
| US | `Soneta.Kasa.OpisPrzelewu.US` | tylko-odczyt |  |  |
| WeryfikacjaTransakcji | `Soneta.Kasa.IWeryfikacjaTransakcji` | tylko-odczyt |  |  |
| Windykacja | `Soneta.Windykacja.WindykacjaInfo` (subrow) | bazodanowe |  |  |
| Windykacja.Data | `Date` | bazodanowe |  |  |
| Windykacja.Stan | `Soneta.Windykacja.StanWindykacji` | bazodanowe |  |  |
| Windykacja.Termin | `Date` | bazodanowe |  |  |
| Windykacja.WgStan | `Key` | podlista |  |  |
| WysylajNipWPodmiocieTrzecimKSeF | `bool` | bazodanowe | Czy wysyłać NIP w podmiocie trzecim dla roli płatnika. | Czy wysyłać NIP w podmiocie trzecim dla roli płatnika. |
| ZUS | `Soneta.Kasa.OpisPrzelewu.ZUS` | tylko-odczyt |  |  |
| ZapisyKsiegowe | `SubTable` | podlista |  |  |
| Zaplaty | `SubTable<Soneta.Kasa.RozliczenieSP>` | podlista |  |  |
| Zatwierdzona | `bool` |  |  |  |
| Zobowiązanie | `Currency` | tylko-odczyt |  |  |
| Zrealizowane | `bool` | tylko-odczyt |  |  |
| Zwrot | `bool` |  |  |  |
| ZwrotInfo | `Soneta.Kasa.InformacjaOZwrocie` (enum) | bazodanowe |  |  |

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
