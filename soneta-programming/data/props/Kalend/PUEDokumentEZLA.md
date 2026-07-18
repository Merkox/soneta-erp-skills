# Pola i właściwości klasy biznesowej: `Soneta.Kalend.PUEDokumentEZLA`
Nazwa tabeli: `PUEDokEZLA`
Tytuł: Dokument ZLA importowany z PUE
Opis: Element szczegółowy raportu nieobecności PUE (PUERaportNieobecnosci). Pojedynczy dokument e-ZLA (zwolnienie lekarskie) importowany z PUE ZUS, zawierający dane ubezpieczonego, okres zwolnienia, kody chorób, wskazania lekarskie oraz stan przetworzenia.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Raport` → `PUERaportNieobecnosci`
Implementuje interfejsy: `IDokumentAktualizacjiKalendarza`

- pola bazodanowe (zapisywalne): 23
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 6
- podlisty: 8
- subrowy: 0
- razem: 37

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzyAnulowane | `string` | bazodanowe |  |  |
| DataUrodzeniaOsoby | `Date` | bazodanowe |  |  |
| DataWystawienia | `Date` | bazodanowe |  |  |
| DataZus | `Date` | bazodanowe |  |  |
| DataZwolnieniaDo | `Date` | bazodanowe |  |  |
| DniKalendarzaHistorie | `SubTable<Soneta.Kalend.DzienKalendarzaHistoria>` | podlista |  |  |
| DniPracyHistorie | `SubTable<Soneta.Kalend.DzienPracyHistoria>` | podlista |  |  |
| EdytowanoNb | `bool` | bazodanowe |  |  |
| KodChoroby | `string` | tylko-odczyt |  |  |
| KodChorobyA | `string` | bazodanowe |  |  |
| KodChorobyB | `string` | bazodanowe |  |  |
| KodChorobyC | `string` | bazodanowe |  |  |
| KodChorobyD | `string` | bazodanowe |  |  |
| KodChorobyE | `string` | bazodanowe |  |  |
| KodPokrewienstwa | `string` | bazodanowe |  |  |
| KodyChoroby | `string` | tylko-odczyt |  |  |
| Kontynuacja | `bool` | tylko-odczyt |  |  |
| MiejsceUbezpieczenia | `string` | bazodanowe |  |  |
| Numer | `string` | bazodanowe |  |  |
| OkresSkroconyEzlaK | `FromTo` | podlista |  |  |
| OkresWSzpitalu | `FromTo` | bazodanowe, podlista |  |  |
| OkresWSzpitaluTxt | `string` | tylko-odczyt |  |  |
| OkresZwolnienia | `FromTo` | bazodanowe, podlista |  |  |
| PoprzedniImport | `bool` | bazodanowe |  |  |
| Raport | `Soneta.Kalend.PUERaportNieobecnosci` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Seria | `string` | bazodanowe |  |  |
| SeriaNumer | `string` | tylko-odczyt |  |  |
| Stan | `Soneta.Kalend.PUEStan` (enum) | bazodanowe |  |  |
| StatusEZLA | `Soneta.Kalend.PUEStatusEZLA` (enum) | bazodanowe |  |  |
| UbIdentyfikator | `string` | bazodanowe |  |  |
| UbIdentyfikatorTyp | `Soneta.Kalend.PUEIdentyfikatorTyp` (enum) | bazodanowe |  |  |
| UbImie | `string` | bazodanowe |  |  |
| UbNazwisko | `string` | bazodanowe |  |  |
| WskazaniaLekarskie | `string` | bazodanowe |  |  |
| ZapisDzialan | `MemoText` | bazodanowe, podlista |  |  |
| Zrodlo | `MemoText` | bazodanowe, podlista |  |  |
| ZrodloEzlaK | `MemoText` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PUEIdentyfikatorTyp (`Soneta.Kalend.PUEIdentyfikatorTyp`)
- `PESEL` = 1
- `Paszport` = 2

### PUEStan (`Soneta.Kalend.PUEStan`)
- `Pobrany` = 0
- `Zaimportowany` = 10
- `Odrzucony` = 20
- `Wszystkie` = 1000

### PUEStatusEZLA (`Soneta.Kalend.PUEStatusEZLA`)
- `Wystawione` = 1
- `Anulowane` = 2
- `Skorygowane` = 3
- `WsteczneDoWyjaśnienia` = 4
- `WsteczneUzasadnione` = 5
- `WsteczneNieUzasadnione` = 6
