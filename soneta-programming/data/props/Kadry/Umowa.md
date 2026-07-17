# Pola i właściwości klasy biznesowej: `Soneta.Kadry.Umowa`
Nazwa tabeli: `Umowy`
Tytuł: Umowy
Opis: Umowa cywilnoprawna (zlecenie, o dzieło) zawarta z pracownikiem. Zawiera dane dokumentu, okres obowiązywania, definicję elementu płacowego, wartość, serię listy płac, stawkę VAT oraz informacje o spłacie i rozliczeniu.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBazaZrodlaWyplaty`, `IPowiązanieWypłaty`, `IZrodloDeklaracji`, `IZrodloPodzielnikaKosztow`, `IPowiązanieDodatku`, `IRozliczenieWynagrodzeniaHost`, `IZestawienieDietZagrHost`, `IZestawienieDietPakietMobilHost`, `IUmowaZKalendarzem`, `IBilansOtwarcia`, `IKwotaSplacanaBO`, `IZrodloPlanu`, `IDostepnoscHost`, `IZrodloNieobecnosci`, `IZrodloWnioskuONieobecnosc`

- pola bazodanowe: 35
- pola kalkulowane (z klas biznesowych): 47

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anulowana | `bool` | bazodanowe |  |  |
| BilansOtwarcia | `bool` | bazodanowe |  |  |
| Brutto | `Soneta.Types.Currency` |  |  |  |
| BruttoSłownie | `string` |  | Słownie |  |
| BruttoSłownieUpr | `string` |  | Słownie |  |
| CRU | `bool` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DataSplaty | `Soneta.Types.Date` | bazodanowe |  |  |
| DataSplatyBO | `Soneta.Types.Date` | bazodanowe |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| DefinicjaStawki | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe |  | Definicja stawki VAT |
| Deklaracje | `Soneta.Business.SubTable` |  |  |  |
| DniPlanu | `Soneta.Business.DateSubTable` |  |  |  |
| DniPracyUmowy | `Soneta.Business.DateSubTable<Soneta.Kalend.DzienPracyUmowy>` |  |  |  |
| Dodatki | `Soneta.Business.SubTable<Soneta.Kadry.Dodatek>` |  |  |  |
| Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Elementy | `Soneta.Business.SubTable<Soneta.Place.WypElement>` |  |  |  |
| ElementyAktywne | `System.Collections.Generic.ICollection<Soneta.Place.WypElement>` |  |  |  |
| Historia | `Soneta.Business.HistorySubTable<Soneta.Kadry.UmowaHistoria>` |  |  |  |
| IsVisibleUstawKwoteBO | `bool` |  |  |  |
| IsVisibleWłączBO | `bool` |  |  |  |
| KalendarzeUmowy | `Soneta.Business.SubTable<Soneta.Kalend.KalendarzBase>` |  |  |  |
| Kod | `string` |  |  |  |
| KwotaSplaconaBO | `Soneta.Types.Currency` | bazodanowe |  |  |
| Last | `Soneta.Kadry.UmowaHistoria` |  |  |  |
| MinimalnaStawkaGodz | `bool` | bazodanowe |  |  |
| NaliczaćPodatekRyczałtowy | `bool` |  |  |  |
| Nieobecnosci | `Soneta.Business.FromToSubTable<Soneta.Kalend.Nieobecnosc>` |  |  |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| NumerPelny | `string` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| PodlegaVAT | `bool` | bazodanowe |  |  |
| Podzielniki | `Soneta.Business.SubTable<Soneta.Core.PodzielnikKosztow>` |  |  |  |
| Pozostało | `Soneta.Types.Currency` |  |  |  |
| PracHistoria | `Soneta.Kadry.PracHistoria` |  |  |  |
| PracaWPolsce | `Soneta.Types.Periods` |  |  |  |
| PracaZaGranicą | `Soneta.Types.Periods` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| RegulyDostepnosci | `Soneta.Business.SubTable<Soneta.Kalend.RegulaDostepnosci>` |  |  |  |
| RodzajRozliczenia | `Soneta.Kadry.RodzajeRozliczeniaUmowy` | bazodanowe, enum |  |  |
| RozliczeniaWynagrodzenia | `Soneta.Business.LpSubTable<Soneta.Place.RozliczenieWynagrodzenia>` |  |  |  |
| RozliczenieCzasu | `Soneta.Business.SubTable` |  |  |  |
| RozliczenieUmowy | `Soneta.Business.SubTable` |  |  |  |
| RozliczenieWynagrodzenia | `Soneta.Place.RozliczenieWynagrodzenia` |  |  |  |
| Seria | `string` | bazodanowe |  |  |
| Splacono | `Soneta.Types.Currency` | bazodanowe |  |  |
| SplaconoZBO | `Soneta.Types.Currency` |  |  |  |
| Stan | `Soneta.Kadry.StanUmowy` | enum |  |  |
| SąAktywneElementy | `bool` |  |  |  |
| Słownie | `string` |  |  |  |
| SłownieUpr | `string` |  | Słownie |  |
| TypWartosci | `Soneta.Kadry.TypWartosciUmowy` | bazodanowe, enum |  |  |
| Tytul | `string` | bazodanowe |  |  |
| Ubezpieczenia | `Soneta.Kadry.Ubezpieczenia` |  |  |  |
| Umowa | `Soneta.Kadry.Umowa` |  |  |  |
| UmowaOkresowa | `bool` |  |  |  |
| Wartosc | `Soneta.Types.Currency` |  |  |  |
| WnioskiUrlopowe | `Soneta.Business.SubTable<Soneta.Kadry.WniosekUrlopowy>` |  |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
| Wynajmujący | `Soneta.CRM.Kontrahent` |  |  |  |
| Wypowiedzenie | `Soneta.Kadry.UmowaWypowiedzenie` | bazodanowe |  |  |
| Wypowiedzenie.DataZlozenia | `Soneta.Types.Date` | bazodanowe | Data złożenia | Data złożenia wypowiedzenia |
| Wypowiedzenie.Dni | `int` | bazodanowe | Dni | Okres wypowiedzenia - dni |
| Wypowiedzenie.Miesiace | `int` | bazodanowe | Miesiące | Okres wypowiedzenia - miesiące |
| Wypowiedzenie.Tygodnie | `int` | bazodanowe | Tygodnie | Okres wypowiedzenia - tygodnie |
| Wypowiedzenie.Uplywa | `Soneta.Types.Date` | bazodanowe | Upływa | Data upływu ukresu wypowiedzenia |
| ZaGranica | `Soneta.Kadry.ZleceniobiorcaZaGranicą` | bazodanowe |  |  |
| ZaGranica.OddelegowanyDo | `Soneta.Kadry.IKrajDelegacji` | bazodanowe, iface-ref |  |  |
| ZaGranica.PodatekZaGranica | `bool` | bazodanowe |  |  |
| ZaGranica.UmowaZaGranicą | `bool` |  |  |  |
| ZaGranica.WgOddelegowanyDo | `Soneta.Business.Key` |  |  |  |
| ZestDietPakietMobil | `Soneta.Business.SubTable<Soneta.Kalend.ZestDietPakietMobil>` |  |  |  |
| Zestawienia | `Soneta.Business.FromToSubTable<Soneta.Kalend.ZestawienieUmowy>` |  |  |  |
| ZestawieniaDiet | `Soneta.Business.FromToSubTable<Soneta.Kalend.ZestawienieDietZagr>` |  |  |  |
| ZgloszenieRUD | `bool` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| ZaGranica.OddelegowanyDo | `IKrajDelegacji` | `KrajDelegacji` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajeRozliczeniaUmowy (`Soneta.Kadry.RodzajeRozliczeniaUmowy`)
- `KwotaDoWypłaty` = 0
- `StawkaZaOkres` = 1
- `StawkaZaGodzinę` = 2

### StanUmowy (`Soneta.Kadry.StanUmowy`)
- `Niewypłacona` = 0 — Wprowadzona
- `WypłaconaCzęściowo` = 1
- `WypłaconaCałkowicie` = 2
- `Anulowana` = 10

### TypWartosciUmowy (`Soneta.Kadry.TypWartosciUmowy`)
- `Brutto` = 0
- `Netto` = 1
