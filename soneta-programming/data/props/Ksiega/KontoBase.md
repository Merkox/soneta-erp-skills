# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.KontoBase`
Nazwa tabeli: `Konta`
Tytuł: Konto
Opis: Konto księgowe w planie kont firmy. Przechowuje symbol, nazwę, typ konta (bilansowe, wynikowe, pozabilansowe), bilans otwarcia, walutę oraz strukturę hierarchiczną (konta syntetyczne i analityczne). Umożliwia powiązanie ze słownikami, kontrolę salda, przypisanie do oddziałów firm oraz obsługę kont wielowalutowych.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 31
- pola kalkulowane (z klas biznesowych): 31

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywne | `bool` | bazodanowe |  |  |
| AktywnoPasywne | `bool` |  |  |  |
| BOMa | `decimal` | bazodanowe |  |  |
| BOMaB | `decimal` | bazodanowe |  |  |
| BOWn | `decimal` | bazodanowe |  |  |
| BOWnB | `decimal` | bazodanowe |  |  |
| Bilansowe | `bool` |  |  |  |
| DefinicjaSlownika | `Soneta.Ksiega.DefinicjaSlownika` |  |  |  |
| DefinicjeAnalityk | `Soneta.Business.SubTable<Soneta.Ksiega.DefinicjaAnalityki>` |  |  |  |
| DefinicjeAnalitykSymbol | `string` |  |  |  |
| DefinicjeAnalitykViewInfo | `Soneta.Business.ViewInfo` |  |  |  |
| ElementKsiegowalny | `Soneta.Core.TypElementuKsiegowalnego` | bazodanowe, enum |  | Określa jaki typ obiektu w systemie związany jest z księgowaniem na to konto |
| Firma | `Soneta.Core.OddzialFirmy` | bazodanowe | Firma |  |
| Grupa | `string` |  |  |  |
| IsChangeFromWorker | `bool` |  |  |  |
| Kod | `string` |  |  |  |
| Kolumna | `Soneta.EwidencjaVat.NrKolumnyKPiR` | bazodanowe, enum |  | Kolumna w Księdze Przychodów i Rozchodów |
| KontaWalutowe | `Soneta.Business.SubTable<Soneta.Ksiega.KontoBase>` |  |  |  |
| KontoWielowalutowe | `Soneta.Ksiega.KontoWielowalutowe` | bazodanowe, enum |  |  |
| KontoZwykle | `Soneta.Ksiega.KontoBase` | bazodanowe |  |  |
| KontrolaSalda | `Soneta.Ksiega.KontrolaSalda` | bazodanowe, enum |  |  |
| Nadrzedne | `Soneta.Ksiega.KontoBase` | bazodanowe |  | Konto nadrzędne. |
| Nazwa | `string` | bazodanowe |  | Nazwa konta. |
| NazwaPelna | `string` |  |  | Nazwa konta z uwzględnieniem nazw kont nadrzędnych |
| ObrotyKsiegowe | `Soneta.Business.SubTable<Soneta.Ksiega.ObrotKsiegowyBase>` |  |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| OddzialFirmyInitiator | `Soneta.Core.OddzialFirmy` |  |  |  |
| Okres | `Soneta.Ksiega.OkresObrachunkowy` | bazodanowe |  | Okres obrachunkowy. |
| PowiazanieKonta | `Soneta.Business.SubTable<Soneta.Ksiega.PowiazanieKontaBase>` |  |  |  |
| PowiazanieKontaSlownikowe | `Soneta.Ksiega.PowiazanieSlownikowe` |  |  |  |
| PowiazanieKontaSystemowe | `Soneta.Ksiega.PowiazanieSystemowe` |  |  |  |
| PozaBilansowe | `bool` |  |  |  |
| Poziom | `int` | bazodanowe |  | Poziom konta w strukturze planu kont |
| PozycjeGrupKont | `Soneta.Business.SubTable<Soneta.Ksiega.PozGrupyKont>` |  |  |  |
| PrzyszlySymbol | `string` | bazodanowe |  | Symbol konta w przyszłym okresie. |
| PrzyszlySymbolUstawiony | `bool` |  |  |  |
| Rodzaj | `Soneta.Ksiega.RodzajKonta` | bazodanowe, enum |  |  |
| Rodzaj2 | `Soneta.Ksiega.Rodzaj2Konta` | enum |  |  |
| Rozliczeniowe | `bool` | bazodanowe |  |  |
| Segment | `string` | bazodanowe |  | Segment konta. |
| Slownik | `Soneta.Ksiega.DefinicjaSlownika` | bazodanowe |  |  |
| SlownikGlowny | `Soneta.Ksiega.DefinicjaSlownika` |  |  |  |
| SlownikPowiazan | `Soneta.Business.SubTable<Soneta.Ksiega.PowiazanieKontaBase>` |  |  |  |
| SubKonta | `Soneta.Business.SubTable<Soneta.Ksiega.KontoBase>` |  |  |  |
| Symbol | `string` | bazodanowe |  | Symbol konta. |
| Symbol2 | `string` | bazodanowe |  | Symbol konta bez myślników. |
| SymbolNadrzednego | `string` |  |  |  |
| SymbolPrzyszlegoOkresu | `string` |  |  |  |
| SymbolWalutyKonta | `string` |  |  |  |
| SymbolWalutyOperacji | `string` |  |  |  |
| Syntetyczne | `bool` | bazodanowe |  |  |
| Syntetyka | `Soneta.Ksiega.KontoBase` | bazodanowe |  |  |
| Typ | `Soneta.Ksiega.TypKonta` | bazodanowe, enum |  | Typ konta |
| Typ2 | `Soneta.Ksiega.Typ2Konta` | enum |  |  |
| Waluta | `Soneta.Waluty.Waluta` | bazodanowe |  |  |
| WalutaWybrana | `Soneta.Waluty.Waluta` | bazodanowe |  |  |
| Wynikowe | `bool` |  |  |  |
| ZabronioneKsiegowanie | `bool` |  |  |  |
| Zapisy | `Soneta.Business.SubTable<Soneta.Ksiega.ZapisKsiegowy>` |  |  |  |
| ZnacznikKonta | `Soneta.Ksiega.ZnacznikKonta` | bazodanowe | Znacznik konta |  |
| ZnacznikKontaDodatkowy | `Soneta.Ksiega.ZnacznikKonta` | bazodanowe | Znacznik konta dodatkowy |  |
| ZnacznikKontaDodatkowyPD | `Soneta.Ksiega.ZnacznikKonta` | bazodanowe | Znacznik konta dodatkowy PD |  |

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
