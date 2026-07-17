# Pola i właściwości klasy biznesowej: `Soneta.Deklaracje.ETransmisja`
Nazwa tabeli: `ETransmisje`
Tytuł: eTransmisja
Opis: Rejestr pojedynczej transmisji eDeklaracji do systemu elektronicznego urzędu. Dokumentuje czas, typ i status każdej próby wysyłki lub sprawdzenia statusu, przechowując referencję UPO oraz ewentualny opis błędu. Jedna eDeklaracja może mieć wiele transmisji.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `System.DateTime` | bazodanowe |  | Czas transmisji |
| EDeklaracja | `Soneta.Deklaracje.EDeklaracja` | bazodanowe | eDeklaracja | eDeklaracja transmisji |
| NazwaPodmiotuPrzyjmujacego | `string` |  |  |  |
| OpisStatusu | `Soneta.Business.MemoText` | bazodanowe |  | Opis statusu transmisji |
| RefUPO | `Soneta.Business.MemoText` | bazodanowe | eDeklaracja | Referencja odbioru/Urzędowe Potwierdzenie Odbioru |
| StatusETransmisji | `int` | bazodanowe | Status eTransmisji | Status transmisji |
| StatusETransmisjiEnum | `Soneta.Deklaracje.StatusETransmisji` | enum | Status eTransmisji | Status eTransmisji enumerator |
| Typ | `Soneta.Deklaracje.TypETransmisji` | bazodanowe, enum |  | Typ transmisji |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusETransmisji (`Soneta.Deklaracje.StatusETransmisji`)
- `Brak` = 0
- `NiepoprawnyKomunikatSOAP` = 100 — Niepoprawny komunikat SOAP
- `ProszęOPonownePrzesłanieDokumentu` = 101 — Proszę o ponowne przesłanie dokumentu
- `ProszęOPonownePrzesłanieŻądaniaUPO` = 102 — Proszę o ponowne przesłanie żądania UPO
- `PrzetwarzanieDokumentuZakończonePoprawnie` = 200 — Przetwarzanie dokumentu zakończone poprawnie
- `BrakDokumentu` = 300 — Brak dokumentu
- `DokumentWTrakciePrzetwarzania` = 301 — Dokument w trakcie przetwarzania
- `DokumentWstępniePrzetworzony` = 302 — Dokument wstępnie przetworzony
- `DokumentWTrakcieWeryfikacjiPodpisu` = 303 — Dokument w trakcie weryfikacji podpisu
- `DokumentWTrakcieWeryfikacjiDuplikatów` = 304 — Dokument w trakcie weryfikacji duplikatów
- `DokumentOczekujeNaWznowieniePrzetwarzania` = 305 — Dokument oczekuje na wznowienie przetwarzania
- `PrzetwarzanieDokumentuZakończoneBłędem` = 400 — Przetwarzanie dokumentu zakończone błędem
- `DokumentNiezgodnyZeSchematemXsd` = 401 — Dokument niezgodny ze schematem xsd
- `DokumentWystawionyPrzezNieupoważnionyPodmiot` = 402 — Dokument wystawiony przez nieupoważniony podmiot
- `DokumentZNiepoprawnymPodpisem` = 403 — Dokument z niepoprawnym podpisem
- `DokumentZNiepoprawnymCertyfikatem` = 404 — Dokument z niepoprawnym certyfikatem
- `DokumentZOdwołanymCertyfikatem` = 405 — Dokument z odwołanym certyfikatem
- `DokumentZCertyfikatemZNieobsługiwanymDostawcą` = 406 — Dokument z certyfikatem z nieobsługiwanym dostawcą
- `DokumentZCertyfikatemZNieprawidłowąŚcieżką` = 407 — Dokument z certyfikatem z nieprawidłową ścieżką
- `DokumentZawieraBłędyUniemożliwiająceJegoPrzetworzenie` = 408 — Dokument zawiera błędy uniemożliwiające jego przetworzenie
- `DokumentZawieraNiewłaściwąIlośćILubRodzajElementów` = 409 — Dokument zawiera niewłaściwą ilość i/lub rodzaj elementów
- `ZłożonyDokumentZeznanieBezPodpisuNieMożeByćKorektą` = 410 — Złożony dokument (zeznanie) bez podpisu nie może być korektą
- `WSystemieJestJuzZłożonyDokumentZTakimIdentyfikatoremPodatkowym` = 411 — Weryfikacja negatywna - w systemie jest już złożony dokument z takim identyfikatorem podatkowym
- `WeryfikacjaNegatywnaNiezgodnośćDanychAutoryzujących` = 412 — Weryfikacja negatywna - niezgodność danych autoryzujących z danymi w dokumencie (np. niezgodność NIP, numeru PESEL, daty urodzenia, nazwiska,pierwszego imienia)
- `DokumentZCertyfikatemBezWymaganychAtrybutów` = 413 — Dokument z certyfikatem bez wymaganych atrybutów
- `WeryfikacjaNegatywnaBłądDanychAutoryzujących` = 414 — Weryfikacja negatywna - błąd w danych autoryzujących (np. błąd w nazwisku, pierwszym imieniu, dacie urodzenia, NIP, numerze PESEL, kwocie przychodu)
- `ZawartośćZałącznikaNiezgodnaZDeklarowanąListąPlików` = 415 — Zawartość załącznika niezgodna z deklarowaną listą plików
- `DlaTegoTypuDeklaracjiZałącznikBinarnyNieJestDozwolony` = 416 — Dla tego typu deklaracji załącznik binarny nie jest dozwolony
- `WniosekVATREFWymagaPrzynajmniejJednejZPozycji` = 417 — Wniosek VAT-REF wymaga przynajmniej jednej z pozycji: VATRefundApplication lub ProRataRateAdjustment
- `DlaZłożonejDeklaracjiWymaganeJestUżyciePodpisuKwalifikowanego` = 418 — Dla złożonej deklaracji wymagane jest użycie podpisu kwalifikowanego
- `BrakZaznaczeniaCeluPrzyczynyKorekty` = 419 — Brak zaznaczenia celu złożenia formularza jako korekty deklaracji (zeznania) lub brak uzasadnienia przyczyny złożenia korekty deklaracji (zeznania)
- `UżyciePodpisuDaneAutoryzujaceVAPJestDozwoloneJedynieDlaDokumentuVAP1` = 420 — Użycie podpisu DaneAutoryzujaceVAP jest dozwolone jedynie dla dokumentu VAP-1
- `DokumentVAP1MożnaZłożyćJedynieZUżyciemPodpisuDaneAutoryzujaceVAP` = 421 — Dokument VAP-1 można złożyć jedynie z użyciem podpisu DaneAutoryzujaceVAP
- `WeryfikacjaNegatywnaDokumentZłożonyZUżyciemDanychAutoryzującychMożeZłożyćWyłączniePodatnikBędącyOsobąFizyczną` = 422 — Weryfikacja negatywna - dokument złożony z użyciem danych autoryzujących może złożyć wyłącznie podatnik, będący osobą fizyczną
- `DokumentMożeZłożyćWyłączniePodmiotBędącyOsobąFizycznąNiebędącyPełnomocnikiem` = 423 — Dokument może złożyć wyłącznie podmiot będący osobą fizyczną, niebędący pełnomocnikiem
- `NiePodanoNumeruVATDostawcyLubNumeruFakturyANieJestToFakturaUproszczona` = 424 — Nie podano numeru VAT dostawcy lub numeru faktury, a nie jest to faktura uproszczona
- `KodPaństwaCzłonkowskiegoIdentyfikacjiDostawcyJestNiezgodnyZKodemPaństwaDoKtóregoKierowanyJestWniosek` = 425 — Kod państwa członkowskiego identyfikacji dostawcy jest niezgodny z kodem państwa, do którego kierowany jest wniosek
- `PaczkaDokumentZbiorczyZawieraDeklaracjęKtóraZostałaJużPrzesłana` = 440 — Paczka/Dokument zbiorczy zawiera deklarację, która została już przesłana
- `PrzesłanyPlikPrzekroczyłDopuszczalnyRozmiar` = 441 — Przesłany plik przekroczył dopuszczalny rozmiar
- `PrzesłanaPaczkaZnajdujeSięJużWSystemie` = 442 — Przesłana paczka znajduje się już w systemie
- `DokumentZnajdujeSięjużWSystemie` = 443 — Dokument znajduje się już w systemie
- `NieZnalezionoPłatnikaLubPodatnikaKtóregoDotyczyZeznanie` = 444 — Nie znaleziono płatnika lub podatnika, którego dotyczy zeznanie
- `PrzesłanyPlikPrzekroczyłDopuszczalnyRozmiarDanychPoRozpakowaniu` = 445 — Przesłany plik przekroczył dopuszczalny rozmiar danych po rozpakowaniu
- `BłędnyPlikLubNiepoprawnaStrukturaPlikuZIP` = 448 — Błędny plik lub niepoprawna struktura pliku (ZIP)
- `WeryfikacjaNegatywnaNieobsługiwanyTypDeklaracji` = 452 — Weryfikacja negatywna – nieobsługiwany typ deklaracji
- `WeryfikacjaNegatywnaNieobsługiwanyTypDeklaracjiDlaTegoKanału` = 453 — Weryfikacja negatywna – nieobsługiwany typ deklaracji dla tego kanału

### TypETransmisji (`Soneta.Deklaracje.TypETransmisji`)
- `Brak` = 0
- `WysyłanieDokumentu` = 1 — Wysyłanie dokumentu
- `PotwierdzenieOdbioru` = 2 — Potwierdzenie odbioru
