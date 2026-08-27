# Pola i właściwości klasy biznesowej: `Soneta.Kadry.Umowa`
Nazwa tabeli: `Umowy`
Tytuł: Umowy
Opis: Umowa cywilnoprawna (zlecenie, o dzieło) zawarta z pracownikiem. Zawiera dane dokumentu, okres obowiązywania, definicję elementu płacowego, wartość, serię listy płac, stawkę VAT oraz informacje o spłacie i rozliczeniu.
Tabela konfiguracyjna: Nie
Guided: root
Historyczna: Tak — wersje (historia) w tabeli `UmowaHistoria`
Implementuje interfejsy: `IBazaZrodlaWyplaty`, `IPowiązanieWypłaty`, `IZrodloDeklaracji`, `IZrodloPodzielnikaKosztow`, `IPowiązanieDodatku`, `IRozliczenieWynagrodzeniaHost`, `IZestawienieDietZagrHost`, `IZestawienieDietPakietMobilHost`, `IUmowaZKalendarzem`, `IBilansOtwarcia`, `IKwotaSplacanaBO`, `IZrodloPlanu`, `IDostepnoscHost`, `IZrodloNieobecnosci`, `IZrodloWnioskuONieobecnosc`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anulowana | `bool` | bazodanowe, tylko-odczyt |  |  |
| BilansOtwarcia | `bool` | bazodanowe |  |  |
| CRU | `bool` | bazodanowe |  |  |
| Data | `Date` | bazodanowe |  |  |
| DataSplaty | `Date` | bazodanowe, tylko-odczyt |  |  |
| DataSplatyBO | `Date` | bazodanowe |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| DefinicjaStawki | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe |  | Definicja stawki VAT |
| Deklaracje | `SubTable` | podlista |  |  |
| DniPlanu | `DateSubTable` | podlista |  |  |
| DniPracyUmowy | `DateSubTable<Soneta.Kalend.DzienPracyUmowy>` | podlista |  |  |
| Dodatki | `SubTable<Soneta.Kadry.Dodatek>` | podlista |  |  |
| Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Elementy | `SubTable<Soneta.Place.WypElement>` | podlista |  |  |
| ElementyAktywne | `System.Collections.Generic.ICollection<Soneta.Place.WypElement>` | podlista |  |  |
| Historia | `HistorySubTable<Soneta.Kadry.UmowaHistoria>` | podlista |  |  |
| IsVisibleUstawKwoteBO | `bool` | tylko-odczyt |  |  |
| IsVisibleWłączBO | `bool` | tylko-odczyt |  |  |
| KalendarzeUmowy | `SubTable<Soneta.Kalend.KalendarzBase>` | podlista |  |  |
| Kod | `string` | tylko-odczyt |  |  |
| KwotaSplaconaBO | `Currency` | bazodanowe |  |  |
| Last | `Soneta.Kadry.UmowaHistoria` | tylko-odczyt |  |  |
| MinimalnaStawkaGodz | `bool` | bazodanowe |  |  |
| NaliczaćPodatekRyczałtowy | `bool` | tylko-odczyt |  |  |
| Nieobecnosci | `FromToSubTable<Soneta.Kalend.Nieobecnosc>` | podlista |  |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| PodlegaVAT | `bool` | bazodanowe |  |  |
| Podzielniki | `SubTable<Soneta.Core.PodzielnikKosztow>` | podlista |  |  |
| Pozostało | `Currency` | tylko-odczyt |  |  |
| PracHistoria | `Soneta.Kadry.PracHistoria` | tylko-odczyt |  |  |
| PracaWPolsce | `Periods` | tylko-odczyt |  |  |
| PracaZaGranicą | `Periods` | tylko-odczyt |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| RegulyDostepnosci | `SubTable<Soneta.Kalend.RegulaDostepnosci>` | podlista |  |  |
| RodzajRozliczenia | `Soneta.Kadry.RodzajeRozliczeniaUmowy` (enum) | bazodanowe |  |  |
| RozliczeniaWynagrodzenia | `LpSubTable<Soneta.Place.RozliczenieWynagrodzenia>` | podlista |  |  |
| RozliczenieCzasu | `SubTable` | podlista |  |  |
| RozliczenieUmowy | `SubTable` | podlista |  |  |
| RozliczenieWynagrodzenia | `Soneta.Place.RozliczenieWynagrodzenia` | tylko-odczyt |  |  |
| Seria | `string` | bazodanowe |  |  |
| Splacono | `Currency` | bazodanowe, tylko-odczyt |  |  |
| SplaconoZBO | `Currency` | tylko-odczyt |  |  |
| Stan | `Soneta.Kadry.StanUmowy` (enum) | tylko-odczyt |  |  |
| SąAktywneElementy | `bool` | tylko-odczyt |  |  |
| TypWartosci | `Soneta.Kadry.TypWartosciUmowy` (enum) | bazodanowe |  |  |
| Tytul | `string` | bazodanowe |  |  |
| UmowaOkresowa | `bool` | tylko-odczyt |  |  |
| WnioskiUrlopowe | `SubTable<Soneta.Kadry.WniosekUrlopowy>` | podlista |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
| Wynajmujący | `Soneta.CRM.Kontrahent` | tylko-odczyt |  |  |
| Wypowiedzenie | `Soneta.Kadry.UmowaWypowiedzenie` (subrow) | bazodanowe |  |  |
| Wypowiedzenie.DataZlozenia | `Date` | bazodanowe | Data złożenia | Data złożenia wypowiedzenia |
| Wypowiedzenie.Dni | `int` | bazodanowe | Dni | Okres wypowiedzenia - dni |
| Wypowiedzenie.Miesiace | `int` | bazodanowe | Miesiące | Okres wypowiedzenia - miesiące |
| Wypowiedzenie.Tygodnie | `int` | bazodanowe | Tygodnie | Okres wypowiedzenia - tygodnie |
| Wypowiedzenie.Uplywa | `Date` | bazodanowe | Upływa | Data upływu ukresu wypowiedzenia |
| ZaGranica | `Soneta.Kadry.ZleceniobiorcaZaGranicą` (subrow) | bazodanowe |  |  |
| ZaGranica.OddelegowanyDo | `Soneta.Kadry.IKrajDelegacji` | bazodanowe, iface-ref |  |  |
| ZaGranica.PodatekZaGranica | `bool` | bazodanowe |  |  |
| ZaGranica.UmowaZaGranicą | `bool` | tylko-odczyt |  |  |
| ZaGranica.WgOddelegowanyDo | `Key` | podlista |  |  |
| ZestDietPakietMobil | `SubTable<Soneta.Kalend.ZestDietPakietMobil>` | podlista |  |  |
| Zestawienia | `FromToSubTable<Soneta.Kalend.ZestawienieUmowy>` | podlista |  |  |
| ZestawieniaDiet | `FromToSubTable<Soneta.Kalend.ZestawienieDietZagr>` | podlista |  |  |
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
