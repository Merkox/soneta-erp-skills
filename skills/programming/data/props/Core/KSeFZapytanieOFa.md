# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFZapytanieOFa`
Nazwa tabeli: `KSeFZapytaniaOFa`
Tytuł: Zapytania o faktury KSeF
Opis: Zapytanie o faktury wysłane do Krajowego Systemu e-Faktur. Zawiera parametry zapytania (okres, rodzaj dokumentu, token, kontekst autentykacji), stan przetworzenia (kod, opis), numery referencyjne, klucze szyfrujące oraz informacje o pakietach wynikowych.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CipherIv | `string` | bazodanowe |  |  |
| CipherKey | `string` | bazodanowe |  |  |
| DataDo | `System.DateTime` | bazodanowe |  |  |
| DataDoOffset | `string` | bazodanowe |  |  |
| DataOd | `System.DateTime` | bazodanowe |  |  |
| DataOdOffset | `string` | bazodanowe |  |  |
| DataZapytaniaDo | `System.DateTime` | tylko-odczyt |  |  |
| DataZapytaniaOd | `System.DateTime` | tylko-odczyt |  |  |
| KontekstAutentykacji | `Soneta.Core.Enums.TypKontekstuAutentykacjiKSeF` (enum) | bazodanowe | Kontekst autentykacji | Kontekst autentykacji |
| LiczbaFakturPominietych | `int` | tylko-odczyt | Liczba faktur pominiętych |  |
| LiczbaFakturZaimportowanych | `int` | tylko-odczyt | Liczba faktur zaimportowanych |  |
| Okres | `FromTo` | podlista |  |  |
| Parts | `Soneta.Core.KSeFPartList` | bazodanowe | Pakiety |  |
| PobieranieSamofakturowania | `Soneta.Core.Enums.PobieranieSamofakturowania` (enum) | bazodanowe | Uwzględniaj samofakturowanie | Uwzględnianie faktur samofakturowania |
| PobraneWszystkie | `bool` | tylko-odczyt | Pobrano wszystkie pakiety |  |
| RodzajDokumentu | `Soneta.Core.RodzajDokumentuKSeFZapytanieOFa` (enum) | bazodanowe | Rodzaj dokumentu | Rodzaj dokumentu |
| RodzajKonta | `Soneta.Core.Enums.RodzajKonta` (enum) | bazodanowe | Rodzaj konta | Rodzaj konta KSeF |
| StatusZapytania | `Soneta.Core.StatusZapytania` (enum) | tylko-odczyt |  |  |
| TokenKSeF | `Soneta.Core.SysZewToken` | bazodanowe | Token KSeF | Token KSeF |
| TypPodmiotu | `Soneta.Core.Enums.PodmiotTworzeniaZapytaniaKSeF` (enum) | bazodanowe | Typ podmiotu zapytania | Typ podmiotu zapytania |
| WartoscKontekstuAutentykacji | `string` | bazodanowe | Wartość kontekstu autentykacji | Wartość kontekstu autentykacji |
| elementReferenceNumber | `string` | bazodanowe |  | Numer referencyjny elementu |
| numberOfElements | `int` | bazodanowe | Ilość dokumentów | Ilość dokumentów |
| numberOfParts | `int` | bazodanowe | Ilość pakietów | Ilość pakietów |
| processingCode | `int` | bazodanowe | Kod | Kod przetwarzania zapytania |
| processingDescription | `string` | bazodanowe | Opis | Opis przetwarzania |
| referenceNumber | `string` | bazodanowe | Numer referencyjny | Numer referencyjny zapytania |
| sessionToken | `string` | bazodanowe | Sesja | Tokem sesji |
| timestamp | `System.DateTime` | bazodanowe | Wysłano | Data i godzina wykonania zapytania |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PobieranieSamofakturowania (`Soneta.Core.Enums.PobieranieSamofakturowania`)
- `Tak` = 0 — Tak
- `Nie` = 1 — Nie
- `TylkoSamofakturowanie` = 2 — Tylko samofakturowanie

### PodmiotTworzeniaZapytaniaKSeF (`Soneta.Core.Enums.PodmiotTworzeniaZapytaniaKSeF`)
- `Brak` = 0
- `Sprzedawca` = 1 — Sprzedawca (Podmiot1)
- `Nabywca` = 2 — Nabywca (Podmiot2)
- `Podmiot3` = 3 — Podmiot trzeci (Podmiot3)

### RodzajKonta (`Soneta.Core.Enums.RodzajKonta`)
- `Testowe` = 0
- `Produkcyjne` = 1
- `Przedprodukcyjne` = 2

### TypKontekstuAutentykacjiKSeF (`Soneta.Core.Enums.TypKontekstuAutentykacjiKSeF`)
- `Brak` = 0
- `NIP` = 1
- `IdentyfikatorWewnetrzny` = 2 — IdWew

### RodzajDokumentuKSeFZapytanieOFa (`Soneta.Core.RodzajDokumentuKSeFZapytanieOFa`)
- `Zakup` = 1 — Zakup
- `Sprzedaz` = 2 — Sprzedaż
- `Razem` = 10 — Razem

### StatusZapytania (`Soneta.Core.StatusZapytania`)
- `Zainicjowano` = 1
- `Przetworzono` = 2
- `WRealizacji` = 4 — W realizacji
- `Bledne` = 8 — Błędne
- `Razem` = 15
