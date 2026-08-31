# Pola i właściwości klasy biznesowej: `Soneta.Handel.DefRelacjiHandlowej`
Nazwa tabeli: `DefRelHandlowych`
Tytuł: Definicje relacji handlowych
Opis: Konfigurowalna definicja relacji między dokumentami handlowymi. Określa typ relacji (kopiowanie, korygowanie itp.), zasady przenoszenia danych, pozycji, kontrahenta, dat i walut między dokumentem nadrzędnym a podrzędnym.
Tabela konfiguracyjna: Tak
Guided: root
Selektor: pole `Typ` (`Soneta.Handel.TypRelacjiHandlowej`) — wiele typów w jednej tabeli, podtypów: 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AutoKompensata | `bool` | bazodanowe |  | Automatycznie tworzy kompensate. |
| Blokada | `bool` | bazodanowe |  | Określa zablokowanie relacji. Zablokowane definicje relacji dokumentów nie wpływają na dokumenty. |
| CechaWidocznosc | `FeatureDefinition` | bazodanowe |  | Cecha dokumentu handlowego (warunek, algorytm z argumentem DefDokPodrzednego) umożliwiająca ograniczenie dostępnych przekształceń dokumentów w relacjach. |
| DefinicjaNadrzednego | `Soneta.Handel.DefDokHandlowego` | bazodanowe | Def. dokumentu nadrzędnego | Definicja dokumentu nadrzędnego, z którego pochodzi relacja |
| DefinicjaPodrzednego | `Soneta.Handel.DefDokHandlowego` |  |  |  |
| DefinicjaPodrzednego2 | `Soneta.Handel.DefDokHandlowego` |  |  |  |
| DefinicjaPodrzednego3 | `Soneta.Handel.DefDokHandlowego` |  |  |  |
| DefinicjaPodrzednego4 | `Soneta.Handel.DefDokHandlowego` |  |  |  |
| Flags | `Soneta.Handel.Helpers.Flags` (enum) | bazodanowe |  | Flagi dodatkowe. |
| Hidden | `bool` | bazodanowe |  | Określa, czy definicja jest ukryta w menu Relacje. |
| Numer | `int` | bazodanowe |  | Określa numer relacji podrzędnej w typie. |
| PełnaNazwa | `string` | tylko-odczyt |  |  |
| PodrzedneDefinicje | `SubTable<Soneta.Handel.RelacjeDokumentow.DefDokPodrzednego>` | podlista |  |  |
| SposobKopiowania | `Soneta.Handel.SposobKopiowaniaPozycji` (enum) | bazodanowe |  | Określa sposób kopiowania wartości pozycji dokumentów handlowych do dokumentów podrzędnych. |
| SposobKopiowaniaKorekta | `Soneta.Handel.SposobKopiowaniaPozycji` (enum) | bazodanowe | Wartość pozycji przenoszona na korektę | Określa sposób kopiowania wartości pozycji na korekty automatyczne. |
| Typ | `Soneta.Handel.TypRelacjiHandlowej` (enum) | bazodanowe, tylko-odczyt, selektor |  | Określa typ relacji opisujący jej zachowanie |
| ZNadrzednego | `Soneta.Handel.DefRelacjiZ` (subrow) | bazodanowe |  | Określa zasady tworzenia dokumentów podrzędnych z nadrzędnych. |
| ZNadrzednego.AnulujNierozliczone | `bool` | bazodanowe |  | Anuluj nierozliczone pozycje. |
| ZNadrzednego.AutomatycznieNowy | `bool` | bazodanowe |  | Dokument zależny jest tworzony automatycznie dla nowego dokumentu. |
| ZNadrzednego.DlaKorygowanego | `bool` | bazodanowe |  | Możliwość tworzenia nadrzędnego korygowanego. |
| ZNadrzednego.IstniejacyDokument | `bool` | bazodanowe |  | Możliwość dołączania istniejących dokumentów zależnych. |
| ZNadrzednego.Kasowanie | `Soneta.Handel.KasowanieRelacji` (enum) | bazodanowe |  | Zachowanie dokumentu zależnego podczas kasowania dokumentu. |
| ZNadrzednego.Klawisz | `Soneta.Commands.CommandShortcut` (enum) | bazodanowe |  | Skrót klawiaturowy wywołujący dokument z danej relacji. |
| ZNadrzednego.Nazwa | `string` | bazodanowe |  | Nazwa dokumentu widoczna z dokumentu. |
| ZNadrzednego.NowyDokument | `bool` | bazodanowe |  | Możliwość tworzenia nowego dokumentu zależnego. |
| ZNadrzednego.PodczasZatwierdzaniaNowy | `bool` | bazodanowe |  | Dokument zależny jest tworzony automatycznie podczas zatwierdzania dokumentu. |
| ZNadrzednego.Recznie | `bool` | bazodanowe |  | Dokument zależny może być tworzony ręcznie dla dokumentów w buforze. |
| ZNadrzednego.RecznieZatwierdzony | `bool` | bazodanowe |  | Dokument zależny może być tworzony ręcznie dla zatwierdzonych dokumentów. |
| ZNadrzednego.RozliczajPozycje | `bool` | bazodanowe |  | Możliwość rozliczania istniejących pozycji dokumentów zależnych. |
| ZNadrzednego.WieleDokumentow | `bool` | bazodanowe |  | Możliwość tworzenia lub dołączania wielu dokumentów zależnych. |
| ZPodrzednego | `Soneta.Handel.DefRelacjiZ` (subrow) | bazodanowe |  | Określa zasady tworzenia dokumentów nadrzędnych z podrzędnych. |
| Zachowanie | `Soneta.Handel.ZachowanieRelacji` (subrow) | bazodanowe |  |  |
| Zachowanie.AutomatycznaKorektaWgPodrzednego | `bool` | bazodanowe | Automatycznie generuj korektę dokumentu magazynowego po zmianie wartości handlowego | Generuje korektę magazynowego, której celem jest synchronizacja wartości zasobów magazynowych z wartością dokumentu handlowego. |
| Zachowanie.AutomatyczniePrzeliczajKosztWytworzenia | `bool` | bazodanowe |  |  |
| Zachowanie.BlokujOtwarcie | `bool` | bazodanowe |  | Blokuje otwarcie zamkniętego dokumentu nadrzędnego, dopóki istnieje relacja. |
| Zachowanie.CechaLaczenia | `string` | bazodanowe |  | Cecha wykorzystywana podczas łączenia pozcyji na dokumencie podrzędnym. |
| Zachowanie.DaneKontrahentaZKarty | `bool` | bazodanowe |  | Określa, czy dane kontrahenta mają być pobierane z kartoteki, czy z dokumentu nadrzędnego. |
| Zachowanie.DataDokumentu | `Soneta.Handel.SposobPrzenoszeniaDaty` (enum) | bazodanowe |  | Sposób inicjowania daty dokumentu podrzędnego z dokumentu nadrzędnego. |
| Zachowanie.DataDostawy | `Soneta.Handel.SposobPrzenoszeniaDaty` (enum) | bazodanowe |  | Sposób inicjowania daty dostawy dokumentu podrzędnego z dokumentu nadrzędnego. |
| Zachowanie.DataKorekty | `Soneta.Handel.SposobPrzenoszeniaDaty` (enum) | bazodanowe | Data korekty |  |
| Zachowanie.DataKursu | `Soneta.Handel.SposobPrzenoszeniaDaty` (enum) | bazodanowe |  | Sposób inicjowania daty kursu dokumentu podrzędnego z dokumentu nadrzędnego. |
| Zachowanie.DataObcy | `Soneta.Handel.SposobPrzenoszeniaDaty` (enum) | bazodanowe |  | Sposób inicjowania daty obcej dokumentu podrzędnego z dokumentu nadrzędnego. |
| Zachowanie.DataOperacji | `Soneta.Handel.SposobPrzenoszeniaDaty` (enum) | bazodanowe |  | Sposób inicjowania daty operacji dokumentu podrzędnego z dokumentu nadrzędnego. |
| Zachowanie.DodajRelacjeDoPrzesylki | `bool` | bazodanowe |  | Jeśli na dokumencie nadrzędnym istnieje przesyłka to zostaje dodana relacja do kolejnego dokumentu |
| Zachowanie.DomyslnyMagazynInfo | `Soneta.Handel.DomyslnyMagazynInfo` (subrow) | bazodanowe | Reguły inicjowania magazynu. |  |
| Zachowanie.DomyslnyMagazynInfo.Cecha | `FeatureDefinition` | bazodanowe | Cecha ustalająca magazyn | Określa cechę dokumentu (algorytmiczną i referencyjną do tabeli Magazyny) wskazującą magazyn dokumentu podrzędnego. |
| Zachowanie.DomyslnyMagazynInfo.SposobUstalania | `Soneta.Handel.ZrodloMagazynu` (enum) | bazodanowe | Magazyn dokumentu podrzędnego | Określa sposób ustalania magazynu na dokumencie podrzędnym. |
| Zachowanie.DomyslnyMagazynInfo.WgCecha | `Key` | podlista |  |  |
| Zachowanie.DostawcaWg | `Soneta.Towary.DostawcaWedług` (enum) | bazodanowe |  | Określa sposób ustalania dostawcy towaru. |
| Zachowanie.DowolnaData | `bool` | bazodanowe |  | Określa, czy data dokumentu podrzędnego może być wcześniejsza niż dokumentu nadrzędnego. |
| Zachowanie.DziedziczyUstawienia | `bool` | bazodanowe |  | Pewne ustawienia dokumentu nie zależą od definicji, tylko od dokumentu nadrzędnego. |
| Zachowanie.FiltrPozycji | `string` | bazodanowe |  |  |
| Zachowanie.FiltrPozycjiTechnologii | `Soneta.Handel.FiltrPozycjiTechnologii` (enum) | bazodanowe |  | Określa jakie pozycje technologii mają być przenoszone do dokumentów podrzednych. |
| Zachowanie.FiltrTowarow | `Soneta.Towary.TypFiltruTowaru` (enum) | bazodanowe |  | Określa jakie pozycje towarów mają być przenoszone do dokumentów podrzednych. |
| Zachowanie.InicjalizatorStawkiVatInfo | `Soneta.Handel.InicjalizatorStawkiVatDefRelacjiInfo` (subrow) | bazodanowe | Reguły inicjacji stawki VAT. | Ustawienia inicjacji stawki VAT dla pozycji podrzędnego w relacji. |
| Zachowanie.InicjalizatorStawkiVatInfo.ZrodloStawkiVat | `Soneta.Handel.ZrodloStawkiVat` (enum) | bazodanowe |  | Określa źródło stawki VAT dla pozycji podrzędnej w relacji. |
| Zachowanie.InicjalizatorWalutyInfo | `Soneta.Handel.InicjalizatorWalutyInfo` (subrow) | bazodanowe | Reguły doboru walut. | Ustawienia sposobu doboru walut dla: wartości pozycji, wartości dokumentu lub płatności. |
| Zachowanie.InicjalizatorWalutyInfo.KursWaluty | `Soneta.Handel.ZrodloKursuWaluty` (enum) | bazodanowe |  | Określa źródło pozyskania kursu waluty. |
| Zachowanie.InicjalizatorWalutyInfo.WalutaPlatnosci | `Soneta.Handel.ZrodloWaluty` (enum) | bazodanowe |  | Określa źródło pozyskania waluty dla podsumowania/płatności dokumentu podrzędnego. |
| Zachowanie.InicjalizatorWalutyInfo.WalutaPozycji | `Soneta.Handel.ZrodloWaluty` (enum) | bazodanowe |  | Określa na źródło pozyskania waluty dla wartości pozycji dokumentu podrzędnego. |
| Zachowanie.JestFiltrPozycji | `bool` | tylko-odczyt |  |  |
| Zachowanie.Kontrahent | `Soneta.Handel.SposobPrzenoszeniaKontrahenta` (enum) | bazodanowe |  | Określa sposób przenoszenia kontrahenta z dokumentu nadrzędnego do dokuemntu podrzędnego. |
| Zachowanie.KontrahentCecha | `FeatureDefinition` | bazodanowe | Cecha ustalająca kontrahenta | Określa cechę dokumentu (algorytmiczną i referencyjną do tabeli Kontrahenci) wskazującą kontrahenta i odbiorcę dokumentu podrzędnego. |
| Zachowanie.KopiujCechyDokumentu | `bool` | bazodanowe |  | Wymusza kopiowanie cech dokumentu z dokumentu nadrzędnego do podrzędnego. |
| Zachowanie.KopiujCechyPozycji | `bool` | bazodanowe |  | Wymusza kopiowanie cech pozycji z dokumentu nadrzędnego do podrzędnego. |
| Zachowanie.KopiujDaneKontaktowe | `bool` | bazodanowe |  | Wymusza kopiowanie danych kontaktowych z dokumentu nadrzędnego do podrzędnego. |
| Zachowanie.KopiujNumerObcy | `bool` | bazodanowe |  | Wymusza kopiowanie numeru obcego z dokumentu nadrzędnego do podrzędnego. |
| Zachowanie.KopiujOpis | `Soneta.Handel.KopiujOpis` (enum) | bazodanowe |  | Wymusza kopiowanie opisu dokumentu z dokumentu nadrzędnego do podrzędnego. |
| Zachowanie.KopiujSerie | `Soneta.Handel.ZrodloDanychPrzyPrzeksztalcaniu` (enum) | bazodanowe | Przenoszenie serii | Sposób przenoszenia serii. |
| Zachowanie.KopiujZadaniaCRM | `bool` | bazodanowe |  | Wymusza kopiowanie zadań CRM z dokumentu nadrzędnego do podrzędnego. |
| Zachowanie.KorektaWartosci | `bool` | bazodanowe |  | Wartość dokumentu nadrzędnego wpływa na wartość podrzędnego (dotyczy również sum VAT). |
| Zachowanie.LaczeniePozycji | `Soneta.Handel.SposobLaczeniaPozycji` (enum) | bazodanowe |  | Określa reguły łączenia wielu pozycji z dokumentu nadrzędnego w dokumencie podrzędnym. |
| Zachowanie.OpisAnalitycznyInfo | `Soneta.Core.KopiowanieOpisuAnalitycznego` (subrow) | bazodanowe | Konfiguracja kopiowania opisu analitycznego |  |
| Zachowanie.OpisAnalitycznyInfo.Cecha | `FeatureDefinition` | bazodanowe |  | Cecha warunkująca kopiowania opisu analitycznego |
| Zachowanie.OpisAnalitycznyInfo.MaskaWymiaru | `string` | bazodanowe |  | Maska wymiaru |
| Zachowanie.OpisAnalitycznyInfo.SposobKopiowania | `Soneta.Core.SposobKopiowaniaOpisuAnalitycznego` (enum) | bazodanowe |  | Sposób kopiowania opisu analitycznego |
| Zachowanie.OpisAnalitycznyInfo.WgCecha | `Key` | podlista |  |  |
| Zachowanie.PlatnoscKaucji | `Soneta.Handel.PlatnoscKaucji` (enum) | bazodanowe | Płatność kaucji |  |
| Zachowanie.PomniejszajIloscZarezerwowana | `bool` | bazodanowe | Pomniejszaj ilość zarezerwowaną | Określa, czy na dokumencie ma być pomniejszana ilość zarezerwowana z dokumentu podrzędnego. |
| Zachowanie.PozwalajNaZmianePlatnosciKaucji | `bool` | bazodanowe |  | Dozwolona zmiana rodzaju płatności na dokumencie kaucji z poziomu dokumentu sprzedaży. |
| Zachowanie.PrzenoszenieDanychEParagon | `bool` | bazodanowe | Przenoszenie danych do e-paragonu | Przenoszenie danych do e-paragonu. |
| Zachowanie.PrzenoszenieGratisow | `Soneta.Handel.SposobPrzenoszeniaGratisow` (enum) | bazodanowe | Sposób przenoszenia gratisów (naliczonych automatycznie) |  |
| Zachowanie.PrzenoszenieIlosci | `Soneta.Handel.SposobPrzenoszeniaIlosci` (enum) | bazodanowe | Sposób przenoszenia pozycji | Określa sposób przenoszenia ilości i wartości do podrzędnej pozycji dokumentu. |
| Zachowanie.PrzenoszenieRozliczonychPozycji | `Soneta.Handel.SposobPrzenoszeniaRozliczonychPozycji` (enum) | bazodanowe | Sposób przenoszenia rozliczonych pozycji | Określa sposób przenoszenia ilości i wartości rozliczonej pozycji do podrzędnej pozycji dokumentu. |
| Zachowanie.PrzepisujDatyDostawy | `bool` | bazodanowe | Przepisuj daty dostawy | Określa, czy daty dostawy mają być przepisywane z dokumentu nadrzędnego na podrzędny. |
| Zachowanie.RozliczenieZKorektami | `bool` | bazodanowe | Korekta dok. podrzędnego zmienia rozliczenie relacji | Określa, czy korekta dok. podrzędnego zmienia rozliczenie relacji. |
| Zachowanie.SchematPodzialowyDok | `Soneta.Core.ISchematPodziałowy` | bazodanowe, iface-ref | Schemat podziałowy opisu analitycznego dla dokumentu |  |
| Zachowanie.SchematPodzialowyPoz | `Soneta.Core.ISchematPodziałowy` | bazodanowe, iface-ref | Schemat podziałowy opisu analitycznego dla pozycji |  |
| Zachowanie.SposobFiltrowaniaPozycji | `Soneta.Handel.SposobFiltrowaniaPozycjiDokumentuNadrzednego` (enum) | bazodanowe |  |  |
| Zachowanie.SposobKorektyMagazynowego | `Soneta.Handel.SposobKorektyMagazynowego` (enum) | bazodanowe |  | Określa sposób generowania korekty dokumentu magazynowego. |
| Zachowanie.SposobPrzenoszniaPlatnosciDokumentu | `Soneta.Handel.SposobPrzenoszniaPlatnosciDokumentu` (enum) | bazodanowe |  |  |
| Zachowanie.SynchroniujStan | `bool` | bazodanowe |  | Określa, czy dokumenty będące w relacji mają być jednocześnie otwierane i zamykane (zmiana stanu dokumentu). |
| Zachowanie.UsuwajAutomatycznie | `bool` | bazodanowe |  | Określa, czy relacja kopiowania będzie rozłączana po zatwierdzeniu dokumentu podrzędnego, gdy ten nie rozlicza nadrzędnego. |
| Zachowanie.UwzgledniajPowiazanyDoPodrzPrzeciwnyDokOpakowan | `bool` | bazodanowe |  | Uwzględniaj w płatnościach i w KSeF powiązany do dokumentu opakowań dokument opakowań o przeciwnym kierunku |
| Zachowanie.UwzgledniajUstawieniePlatnosciKaucji | `bool` | bazodanowe |  | W relacji kopiowania do dokumentu wydania/przyjecia opakowań steruje sposobem uwzględniania parametru Płatność Kaucji z dokumentu nadrzędnego |
| Zachowanie.VatWgPodrzednego | `bool` | bazodanowe |  | Określa, czy VAT będzie liczony wg ustawień w definicji dokumentu podrzędnego, jeśli metoda liczenia VAT w dokumencie nadrzędnym jest inna niż w definicji dokumentu podrzędnego. |
| Zachowanie.WartoscZPrzeciwnymZnakiem | `bool` | bazodanowe |  |  |
| Zachowanie.WgKontrahentCecha | `Key` | podlista |  |  |
| Zachowanie.WgSchematPodzialowyDok | `Key` | podlista |  |  |
| Zachowanie.WgSchematPodzialowyPoz | `Key` | podlista |  |  |
| Zachowanie.WielePozycji | `bool` | bazodanowe |  | Określa, czy do jednej pozycji nadrzędnej może istnieć wiele pozycji podrzędnych. |
| Zachowanie.WyborPozycji | `Soneta.Handel.WyborPozycjiDlaRelacji` (enum) | bazodanowe |  | Określa formularz wyświetlany podczas tworzenia dokumentu podrzędnego, w którym można wybrać dodatkowe informacje o dokumencie podrzędnym. |
| Zachowanie.WyliczanieIlosci | `Soneta.Handel.SposobWyliczaniaIlosci` (enum) | bazodanowe |  | Określa sposób wyliczania ilości przenoszonej do podrzędnej pozycji dokumentu. |
| Zachowanie.ZasobyZNadrzednego | `bool` | bazodanowe | Zasoby z nadrzędnego | Na pozycji podrzędnego powstaje wskazanie dostawy i pobierany jest zasób utworzony przez pozycję nadrzędnego. |
| Zachowanie.ZastepowanieProduktowSkladnikami | `bool` | bazodanowe |  | Określa, czy w relacji kopiowania produkt na pozycji nadrzędnej zostanie zastąpiony składnikami na pozycji podrzędnej. |
| Zachowanie.ZrodloNazwyTowaru | `Soneta.Handel.ZrodloDanychPrzyPrzeksztalcaniu` (enum) | bazodanowe | Zródło nazwy towaru | Określa skąd pobierana ma być nazwa towaru na pozycje. |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Korekta` | 1 | `Soneta.Handel.DefRelacjiKorekta` | Korekta |
| `Kopiowania` | 2 | `Soneta.Handel.DefRelacjiKopiowania` | Kopiowanie |
| `HandlowoMagazynowa` | 3 | `Soneta.Handel.DefRelacjiMagazynowa` | Handlowo-magazynowa |
| `Przesunięcie` | 4 | `Soneta.Handel.DefRelacjiPrzesunięcia` | Przesunięcie |
| `Inwentaryzacja` | 6 | `Soneta.Handel.DefRelacjiInwentaryzacja` | Inwentaryzacja |
| `Kompletacja` | 9 | `Soneta.Handel.DefRelacjiKompletacji` | Kompletacja |
| `Wiązania` | 11 | `Soneta.Handel.DefRelacjiWiązania` | Wiązanie |
| `Zaliczka` | 12 | `Soneta.Handel.DefRelacjiZaliczki` | Relacja zaliczki |
| `Cykliczna` | 13 | `Soneta.Handel.DefRelacjiCykliczna` | Cykliczna |
| `Kaucji` | 14 | `Soneta.Handel.DefRelacjiKaucji` | Kaucji |
| `ProdukcjaSurowce` | 16 | `Soneta.Handel.DefRelacjiProdukcja.Surowce` | Produkcyjna surowce |
| `ProdukcjaProdukty` | 17 | `Soneta.Handel.DefRelacjiProdukcja.Produkty` | Produkcyjna produkty |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Zachowanie.SchematPodzialowyDok | `ISchematPodziałowy` | `SchematPodz` |
| Zachowanie.SchematPodzialowyPoz | `ISchematPodziałowy` | `SchematPodz` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### CommandShortcut (`Soneta.Commands.CommandShortcut`)
- `A` = 65
- `Add` = 107
- `Alt` = 262144
- `Apps` = 93
- `Attn` = 246
- `B` = 66
- `Back` = 8
- `BrowserBack` = 166
- `BrowserFavorites` = 171
- `BrowserForward` = 167
- `BrowserHome` = 172
- `BrowserRefresh` = 168
- `BrowserSearch` = 170
- `BrowserStop` = 169
- `C` = 67
- `Cancel` = 3
- `Capital` = 20
- `CapsLock` = 20
- `Clear` = 12
- `Control` = 131072
- `ControlKey` = 17
- `Crsel` = 247
- `D` = 68
- `D0` = 48
- `D1` = 49
- `D2` = 50
- `D3` = 51
- `D4` = 52
- `D5` = 53
- `D6` = 54
- `D7` = 55
- `D8` = 56
- `D9` = 57
- `Decimal` = 110
- `Delete` = 46
- `Divide` = 111
- `Down` = 40
- `E` = 69
- `End` = 35
- `Enter` = 13
- `EraseEof` = 249
- `Escape` = 27
- `Execute` = 43
- `Exsel` = 248
- `F` = 70
- `F1` = 112
- `F10` = 121
- `F11` = 122
- `F12` = 123
- `F13` = 124
- `F14` = 125
- `F15` = 126
- `F16` = 127
- `F17` = 128
- `F18` = 129
- `F19` = 130
- `F2` = 113
- `F20` = 131
- `F21` = 132
- `F22` = 133
- `F23` = 134
- `F24` = 135
- `F3` = 114
- `F4` = 115
- `F5` = 116
- `F6` = 117
- `F7` = 118
- `F8` = 119
- `F9` = 120
- `ShiftF1` = 65648
- `ShiftF10` = 65657
- `ShiftF11` = 65658
- `ShiftF12` = 65659
- `ShiftF13` = 65660
- `ShiftF14` = 65661
- `ShiftF15` = 65662
- `ShiftF16` = 65663
- `ShiftF17` = 65664
- `ShiftF18` = 65665
- `ShiftF19` = 65666
- `ShiftF2` = 65649
- `ShiftF20` = 65667
- `ShiftF21` = 65668
- `ShiftF22` = 65669
- `ShiftF23` = 65670
- `ShiftF24` = 65671
- `ShiftF3` = 65650
- `ShiftF4` = 65651
- `ShiftF5` = 65652
- `ShiftF6` = 65653
- `ShiftF7` = 65654
- `ShiftF8` = 65655
- `ShiftF9` = 65656
- `ControlF1` = 131184
- `ControlF10` = 131193
- `ControlF11` = 131194
- `ControlF12` = 131195
- `ControlF13` = 131196
- `ControlF14` = 131197
- `ControlF15` = 131198
- `ControlF16` = 131199
- `ControlF17` = 131200
- `ControlF18` = 131201
- `ControlF19` = 131202
- `ControlF2` = 131185
- `ControlF20` = 131203
- `ControlF21` = 131204
- `ControlF22` = 131205
- `ControlF23` = 131206
- `ControlF24` = 131207
- `ControlF3` = 131186
- `ControlF4` = 131187
- `ControlF5` = 131188
- `ControlF6` = 131189
- `ControlF7` = 131190
- `ControlF8` = 131191
- `ControlF9` = 131192
- `AltF1` = 262256
- `AltF10` = 262265
- `AltF11` = 262266
- `AltF12` = 262267
- `AltF13` = 262268
- `AltF14` = 262269
- `AltF15` = 262270
- `AltF16` = 262271
- `AltF17` = 262272
- `AltF18` = 262273
- `AltF19` = 262274
- `AltF2` = 262257
- `AltF20` = 262275
- `AltF21` = 262276
- `AltF22` = 262277
- `AltF23` = 262278
- `AltF24` = 262279
- `AltF3` = 262258
- `AltF4` = 262259
- `AltF5` = 262260
- `AltF6` = 262261
- `AltF7` = 262262
- `AltF8` = 262263
- `AltF9` = 262264
- `FinalMode` = 24
- `G` = 71
- `H` = 72
- `HanguelMode` = 21
- `HangulMode` = 21
- `HanjaMode` = 25
- `Help` = 47
- `Home` = 36
- `I` = 73
- `IMEAccept` = 30
- `IMEAceept` = 30
- `IMEConvert` = 28
- `IMEModeChange` = 31
- `IMENonconvert` = 29
- `Insert` = 45
- `J` = 74
- `JunjaMode` = 23
- `K` = 75
- `KanaMode` = 21
- `KanjiMode` = 25
- `KeyCode` = 65535
- `L` = 76
- `LaunchApplication1` = 182
- `LaunchApplication2` = 183
- `LaunchMail` = 180
- `LButton` = 1
- `LControlKey` = 162
- `Left` = 37
- `LineFeed` = 10
- `LMenu` = 164
- `LShiftKey` = 160
- `LWin` = 91
- `M` = 77
- `MButton` = 4
- `MediaNextTrack` = 176
- `MediaPlayPause` = 179
- `MediaPreviousTrack` = 177
- `MediaStop` = 178
- `Menu` = 18
- `Modifiers` = -65536
- `Multiply` = 106
- `N` = 78
- `Next` = 34
- `NoName` = 252
- `None` = 0
- `NumLock` = 144
- `NumPad0` = 96
- `NumPad1` = 97
- `NumPad2` = 98
- `NumPad3` = 99
- `NumPad4` = 100
- `NumPad5` = 101
- `NumPad6` = 102
- `NumPad7` = 103
- `NumPad8` = 104
- `NumPad9` = 105
- `O` = 79
- `Oem1` = 186
- `Oem102` = 226
- `Oem2` = 191
- `Oem3` = 192
- `Oem4` = 219
- `Oem5` = 220
- `Oem6` = 221
- `Oem7` = 222
- `Oem8` = 223
- `OemBackslash` = 226
- `OemClear` = 254
- `OemCloseBrackets` = 221
- `Oemcomma` = 188
- `OemMinus` = 189
- `OemOpenBrackets` = 219
- `OemPeriod` = 190
- `OemPipe` = 220
- `Oemplus` = 187
- `OemQuestion` = 191
- `OemQuotes` = 222
- `OemSemicolon` = 186
- `Oemtilde` = 192
- `P` = 80
- `Pa1` = 253
- `Packet` = 231
- `PageDown` = 34
- `PageUp` = 33
- `Pause` = 19
- `Play` = 250
- `Print` = 42
- `PrintScreen` = 44
- `Prior` = 33
- `ProcessKey` = 229
- `Q` = 81
- `R` = 82
- `RButton` = 2
- `RControlKey` = 163
- `Return` = 13
- `Right` = 39
- `RMenu` = 165
- `RShiftKey` = 161
- `RWin` = 92
- `S` = 83
- `Scroll` = 145
- `Select` = 41
- `SelectMedia` = 181
- `Separator` = 108
- `Shift` = 65536
- `ShiftKey` = 16
- `Sleep` = 95
- `Snapshot` = 44
- `Space` = 32
- `Subtract` = 109
- `T` = 84
- `Tab` = 9
- `U` = 85
- `Up` = 38
- `V` = 86
- `VolumeDown` = 174
- `VolumeMute` = 173
- `VolumeUp` = 175
- `W` = 87
- `X` = 88
- `XButton1` = 5
- `XButton2` = 6
- `Y` = 89
- `Z` = 90
- `Zoom` = 251

### SposobKopiowaniaOpisuAnalitycznego (`Soneta.Core.SposobKopiowaniaOpisuAnalitycznego`)
- `Brak` = 0
- `Wszystkie` = 1
- `WgMaskiWymiaru` = 2
- `WgCechy` = 3

### FiltrPozycjiTechnologii (`Soneta.Handel.FiltrPozycjiTechnologii`)
- `Default` = 0
- `Produkt` = 1 — Produkty
- `Polprodukt` = 16 — Półprodukty
- `Surowiec` = 256 — Surowce
- `RazemProdukty` = 17 — Razem
- `RazemSurowce` = 272 — Razem

### Flags (`Soneta.Handel.Helpers.Flags`)
- `None` = 0
- `KWPZAgregowanieWgDokumentow` = 1
- `KWPZAgregowanieGroup` = 1
- `KursWalutyZmieniony` = 2
- `KursWalutyGroup` = 2
- `ZmianaZatwierdzonegoDokumentu` = 4
- `ZmianaZatwierdzonegoDokumentuGroup` = 4
- `ZmianaParametrowZasobuZmianaIlosci` = 16
- `ZmianaParametrowZasobuZmianaWartosc` = 32
- `ZmianaParametrowZasobuGroup` = 48
- `DodatkoweStornoZasobuWZamknietymOkresie` = 256

### KasowanieRelacji (`Soneta.Handel.KasowanieRelacji`)
- `Zakazane` = 0 — Zakazane
- `TylkoRelacja` = 1
- `ZDokumentem` = 2

### KopiujOpis (`Soneta.Handel.KopiujOpis`)
- `NieKopiować` = 0 — Nie kopiować
- `KopiowaćOstatni` = 1
- `KopiowaćWszystkie` = 2

### PlatnoscKaucji (`Soneta.Handel.PlatnoscKaucji`)
- `WgKartotekiKontrahenta` = 0 — Wg karty kontrahenta
- `NaliczajDlaOpakowan` = 1 — Naliczaj dla opakowań
- `NaliczajDlaSystemuKaucyjnego` = 2 — Naliczaj dla systemu kaucyjnego
- `NaliczajDlaWszystkich` = 3 — Naliczaj dla wszystkich
- `NieNaliczajDlaWszystkich` = 4 — Nie naliczaj dla wszystkich

### SposobFiltrowaniaPozycjiDokumentuNadrzednego (`Soneta.Handel.SposobFiltrowaniaPozycjiDokumentuNadrzednego`)
- `WgDefinicjiRelacji` = 0
- `WgDefinicjiPodrzednego` = 1 — Wg definicji podrzędnego
- `Brak` = 100

### SposobKopiowaniaPozycji (`Soneta.Handel.SposobKopiowaniaPozycji`)
- `Standardowo` = 0 — Standardowo
- `WartościStatystycznej` = 1
- `WartościFakturowej` = 2
- `WartościMagazynowej` = 3
- `KosztuWytworzenia` = 4
- `StandardowoZWaluta` = 5

### SposobKorektyMagazynowego (`Soneta.Handel.SposobKorektyMagazynowego`)
- `Brak` = 0 — Nie generuj
- `Reczny` = 1 — Ręcznie. Niezależne korekty faktury i dokumentu magazynowego
- `Automatyczny` = 2 — Automatycznie

### SposobLaczeniaPozycji (`Soneta.Handel.SposobLaczeniaPozycji`)
- `BezŁączenia` = 0 — Bez łączenia
- `TylkoTowar` = 1
- `WedługCeny` = 2
- `WedługCechyPozycji` = 3

### SposobPrzenoszeniaDaty (`Soneta.Handel.SposobPrzenoszeniaDaty`)
- `Standardowy` = 0
- `Dzisiejsza` = 1
- `ZDatyDokumentu` = 2 — Z głównej daty dokumentu
- `ZDatyOperacji` = 3 — Z daty operacji dokumentu
- `ZDokumentuObcego` = 4 — Z daty otrzymania dokumentu
- `ZDatyKursu` = 5 — Z daty kursu waluty
- `ZDatyDostawy` = 6

### SposobPrzenoszeniaGratisow (`Soneta.Handel.SposobPrzenoszeniaGratisow`)
- `IloscICena` = 0 — Ilość i cena
- `NiePrzenosic` = 1 — Nie przenosić

### SposobPrzenoszeniaIlosci (`Soneta.Handel.SposobPrzenoszeniaIlosci`)
- `IlośćIWartość` = 0
- `TylkoIlość` = 1
- `TylkoInicjuje` = 2
- `NiePrzenosiPozycji` = 3
- `IlośćICena` = 4
- `UslugiWgWartosci` = 5 — Ilość i wartość, usługi tylko wg wartości

### SposobPrzenoszeniaKontrahenta (`Soneta.Handel.SposobPrzenoszeniaKontrahenta`)
- `KontrahentaIOdbiorcę` = 0
- `TylkoKontrahenta` = 1
- `TylkoOdbiorcę` = 2
- `NiePrzenosić` = 3
- `PłatnikLubKontrahent` = 4
- `KontrahentIOdbiorca` = 5 — Kontrahent, gdy wielu odbiorców
- `Dostawca` = 6 — Dostawcę towaru
- `WgCechy` = 7 — Kontrahenta i odbiorcę wg cechy

### SposobPrzenoszeniaRozliczonychPozycji (`Soneta.Handel.SposobPrzenoszeniaRozliczonychPozycji`)
- `NiePrzenosic` = 0 — Nie przenosić
- `ZerowaIloscLubWartosc` = 1 — Przenosić z zerową ilością lub wartością
- `Ilosc` = 2 — Ilość

### SposobPrzenoszniaPlatnosciDokumentu (`Soneta.Handel.SposobPrzenoszniaPlatnosciDokumentu`)
- `ZNadrzednegoSposobPlatnosci` = 0 — Z nadrzędnego sposób zapłaty
- `NiePrzenosic` = 1 — Nie przenosić
- `ZNadrzednegoWszystkiePlatnosci` = 2 — Z nadrzędnego wszystkie zapłaty

### SposobWyliczaniaIlosci (`Soneta.Handel.SposobWyliczaniaIlosci`)
- `ZNadrzędnego` = 0 — Z nadrzędnego
- `ZNadrzędnegoMagazynowa` = 1 — Z nadrzędnego magazynowa
- `TylkoKorektyDodatnie` = 2
- `TylkoKorektyUjemne` = 3
- `ZNadrzednegoZrealizowana` = 4 — Z nadrzędnego zrealizowana
- `ZNadrzednegoRoznicaRealizacji` = 5 — Z nadrzędnego różnica realizacji

### TypRelacjiHandlowej (`Soneta.Handel.TypRelacjiHandlowej`)
- `Brak` = 0
- `Korekta` = 1
- `Kopiowania` = 2
- `HandlowoMagazynowa` = 3
- `Przesunięcie` = 4
- `PrzesunięcieDo` = 5
- `Inwentaryzacja` = 6
- `InwentaryzacjaStrata` = 7
- `KorektaPWZ` = 8
- `Kompletacja` = 9
- `KompletacjaSkładniki` = 10
- `Wiązania` = 11
- `Zaliczka` = 12
- `Cykliczna` = 13
- `Kaucji` = 14
- `RozliczenieKaucji` = 15
- `ProdukcjaSurowce` = 16 — Produkcyjna surowce
- `ProdukcjaProdukty` = 17 — Produkcyjna produkty

### WyborPozycjiDlaRelacji (`Soneta.Handel.WyborPozycjiDlaRelacji`)
- `BrakOkna` = 0 — Brak okna
- `WybórMagazynu` = 1
- `WybórPozycji` = 2
- `WybórPozycjiKopiuj` = 3
- `WybórSposobuRozliczenia` = 4

### ZrodloDanychPrzyPrzeksztalcaniu (`Soneta.Handel.ZrodloDanychPrzyPrzeksztalcaniu`)
- `ZNadrzednego` = 0 — Z nadrzędnego
- `ZDefinicjiPodrzednego` = 1 — Z definicji podrzędnego

### ZrodloKursuWaluty (`Soneta.Handel.ZrodloKursuWaluty`)
- `WgDatyKursu` = 0
- `ZNadrzednego` = 1 — Z nadrzędnego

### ZrodloMagazynu (`Soneta.Handel.ZrodloMagazynu`)
- `ZNadrzednego` = 0 — Z nadrzędnego
- `WedlugCechy` = 1 — Według cechy
- `ZNadrzednegoZrodlowy` = 2 — Z nadrzędnego źródłowy

### ZrodloStawkiVat (`Soneta.Handel.ZrodloStawkiVat`)
- `Towar` = 0 — Kartoteka towaru
- `PozycjaNadrzedna` = 1 — Pozycja dokumentu nadrzędnego
- `RelacjaCykliczna` = 2

### ZrodloWaluty (`Soneta.Handel.ZrodloWaluty`)
- `None` = 0
- `ZNadrzednego` = 1 — Z nadrzędnego
- `ZKartyKontrahenta` = 2 — Z karty kontrahenta
- `ZDefinicjiPodrzednego` = 4 — Z definicji podrzędnego
- `ZDefinicji` = 8 — Z definicji dokumentu
- `ZCennika` = 16 — Z cennika
- `ZrodloWalutyWRelacjiPlatnosc` = 7
- `ZrodloWalutyWRelacjiPozycja` = 7
- `ZrodloWalutyPlatnosc` = 10
- `ZrodloWalutyPozycja` = 26

### DostawcaWedług (`Soneta.Towary.DostawcaWedług`)
- `KartyTowaru` = 0 — Karty towaru
- `OstatnieZamówienie` = 1
- `OstatniZakup` = 2
- `NajtańszaOfertaZaakceptowana` = 3
- `WybioręPóźniej` = 4

### TypFiltruTowaru (`Soneta.Towary.TypFiltruTowaru`)
- `Razem` = 0
- `Towary` = 1
- `Usługi` = 2
- `Produkty` = 4
- `Wariantowe` = 5
- `Receptury` = 8
- `ProduktyIReceptury` = 12
- `NieUsługi` = 4096
- `TowaryUE` = 8192 — Towary UE
- `TowaryUEUslugi` = 8194 — Towary UE i usługi
- `TowaryNieUE` = 12288 — Towary nie UE
- `Opakowania` = 16384
- `NieOpakowania` = 20480
- `NabywcaPodatnik` = 32768
- `Odpady` = 65536
- `Gratis` = 73728
- `RazemZRecepturami` = 131072
- `TowaryKGO` = 262144 — Towary z KGO
