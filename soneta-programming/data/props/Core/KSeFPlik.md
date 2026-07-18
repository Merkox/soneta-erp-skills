# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFPlik`
Nazwa tabeli: `KSeFPliki`
Tytuł: Pliki KSeF
Opis: Plik dokumentu pobranego z Krajowego Systemu e-Faktur (KSeF). Zawiera dane faktury: kontrahent, NIP, numer KSeF, numer dokumentu, daty, kwoty (netto, brutto, VAT), kategorię, rodzaj dokumentu, formę płatności, termin płatności oraz powiązanie z dokumentem w systemie.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 33
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 10
- podlisty: 2
- subrowy: 0
- razem: 45

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AkceptacjaKlienta | `bool` | bazodanowe | Akceptacja klienta | Akceptacja klienta |
| Czesc | `Soneta.Core.KSeFPartList` | bazodanowe | Pakiet | Pakiet danych |
| Data | `Date` | bazodanowe | Data wystawienia | Data dokumentu z pola P_1 w XML |
| DataKSeF | `Date` | bazodanowe | Data KSeF | Data wystawienia dokumentu na platformie KSeF |
| DataZPolaP6 | `Date` | bazodanowe | Data dokonania lub zakończenia dostawy towarów lub wykonania usługi | Data dokonania lub zakończenia dostawy towarów lub wykonania usługi |
| DataZPolaP6Do | `Date` | bazodanowe | Data końcowa okresu, którego dotyczy faktura | Data końcowa okresu, którego dotyczy faktura |
| DataZPolaP6Od | `Date` | bazodanowe | Data początkowa okresu, którego dotyczy faktura | Data początkowa okresu, którego dotyczy faktura |
| Dokument | `Soneta.Core.IKomunikatKSeFHost` | bazodanowe | Dokument | Dokument, który powstał z pliku KSeF |
| DozwolonaZmianaRodzaju | `bool` | tylko-odczyt |  |  |
| FormaPlatnosci | `string` | bazodanowe | Forma płatności | Forma płatności |
| HtmlVisualization | `string` | tylko-odczyt |  |  |
| HtmlVisualizationForPrint | `string` | tylko-odczyt |  |  |
| ImportExportXmlKSeF | `Soneta.Core.ImportExportXml` | tylko-odczyt |  |  |
| ImportExportXmls | `System.Collections.Generic.IEnumerable<Soneta.Core.ImportExportXml>` | podlista |  |  |
| IsKBNLicence | `bool` | tylko-odczyt |  |  |
| IsReadOnlyKategoria | `bool` | tylko-odczyt |  |  |
| IsReadOnlyKontrahent | `bool` | tylko-odczyt |  |  |
| Kategoria | `Soneta.Core.KategoriaKSeF` (enum) | bazodanowe | Kategoria KSeF |  |
| Kontrahent | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref | Kontrahent | Obiekt kontrahenta powiązany z plikiem KSeF |
| Kwota | `DoubleCy` | bazodanowe | Wartość brutto | Wartość brutto dokumentu |
| KwotaNetto | `DoubleCy` | bazodanowe | Wartość netto | Wartość netto dokumentu |
| KwotaVat | `DoubleCy` | bazodanowe | Suma VAT w walucie dokumentu | Suma VAT w walucie dokumentu |
| KwotaVatPln | `double` | bazodanowe | Suma VAT w walucie PLN | Suma VAT w walucie PLN |
| NIPKontrahenta | `string` | bazodanowe | NIP Kontrahenta | NIP Kontrahenta |
| NazwaKontrahenta | `string` | bazodanowe | Nazwa kontrahenta |  |
| NazwaPliku | `string` | tylko-odczyt |  |  |
| NumerDokumentu | `string` | bazodanowe | Numer dokumentu | Numer dokumentu |
| NumerKSeF | `string` | bazodanowe | Numer KSeF | Numer KSeF |
| NumeryWZ | `string` | bazodanowe | Numery dokumentów WZ | Numery dokumentów WZ |
| NumeryZamowien | `string` | bazodanowe | Numery zamówień | Numery zamówień |
| OddzialFirmy | `Soneta.Core.OddzialFirmy` | tylko-odczyt |  |  |
| Opis | `string` | bazodanowe | Opis | Opis |
| PrzyczynaKorekty | `string` | bazodanowe | Przyczyna korekty | Przyczyna korekty |
| Rodzaj | `Soneta.Core.RodzajDokumentuKSeFZapytanieOFa` (enum) | bazodanowe | Rodzaj | Rodzaj |
| RodzajDokKSeF | `Soneta.Core.RodzajDokumentuKseF` | bazodanowe | Rodzaj dokumentu KSeF |  |
| RodzajDokumentu | `string` | bazodanowe | Rodzaj dokumentu | Rodzaj dokumentu |
| Rola11Podmiot3IdWew | `string` | bazodanowe | Identyfikator wewnętrzny - Pracownik | Identyfikator wewnętrzny - Pracownik |
| Rola2Podmiot3IdWew | `string` | bazodanowe | Identyfikator wewnętrzny - odbiorca | Identyfikator wewnętrzny - odbiorca |
| Rola4Podmiot3IdWew | `string` | bazodanowe | Identyfikator wewnętrzny - dodatkowy nabywca | Identyfikator wewnętrzny - dodatkowy nabywca |
| Rola6Podmiot3IdWew | `string` | bazodanowe | Identyfikator wewnętrzny - dokonujący płatności | Identyfikator wewnętrzny - dokonujący płatności |
| Rola8Podmiot3IdWew | `string` | bazodanowe | Identyfikator wewnętrzny - JST Odbiorca | Identyfikator wewnętrzny - JST Odbiorca |
| TerminPlatnosci | `Date` | bazodanowe | Termin płatności | Termin płatności |
| Wykluczone | `bool` | bazodanowe | Wykluczone | Pliki KSeF wykluczone z księgowania lub ewidencji handlowej |
| Xml | `MemoText` | podlista |  |  |
| Zapytanie | `Soneta.Core.KSeFZapytanieOFa` | tylko-odczyt |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Kontrahent | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KategoriaKSeF (`Soneta.Core.KategoriaKSeF`)
- `Nieokreslona` = 0 — Nieokreślona
- `Handel` = 1 — Dokument handlowy
- `Ewidencja` = 2 — Dokument ewidencji
- `DoWyjasnienia` = 3 — Do wyjaśnienia

### RodzajDokumentuKSeFZapytanieOFa (`Soneta.Core.RodzajDokumentuKSeFZapytanieOFa`)
- `Zakup` = 1 — Zakup
- `Sprzedaz` = 2 — Sprzedaż
- `Razem` = 10 — Razem
