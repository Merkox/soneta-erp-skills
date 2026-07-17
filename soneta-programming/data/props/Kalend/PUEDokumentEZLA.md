# Pola i właściwości klasy biznesowej: `Soneta.Kalend.PUEDokumentEZLA`
Nazwa tabeli: `PUEDokEZLA`
Tytuł: Dokument ZLA importowany z PUE
Opis: Element szczegółowy raportu nieobecności PUE (PUERaportNieobecnosci). Pojedynczy dokument e-ZLA (zwolnienie lekarskie) importowany z PUE ZUS, zawierający dane ubezpieczonego, okres zwolnienia, kody chorób, wskazania lekarskie oraz stan przetworzenia.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Raport` → `PUERaportNieobecnosci`
Implementuje interfejsy: `IDokumentAktualizacjiKalendarza`

- pola bazodanowe: 28
- pola kalkulowane (z klas biznesowych): 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzyAnulowane | `string` | bazodanowe |  |  |
| DataUrodzeniaOsoby | `Soneta.Types.Date` | bazodanowe |  |  |
| DataWystawienia | `Soneta.Types.Date` | bazodanowe |  |  |
| DataZus | `Soneta.Types.Date` | bazodanowe |  |  |
| DataZwolnieniaDo | `Soneta.Types.Date` | bazodanowe |  |  |
| DniKalendarzaHistorie | `Soneta.Business.SubTable<Soneta.Kalend.DzienKalendarzaHistoria>` |  |  |  |
| DniPracyHistorie | `Soneta.Business.SubTable<Soneta.Kalend.DzienPracyHistoria>` |  |  |  |
| EdytowanoNb | `bool` | bazodanowe |  |  |
| KodChoroby | `string` |  |  |  |
| KodChorobyA | `string` | bazodanowe |  |  |
| KodChorobyB | `string` | bazodanowe |  |  |
| KodChorobyC | `string` | bazodanowe |  |  |
| KodChorobyD | `string` | bazodanowe |  |  |
| KodChorobyE | `string` | bazodanowe |  |  |
| KodPokrewienstwa | `string` | bazodanowe |  |  |
| KodyChoroby | `string` |  |  |  |
| Kontynuacja | `bool` |  |  |  |
| MiejsceUbezpieczenia | `string` | bazodanowe |  |  |
| Numer | `string` | bazodanowe |  |  |
| OkresSkroconyEzlaK | `Soneta.Types.FromTo` |  |  |  |
| OkresWSzpitalu | `Soneta.Types.FromTo` | bazodanowe |  |  |
| OkresWSzpitaluTxt | `string` |  |  |  |
| OkresZwolnienia | `Soneta.Types.FromTo` | bazodanowe |  |  |
| PoprzedniImport | `bool` | bazodanowe |  |  |
| Raport | `Soneta.Kalend.PUERaportNieobecnosci` | bazodanowe, guided-parent |  |  |
| Seria | `string` | bazodanowe |  |  |
| SeriaNumer | `string` |  |  |  |
| Stan | `Soneta.Kalend.PUEStan` | bazodanowe, enum |  |  |
| StatusEZLA | `Soneta.Kalend.PUEStatusEZLA` | bazodanowe, enum |  |  |
| UbIdentyfikator | `string` | bazodanowe |  |  |
| UbIdentyfikatorTyp | `Soneta.Kalend.PUEIdentyfikatorTyp` | bazodanowe, enum |  |  |
| UbImie | `string` | bazodanowe |  |  |
| UbNazwisko | `string` | bazodanowe |  |  |
| WskazaniaLekarskie | `string` | bazodanowe |  |  |
| ZapisDzialan | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Zrodlo | `Soneta.Business.MemoText` | bazodanowe |  |  |
| ZrodloEzlaK | `Soneta.Business.MemoText` |  |  |  |

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
