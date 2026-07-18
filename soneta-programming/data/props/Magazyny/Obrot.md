# Pola i właściwości klasy biznesowej: `Soneta.Magazyny.Obrot`
Nazwa tabeli: `Obroty`
Tytuł: Obrót
Opis: Obrót magazynowy rejestrujący ruch towaru między partiami (przychód i rozchód). Zawiera ilość, daty, informacje o partii przychodowej i rozchodowej, stornowaniach oraz jest powiązany z magazynem i okresem magazynowym.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 8
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 20
- podlisty: 3
- subrowy: 3
- razem: 34

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Time` | bazodanowe, tylko-odczyt |  | Czas (rozchodu) powstania obrotu. |
| Data | `Date` | bazodanowe, tylko-odczyt |  | Data (rozchodu) powstania obrotu. |
| Flags | `Soneta.Handel.Helpers.Flags` (enum) | bazodanowe |  | Flagi dodatkowe. |
| Ilosc | `Soneta.Towary.Quantity` | bazodanowe | Ilość | Ilość towaru z partii towaru użytej w tyn obrocie.  |
| Korekta | `Soneta.Magazyny.KorektaObrotu` (enum) | bazodanowe |  | Określa sposób powstania obrotu, czy jest to obrót stornujący inne oborty. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe, tylko-odczyt |  | Magazyn, w którym został naliczony ten obrót magazynowy. |
| Marża | `decimal` | tylko-odczyt |  | Wartość marży uzyskana na obrocie towaru, różnica Rozchód-Przychód. |
| MarżaJednostkowa | `double` | tylko-odczyt |  | Wartość marży uzyskana na jednostce towaru. |
| MinimalnaMarża | `bool` | tylko-odczyt |  | Sprawdza dany obrót nie spełnia warunku minimalnej marży. |
| Okres | `Soneta.Magazyny.OkresMagazynowy` | bazodanowe, tylko-odczyt |  | Okres magazynowy, w którym został naliczony ten obrót magazynowy (marża). |
| ProcentMarży | `Percent` | tylko-odczyt |  | Procent marży uzyskanej na obrocie towaru (liczony wstecz od wartości rozchodu). |
| ProcentNarzutu | `Percent` | tylko-odczyt |  | Procent narzutu na obrocie towaru dodanego do wartości przychodu. |
| Przychod | `Soneta.Magazyny.PartiaTowaru` (subrow) | bazodanowe | Przychód | Informacja o przychodowej partii towaru. |
| PrzychodPierwotny | `Soneta.Magazyny.PartiaTowaru` (subrow) | bazodanowe | Przychód pierwotny | Informacja o pierwotnej przychodowej partii towaru. |
| PrzychodPierwotny.Cena | `double` | tylko-odczyt |  |  |
| PrzychodPierwotny.Czas | `Time` | bazodanowe, tylko-odczyt |  | Czas powstania partii towaru, pobrany z dokumentu. |
| PrzychodPierwotny.Data | `Date` | bazodanowe, tylko-odczyt |  | Data powstania partii towaru, pobrana z dokumentu. |
| PrzychodPierwotny.Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe |  | Dokument, na podstawie którego powstała ta partia towaru. |
| PrzychodPierwotny.IlośćWartość | `Soneta.Handel.IlośćWartość` | tylko-odczyt |  |  |
| PrzychodPierwotny.KontrahentPartii | `Soneta.CRM.Kontrahent` | bazodanowe, tylko-odczyt |  | Kontrahent, który jest dostawcą/odbiorcą tej partii towaru. |
| PrzychodPierwotny.PartiaTowaru | `Soneta.Magazyny.Dostawy.GrupaDostaw` | bazodanowe, tylko-odczyt |  | Partia towaru. |
| PrzychodPierwotny.Pozycja | `Soneta.Handel.PozycjaDokHandlowego` | tylko-odczyt |  |  |
| PrzychodPierwotny.PozycjaIdent | `int` | bazodanowe |  | Identyfikuje pozycje dokumentu handlowego, na wskutek którego powstała partia towaru. |
| PrzychodPierwotny.Typ | `Soneta.Magazyny.TypPartii` (enum) | bazodanowe |  | Typ partii towaru, określający czy jest to rzeczywista partia towaru, czy jedynie zamówiona. |
| PrzychodPierwotny.Wartosc | `decimal` | bazodanowe | Wartość | Wartość tej partii towaru. |
| PrzychodPierwotny.WgDokument | `Key` | podlista |  |  |
| PrzychodPierwotny.WgKontrahentPartii | `Key` | podlista |  |  |
| PrzychodPierwotny.WgPartiaTowaru | `Key` | podlista |  |  |
| Rozchod | `Soneta.Magazyny.PartiaTowaru` (subrow) | bazodanowe | Rozchód | Informacja o rozchodowej partii towaru. |
| Stornowany | `Soneta.Magazyny.Obrot` | bazodanowe |  | Określa obrót, który został stornowany przez ten obrót. |
| Stornujący | `Soneta.Magazyny.Obrot` | tylko-odczyt |  | Zwraca obrót stornujący ten zapis stornowany. |
| Towar | `Soneta.Towary.Towar` | bazodanowe, tylko-odczyt |  | Towar, dla ktrego zostałł naliczony obrót magazynowy |
| UjemnaMarża | `bool` | tylko-odczyt |  | Wskazuje ujemną marżę uzyskaną na obrocie z dokładnością do zaokrąglonej ceny, czyli Rozchód<Przychód. |
| Zamkniety | `bool` | tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### Flags (`Soneta.Handel.Helpers.Flags`)
- `None` = 0
- `KWPZAgregowanieWgDokumentow` = 1
- `KWPZAgregowanieGroup` = 1
- `KursWalutyZmieniony` = 2
- `KursWalutyGroup` = 2
- `ZmianaZatwierdzonegoDokumentu` = 4
- `ZmianaZatwierdzonegoDokumentuGroup` = 4
- `ZmianaParametrowZasobuZmianaIlosci` = 16
- `ZmianaParametrowZasobuZmianaWartosc` = 32
- `ZmianaParametrowZasobuGroup` = 48
- `DodatkoweStornoZasobuWZamknietymOkresie` = 256

### KorektaObrotu (`Soneta.Magazyny.KorektaObrotu`)
- `Brak` = 0 — Brak
- `Ilości` = 1
- `Wartości` = 2
- `StornoZasobu` = 3
- `StornoPrzychodu` = 11
- `StornoRozchodu` = 12
- `Stornowany` = 20

### TypPartii (`Soneta.Magazyny.TypPartii`)
- `Brak` = 0 — Brak
- `Magazynowy` = 1
- `Zarezerwowany` = 2
- `Zamówiony` = 4
- `ZarezerwowanyZamówienie` = 16
- `TylkoZasób` = 65280
- `ZamówionyZasóbMagazynowy` = 260
- `ZamówionyZasób` = 264
- `Produkcyjny` = 271
