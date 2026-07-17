# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.SrodekTrwalyBaseHistoria`
Nazwa tabeli: `SrodkiTrwaleHist`
Tytuł: Ewidencja środków trwałych oraz wartości niematerialnych i prawnych - historia
Opis: Element szczegółowy środka trwałego (SrodekTrwalyBase). Rejestruje historyczne zmiany parametrów środka trwałego, takich jak klasyfikacja KRŚT, miejsce użytkowania, osoba odpowiedzialna, parametry amortyzacji bilansowej i podatkowej oraz dane MSR i JPK.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Srodek` → `SrodekTrwalyBase`

- pola bazodanowe: 45
- pola kalkulowane (z klas biznesowych): 20

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Soneta.Types.FromTo` | bazodanowe |  |  |
| AktualnoscKUP | `Soneta.Types.FromTo` | bazodanowe |  | Aktualność KUP |
| Bilansowa | `Soneta.SrodkiTrwale.ParametryAmortyzacji` | bazodanowe |  | Parametry amortyzacji bilansowej |
| Bilansowa.Metoda | `Soneta.SrodkiTrwale.MetodaAmortyzacji` | bazodanowe, enum |  | Metoda amortyzacji środka trwałego |
| Bilansowa.Proporcja | `double` |  |  |  |
| Bilansowa.Stawka | `Soneta.Types.Percent` | bazodanowe |  | Stawka amortyzacji środka trwałego |
| Bilansowa.WgProporcji | `bool` | bazodanowe | Wg proporcji | Amortyzacja Liniowa liczona wg proporcji |
| Bilansowa.Wspolczynnik | `decimal` | bazodanowe | Współczynnik | Współczynnik amortyzacji środka trwałego |
| Bilansowa.ZmianaOkresuUzytecznosci | `bool` | bazodanowe | Zmiana okresu użyteczności | Zmiana okresu użyteczności |
| CentrumKosztow | `Soneta.Core.CentrumKosztow` | bazodanowe | Centrum kosztów | Centrum kosztów środka trwałego |
| CzestotliwoscOdpisu | `string` |  | Częstotliwość odpisu |  |
| CzyKorektaWartosciPodatkowych | `bool` | bazodanowe |  | Korekta wartości podatkowych |
| CzyKwotaOdpisowAmortyzacyjnych | `bool` | bazodanowe |  | E_16 Czy kwota odpisów amortyzacyjnych przy zmianie formy opodatkowania |
| DataWyceny | `Soneta.Types.Date` | bazodanowe |  | Data wyceny wartości rynkowej środka trwałego |
| Dokumenty | `Soneta.Business.SubTable<Soneta.SrodkiTrwale.DokumentST>` |  |  |  |
| Elementy | `Soneta.Business.LpSubTable<Soneta.SrodkiTrwale.ElementPodatkuOdNieruch>` |  |  |  |
| Ilosc | `double` | bazodanowe | Ilość |  |
| JednostkaMiary | `Soneta.Towary.Jednostka` | bazodanowe | Jm. |  |
| KRST | `Soneta.SrodkiTrwale.RodzajST` | bazodanowe | KRŚT | Rodzaj środka trwałego według KRŚT |
| Kategoria | `Soneta.SrodkiTrwale.KategoriaST` | bazodanowe | Kategoria | Kategoria środka trwałego |
| KwotaOdpisowAmortyzacyjnych | `Soneta.Types.Currency` | bazodanowe |  | E_16 Kwota odpisów amortyzacyjnych przy zmianie formy opodatkowania |
| Lokalizacja | `Soneta.SrodkiTrwale.LokalizacjaNier` | bazodanowe |  | Nazwa lokalizacji do podatku od nieruchomości |
| MetodaAmortyzacji | `string` |  | Metoda amortyzacji |  |
| MetodaInnaJPK | `bool` | bazodanowe |  | Metoda Inna (JPK) |
| MetodaWRMSR | `Soneta.SrodkiTrwale.MetodaObliczeniaWartosciMSR` | bazodanowe, enum |  | Metoda obliczenia wartości rezydualnej MSR |
| MiejsceUzytkowania | `Soneta.SrodkiTrwale.MiejsceUzytkowania` | bazodanowe | Miejsce użytkowania | Miejsce użytkowania środeka trwałego |
| Nazwisko | `string` | bazodanowe |  | Nazwisko osoby odpowiedzialnej za środek trwały |
| OdpisyBiezaceZRokuPodatkowegoNKUP | `Soneta.Types.Currency` | bazodanowe |  | E_18 – Odpisy bieżące z roku podatkowego NKUP |
| OdpisyRazem | `Soneta.Types.Currency` | bazodanowe |  | E_23 - Zaktualizowana kwota odpisów amortyzacyjnych rachunkowa z Rozporządzenia |
| OdpisyRazemKUP | `Soneta.Types.Currency` | bazodanowe |  | E_14 - Zaktualizowana kwota odpisów amortyzacyjnych podatkowa z Rozporządzenia |
| Odpowiedzialny | `Soneta.Kadry.Pracownik` | bazodanowe |  | Pracownik odpowiedzialny za środek trwały |
| OkresObrachunkowy | `Soneta.Ksiega.OkresObrachunkowy` |  |  |  |
| Parent | `Soneta.Business.Row` |  |  |  |
| Podatkowa | `Soneta.SrodkiTrwale.ParametryAmortyzacji` | bazodanowe |  | Parametry amortyzacji podatkowej |
| Pozabilansowy | `bool` | bazodanowe |  | Środek bilansowy/pozabilansowy |
| Reklasyfikacja | `bool` |  |  |  |
| Sezonowosc | `Soneta.SrodkiTrwale.Sezonowosc` | bazodanowe | Sezonowość | Sezonowość środka trwałego |
| Sezonowosc.M1 | `bool` |  |  | Miesiąc |
| Sezonowosc.M10 | `bool` |  |  | Miesiąc |
| Sezonowosc.M11 | `bool` |  |  | Miesiąc |
| Sezonowosc.M12 | `bool` |  |  | Miesiąc |
| Sezonowosc.M2 | `bool` |  |  | Miesiąc |
| Sezonowosc.M3 | `bool` |  |  | Miesiąc |
| Sezonowosc.M4 | `bool` |  |  | Miesiąc |
| Sezonowosc.M5 | `bool` |  |  | Miesiąc |
| Sezonowosc.M6 | `bool` |  |  | Miesiąc |
| Sezonowosc.M7 | `bool` |  |  | Miesiąc |
| Sezonowosc.M8 | `bool` |  |  | Miesiąc |
| Sezonowosc.M9 | `bool` |  |  | Miesiąc |
| Sezonowosc.Proporcjonalnie | `bool` | bazodanowe |  | Proporcjonalnie do liczby okresów lub 1/12 |
| Sezonowosc.Rodzaj | `Soneta.SrodkiTrwale.RodzajSezonowosci` | bazodanowe, enum |  | Rodzaj sezonowości |
| Sezonowosc.Wartosc | `string` | bazodanowe |  |  |
| Srodek | `Soneta.SrodkiTrwale.SrodekTrwalyBase` | bazodanowe, guided-parent |  |  |
| Typ | `Soneta.SrodkiTrwale.TypSrodkaTrwalego` | bazodanowe, enum |  | Typ środka trwałego |
| UlgaInwestycyjna | `Soneta.Types.Currency` | bazodanowe |  | Wartość zaliczona do ulgi inwestycyjnej |
| UlgaInwestycyjna30 | `Soneta.Types.Currency` | bazodanowe |  | Wartość 30% ulgi inwestycyjnej w pierwszym roku użytkowania |
| WartoscPoczatkowaKUP | `Soneta.Types.Currency` | bazodanowe |  | E_12 – Wartość początkowa KUP |
| WartoscRynkowa | `Soneta.Types.Currency` | bazodanowe | Wartość rynkowa |  |
| WartoscWRMSR | `Soneta.Types.Currency` | bazodanowe |  | Wartość rezydualna MSR |
| WspolczynnikWRMSR | `Soneta.Types.Percent` | bazodanowe |  | Wartość współczynnika obliczenia wartości rezydualnej MSR |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka Organizacyjna |  |
| ZaktualizowanaWartoscPoczatkowa | `Soneta.Types.Currency` | bazodanowe |  | E_22 - Zaktualizowana wartość początkowa rachunkowa z Rozporządzenia |
| ZaktualizowanaWartoscPoczatkowaKUP | `Soneta.Types.Currency` | bazodanowe |  | E_13 - Zaktualizowana wartość początkowa podatkowa z Rozporządzenia |
| Zestaw | `Soneta.SrodkiTrwale.ZestawST` | bazodanowe |  | Zestaw, do którego należy środek trwały |
| ZmianaWartosciPoczatkowejKUP | `Soneta.Types.Currency` | bazodanowe |  | E_15 – Zmiana wartości początkowej KUP |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### MetodaAmortyzacji (`Soneta.SrodkiTrwale.MetodaAmortyzacji`)
- `NieAmortyzować` = 0 — Nie amortyzować
- `Jednorazowa` = 1
- `Liniowa` = 2
- `Degresywna` = 3

### MetodaObliczeniaWartosciMSR (`Soneta.SrodkiTrwale.MetodaObliczeniaWartosciMSR`)
- `Brak` = 0
- `WgWartościRynkowej` = 1
- `WgWspółczynnikaPrzeszacowania` = 2 — Wg współczynnika
- `Dowolna` = 3

### RodzajSezonowosci (`Soneta.SrodkiTrwale.RodzajSezonowosci`)
- `Miesięczna` = 0
- `Kwartalna` = 1
- `Półroczna` = 2
- `Roczna` = 3
- `Sezonowa` = 4
- `Inna` = 5

### TypSrodkaTrwalego (`Soneta.SrodkiTrwale.TypSrodkaTrwalego`)
- `Brak` = 0
- `ŚrodekTrwały` = 1
- `WartośćNiematerialnaIPrawna` = 2
- `Wyposażenie` = 3
