# Pola i właściwości klasy biznesowej: `Soneta.Handel.RelacjaHandlowa`
Nazwa tabeli: `RelacjeHandlowe`
Opis: Instancja relacji między dwoma dokumentami handlowymi (nadrzędnym i podrzędnym). Przechowuje informacje o definicji relacji, stanie rozliczenia, typie oraz danych zaliczkowych.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 18
- pola kalkulowane (z klas biznesowych): 15

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AnulujNierozliczone | `bool` | bazodanowe |  |  |
| AutomatycznieKoryguj | `bool` |  |  | Gdy korygowany jest dokument nadrzędny wymuszaj korektę dokumentu podrzędnego. |
| Definicja | `Soneta.Handel.DefRelacjiHandlowej` | bazodanowe |  | Definicja opisująca zachowanie relacji |
| DefinicjaStawki | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe | Stawka pozycji | Definicja stawki VAT naliczonej do tej relacji (zaliczki). |
| DefinicjaStawkiZaliczki | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe | Stawka zaliczki | Definicja stawki VAT zaliczki naliczonej do tej relacji (zaliczki). |
| DziedziczyUstawienia | `bool` |  |  | Pewne ustawienia dokumentu nie zależą od definicji, tylko od dokumentu nadrzędnego. |
| Flags | `Soneta.Handel.Helpers.Flags` | bazodanowe, enum |  | Flagi dodatkowe. |
| Glowna | `bool` | bazodanowe | Główna | Wskazuje, że dla tej relacji będą wykonywane wszystkie automatyczne operacje. |
| KasowanieNadrzędnego | `Soneta.Handel.KasowanieRelacji` | enum |  | Zachowanie relacji podczas kasowania dokumentu nadrzędnego. |
| KorektaWartości | `bool` |  |  | Wartość dokumentu nadrzędnego wpływa na wartość podrzędnego (dotyczy również sum VAT). |
| Nadrzedny | `Soneta.Handel.DokumentHandlowy` | bazodanowe | Dokument nadrzędny | Nadrzędny dokumenty relacji handlowej. |
| Podrzedny | `Soneta.Handel.DokumentHandlowy` | bazodanowe | Dokument podrzędny | Podrzędny dokument relacji handlowej. |
| Pozycje | `Soneta.Business.SubTable<Soneta.Handel.PozycjaRelacjiHandlowej>` |  |  |  |
| PrzenoszenieIlości | `Soneta.Handel.SposobPrzenoszeniaIlosci` | enum |  | Określa sposób przenoszenia ilości i wartości do pozycji podrzednej. |
| RelacjaGłówna | `Soneta.Handel.RelacjaHandlowa` |  |  | Wybiera główną relację ze wszystkich relacji tej definicji relacji z dokumentu. |
| RelacjaKontrahenta | `Soneta.Handel.RelacjaKontrahenta` | enum |  | Określa sposób przenoszenia podmiotu pomiędzy dokumentem nadrzędnym i podrzędnym. |
| Rozliczenie | `Soneta.Handel.RozliczenieRelacji` | bazodanowe, enum |  | Określa, jaka część dokumentu nadrzędnego została już rozliczona. |
| RozliczenieKoncowy | `Soneta.Handel.RozliczenieRelacji` | bazodanowe, enum |  | Określa, jaka część dokumentu nadrzędnego została już rozliczona dokumentem końcowym. |
| SposobUtworzenia | `Soneta.Handel.SposobUtworzeniaRelacjiHandlowej` | bazodanowe, enum |  |  |
| SprawdzajStan | `bool` |  |  | Określa, można zatwierdzać dokument podrzędny, gdy dokument nadrzędny nie jest zatwierdzony. |
| Stornowana | `bool` | bazodanowe |  |  |
| Suma | `Soneta.Handel.BruttoNetto` | bazodanowe |  | Przeliczone na PLN i odpowiednio policzone wartości Netto, Brutto i VAT dla tej relacji (zaliczki). |
| Suma.Brutto | `decimal` | bazodanowe |  | Wartość brutto. |
| Suma.BruttoCy | `Soneta.Types.Currency` |  |  | Wartość brutto wyrażona w walucie. Zawsze PLN poza dokumentami 0%. |
| Suma.JestZero | `bool` |  |  |  |
| Suma.Netto | `decimal` | bazodanowe |  | Wartość netto. |
| Suma.NettoCy | `Soneta.Types.Currency` |  |  | Wartość netto wyrażona w walucie. Zawsze PLN poza dokumentami 0%. |
| Suma.VAT | `decimal` | bazodanowe |  | Kwota podatku VAT. |
| Suma.VATCy | `Soneta.Types.Currency` |  |  | Wartość podatku VAT wyrażona w walucie. Zawsze PLN poza dokumentami 0%. |
| Typ | `Soneta.Handel.TypRelacjiHandlowej` | bazodanowe, enum |  | Określa typ relacji opisujący jej zachowanie |
| VatWgPodrzednego | `bool` |  |  |  |
| Wartosc | `Soneta.Types.Currency` | bazodanowe |  |  |
| WielePozycji | `bool` |  |  | Określa, czy do jednej pozycji nadrzędnej może istnieć wiele pozycji podrzędnych. |

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
