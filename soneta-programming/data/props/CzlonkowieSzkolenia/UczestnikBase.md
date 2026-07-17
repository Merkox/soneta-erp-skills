# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.UczestnikBase`
Nazwa tabeli: `Uczestnicy`
Tytuł: Uczestnicy, członkowie
Opis: Kartoteka uczestników i członków organizacji. Przechowuje dane osobowe, kontaktowe, przynależność do klubów i kół oraz historię członkostwa, stanowiąc centralny rejestr osób w module.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IPeselHost`, `INipHost`, `IPlecHost`, `IGIODOZgodnyHost`, `IGIODOWymianaDanychHost`, `IGIODOOświadczenieHost`, `IEmailElement`, `IOceniany`

- pola bazodanowe: 66
- pola kalkulowane (z klas biznesowych): 37

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` |  |  |  |
| AdresDoKorespondencji | `Soneta.Core.Adres` |  |  |  |
| AdresZamieszkania | `Soneta.Core.Adres` |  |  |  |
| CertyfikatEUK | `bool` | bazodanowe |  | Okresla czy członek jest jest certyfikowanym ekspertem usług księgowych. |
| CertyfikatSUPKRIP | `bool` | bazodanowe |  | Okresla czy członek jest jest certyfikowanym specjalista usługowego prowadzenia ksiąg. |
| CertyfikatUPKR | `bool` | bazodanowe |  | Certyfikat na usługowe prowadzenie ksiąg rachunkowych. |
| CertyfikatyUczestnika | `Soneta.Business.SubTable` |  |  |  |
| DataUr | `Soneta.Types.Date` | bazodanowe | Data urodzenia | Data urodzenia. |
| DyplomData | `Soneta.Types.Date` | bazodanowe |  | Data złożenia przyrzeczenia |
| DyplomNiekaralnosc | `bool` | bazodanowe |  | Zaświadczenie o niekaralności. |
| DyplomPraktyka | `bool` | bazodanowe |  | Praktyka zawodowa. |
| DyplomPrzyrzeczenie | `bool` | bazodanowe |  | Potwierdzenie złożenia przyrzeczenia. |
| DyplomStan | `Soneta.CzlonkowieSzkolenia.StanUczestnika` | bazodanowe, enum |  |  |
| DyplomWyksztalcenie | `bool` | bazodanowe |  | Wykształcenie średnie lub wyższe. |
| DyplomZwolnionyUDZ | `bool` | bazodanowe |  | Zwolniony z Ustawicznego Szkolenia Zawodowego. |
| DyplomowanyKS | `bool` | bazodanowe |  | Okresla czy członek jest dyplomowanym ksiegowym. |
| EUKData | `Soneta.Types.Date` | bazodanowe |  | Data złożenia przyrzeczenia |
| EUKNiekaralnosc | `bool` | bazodanowe |  | Zaświadczenie o niekaralności. |
| EUKPraktyka | `bool` | bazodanowe |  | Praktyka zawodowa. |
| EUKPrzyrzeczenie | `bool` | bazodanowe |  | Potwierdzenie złożenia przyrzeczenia. |
| EUKWyksztalcenie | `bool` | bazodanowe |  | Wykształcenie średnie lub wyższe. |
| EUKZwolnionyUDZ | `bool` | bazodanowe |  | Zwolniony z Ustawicznego Szkolenia Zawodowego. |
| EuVAT | `string` | bazodanowe |  |  |
| Firma | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
| GIODOOświadczenia | `Soneta.Business.SubTable<Soneta.Core.GIODOOświadczenie>` |  |  |  |
| GIODOUdostępnienia | `Soneta.Business.SubTable<Soneta.Core.GIODOWymianaDanych>` |  |  |  |
| GodzPosiadaneDK | `double` | bazodanowe | Liczba godzin | Posiadana w roku liczba godzin Dyplomowany Ksiegowy. |
| GodzPosiadaneEUK | `double` | bazodanowe | Liczba godzin | Posiadana w roku liczba godzin EUK. |
| GodzPosiadaneSUPKRIP | `double` | bazodanowe | Liczba godzin | Posiadana w roku liczba godzin SUPKRIP. |
| GodzWymaganeDK | `double` | bazodanowe | Liczba godzin | Wymagana w roku liczba godzin Dyplomowany Ksiegowy. |
| GodzWymaganeEUK | `double` | bazodanowe | Liczba godzin | Wymagana w roku liczba godzin EUK. |
| GodzWymaganeSUPKRIP | `double` | bazodanowe | Liczba godzin | Wymagana w roku liczba godzin SUPKRIP. |
| Imie | `string` | bazodanowe | Imie uczestnika | Imie uczestnika. |
| ImieMatki | `string` | bazodanowe | Imie matki uczestnika | Imie matki uczestnika. |
| ImieNazwisko | `string` |  |  |  |
| ImieOjca | `string` | bazodanowe | Imie ojca uczestnika | Imie ojca uczestnika. |
| IsReadOnlyAdres | `bool` |  |  |  |
| IsReadOnlyAdresDoKorespondencji | `bool` |  |  |  |
| IsReadOnlyAdresZamieszkania | `bool` |  |  |  |
| JednostkaOrg | `string` | bazodanowe | Przynależność do koła | Przynależność do koła. |
| JestZgloszenie | `bool` |  |  |  |
| Klub | `string` | bazodanowe | Przynależność do klubu | Przynależność do klubu. |
| Kluby | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.KlubUcz>` |  |  |  |
| KlubyUczHist | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.KlubUczHist>` |  |  |  |
| Kod | `string` | bazodanowe |  | Kod uczestnika. |
| Komunikator | `string` | bazodanowe |  |  |
| Kontakt | `Soneta.Core.Kontakt` |  |  |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
| KontrolaAktywna | `bool` |  |  |  |
| MailTo | `string` |  |  |  |
| MiejsceUr | `string` | bazodanowe | Miejsce urodzenia | Miejsce urodzenia. |
| NIP | `string` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe | Nazwa firmy | Nazwa firmy. |
| Nazwisko | `string` | bazodanowe | Nazwisko uczestnika | Nazwa uczestnika. |
| NazwiskoImie | `string` |  |  |  |
| NazwiskoRodowe | `string` | bazodanowe | Nazwisko rodowe | Nazwisko rodowe uczestnika. |
| NrRewidenta | `string` | bazodanowe | Numer rewidenta | Numer rewidenta. |
| Numer | `string` | bazodanowe |  | Numer uczestnika. |
| Oceniani | `Soneta.Business.SubTable` |  |  |  |
| OczekujacyNaSkreslenie | `bool` | bazodanowe | Oczekujący na skreślenie | Oczekujący na skreślenie |
| Odczyty | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.OdczytCzlonek>` |  |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy do którego przypisany jest uczestnik. |
| OdznaczeniaUczestnika | `Soneta.Business.SubTable` |  |  |  |
| PESEL | `string` | bazodanowe |  |  |
| Plec | `Soneta.Kadry.PłećOsoby` | bazodanowe, enum |  |  |
| PotwierdzeniaGIODO | `Soneta.Business.SubTable<Soneta.Core.GIODOZgodny>` |  |  |  |
| RejestrUDZ | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.RejestrUDZ>` |  |  |  |
| Rodzaj | `Soneta.CzlonkowieSzkolenia.RodzajCzlonka` | bazodanowe, enum |  |  |
| RodzajDzialalnosci | `string` | bazodanowe |  |  |
| RodzajFirmy | `string` | bazodanowe | Rodzaj firmy | Rodzaj firmy. |
| RokUr | `int` |  |  |  |
| SUPKRIPData | `Soneta.Types.Date` | bazodanowe |  | Data złożenia przyrzeczenia |
| SUPKRIPNiekaralnosc | `bool` | bazodanowe |  | Zaświadczenie o niekaralności. |
| SUPKRIPPraktyka | `bool` | bazodanowe |  | Praktyka zawodowa. |
| SUPKRIPPrzyrzeczenie | `bool` | bazodanowe |  | Potwierdzenie złożenia przyrzeczenia. |
| SUPKRIPWyksztalcenie | `bool` | bazodanowe |  | Wykształcenie średnie lub wyższe. |
| SUPKRIPZwolnionyUDZ | `bool` | bazodanowe |  | Zwolniony z Ustawicznego Szkolenia Zawodowego. |
| Settings | `Soneta.Business.SchedulerSettings` |  |  |  |
| Skladka | `Soneta.Types.Currency` | bazodanowe |  |  |
| Skladki | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.Skladka>` |  |  |  |
| Stan | `Soneta.CzlonkowieSzkolenia.StanUczestnika` | bazodanowe, enum |  |  |
| Stanowisko | `string` | bazodanowe | Stanowisko | Stanowisko. |
| StatusZawodowy | `Soneta.CzlonkowieSzkolenia.StatusZawodowy` | bazodanowe, enum |  |  |
| Staz | `double` | bazodanowe | Ilość lat w zawodzie | Ilość lat w zawodzie. |
| Sygnatariusz | `bool` | bazodanowe |  |  |
| SygnatariuszData | `Soneta.Types.Date` | bazodanowe |  |  |
| Symbol | `string` |  |  |  |
| Typ | `Soneta.CzlonkowieSzkolenia.TypUczestnika` | bazodanowe, enum |  |  |
| TypyDzialalnosci | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.TypDzialalUcz>` |  |  |  |
| TytulNaukowy | `string` | bazodanowe | Tytul naukowy | Tytul naukowy. |
| TytulZawodowy | `string` | bazodanowe | Tytul zawodowy | Tytul zawodowy. |
| TytulyZawodowe | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.TytulZawodUcz>` |  |  |  |
| UczFunkcje | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.UczFunkcja>` |  |  |  |
| UczestnikHist | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.UczestnikHist>` |  |  |  |
| UwagiKontrahenta | `Soneta.Business.MemoText` |  |  |  |
| View | `Soneta.Business.View` |  |  |  |
| WiadomosciPowiazane | `Soneta.Business.SubTable<Soneta.CRM.ElementEmail>` |  |  |  |
| WojewodztwoUr | `Soneta.Core.Wojewodztwa` | bazodanowe, enum |  |  |
| Wyksztalcenie | `string` | bazodanowe | Wykształcenie | Wykształcenie. |
| Wyroznienia | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.Wyroznienie>` |  |  |  |
| Zajecia | `Soneta.Business.View` |  |  |  |
| Zgloszenia | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik>` |  |  |  |
| ZgodnoscGIODOPotwierdzona | `bool` |  |  |  |

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
