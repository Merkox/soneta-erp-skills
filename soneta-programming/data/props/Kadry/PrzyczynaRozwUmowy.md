# Pola i właściwości klasy biznesowej: `Soneta.Kadry.PrzyczynaRozwUmowy`
Nazwa tabeli: `PrzyczRozwUmow`
Tytuł: Przyczyna rozwiązania umów o pracę
Opis: Słownik przyczyn rozwiązania umowy o pracę z kodami podstawy prawnej, inicjatywy i przyczyny wyrejestrowania z ZUS. Określa typ rozwiązania, możliwość odszkodowania oraz kod zwolnienia wymagany w dokumentach kadrowych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Inicjatywa | `Soneta.Kadry.KodInicjatywyZwolnienia` | bazodanowe, enum |  |  |
| KodZwolnienia | `Soneta.Kadry.KodZwolnienia` | bazodanowe, enum |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| PodstawaPrawna | `Soneta.Kadry.KodPodstawyPrawnejZwolnienia` | bazodanowe, enum |  |  |
| Przyczyna | `Soneta.Kadry.PrzyczynaWyrejestrowania` | bazodanowe, enum |  |  |
| Typ | `Soneta.Kadry.TypPrzyczynyRozwUmowy` | bazodanowe, enum |  |  |
| ZaOdszkodowaniem | `bool` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KodInicjatywyZwolnienia (`Soneta.Kadry.KodInicjatywyZwolnienia`)
- `NieDotyczy` = 0
- `Pracownik` = 1
- `Pracodawca` = 2

### KodPodstawyPrawnejZwolnienia (`Soneta.Kadry.KodPodstawyPrawnejZwolnienia`)
- `NieDotyczy` = 0
- `_400` = 400 — 400 - art. 23¹ § 4 ustawy z dnia 26 czerwca 1974 r. - Kodeks pracy
- `_401` = 401 — 401 - art. 23¹ § 5 ustawy z dnia 26 czerwca 1974 r. - Kodeks pracy
- `_402` = 402 — 402 - art. 30 § 1 pkt 1 ustawy z dnia 26 czerwca 1974 r. - Kodeks pracy
- `_403` = 403 — 403 - art. 30 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_404` = 404 — 404 - art. 30 § 1 pkt 3 w związku z art. 52 § 1 pkt 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_405` = 405 — 405 - art. 30 § 1 pkt 3 w związku z art. 52 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_406` = 406 — 406 - art. 30 § 1 pkt 3 w związku z art. 52 § 1 pkt 3 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_407` = 407 — 407 - art. 30 § 1 pkt 4 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_408` = 408 — 408 - art. 30 § 1 pkt 5 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w brzmieniu obowiązującym do dnia 21 lutego 2016 r.
- `_409` = 409 — 409 - art. 36¹ § 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_410` = 410 — 410 - art. 48 § 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_411` = 411 — 411 - art. 30 § 1 pkt 3 w związku z art. 53 § 1 pkt 1 lit. a ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_412` = 412 — 412 - art. 30 § 1 pkt 3 w związku z art. 53 § 1 pkt 1 lit. b ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_413` = 413 — 413 - art. 30 § 1 pkt 3 w związku z art. 53 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_414` = 414 — 414 - art. 30 § 1 pkt 3 w związku z art. 55 § 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_415` = 415 — 415 - art. 30 § 1 pkt 3 w związku z art. 55 § 1¹ ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_416` = 416 — 416 - art. 68³ ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_417` = 417 — 417 - art. 70 § 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_418` = 418 — 418 - art. 70 § 3 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_419` = 419 — 419 - art. 73 § 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_420` = 420 — 420 - art. 201 § 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_421` = 421 — 421 - art. 30 § 1 pkt 2 w związku z art. 1 ust. 1 ustawy z dnia 13 marca 2003 r. o szczególnych zasadach rozwiązywania z pracownikami stosunków pracy z przyczyn niedotyczących pracowników
- `_422` = 422 — 422 - art. 30 § 1 pkt 2 w związku z art. 10 ust. 1 ustawy z dnia 13 marca 2003 r. o szczególnych zasadach rozwiązywania z pracownikami stosunków pracy z przyczyn niedotyczących pracowników
- `_423` = 423 — 423 - art. 74 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_424` = 424 — 424 - art. 63¹ § 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_425` = 425 — 425 - art. 63² § 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_426` = 426 — 426 - art.66 § 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_427` = 427 — 427 - art. 63 ustawy z dnia 26 czerwca 1974 r. – Kodeks pracy w związku z art. 189 ust. 2 ustawy z dnia 11 marca 2022 r. o obronie Ojczyzny
- `_428` = 428 — 428 - art. 63 ustawy z dnia 26 czerwca 1974 r. – Kodeks pracy w związku z art. 315 ust. 1 ustawy z dnia 11 marca 2022 r. o obronie Ojczyzny
- `_429` = 429 — 429 - art. 30 § 1 pkt 1 ustawy z dnia 26 czerwca 1974 r. - Kodeks pracy w związku z art. 2 pkt 38 lit. a ustawy z dnia 20 marca 2025 r. o rynku pracy i służbach zatrudnienia
- `_430` = 430 — 430 - art. 30 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r. - Kodeks pracy w związku z art. 2 pkt 38 lit. a ustawy z dnia 20 marca 2025 r. o rynku pracy i służbach zatrudnienia
- `_431` = 431 — 431 - art. 30 § 1 pkt 1 ustawy z dnia 26 czerwca 1974 r. - Kodeks pracy w związku z art. 2 pkt 38 lit. b ustawy z dnia 20 marca 2025 r. o rynku pracy i służbach zatrudnienia
- `_432` = 432 — 432 - art. 30 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r. - Kodeks pracy w związku z art. 2 pkt 38 lit. b ustawy z dnia 20 marca 2025 r. o rynku pracy i służbach zatrudnienia
- `_433` = 433 — 433 - art. 30 § 1 pkt 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 3 ustawy z dnia 13 lipca 2006 r. o ochronie roszczeń pracowniczych w razie niewypłacalności pracodawcy
- `_434` = 434 — 434 - art. 30 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 3 ustawy z dnia 13 lipca 2006 r. o ochronie roszczeń pracowniczych w razie niewypłacalności pracodawcy
- `_435` = 435 — 435 - art. 30 § 1 pkt 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 4 ustawy z dnia 13 lipca 2006 r. o ochronie roszczeń pracowniczych w razie niewypłacalności pracodawcy
- `_436` = 436 — 436 - art. 30 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 4 ustawy z dnia 13 lipca 2006 r. o ochronie roszczeń pracowniczych w razie niewypłacalności pracodawcy
- `_437` = 437 — 437 - art. 30 § 1 pkt 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 5 ustawy z dnia 13 lipca 2006 r. o ochronie roszczeń pracowniczych w razie niewypłacalności pracodawcy
- `_438` = 438 — 438 - art. 30 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 5 ustawy z dnia 13 lipca 2006 r. o ochronie roszczeń pracowniczych w razie niewypłacalności pracodawcy
- `_439` = 439 — 439 - art. 30 § 1 pkt 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 6 ustawy z dnia 13 lipca 2006 r. o ochronie roszczeń pracowniczych w razie niewypłacalności pracodawcy
- `_440` = 440 — 440 - art. 30 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 6 ustawy z dnia 13 lipca 2006 r. o ochronie roszczeń pracowniczych w razie niewypłacalności pracodawcy
- `_441` = 441 — 441 - art. 30 § 1 pkt 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 8 ustawy z dnia 13 lipca 2006 r. o ochronie roszczeń pracowniczych w razie niewypłacalności pracodawcy
- `_442` = 442 — 442 - art. 30 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 8 ustawy z dnia 13 lipca 2006 r. o ochronie roszczeń pracowniczych w razie niewypłacalności pracodawcy
- `_443` = 443 — 443 - art. 30 § 1 pkt 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 8a ustawy z dnia 13 lipca 2006 r. o ochronie roszczeń pracowniczych w razie niewypłacalności pracodawcy
- `_444` = 444 — 444 - art. 30 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 8a ustawy z dnia 13 lipca 2006 r. o ochronie roszczeń pracowniczych w razie niewypłacalności pracodawcy
- `_445` = 445 — 445 - art. 27 ust. 1 pkt 2 ustawy z dnia 27 lipca 2001 r. o kuratorach sądowych
- `_446` = 446 — 446 - art. 62 ust. 1 pkt 2 ustawy z dnia 13 kwietnia 2007 r. o Państwowej Inspekcji Pracy
- `_447` = 447 — 447 - art.71 ust. 1 pkt 4 ustawy z dnia 21 listopada 2008 r. o służbie cywilnej
- `_448` = 448 — 448 - art. 13 ust. 1 pkt 2 ustawy z dnia 16 września 1982 r. o pracownikach urzędów państwowych
- `_449` = 449 — 449 - art. 170 ust. 1 pkt 1 ustawy z dnia 16 listopada 2016 r. Przepisy wprowadzające ustawę o Krajowej Administracji Skarbowej
- `_450` = 450 — 450 - art. 97 ust. 3 ustawy z dnia 16 grudnia 2016 r. Przepisy wprowadzające ustawę o zasadach zarządzania mieniem państwowym
- `_451` = 451 — 451 - art. 30 § 1 pkt 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 20 ust. 1 pkt 1 ustawy z dnia 26 stycznia 1982 r. - Karta Nauczyciela
- `_452` = 452 — 452 - art. 30 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 20 ust. 1 pkt 1 ustawy z dnia 26 stycznia 1982 r. - Karta Nauczyciela
- `_453` = 453 — 453 - art. 30 § 1 pkt 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 20 ust. 1 pkt 2 ustawy z dnia 26 stycznia 1982 r. - Karta Nauczyciela
- `_454` = 454 — 454 - art. 30 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 20 ust. 1 pkt 2 ustawy z dnia 26 stycznia 1982 r. - Karta Nauczyciela
- `_455` = 455 — 455 - art. 20 ust. 5c ustawy z dnia 26 stycznia 1982 r. - Karta Nauczyciela
- `_456` = 456 — 456 - art. 20 ust. 6 ustawy z dnia 26 stycznia 1982 r. - Karta Nauczyciela
- `_457` = 457 — 457 - art. 20 ust. 7 ustawy z dnia 26 stycznia 1982 r. - Karta Nauczyciela
- `_458` = 458 — 458 - art. 23 ust. 1 pkt 1 ustawy z dnia 26 stycznia 1982 r. - Karta Nauczyciela
- `_459` = 459 — 459 - art. 23 ust. 4 pkt 1 ustawy z dnia 26 stycznia 1982 r. - Karta Nauczyciela
- `_460` = 460 — 460 - art. 27 ust. 1 ustawy z dnia 26 stycznia 1982 r. - Karta Nauczyciela
- `_461` = 461 — 461 - art. 225 ust. 1, 6 i 10 ustawy z dnia 14 grudnia 2016 r. - Przepisy wprowadzające ustawę - Prawo oświatowe
- `_462` = 462 — 462 - art. 225 ust. 7 pkt 1 ustawy z dnia 14 grudnia 2016 r. - Przepisy wprowadzające ustawę - Prawo oświatowe
- `_463` = 463 — 463 - art. 226 ust. 1 ustawy z dnia 14 grudnia 2016 r. - Przepisy wprowadzające ustawę - Prawo oświatowe
- `_550` = 550 — 550 – inna niż określona w kodach od 400 do 463 - podstawa prawna rozwiązania lub wygaśnięcia stosunku pracy lub stosunku służbowego

### KodZwolnienia (`Soneta.Kadry.KodZwolnienia`)
- `NieDotyczy` = 0
- `_20R` = 20 — 20R - bez wypowiedzenia, przez pracownika w związku przejściem zakładu pracy lub jego części na innego pracodawcę
- `_21R` = 21 — 21R - w wyniku nieuzgodnienia nowych warunków pracy i płacy, zaproponowanych przez pracodawcę z dniem przejęcia zakładu pracy lub jego części
- `_22R` = 22 — 22R - na mocy porozumienia stron
- `_23R` = 23 — 23R - wypowiedzenie przez pracodawcę
- `_24R` = 24 — 24R - wypowiedzenie przez pracownika
- `_25R` = 25 — 25R - bez wypowiedzenia przez pracodawcę, naruszenie obowiązków pracowniczych
- `_26R` = 26 — 26R - bez wypowiedzenia przez pracodawcę, popełnienie przestępstwa
- `_27R` = 27 — 27R - bez wypowiedzenia przez pracodawcę, utrata koniecznych uprawnień
- `_28R` = 28 — 28R - z upływem czasu, na który była zawarta umowa o pracę
- `_29R` = 29 — 29R - z dniem ukończenia pracy, dla której wykonania była zawarta umowa
- `_30R` = 30 — 30R - ze skróconym okresem wypowiedzenia, z przyczyn niedotyczących pracowników
- `_31R` = 31 — 31R - przywrócenie do pracy i zatrudnienie u innego pracodawcy
- `_32R` = 32 — 32R - bez wypowiedzenia przez pracodawcę, niezdolność do pracy dłuższa niż 3 mies.
- `_33R` = 33 — 33R - bez wypowiedzenia przez pracodawcę, wyczerpanie okresu zasiłkowego, pobierania świadczenia rehabilitacyjnego
- `_34R` = 34 — 34R - bez wypowiedzenia przez pracodawcę, usprawiedliwiona nieobecność dłuższa niż 1 mies.
- `_35R` = 35 — 35R - bez wypowiedzenia przez pracownika, orzeczenie o szkodliwym wpływie wykonywanej pracy na zdrowie
- `_36R` = 36 — 36R - bez wypowiedzenia przez pracownika, naruszenie obowiązków przez pracodawcę
- `_37R` = 37 — 37R - w przypadkach określonych w przepisach szczególnych, innych niż określone w części XVI
- `_38R` = 38 — 38R - powołanie u innego pracodawcy
- `_39R` = 39 — 39R - odwołanie
- `_40R` = 40 — 40R - odwołanie bez wypowiedzenia
- `_41R` = 41 — 41R - wygaśnięcie mandatu
- `_42R` = 42 — 42R - pracownikiem młodocianym w związku z orzeczeniem lekarskim o pracy zagrażającej zdrowiu
- `_43R` = 43 — 43R - z przyczyn niedotyczących pracownika, grupowe zwolnienie- porozumienie stron
- `_44R` = 44 — 44R - z przyczyn niedotyczących pracownika, grupowe zwolnienie - wypowiedzenie
- `_45R` = 45 — 45R - z przyczyn niedotyczących pracownika, indywidualne zwolnienie - wypowiedzenie
- `_46R` = 46 — 46R - z przyczyn niedotyczących pracownika, indywidualne zwolnienie – porozumienie stron
- `_47W` = 47 — 47W - brak powrotu do pracy po zakończeniu stosunku pracy z wyboru
- `_48W` = 48 — 48W - śmierć pracownika
- `_49W` = 49 — 49W - śmierć pracodawcy
- `_50W` = 50 — 50W - tymczasowe aresztowanie
- `_51W` = 51 — 51W - powołanie do zawodowej służby wojskowej
- `_52W` = 52 — 52W - brak powrotu do pracy po zwolnieniu z czynnej służby wojskowej
- `_53W` = 53 — 53W - w przypadkach określonych w przepisach szczególnych, innych niż określone w części XVI

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

### TypPrzyczynyRozwUmowy (`Soneta.Kadry.TypPrzyczynyRozwUmowy`)
- `Rozwiązanie` = 0 — Rozwiązanie
- `Wygaśnięcie` = 1
