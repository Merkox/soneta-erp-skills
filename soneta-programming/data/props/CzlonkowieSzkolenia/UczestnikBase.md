# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.UczestnikBase`
Nazwa tabeli: `Uczestnicy`
Tytuł: Uczestnicy, członkowie
Opis: Kartoteka uczestników i członków organizacji. Przechowuje dane osobowe, kontaktowe, przynależność do klubów i kół oraz historię członkostwa, stanowiąc centralny rejestr osób w module.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IPeselHost`, `INipHost`, `IPlecHost`, `IGIODOZgodnyHost`, `IGIODOWymianaDanychHost`, `IGIODOOświadczenieHost`, `IEmailElement`, `IOceniany`
Selektor: pole `Typ` (`Soneta.CzlonkowieSzkolenia.TypUczestnika`) — wiele typów w jednej tabeli, podtypów: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| AdresDoKorespondencji | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| AdresZamieszkania | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| CertyfikatEUK | `bool` | bazodanowe |  | Okresla czy członek jest jest certyfikowanym ekspertem usług księgowych. |
| CertyfikatSUPKRIP | `bool` | bazodanowe |  | Okresla czy członek jest jest certyfikowanym specjalista usługowego prowadzenia ksiąg. |
| CertyfikatUPKR | `bool` | bazodanowe |  | Certyfikat na usługowe prowadzenie ksiąg rachunkowych. |
| CertyfikatyUczestnika | `SubTable` | podlista |  |  |
| DataUr | `Date` | bazodanowe | Data urodzenia | Data urodzenia. |
| DyplomData | `Date` | bazodanowe |  | Data złożenia przyrzeczenia |
| DyplomNiekaralnosc | `bool` | bazodanowe |  | Zaświadczenie o niekaralności. |
| DyplomPraktyka | `bool` | bazodanowe |  | Praktyka zawodowa. |
| DyplomPrzyrzeczenie | `bool` | bazodanowe |  | Potwierdzenie złożenia przyrzeczenia. |
| DyplomStan | `Soneta.CzlonkowieSzkolenia.StanUczestnika` (enum) | bazodanowe |  |  |
| DyplomWyksztalcenie | `bool` | bazodanowe |  | Wykształcenie średnie lub wyższe. |
| DyplomZwolnionyUDZ | `bool` | bazodanowe |  | Zwolniony z Ustawicznego Szkolenia Zawodowego. |
| DyplomowanyKS | `bool` | bazodanowe |  | Okresla czy członek jest dyplomowanym ksiegowym. |
| EUKData | `Date` | bazodanowe |  | Data złożenia przyrzeczenia |
| EUKNiekaralnosc | `bool` | bazodanowe |  | Zaświadczenie o niekaralności. |
| EUKPraktyka | `bool` | bazodanowe |  | Praktyka zawodowa. |
| EUKPrzyrzeczenie | `bool` | bazodanowe |  | Potwierdzenie złożenia przyrzeczenia. |
| EUKWyksztalcenie | `bool` | bazodanowe |  | Wykształcenie średnie lub wyższe. |
| EUKZwolnionyUDZ | `bool` | bazodanowe |  | Zwolniony z Ustawicznego Szkolenia Zawodowego. |
| EuVAT | `string` | bazodanowe |  |  |
| Firma | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
| GIODOOświadczenia | `SubTable<Soneta.Core.GIODOOświadczenie>` | podlista |  |  |
| GIODOUdostępnienia | `SubTable<Soneta.Core.GIODOWymianaDanych>` | podlista |  |  |
| GodzPosiadaneDK | `double` | bazodanowe | Liczba godzin | Posiadana w roku liczba godzin Dyplomowany Ksiegowy. |
| GodzPosiadaneEUK | `double` | bazodanowe | Liczba godzin | Posiadana w roku liczba godzin EUK. |
| GodzPosiadaneSUPKRIP | `double` | bazodanowe | Liczba godzin | Posiadana w roku liczba godzin SUPKRIP. |
| GodzWymaganeDK | `double` | bazodanowe | Liczba godzin | Wymagana w roku liczba godzin Dyplomowany Ksiegowy. |
| GodzWymaganeEUK | `double` | bazodanowe | Liczba godzin | Wymagana w roku liczba godzin EUK. |
| GodzWymaganeSUPKRIP | `double` | bazodanowe | Liczba godzin | Wymagana w roku liczba godzin SUPKRIP. |
| Imie | `string` | bazodanowe | Imie uczestnika | Imie uczestnika. |
| ImieMatki | `string` | bazodanowe | Imie matki uczestnika | Imie matki uczestnika. |
| ImieNazwisko | `string` | tylko-odczyt |  |  |
| ImieOjca | `string` | bazodanowe | Imie ojca uczestnika | Imie ojca uczestnika. |
| IsReadOnlyAdres | `bool` | tylko-odczyt |  |  |
| IsReadOnlyAdresDoKorespondencji | `bool` | tylko-odczyt |  |  |
| IsReadOnlyAdresZamieszkania | `bool` | tylko-odczyt |  |  |
| JednostkaOrg | `string` | bazodanowe | Przynależność do koła | Przynależność do koła. |
| JestZgloszenie | `bool` | tylko-odczyt |  |  |
| Klub | `string` | bazodanowe | Przynależność do klubu | Przynależność do klubu. |
| Kluby | `SubTable<Soneta.CzlonkowieSzkolenia.KlubUcz>` | podlista |  |  |
| KlubyUczHist | `SubTable<Soneta.CzlonkowieSzkolenia.KlubUczHist>` | podlista |  |  |
| Kod | `string` | bazodanowe |  | Kod uczestnika. |
| Komunikator | `string` | bazodanowe |  |  |
| Kontakt | `Soneta.Core.Kontakt` | tylko-odczyt |  |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
| KontrolaAktywna | `bool` | tylko-odczyt |  |  |
| MailTo | `string` | tylko-odczyt |  |  |
| MiejsceUr | `string` | bazodanowe | Miejsce urodzenia | Miejsce urodzenia. |
| NIP | `string` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe | Nazwa firmy | Nazwa firmy. |
| Nazwisko | `string` | bazodanowe | Nazwisko uczestnika | Nazwa uczestnika. |
| NazwiskoImie | `string` | tylko-odczyt |  |  |
| NazwiskoRodowe | `string` | bazodanowe | Nazwisko rodowe | Nazwisko rodowe uczestnika. |
| NrRewidenta | `string` | bazodanowe | Numer rewidenta | Numer rewidenta. |
| Numer | `string` | bazodanowe |  | Numer uczestnika. |
| Oceniani | `SubTable` | podlista |  |  |
| OczekujacyNaSkreslenie | `bool` | bazodanowe | Oczekujący na skreślenie | Oczekujący na skreślenie |
| Odczyty | `SubTable<Soneta.CzlonkowieSzkolenia.OdczytCzlonek>` | podlista |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy do którego przypisany jest uczestnik. |
| OdznaczeniaUczestnika | `SubTable` | podlista |  |  |
| PESEL | `string` | bazodanowe |  |  |
| Plec | `Soneta.Kadry.PłećOsoby` (enum) | bazodanowe |  |  |
| PotwierdzeniaGIODO | `SubTable<Soneta.Core.GIODOZgodny>` | podlista |  |  |
| RejestrUDZ | `SubTable<Soneta.CzlonkowieSzkolenia.RejestrUDZ>` | podlista |  |  |
| Rodzaj | `Soneta.CzlonkowieSzkolenia.RodzajCzlonka` (enum) | bazodanowe |  |  |
| RodzajDzialalnosci | `string` | bazodanowe |  |  |
| RodzajFirmy | `string` | bazodanowe | Rodzaj firmy | Rodzaj firmy. |
| RokUr | `int` |  |  |  |
| SUPKRIPData | `Date` | bazodanowe |  | Data złożenia przyrzeczenia |
| SUPKRIPNiekaralnosc | `bool` | bazodanowe |  | Zaświadczenie o niekaralności. |
| SUPKRIPPraktyka | `bool` | bazodanowe |  | Praktyka zawodowa. |
| SUPKRIPPrzyrzeczenie | `bool` | bazodanowe |  | Potwierdzenie złożenia przyrzeczenia. |
| SUPKRIPWyksztalcenie | `bool` | bazodanowe |  | Wykształcenie średnie lub wyższe. |
| SUPKRIPZwolnionyUDZ | `bool` | bazodanowe |  | Zwolniony z Ustawicznego Szkolenia Zawodowego. |
| Settings | `SchedulerSettings` | tylko-odczyt |  |  |
| Skladka | `Currency` | bazodanowe |  |  |
| Skladki | `SubTable<Soneta.CzlonkowieSzkolenia.Skladka>` | podlista |  |  |
| Stan | `Soneta.CzlonkowieSzkolenia.StanUczestnika` (enum) | bazodanowe |  |  |
| Stanowisko | `string` | bazodanowe | Stanowisko | Stanowisko. |
| StatusZawodowy | `Soneta.CzlonkowieSzkolenia.StatusZawodowy` (enum) | bazodanowe |  |  |
| Staz | `double` | bazodanowe | Ilość lat w zawodzie | Ilość lat w zawodzie. |
| Sygnatariusz | `bool` | bazodanowe |  |  |
| SygnatariuszData | `Date` | bazodanowe |  |  |
| Symbol | `string` | tylko-odczyt |  |  |
| Typ | `Soneta.CzlonkowieSzkolenia.TypUczestnika` (enum) | bazodanowe, selektor |  |  |
| TypyDzialalnosci | `SubTable<Soneta.CzlonkowieSzkolenia.TypDzialalUcz>` | podlista |  |  |
| TytulNaukowy | `string` | bazodanowe | Tytul naukowy | Tytul naukowy. |
| TytulZawodowy | `string` | bazodanowe | Tytul zawodowy | Tytul zawodowy. |
| TytulyZawodowe | `SubTable<Soneta.CzlonkowieSzkolenia.TytulZawodUcz>` | podlista |  |  |
| UczFunkcje | `SubTable<Soneta.CzlonkowieSzkolenia.UczFunkcja>` | podlista |  |  |
| UczestnikHist | `SubTable<Soneta.CzlonkowieSzkolenia.UczestnikHist>` | podlista |  |  |
| UwagiKontrahenta | `MemoText` | podlista |  |  |
| View | `View` | podlista |  |  |
| WiadomosciPowiazane | `SubTable<Soneta.CRM.ElementEmail>` | podlista |  |  |
| WojewodztwoUr | `Soneta.Core.Wojewodztwa` (enum) | bazodanowe |  |  |
| Wyksztalcenie | `string` | bazodanowe | Wykształcenie | Wykształcenie. |
| Wyroznienia | `SubTable<Soneta.CzlonkowieSzkolenia.Wyroznienie>` | podlista |  |  |
| Zajecia | `View` | podlista |  |  |
| Zgloszenia | `SubTable<Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik>` | podlista |  |  |
| ZgodnoscGIODOPotwierdzona | `bool` |  |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `UczestnikSzkolenia` | 1 | `Soneta.CzlonkowieSzkolenia.UczestnikSzkolenia` |  |
| `CzlonekZwyczajny` | 2 | `Soneta.CzlonkowieSzkolenia.CzlonekZwyczajny` | Członek zwyczajny |
| `CzlonekWspierajacy` | 3 | `Soneta.CzlonkowieSzkolenia.CzlonekWspierajacy` | Członek wspierający |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### Wojewodztwa (`Soneta.Core.Wojewodztwa`)
- `nieokreślone` = 0
- `dolnośląskie` = 1
- `kujawsko_pomorskie` = 2 — kujawsko-pomorskie
- `lubelskie` = 3
- `lubuskie` = 4
- `łódzkie` = 5
- `małopolskie` = 6
- `mazowieckie` = 7
- `opolskie` = 8
- `podkarpackie` = 9
- `podlaskie` = 10
- `pomorskie` = 11
- `śląskie` = 12
- `świętokrzyskie` = 13
- `warmińsko_mazurskie` = 14 — warmińsko-mazurskie
- `wielkopolskie` = 15
- `zachodniopomorskie` = 16

### RodzajCzlonka (`Soneta.CzlonkowieSzkolenia.RodzajCzlonka`)
- `NieDotyczy` = 0
- `Zwyczajny` = 1
- `ZwyczajnyDyplomKs` = 2 — Zwyczajny - dyplomowany księgowy
- `Honorowy` = 3

### StanUczestnika (`Soneta.CzlonkowieSzkolenia.StanUczestnika`)
- `NieDotyczy` = 0 — Nie dotyczy
- `Oczekujący` = 1
- `Czynny` = 2
- `Skreślony` = 3
- `Razem` = 99

### StatusZawodowy (`Soneta.CzlonkowieSzkolenia.StatusZawodowy`)
- `NieDotyczy` = 0 — Nie dotyczy
- `Zatrudniony` = 1
- `Emeryt` = 2
- `Rencista` = 3
- `Student` = 4
- `Uczeń` = 5
- `Senior` = 6
- `CzłonekHonorowy` = 7 — Członek honorowy

### TypUczestnika (`Soneta.CzlonkowieSzkolenia.TypUczestnika`)
- `UczestnikSzkolenia` = 1 — Uczestnik szkolenia
- `CzlonekZwyczajny` = 2
- `CzlonekWspierajacy` = 3

### PłećOsoby (`Soneta.Kadry.PłećOsoby`)
- `Kobieta` = 0
- `Mężczyzna` = 1
