# Pola i właściwości klasy biznesowej: `Soneta.Magazyny.Obrot`
Nazwa tabeli: `Obroty`
Tytuł: Obrót
Opis: Obrót magazynowy rejestrujący ruch towaru między partiami (przychód i rozchód). Zawiera ilość, daty, informacje o partii przychodowej i rozchodowej, stornowaniach oraz jest powiązany z magazynem i okresem magazynowym.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 20
- pola kalkulowane (z klas biznesowych): 17

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.Time` | bazodanowe |  | Czas (rozchodu) powstania obrotu. |
| Data | `Soneta.Types.Date` | bazodanowe |  | Data (rozchodu) powstania obrotu. |
| Flags | `Soneta.Handel.Helpers.Flags` | bazodanowe, enum |  | Flagi dodatkowe. |
| Ilosc | `Soneta.Towary.Quantity` | bazodanowe | Ilość | Ilość towaru z partii towaru użytej w tyn obrocie.  |
| Korekta | `Soneta.Magazyny.KorektaObrotu` | bazodanowe, enum |  | Określa sposób powstania obrotu, czy jest to obrót stornujący inne oborty. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe |  | Magazyn, w którym został naliczony ten obrót magazynowy. |
| Marża | `decimal` |  |  | Wartość marży uzyskana na obrocie towaru, różnica Rozchód-Przychód. |
| MarżaJednostkowa | `double` |  |  | Wartość marży uzyskana na jednostce towaru. |
| MinimalnaMarża | `bool` |  |  | Sprawdza dany obrót nie spełnia warunku minimalnej marży. |
| Okres | `Soneta.Magazyny.OkresMagazynowy` | bazodanowe |  | Okres magazynowy, w którym został naliczony ten obrót magazynowy (marża). |
| ProcentMarży | `Soneta.Types.Percent` |  |  | Procent marży uzyskanej na obrocie towaru (liczony wstecz od wartości rozchodu). |
| ProcentNarzutu | `Soneta.Types.Percent` |  |  | Procent narzutu na obrocie towaru dodanego do wartości przychodu. |
| Przychod | `Soneta.Magazyny.PartiaTowaru` | bazodanowe | Przychód | Informacja o przychodowej partii towaru. |
| PrzychodKontrahent | `Soneta.CRM.Kontrahent` |  |  |  |
| PrzychodPierwotny | `Soneta.Magazyny.PartiaTowaru` | bazodanowe | Przychód pierwotny | Informacja o pierwotnej przychodowej partii towaru. |
| PrzychodPierwotny.Cena | `double` |  |  |  |
| PrzychodPierwotny.Czas | `Soneta.Types.Time` | bazodanowe |  | Czas powstania partii towaru, pobrany z dokumentu. |
| PrzychodPierwotny.Data | `Soneta.Types.Date` | bazodanowe |  | Data powstania partii towaru, pobrana z dokumentu. |
| PrzychodPierwotny.DataZasobu | `Soneta.Types.Date` |  |  |  |
| PrzychodPierwotny.Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe |  | Dokument, na podstawie którego powstała ta partia towaru. |
| PrzychodPierwotny.IlośćWartość | `Soneta.Handel.IlośćWartość` |  |  |  |
| PrzychodPierwotny.KontrahentPartii | `Soneta.CRM.Kontrahent` | bazodanowe |  | Kontrahent, który jest dostawcą/odbiorcą tej partii towaru. |
| PrzychodPierwotny.PartiaTowaru | `Soneta.Magazyny.Dostawy.GrupaDostaw` | bazodanowe |  | Partia towaru. |
| PrzychodPierwotny.Pozycja | `Soneta.Handel.PozycjaDokHandlowego` |  |  |  |
| PrzychodPierwotny.PozycjaIdent | `int` | bazodanowe |  | Identyfikuje pozycje dokumentu handlowego, na wskutek którego powstała partia towaru. |
| PrzychodPierwotny.Typ | `Soneta.Magazyny.TypPartii` | bazodanowe, enum |  | Typ partii towaru, określający czy jest to rzeczywista partia towaru, czy jedynie zamówiona. |
| PrzychodPierwotny.Wartosc | `decimal` | bazodanowe | Wartość | Wartość tej partii towaru. |
| PrzychodPierwotny.WgDokument | `Soneta.Business.Key` |  |  |  |
| PrzychodPierwotny.WgKontrahentPartii | `Soneta.Business.Key` |  |  |  |
| PrzychodPierwotny.WgPartiaTowaru | `Soneta.Business.Key` |  |  |  |
| Rozchod | `Soneta.Magazyny.PartiaTowaru` | bazodanowe | Rozchód | Informacja o rozchodowej partii towaru. |
| RozchodKontrahent | `Soneta.CRM.Kontrahent` |  |  |  |
| Stornowany | `Soneta.Magazyny.Obrot` | bazodanowe |  | Określa obrót, który został stornowany przez ten obrót. |
| Stornujący | `Soneta.Magazyny.Obrot` |  |  | Zwraca obrót stornujący ten zapis stornowany. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar, dla ktrego zostałł naliczony obrót magazynowy |
| UjemnaMarża | `bool` |  |  | Wskazuje ujemną marżę uzyskaną na obrocie z dokładnością do zaokrąglonej ceny, czyli Rozchód<Przychód. |
| Zamkniety | `bool` |  |  |  |

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
