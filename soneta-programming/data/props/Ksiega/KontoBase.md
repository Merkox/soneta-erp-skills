# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.KontoBase`
Nazwa tabeli: `Konta`
Tytuł: Konto
Opis: Konto księgowe w planie kont firmy. Przechowuje symbol, nazwę, typ konta (bilansowe, wynikowe, pozabilansowe), bilans otwarcia, walutę oraz strukturę hierarchiczną (konta syntetyczne i analityczne). Umożliwia powiązanie ze słownikami, kontrolę salda, przypisanie do oddziałów firm oraz obsługę kont wielowalutowych.
Tabela konfiguracyjna: Nie
Guided: root
Selektor: pole `Rodzaj` (`Soneta.Ksiega.RodzajKonta`) — wiele typów w jednej tabeli, podtypów: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywne | `bool` | bazodanowe |  |  |
| AktywnoPasywne | `bool` | tylko-odczyt |  |  |
| BOMa | `decimal` | bazodanowe, tylko-odczyt |  |  |
| BOMaB | `decimal` | bazodanowe, tylko-odczyt |  |  |
| BOWn | `decimal` | bazodanowe, tylko-odczyt |  |  |
| BOWnB | `decimal` | bazodanowe, tylko-odczyt |  |  |
| Bilansowe | `bool` | tylko-odczyt |  |  |
| DefinicjaSlownika | `Soneta.Ksiega.DefinicjaSlownika` | tylko-odczyt |  |  |
| DefinicjeAnalityk | `SubTable<Soneta.Ksiega.DefinicjaAnalityki>` | podlista |  |  |
| DefinicjeAnalitykSymbol | `string` | tylko-odczyt |  |  |
| DefinicjeAnalitykViewInfo | `ViewInfo` | tylko-odczyt |  |  |
| ElementKsiegowalny | `Soneta.Core.TypElementuKsiegowalnego` (enum) | bazodanowe |  | Określa jaki typ obiektu w systemie związany jest z księgowaniem na to konto |
| Firma | `Soneta.Core.OddzialFirmy` | bazodanowe, tylko-odczyt | Firma |  |
| Grupa | `string` | tylko-odczyt |  |  |
| IsChangeFromWorker | `bool` |  |  |  |
| Kod | `string` | tylko-odczyt |  |  |
| Kolumna | `Soneta.EwidencjaVat.NrKolumnyKPiR` (enum) | bazodanowe |  | Kolumna w Księdze Przychodów i Rozchodów |
| KontaWalutowe | `SubTable<Soneta.Ksiega.KontoBase>` | podlista |  |  |
| KontoWielowalutowe | `Soneta.Ksiega.KontoWielowalutowe` (enum) | bazodanowe |  |  |
| KontoZwykle | `Soneta.Ksiega.KontoBase` | bazodanowe |  |  |
| KontrolaSalda | `Soneta.Ksiega.KontrolaSalda` (enum) | bazodanowe |  |  |
| Nadrzedne | `Soneta.Ksiega.KontoBase` | bazodanowe, tylko-odczyt |  | Konto nadrzędne. |
| Nazwa | `string` | bazodanowe |  | Nazwa konta. |
| NazwaPelna | `string` | tylko-odczyt |  | Nazwa konta z uwzględnieniem nazw kont nadrzędnych |
| ObrotyKsiegowe | `SubTable<Soneta.Ksiega.ObrotKsiegowyBase>` | podlista |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe, tylko-odczyt |  |  |
| OddzialFirmyInitiator | `Soneta.Core.OddzialFirmy` |  |  |  |
| Okres | `Soneta.Ksiega.OkresObrachunkowy` | bazodanowe, tylko-odczyt |  | Okres obrachunkowy. |
| PowiazanieKonta | `SubTable<Soneta.Ksiega.PowiazanieKontaBase>` | podlista |  |  |
| PowiazanieKontaSlownikowe | `Soneta.Ksiega.PowiazanieSlownikowe` | tylko-odczyt |  |  |
| PowiazanieKontaSystemowe | `Soneta.Ksiega.PowiazanieSystemowe` | tylko-odczyt |  |  |
| PozaBilansowe | `bool` | tylko-odczyt |  |  |
| Poziom | `int` | bazodanowe, tylko-odczyt |  | Poziom konta w strukturze planu kont |
| PozycjeGrupKont | `SubTable<Soneta.Ksiega.PozGrupyKont>` | podlista |  |  |
| PrzyszlySymbol | `string` | bazodanowe |  | Symbol konta w przyszłym okresie. |
| PrzyszlySymbolUstawiony | `bool` | tylko-odczyt |  |  |
| Rodzaj | `Soneta.Ksiega.RodzajKonta` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| Rodzaj2 | `Soneta.Ksiega.Rodzaj2Konta` (enum) | tylko-odczyt |  |  |
| Rozliczeniowe | `bool` | bazodanowe |  |  |
| Segment | `string` | bazodanowe |  | Segment konta. |
| Slownik | `Soneta.Ksiega.DefinicjaSlownika` | bazodanowe |  |  |
| SlownikGlowny | `Soneta.Ksiega.DefinicjaSlownika` | tylko-odczyt |  |  |
| SlownikPowiazan | `SubTable<Soneta.Ksiega.PowiazanieKontaBase>` | podlista |  |  |
| SubKonta | `SubTable<Soneta.Ksiega.KontoBase>` | podlista |  |  |
| Symbol | `string` | bazodanowe, tylko-odczyt |  | Symbol konta. |
| Symbol2 | `string` | bazodanowe, tylko-odczyt |  | Symbol konta bez myślników. |
| SymbolNadrzednego | `string` | tylko-odczyt |  |  |
| SymbolPrzyszlegoOkresu | `string` | tylko-odczyt |  |  |
| SymbolWalutyKonta | `string` | tylko-odczyt |  |  |
| SymbolWalutyOperacji | `string` | tylko-odczyt |  |  |
| Syntetyczne | `bool` | bazodanowe, tylko-odczyt |  |  |
| Syntetyka | `Soneta.Ksiega.KontoBase` | bazodanowe |  |  |
| Typ | `Soneta.Ksiega.TypKonta` (enum) | bazodanowe |  | Typ konta |
| Typ2 | `Soneta.Ksiega.Typ2Konta` (enum) | tylko-odczyt |  |  |
| Waluta | `Soneta.Waluty.Waluta` | bazodanowe |  |  |
| WalutaWybrana | `Soneta.Waluty.Waluta` | bazodanowe |  |  |
| Wynikowe | `bool` | tylko-odczyt |  |  |
| ZabronioneKsiegowanie | `bool` | tylko-odczyt |  |  |
| Zapisy | `SubTable<Soneta.Ksiega.ZapisKsiegowy>` | podlista |  |  |
| ZnacznikKonta | `Soneta.Ksiega.ZnacznikKonta` | bazodanowe | Znacznik konta |  |
| ZnacznikKontaDodatkowy | `Soneta.Ksiega.ZnacznikKonta` | bazodanowe | Znacznik konta dodatkowy |  |
| ZnacznikKontaDodatkowyPD | `Soneta.Ksiega.ZnacznikKonta` | bazodanowe | Znacznik konta dodatkowy PD |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Rodzaj`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Zwykłe` | 1 | `Soneta.Ksiega.Konto` | Konto |
| `Waluty` | 2 | `Soneta.Ksiega.KontoWaluty` | Konto waluty |
| `Walutowe` | 3 | `Soneta.Ksiega.KontoWalutowe` | Konto walutowe |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypElementuKsiegowalnego (`Soneta.Core.TypElementuKsiegowalnego`)
- `Brak` = 0
- `Rozrachunki` = 1
- `RożniceKursowe` = 2
- `ZapisyNierozliczone` = 4
- `ObrotyŚrodkówTrwałych` = 5

### NrKolumnyKPiR (`Soneta.EwidencjaVat.NrKolumnyKPiR`)
- `NieDotyczy` = 0
- `Sprzedaż` = 7 — Sprzedaż
- `PozostałePrzychody` = 8 — Pozostałe przychody
- `ZakupTowarów` = 10 — Zakup towarów
- `KosztyUboczne` = 11 — Koszty uboczne
- `ReprezentacjaIReklama` = 12 — Reprezentacja i reklama
- `Wynagrodzenia` = 13 — Wynagrodzenia
- `PozostałeKoszty` = 14 — Pozostałe koszty
- `Zaszłości` = 16 — Zaszłości
- `BadaniaIRozwój` = 17 — Badania i rozwój
- `Remanent` = 99 — Remanent
- `Ryczałt1` = 101 — Ryczałt 1
- `Ryczałt2` = 102 — Ryczałt 2
- `Ryczałt3` = 103 — Ryczałt 3
- `Ryczałt4` = 104 — Ryczałt 4
- `Ryczałt5` = 105 — Ryczałt 5
- `Ryczałt6` = 106 — Ryczałt 6
- `Ryczałt7` = 107 — Ryczałt 7
- `Ryczałt8` = 108 — Ryczałt 8
- `Ryczałt9` = 109 — Ryczałt 9
- `Ryczałt10` = 110 — Ryczałt 10

### KontoWielowalutowe (`Soneta.Ksiega.KontoWielowalutowe`)
- `Nie` = 0 — Nie
- `JednaWybrana` = 1
- `Wiele` = 2

### KontrolaSalda (`Soneta.Ksiega.KontrolaSalda`)
- `Brak` = 0 — Brak
- `Winien` = 1
- `Ma` = 2

### Rodzaj2Konta (`Soneta.Ksiega.Rodzaj2Konta`)
- `Syntetyczne` = 0 — Syntetyczne
- `Analityczne` = 1

### RodzajKonta (`Soneta.Ksiega.RodzajKonta`)
- `Brak` = 0 — Brak
- `Zwykłe` = 1
- `Waluty` = 2
- `Walutowe` = 3

### Typ2Konta (`Soneta.Ksiega.Typ2Konta`)
- `Bilansowe` = 0 — Bilansowe
- `Wynikowe` = 1
- `Pozabilansowe` = 2

### TypKonta (`Soneta.Ksiega.TypKonta`)
- `Aktywa` = 0 — Aktywa
- `Pasywa` = 1
- `AktywaPasywa` = 2
- `Przychody` = 3
- `Koszty` = 4
- `Pozabilansowe` = 5
- `PozabilansoweAktywnoPasywne` = 6
