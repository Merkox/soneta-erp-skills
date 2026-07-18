# Pola i właściwości klasy biznesowej: `Soneta.Kadry.UmowaHistoria`
Nazwa tabeli: `UmowaHistorie`
Tytuł: Umowy
Opis: Element szczegółowy umowy (Umowa). Wersja historyczna umowy cywilnoprawnej rejestrująca zmiany wartości, ubezpieczeń, kodu zawodu, kalendarza i ulg podatkowych w kolejnych okresach aktualności.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Umowa` → `Umowa`
Historia: Tak — zapis historyczny tabeli `Umowa`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista |  |  |
| BilansOtwarcia | `bool` |  |  |  |
| Brutto | `Currency` | tylko-odczyt |  |  |
| BruttoSłownie | `string` | tylko-odczyt | Słownie |  |
| BruttoSłownieUpr | `string` | tylko-odczyt | Słownie |  |
| DataSplatyBO | `Date` |  |  |  |
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe |  |  |
| DefinicjaStanowiskaHistoria | `Soneta.HR.DefinicjaStanowiskaHist` | tylko-odczyt |  |  |
| DochodPodstawowy | `bool` | bazodanowe |  |  |
| EfektywnyOkres | `FromTo` | podlista |  |  |
| IndywidualnyKalendarz | `bool` | bazodanowe |  |  |
| InterpretacjaKalendarza | `Soneta.Kadry.InterpretacjaKalendarza` (enum) | bazodanowe |  |  |
| IsVisibleUstawKwoteBO | `bool` | tylko-odczyt |  |  |
| IsVisibleWłączBO | `bool` | tylko-odczyt |  |  |
| Kalendarz | `Soneta.Kalend.Kalendarz` | bazodanowe |  | Domyślny kalendarz umowy |
| KodWykonywanegoZawodu | `Soneta.Kadry.KodWykonywanegoZawodu` | bazodanowe |  |  |
| KwotaSplaconaBO | `Currency` |  |  |  |
| Oddział | `Soneta.Core.OddzialFirmy` | tylko-odczyt |  |  |
| OpisAktualizacji | `MemoText` | bazodanowe, podlista | Opis aktualizacji | Opis aktualizacji zapisu |
| PakietMobilnosci | `bool` | bazodanowe |  |  |
| Parent | `Row` | tylko-odczyt |  |  |
| PotracenieCalkowite | `bool` | bazodanowe |  |  |
| PowodAktualizacji | `string` | bazodanowe, tylko-odczyt | Powód aktualizacji | Opis powodu aktualizacji zapisu |
| SprawdźUbezpieczenie | `Soneta.Kadry.UmowaHistoria.SprawdźUbezpieczenieResult` (enum) | tylko-odczyt |  |  |
| Stanowisko | `string` | bazodanowe |  |  |
| Słownie | `string` | tylko-odczyt |  |  |
| SłownieUpr | `string` | tylko-odczyt | Słownie |  |
| TypWartosci | `Soneta.Kadry.TypWartosciUmowy` (enum) |  |  |  |
| Ubezpieczenia | `Soneta.Kadry.Ubezpieczenia` (subrow) | bazodanowe |  |  |
| Ubezpieczenia.Chorobowe | `Soneta.Kadry.Spoleczne` (subrow) | bazodanowe |  |  |
| Ubezpieczenia.Emerytalne | `Soneta.Kadry.Spoleczne` (subrow) | bazodanowe |  |  |
| Ubezpieczenia.Emerytalne.Do | `Date` | bazodanowe |  |  |
| Ubezpieczenia.Emerytalne.Dobrowolne | `bool` |  |  |  |
| Ubezpieczenia.Emerytalne.DobrowolneOd | `Date` |  |  |  |
| Ubezpieczenia.Emerytalne.KodPrzyczyny | `Soneta.Kadry.PrzyczynaWyrejestrowania` (enum) |  |  |  |
| Ubezpieczenia.Emerytalne.Obowiazkowe | `bool` |  |  |  |
| Ubezpieczenia.Emerytalne.ObowiazkoweOd | `Date` | tylko-odczyt |  |  |
| Ubezpieczenia.Emerytalne.ObowiązujeOd | `Date` | tylko-odczyt |  |  |
| Ubezpieczenia.Emerytalne.Od | `Date` | bazodanowe |  |  |
| Ubezpieczenia.Emerytalne.Okres | `FromTo` | podlista |  |  |
| Ubezpieczenia.Emerytalne.Przyczyna | `Soneta.Kadry.Wyrejestrowanie` | bazodanowe |  |  |
| Ubezpieczenia.Emerytalne.Typ | `Soneta.Kadry.TypUbezpieczenia` (enum) | bazodanowe |  |  |
| Ubezpieczenia.Emerytalne.UbezpieczenieOd | `Date` | tylko-odczyt |  |  |
| Ubezpieczenia.Emerytalne.Ubezpieczony | `bool` | tylko-odczyt |  |  |
| Ubezpieczenia.Emerytalne.Wyrejestrowany | `bool` |  |  |  |
| Ubezpieczenia.Historia | `Soneta.Kadry.PracHistoria` | tylko-odczyt |  |  |
| Ubezpieczenia.Host | `Soneta.Kadry.IUbezpieczenieHost` | tylko-odczyt |  |  |
| Ubezpieczenia.Kontynuacja | `Soneta.Kadry.KontynuacjaUbezpieczenia` (subrow) | bazodanowe |  |  |
| Ubezpieczenia.Kontynuacja.OdDnia | `Date` | bazodanowe |  |  |
| Ubezpieczenia.Kontynuacja.Tyub | `int` | tylko-odczyt |  |  |
| Ubezpieczenia.Kontynuacja.Tyub4 | `Soneta.Kadry.TytulUbezpieczenia4` | bazodanowe | Tytuł ubezpieczenia |  |
| Ubezpieczenia.Kontynuacja.WgTyub4 | `Key` | podlista |  |  |
| Ubezpieczenia.ObowiazkoweOd | `Date` | bazodanowe |  |  |
| Ubezpieczenia.PrawoEmRent | `int` | tylko-odczyt |  |  |
| Ubezpieczenia.Rentowe | `Soneta.Kadry.Spoleczne` (subrow) | bazodanowe |  |  |
| Ubezpieczenia.StopienNiepelnosp | `int` | tylko-odczyt |  |  |
| Ubezpieczenia.Tyub | `Soneta.Kadry.TytulUbezpieczenia` | tylko-odczyt |  |  |
| Ubezpieczenia.Tyub4 | `Soneta.Kadry.TytulUbezpieczenia4` | bazodanowe | Tytuł ubezpieczenia |  |
| Ubezpieczenia.Ubezpieczony | `bool` | tylko-odczyt |  |  |
| Ubezpieczenia.WgTyub4 | `Key` | podlista |  |  |
| Ubezpieczenia.Wypadkowe | `Soneta.Kadry.Spoleczne` (subrow) | bazodanowe |  |  |
| Ubezpieczenia.Zdrowotne | `Soneta.Kadry.Zdrowotne` (subrow) | bazodanowe |  |  |
| Ubezpieczenia.Zdrowotne.Do | `Date` | bazodanowe |  |  |
| Ubezpieczenia.Zdrowotne.Dobrowolne | `bool` | tylko-odczyt |  |  |
| Ubezpieczenia.Zdrowotne.DobrowolneOd | `Date` |  |  |  |
| Ubezpieczenia.Zdrowotne.KodPrzyczyny | `Soneta.Kadry.PrzyczynaWyrejestrowania` (enum) |  |  |  |
| Ubezpieczenia.Zdrowotne.Obowiazkowe | `bool` | tylko-odczyt |  |  |
| Ubezpieczenia.Zdrowotne.ObowiazkoweOd | `Date` |  |  |  |
| Ubezpieczenia.Zdrowotne.ObowiązujeOd | `Date` | tylko-odczyt |  |  |
| Ubezpieczenia.Zdrowotne.Od | `Date` | bazodanowe |  |  |
| Ubezpieczenia.Zdrowotne.Okres | `FromTo` | podlista |  |  |
| Ubezpieczenia.Zdrowotne.Przyczyna | `Soneta.Kadry.Wyrejestrowanie` | bazodanowe |  |  |
| Ubezpieczenia.Zdrowotne.Skladka | `decimal` | bazodanowe |  |  |
| Ubezpieczenia.Zdrowotne.Typ | `Soneta.Kadry.TypUbezpieczenia` (enum) | bazodanowe |  |  |
| Ubezpieczenia.Zdrowotne.Ubezpieczony | `bool` | tylko-odczyt |  |  |
| Ubezpieczenia.Zdrowotne.Wyrejestrowany | `bool` |  |  |  |
| Umowa | `Soneta.Kadry.Umowa` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| UmowaUlgi | `Soneta.Kadry.UmowaUlgiInfo` (subrow) | bazodanowe |  |  |
| UmowaUlgi.Pit26 | `Soneta.Kadry.NaliczajPit26` (enum) | bazodanowe |  |  |
| UmowaUlgi.UlgaCzesc | `Soneta.Kadry.UlgaPodatkowaCzesc` (enum) | bazodanowe |  |  |
| UmowaUlgi.UlgaDuzaRodzina | `bool` | bazodanowe |  |  |
| UmowaUlgi.UlgaEmeryt | `bool` | bazodanowe |  |  |
| UmowaUlgi.UlgaMnoznik | `decimal` | bazodanowe |  |  |
| UmowaUlgi.UlgaZagranica | `bool` | bazodanowe |  |  |
| UmowaUlgi.UlgaZagranicaDo | `int` | bazodanowe |  |  |
| UmowaUlgi.UlgaZagranicaOd | `int` | bazodanowe |  |  |
| UmowaUlgi.UmowaKwotaWolna | `bool` | bazodanowe |  |  |
| Wartosc | `Currency` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### InterpretacjaKalendarza (`Soneta.Kadry.InterpretacjaKalendarza`)
- `WgPlanu` = 0
- `WgObecnosci` = 1 — Wg obecności
- `WgZestawien` = 2 — Wg zestawień

### NaliczajPit26 (`Soneta.Kadry.NaliczajPit26`)
- `Warunkowo2020` = 0 — Warunkowo od 1 stycznia 2020
- `Warunkowo2019` = 1 — Warunkowo od 1 sierpnia 2019
- `NieNaliczaj` = 2

### PrzyczynaWyrejestrowania (`Soneta.Kadry.PrzyczynaWyrejestrowania`)
- `NieDotyczy` = 0
- `_100` = 100 — 100 - ustanie tytułu do ubezpieczeń/ubezpieczenia
- `_101` = 101 — 101 – rozwiązanie lub zakończenie umowy o pracy w celu przygotowania zawodowego
- `_102` = 102 — 102 – rozwiązanie lub zakończenie pracy osoby przyuczanej do wykonywania określonej pracy
- `_110` = 110 — 110 - rozwiązanie lub wygaśnięcie umowy o pracę nakładczą
- `_120` = 120 — 120 - rozwiązanie lub wygaśnięcie umowy agencyjnej lub umowy zlecenia
- `_121` = 121 — 121 - zakończenie współpracy przy wykonywaniu umowy agencyjnej lub umowy zlecenia
- `_130` = 130 — 130 - wygaśnięcie obowiązku wykonywania pracy na rzecz rolniczej spółdzielni produkcyjnej
- `_131` = 131 — 131 - wygaśnięcie obowiązku wykonywania pracy na rzecz spółdzielni kółek rolniczych
- `_140` = 140 — 140 - zaprzestanie prowadzenia pozarolniczej działalności gospodarczej
- `_141` = 141 — 141 - zaprzestanie wykonywania działalności twórczej lub artystycznej
- `_142` = 142 — 142 - zaprzestanie wykonywania wolnego zawodu
- `_143` = 143 — 143 - zakończenie współpracy przy prowadzeniu pozarolniczej działalności gospodarczej
- `_144` = 144 — 144 - zakończenie współpracy przy wykonywaniu działalności twórczej lub artystycznej
- `_145` = 145 — 145 - zakończenie współpracy przy wykonywaniu wolnego zawodu
- `_150` = 150 — 150 - utrata prawa do uposażenia poselskiego lub senatorskiego
- `_160` = 160 — 160 - zaprzestanie spełniania warunków do pobierania stypendium sportowego
- `_170` = 170 — 170 - zakończenie wykonywania odpłatnej pracy w czasie odbywania kary pozbawienia wolności lub tymczasowego aresztowania
- `_180` = 180 — 180 - utrata prawa do zasiłku dla bezrobotnych
- `_181` = 181 — 181 - utrata prawa do stypendium z tytułu skierowania przez powiatowy urząd pracy na szkolenie lub odbycie stażu
- `_182` = 182 — 182 - utrata prawa do pobierania zasiłku lub świadczenia przedemerytalnego z powiatowego urzędu pracy
- `_190` = 190 — 190 - wystąpienie ze stanu duchownego
- `_200` = 200 — 200 - zakończenie odbywania służby czynnej przez żołnierz niezawodowych
- `_201` = 201 — 201 - zakończenie odbywania zastępczej formy służby wojskowej
- `_202` = 202 — 202 - zakończenie odbywania nadterminowej zasadniczej służby wojskowej
- `_203` = 203 — 203 - zakończenie odbywania okresowej zasadniczej służby wojskowej
- `_210` = 210 — 210 - zakończenie służby żołnierza zawodowego
- `_220` = 220 — 220 - zakończenie służby funkcjonariusza Policji
- `_221` = 221 — 221 - zakończenie służby funkcjonariusza UOP
- `_222` = 222 — 222 - zakończenie służby funkcjonariusza Straży Granicznej
- `_223` = 223 — 223 - zakończenie służby funkcjonariusza Państwowej Straży Pożarnej
- `_224` = 224 — 224 - zakończenie służby funkcjonariusza Służby Więziennej
- `_230` = 230 — 230 - zaprzestanie spełniania warunków do objęcia ubezpieczeniem obowiązkowym osób przebywających na urlopie wychowawczym
- `_231` = 231 — 231 - zaprzestanie spełniania warunków do objęcia ubezpieczeniem obowiązkowym osób przebywających na zasiłku macierzyńskim
- `_240` = 240 — 240 - utrata prawa do pobierania świadczenia socjalnego na podstawie odrębnych przepisów lub układów zbiorowych pracy
- `_241` = 241 — 241 - utrata prawa do pobierania zasiłku socjalnego na czas przekwalifikowania zawodowego i poszukiwania nowego zatrudnienia na podstawie odrębnych przepisów lub układów zbiorowych pracy
- `_250` = 250 — 250 – wydanie decyzji o zaprzestaniu opłacania składki za osobę pobierającą zasiłek stały z pomocy społecznej
- `_251` = 251 — 251 - wydanie decyzji o zaprzestaniu opłacania składki za osobę pobierającą gwarantowany zasiłek okresowy z pomocy społecznej
- `_252` = 252 — 252 - utrata prawa do pobierania renty socjalnej z pomocy społecznej
- `_253` = 253 — 253 - utrata prawa do pobierania zasiłku stałego wyrównawczego z pomocy społecznej
- `_300` = 300 — 300 - rezygnacja z dobrowolnych ubezpieczeń społecznych lub zaprzestanie spełniania warunków do tych ubezpieczeń z tytułu bycia małżonkiem pracownika skierowanego do pracy w przedstawicielstwie dyplomatycznym,
- `_301` = 301 — 301 - rezygnacja z dobrowolnych ubezpieczeń społecznych lub zaprzestanie spełniania warunków do tych ubezpieczeń z tytułu bycia osobą, która z powodu stanu zdrowia członka rodziny wymagającego stałej opieki oraz pielęgnacji lub pomocy w czynnościach samoobsługowych nie podlega ubezpieczeniom społecznym z innych tytułów
- `_310` = 310 — 310 - rezygnacja z dobrowolnych ubezpieczeń społecznych lub zaprzestanie spełniania warunków do tych ubezpieczeń przez obywatela polskiego wykonującego pracę u podmiotu zagranicznego
- `_311` = 311 — 311 - rezygnacja z dobrowolnych ubezpieczeń społecznych lub zaprzestanie spełniania warunków do tych ubezpieczeń przez obywatela polskiego z tytułu wykonywania pracy u podmiotu zagranicznego na terytorium RP, jeżeli podmioty te nie posiadają w Polsce swojej siedziby ani przedstawicielstwa
- `_320` = 320 — 320 - rezygnacja z dobrowolnych ubezpieczeń społecznych lub zaprzestanie spełniania warunków z tytułu bycia studentem lub uczestnikiem dziennych studiów doktoranckich
- `_321` = 321 — 321 - rezygnacja z dobrowolnych ubezpieczeń społecznych lub zaprzestanie spełniania warunków z tytułu bycia uczestnikiem innych niż dzienne studia doktoranckie
- `_322` = 322 — 322 - rezygnacja z ubezpieczeń społecznych lub zaprzestanie spełniania warunków z tytułu bycia słuchaczem Krajowej Szkoły Administracji Publicznej
- `_330` = 330 — 330 - rezygnacja z kontynuowania ubezpieczeń społecznych
- `_340` = 340 — 340 - utrata prawa do wykonywania zawodu sędziego
- `_341` = 341 — 341 - utrata prawa do wykonywania zawodu prokuratora
- `_342` = 342 — 342 - utrata prawa do wykonywania zawodu adwokata
- `_350` = 350 — 350 - utrata prawa do ubezpieczenia zdrowotnego z tytułu pozostawania na wyłącznym utrzymaniu ubezpieczonego
- `_351` = 351 — 351 - utrata prawa do ubezpieczenia zdrowotnego dziecka, ucznia, słuchacza zakładów lub nauczycieli, którzy nie pozostają na wyłącznym utrzymaniu ubezpieczonego
- `_360` = 360 — 360 - utrata prawa do ubezpieczenia zdrowotnego z tytułu bycia kombatantem nie podlegającym ubezpieczeniom społecznym w RP lub nie pobierającym emerytury bądź renty
- `_370` = 370 — 370 - ustanie prawa do ubezpieczenia zdrowotnego cudzoziemca, który przebywa na terytorium RP na podstawie karty stałego pobytu
- `_371` = 371 — 371 - ustanie prawa do ubezpieczenia zdrowotnego cudzoziemca, który przebywa na terytorium RP na podstawie karty czasowego pobytu wydanej w związku z udzieleniem statusu uchodźcy
- `_372` = 372 — 372 - ustanie prawa do ubezpieczenia zdrowotnego cudzoziemca, który jest zatrudniony w obcych przedstawicielstwach dyplomatycznych, urzędach konsularnych, misjach lub międzynarodowych instytucjach
- `_373` = 373 — 373 - ustanie prawa do ubezpieczenia zdrowotnego cudzoziemca, który przebywa w RP na podstawie innych umów międzynarodowych
- `_400` = 400 — 400 - rezygnacja z dobrowolnego ubezpieczenia zdrowotnego osoby nie objętej obowiązkowym ubezpieczeniem zdrowotnym
- `_500` = 500 — 500 - zgon osoby ubezpieczonej
- `_600` = 600 — 600 - inne przyczyny wyrejestrowania z ubezpieczeń
- `_601` = 601 — 601 – nabycie prawa do emerytury lub renty
- `_602` = 602 — 602 – powstanie zbiegu ubezpieczeń społecznych powodującego możliwość wyrejestrowania z tytułu dotychczasowego ubezpieczenia
- `_603` = 603 — 603 – porzucenie pracy lub zerwanie umowy, z tytułu której osoba podlegała ubezpieczeniom
- `_700` = 700 — 700 - zawieszenie wykonywania pozarolniczej działalności gospodarczej na podstawie przepisów o swobodzie działalności gospodarczej
- `_750` = 750 — 750 - zawieszenie statusu marynarza
- `_800` = 800 — 800 – wyrejestrowanie pracownika w związku z przejściem zakładu pracy lub jego części na innego pracodawcę w trybie art. 231 ustawy z dnia 26 czerwca 1974 r. – Kodeks pracy (Dz. U. z 2016 r. poz. 1666, 2138 i 2255 oraz z 2017 r. poz. 60)

### TypUbezpieczenia (`Soneta.Kadry.TypUbezpieczenia`)
- `Brak` = 0
- `Obowiazkowe` = 1
- `Dobrowolne` = 2

### TypWartosciUmowy (`Soneta.Kadry.TypWartosciUmowy`)
- `Brutto` = 0
- `Netto` = 1

### UlgaPodatkowaCzesc (`Soneta.Kadry.UlgaPodatkowaCzesc`)
- `Ulga112` = 0 — 1/12 kwoty zmniejszającej podatek
- `Ulga124` = 1 — 1/24 kwoty zmniejszającej podatek
- `Ulga136` = 2 — 1/36 kwoty zmniejszającej podatek

### SprawdźUbezpieczenieResult (`Soneta.Kadry.UmowaHistoria.SprawdźUbezpieczenieResult`)
- `OK` = 0
- `BrakWyrejestrowania` = 1 — Brak lub błędna informacja o wyrejestrowaniu z ubezpieczeń.
- `NieoczekiwaneWyrejestrowanie` = 2 — Nieoczekiwane wyrejstrowanie z ubezpieczeń. Kolejny zapis ma takie samo ubezpieczenie.
- `ZłaDataRejestracji` = 3 — Początek ubezpieczenia powinien być zgodny z początkiem umowy lub datą aktualizacji.
