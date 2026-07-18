# Pola i właściwości klasy biznesowej: `Soneta.Handel.RelacjaHandlowa`
Nazwa tabeli: `RelacjeHandlowe`
Opis: Instancja relacji między dwoma dokumentami handlowymi (nadrzędnym i podrzędnym). Przechowuje informacje o definicji relacji, stanie rozliczenia, typie oraz danych zaliczkowych.
Tabela konfiguracyjna: Nie
Guided: root
Selektor: pole `Typ` (`Soneta.Handel.TypRelacjiHandlowej`) — wiele typów w jednej tabeli, podtypów: 17

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AnulujNierozliczone | `bool` | bazodanowe |  |  |
| AutomatycznieKoryguj | `bool` | tylko-odczyt |  | Gdy korygowany jest dokument nadrzędny wymuszaj korektę dokumentu podrzędnego. |
| Definicja | `Soneta.Handel.DefRelacjiHandlowej` | bazodanowe, tylko-odczyt |  | Definicja opisująca zachowanie relacji |
| DefinicjaStawki | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe, tylko-odczyt | Stawka pozycji | Definicja stawki VAT naliczonej do tej relacji (zaliczki). |
| DefinicjaStawkiZaliczki | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe, tylko-odczyt | Stawka zaliczki | Definicja stawki VAT zaliczki naliczonej do tej relacji (zaliczki). |
| DziedziczyUstawienia | `bool` | tylko-odczyt |  | Pewne ustawienia dokumentu nie zależą od definicji, tylko od dokumentu nadrzędnego. |
| Flags | `Soneta.Handel.Helpers.Flags` (enum) | bazodanowe |  | Flagi dodatkowe. |
| Glowna | `bool` | bazodanowe | Główna | Wskazuje, że dla tej relacji będą wykonywane wszystkie automatyczne operacje. |
| KasowanieNadrzędnego | `Soneta.Handel.KasowanieRelacji` (enum) | tylko-odczyt |  | Zachowanie relacji podczas kasowania dokumentu nadrzędnego. |
| KorektaWartości | `bool` | tylko-odczyt |  | Wartość dokumentu nadrzędnego wpływa na wartość podrzędnego (dotyczy również sum VAT). |
| Nadrzedny | `Soneta.Handel.DokumentHandlowy` | bazodanowe, tylko-odczyt | Dokument nadrzędny | Nadrzędny dokumenty relacji handlowej. |
| Podrzedny | `Soneta.Handel.DokumentHandlowy` | bazodanowe, tylko-odczyt | Dokument podrzędny | Podrzędny dokument relacji handlowej. |
| Pozycje | `SubTable<Soneta.Handel.PozycjaRelacjiHandlowej>` | podlista |  |  |
| PrzenoszenieIlości | `Soneta.Handel.SposobPrzenoszeniaIlosci` (enum) | tylko-odczyt |  | Określa sposób przenoszenia ilości i wartości do pozycji podrzednej. |
| RelacjaGłówna | `Soneta.Handel.RelacjaHandlowa` | tylko-odczyt |  | Wybiera główną relację ze wszystkich relacji tej definicji relacji z dokumentu. |
| RelacjaKontrahenta | `Soneta.Handel.RelacjaKontrahenta` (enum) | tylko-odczyt |  | Określa sposób przenoszenia podmiotu pomiędzy dokumentem nadrzędnym i podrzędnym. |
| Rozliczenie | `Soneta.Handel.RozliczenieRelacji` (enum) | bazodanowe, tylko-odczyt |  | Określa, jaka część dokumentu nadrzędnego została już rozliczona. |
| RozliczenieKoncowy | `Soneta.Handel.RozliczenieRelacji` (enum) | bazodanowe, tylko-odczyt |  | Określa, jaka część dokumentu nadrzędnego została już rozliczona dokumentem końcowym. |
| SposobUtworzenia | `Soneta.Handel.SposobUtworzeniaRelacjiHandlowej` (enum) | bazodanowe |  |  |
| SprawdzajStan | `bool` | tylko-odczyt |  | Określa, można zatwierdzać dokument podrzędny, gdy dokument nadrzędny nie jest zatwierdzony. |
| Stornowana | `bool` | bazodanowe |  |  |
| Suma | `Soneta.Handel.BruttoNetto` (subrow) | bazodanowe |  | Przeliczone na PLN i odpowiednio policzone wartości Netto, Brutto i VAT dla tej relacji (zaliczki). |
| Suma.Brutto | `decimal` | bazodanowe |  | Wartość brutto. |
| Suma.BruttoCy | `Currency` | tylko-odczyt |  | Wartość brutto wyrażona w walucie. Zawsze PLN poza dokumentami 0%. |
| Suma.JestZero | `bool` | tylko-odczyt |  |  |
| Suma.Netto | `decimal` | bazodanowe |  | Wartość netto. |
| Suma.NettoCy | `Currency` | tylko-odczyt |  | Wartość netto wyrażona w walucie. Zawsze PLN poza dokumentami 0%. |
| Suma.VAT | `decimal` | bazodanowe |  | Kwota podatku VAT. |
| Suma.VATCy | `Currency` | tylko-odczyt |  | Wartość podatku VAT wyrażona w walucie. Zawsze PLN poza dokumentami 0%. |
| Typ | `Soneta.Handel.TypRelacjiHandlowej` (enum) | bazodanowe, tylko-odczyt, selektor |  | Określa typ relacji opisujący jej zachowanie |
| Wartosc | `Currency` | bazodanowe |  |  |
| WielePozycji | `bool` | tylko-odczyt |  | Określa, czy do jednej pozycji nadrzędnej może istnieć wiele pozycji podrzędnych. |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Korekta` | 1 | `Soneta.Handel.RelacjaHandlowa.Korekta` |  |
| `Kopiowania` | 2 | `Soneta.Handel.RelacjaHandlowa.Kopiowania` |  |
| `HandlowoMagazynowa` | 3 | `Soneta.Handel.RelacjaHandlowa.HandlowoMagazynowa` |  |
| `Przesunięcie` | 4 | `Soneta.Handel.RelacjaHandlowa.PrzesunięcieZ` |  |
| `PrzesunięcieDo` | 5 | `Soneta.Handel.RelacjaHandlowa.PrzesunięcieDo` |  |
| `Inwentaryzacja` | 6 | `Soneta.Handel.RelacjaHandlowa.InwentaryzacjaNadwyżka` |  |
| `InwentaryzacjaStrata` | 7 | `Soneta.Handel.RelacjaHandlowa.InwentaryzacjaStrata` |  |
| `KorektaPWZ` | 8 | `Soneta.Handel.RelacjaHandlowa.KorektaPWZ` |  |
| `Kompletacja` | 9 | `Soneta.Handel.RelacjaHandlowa.ProduktyKompletacji` |  |
| `KompletacjaSkładniki` | 10 | `Soneta.Handel.RelacjaHandlowa.SkładnikiKompletacji` |  |
| `Wiązania` | 11 | `Soneta.Handel.RelacjaHandlowa.Wiązania` |  |
| `Zaliczka` | 12 | `Soneta.Handel.RelacjaHandlowa.Zaliczka` |  |
| `Cykliczna` | 13 | `Soneta.Handel.RelacjaHandlowa.Cykliczna` |  |
| `Kaucji` | 14 | `Soneta.Handel.RelacjaHandlowa.Kaucji` |  |
| `RozliczenieKaucji` | 15 | `Soneta.Handel.RelacjaHandlowa.RozliczeniaKaucji` |  |
| `ProdukcjaSurowce` | 16 | `Soneta.Handel.RelacjaHandlowa.Produkcja.Skladniki` |  |
| `ProdukcjaProdukty` | 17 | `Soneta.Handel.RelacjaHandlowa.Produkcja.Produkty` |  |

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

### KasowanieRelacji (`Soneta.Handel.KasowanieRelacji`)
- `Zakazane` = 0 — Zakazane
- `TylkoRelacja` = 1
- `ZDokumentem` = 2

### RelacjaKontrahenta (`Soneta.Handel.RelacjaKontrahenta`)
- `Brak` = 0
- `Kopiuj` = 1
- `Synchronizuj` = 2

### RozliczenieRelacji (`Soneta.Handel.RozliczenieRelacji`)
- `NiePodlega` = -1
- `Brak` = 0
- `Część` = 1
- `CałośćWCzęściach` = 2
- `Całość` = 3
- `Anulowano` = 4
- `AnulowanaReszta` = 5
- `Niezrealizowana` = 6

### SposobPrzenoszeniaIlosci (`Soneta.Handel.SposobPrzenoszeniaIlosci`)
- `IlośćIWartość` = 0
- `TylkoIlość` = 1
- `TylkoInicjuje` = 2
- `NiePrzenosiPozycji` = 3
- `IlośćICena` = 4
- `UslugiWgWartosci` = 5 — Ilość i wartość, usługi tylko wg wartości

### SposobUtworzeniaRelacjiHandlowej (`Soneta.Handel.SposobUtworzeniaRelacjiHandlowej`)
- `Standard` = 0
- `AutomatKorektaMagazynowego` = 1
- `AutomatRozliczanieOpakowan` = 2

### TypRelacjiHandlowej (`Soneta.Handel.TypRelacjiHandlowej`)
- `Brak` = 0
- `Korekta` = 1
- `Kopiowania` = 2
- `HandlowoMagazynowa` = 3
- `Przesunięcie` = 4
- `PrzesunięcieDo` = 5
- `Inwentaryzacja` = 6
- `InwentaryzacjaStrata` = 7
- `KorektaPWZ` = 8
- `Kompletacja` = 9
- `KompletacjaSkładniki` = 10
- `Wiązania` = 11
- `Zaliczka` = 12
- `Cykliczna` = 13
- `Kaucji` = 14
- `RozliczenieKaucji` = 15
- `ProdukcjaSurowce` = 16 — Produkcyjna surowce
- `ProdukcjaProdukty` = 17 — Produkcyjna produkty
