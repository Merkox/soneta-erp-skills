# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFKomunikat`
Nazwa tabeli: `KSeFKomunikaty`
Tytuł: Komunikaty KSeF
Opis: Komunikat (faktura) wymieniany z Krajowym Systemem e-Faktur. Przechowuje daty przesłania i przyjęcia, numer dokumentu i referencyjny KSeF, numer sesji, token, rodzaj konta, tryb offline, certyfikat, skrót SHA-256 oraz kontekst autentykacji.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CertyfikatOffline | `Soneta.Core.SysZewToken` | bazodanowe | Certyfikat KSeF do podpisu offline | Certyfikat KSeF, do podpisu linku do weryfikacji wystawcy, dla dokumentów wystawianych w trybie offline. |
| DataKsef | `Date` | tylko-odczyt | Data KSeF |  |
| DataPrzeslaniaKSeF | `System.DateTime` | bazodanowe | Data przesłania do KSeF | Data momentu wysłania do serwisu KSeF |
| DataPrzyjeciaKSeF | `System.DateTime` | bazodanowe | Data przyjęcia w KSeF | Moment przetworzneia i przyjęcia dokumentu w KSeF |
| EdycjaTypuKorekty | `bool` | bazodanowe | Czy nastąpiła ręczna edycja typu korekty | Czy nastąpiła ręczna edycja typu korekty |
| KontekstAutentykacji | `Soneta.Core.Enums.TypKontekstuAutentykacjiKSeF` (enum) | bazodanowe | Kontekst autentykacji | Kontekst autentykacji |
| KorektaRabatowa | `bool` | bazodanowe | Korekta rabatowa | Korekta rabatowa |
| NumerDodanyRecznie | `bool` | tylko-odczyt | Numer dodany ręcznie |  |
| NumerDokumentuKSeF | `string` | bazodanowe | Numer dokumentu KSeF | Numer dokumentu nadany przez KSeF |
| NumerReferencyjnyKSeF | `string` | bazodanowe | Numer referencyjny KSeF | Numer referencyjny nadany przez KSeF |
| NumerReferencyjnySesjiKSeF | `string` | bazodanowe | Numer referencyjny sesji KSeF | Numer referencyjny sesji KSeF nadany przy wysyłce |
| Offline | `bool` | bazodanowe | Offline | Wysyłka dokumentu w trybie offline. |
| OpisBledu | `string` | bazodanowe | Opis błędu | Opis błędu zwróconego podczas sprawdzania statusu. |
| Podmioty3 | `SubTable<Soneta.Core.KSeFPodmiot3>` | podlista |  |  |
| PosiadaRole1 | `bool` | tylko-odczyt |  |  |
| PosiadaRole10 | `bool` | tylko-odczyt |  |  |
| PosiadaRole11 | `bool` | tylko-odczyt |  |  |
| PosiadaRole2 | `bool` | tylko-odczyt |  |  |
| PosiadaRole5 | `bool` | tylko-odczyt |  |  |
| PosiadaRole6 | `bool` | tylko-odczyt |  |  |
| PosiadaRole7 | `bool` | tylko-odczyt |  |  |
| PosiadaRole8 | `bool` | tylko-odczyt |  |  |
| PosiadaRole9 | `bool` | tylko-odczyt |  |  |
| RodzajKonta | `Soneta.Core.Enums.RodzajKonta` (enum) | bazodanowe | Rodzaj konta | Rodzaj konta |
| Rola10Podmiot3 | `Soneta.Core.KSeFPodmiot3` | tylko-odczyt |  |  |
| Rola11Podmiot3 | `Soneta.Core.KSeFPodmiot3` | tylko-odczyt |  |  |
| Rola1Podmiot3 | `Soneta.Core.KSeFPodmiot3` | tylko-odczyt |  |  |
| Rola2Podmiot3 | `Soneta.Core.KSeFPodmiot3` | tylko-odczyt |  |  |
| Rola5Podmiot3 | `Soneta.Core.KSeFPodmiot3` | tylko-odczyt |  |  |
| Rola6Podmiot3 | `Soneta.Core.KSeFPodmiot3` | tylko-odczyt |  |  |
| Rola7Podmiot3 | `Soneta.Core.KSeFPodmiot3` | tylko-odczyt |  |  |
| Rola8Podmiot3 | `Soneta.Core.KSeFPodmiot3` | tylko-odczyt |  |  |
| Rola9Podmiot3 | `Soneta.Core.KSeFPodmiot3` | tylko-odczyt |  |  |
| SkrotSHA256Dokumentu | `string` | bazodanowe |  |  |
| TokenKSeF | `Soneta.Core.SysZewToken` | bazodanowe | Token KSeF | Token KSeF |
| TrybOffline | `Soneta.Core.KSeFAwaria` | bazodanowe | W przypadku trybu offline wskazanie powodu użycia | W przypadku trybu offline wskazanie powodu użycia |
| TypKorekty | `Soneta.Core.Enums.TypKorektyKSeF` (enum) | bazodanowe | Oznaczenie typu korekty w pliku KSeF | Oznaczenie typu korekty w pliku KSeF |
| WartoscKontekstuAutentykacji | `string` | bazodanowe | Wartość kontekstu autentykacji | Wartość kontekstu autentykacji |
| WysylajPozycjeKorektyWFaWiersz | `Soneta.Core.Enums.WysylajPozycjeKorektyWPlikuKSeF` (enum) | bazodanowe | Czy wysyłać pozycje korekty w sekcji FaWiersz | Czy wysyłać pozycje korekty w sekcji FaWiersz |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajKonta (`Soneta.Core.Enums.RodzajKonta`)
- `Testowe` = 0
- `Produkcyjne` = 1
- `Przedprodukcyjne` = 2

### TypKontekstuAutentykacjiKSeF (`Soneta.Core.Enums.TypKontekstuAutentykacjiKSeF`)
- `Brak` = 0
- `NIP` = 1
- `IdentyfikatorWewnetrzny` = 2 — IdWew

### TypKorektyKSeF (`Soneta.Core.Enums.TypKorektyKSeF`)
- `Brak` = 0
- `KorektaZwykla` = 1 — 1 - skutek w dacie faktury
- `KorektaRabatowa` = 2 — 2 - skutek w dacie korekty
- `KorektaDanychLubPlatnosci` = 3 — 3 - skutek w różnych datach

### WysylajPozycjeKorektyWPlikuKSeF (`Soneta.Core.Enums.WysylajPozycjeKorektyWPlikuKSeF`)
- `NieDotyczy` = 0 — Nie dotyczy
- `Nie` = 1 — Nie
- `Tak` = 2 — Tak
- `TylkoKorygowane` = 3 — Tylko korygowane
