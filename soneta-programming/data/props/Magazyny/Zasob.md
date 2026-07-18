# Pola i właściwości klasy biznesowej: `Soneta.Magazyny.Zasob`
Nazwa tabeli: `Zasoby`
Tytuł: Zasób
Opis: Zasób magazynowy reprezentujący stan towaru w danym magazynie i okresie. Przechowuje ilość, ilość zarezerwowaną, partię towaru (przychodową lub rozchodową), kierunek oraz hierarchię zasobów nadrzędnych i podrzędnych.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 14
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 17
- podlisty: 5
- subrowy: 3
- razem: 39

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Gratis | `bool` | bazodanowe | Zasób gratisowy | Zasób gratisowy. |
| HasPodrzedne | `bool` | tylko-odczyt | Zasób nadrzędny | Wskazuje na to, czy zasób posiada zasoby podrzędne. |
| Ilosc | `Soneta.Towary.Quantity` | bazodanowe | Ilość | Ilość towaru z partii w tym zasobie. |
| IloscRezerwowana | `Soneta.Towary.Quantity` | bazodanowe | Rezerwacja | Ilość towaru zarezerwowana na tym zasobie. |
| IlośćZasobu | `Soneta.Towary.Quantity` | tylko-odczyt |  | Ilość zasobu towaru uwzględniający znak wynikający z kierunku (przychód, rozchód). |
| JestPodrzedny | `bool` | tylko-odczyt | Zasób podrzędny | Wskazuje na to, czy zasób jest zasobem podrzędnym względem innego zasobu. |
| Kierunek | `Soneta.Magazyny.KierunekPartii` (enum) | bazodanowe |  | Określa kierunek partii towaru, czy jest to partia towaru na magazynie, czy towar sprzedany na stanie ujemnym. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe, tylko-odczyt |  | Magazyn, w którym znajduje się partia towaru tego zasobu. |
| Nadrzedny | `Soneta.Magazyny.Zasob` | bazodanowe |  | Zasób nadrzędny. |
| Okres | `Soneta.Magazyny.OkresMagazynowy` | bazodanowe, tylko-odczyt |  | Okres magazynowy, do którego został naliczony zasób magazynowy. |
| ParametryRezerwacji | `Soneta.Magazyny.ParametryRezerwacji` (subrow) | bazodanowe | Parametry rezerwacji zasobu | Parametry rezerwacji zasóbu (w przypadku zamówień algorytmicznych). |
| ParametryRezerwacji.CzasDo | `Time` | bazodanowe | Czas końca rezerwacji. |  |
| ParametryRezerwacji.CzasOd | `Time` | bazodanowe | Czas początku rezerwacji. |  |
| ParametryRezerwacji.DataDo | `Date` | bazodanowe | Data końca rezerwacji. |  |
| ParametryRezerwacji.DataOd | `Date` | bazodanowe | Data początku rezerwacji. |  |
| ParametryRezerwacji.JestUsluga | `bool` | tylko-odczyt |  |  |
| ParametryRezerwacji.Priorytet | `Soneta.Core.SlownikElem` | bazodanowe | Priorytet rezerwacji. |  |
| ParametryRezerwacji.WgPriorytet | `Key` | podlista |  |  |
| Partia | `Soneta.Magazyny.PartiaTowaru` (subrow) | bazodanowe |  | Informacja o partii towaru (przychodowej lub rozchodowej). |
| PartiaPierwotna | `Soneta.Magazyny.PartiaTowaru` (subrow) | bazodanowe |  | Informacja o pierwotnej partii towaru (przychodowej lub rozchodowej). |
| PartiaPierwotna.Cena | `double` | tylko-odczyt |  |  |
| PartiaPierwotna.Czas | `Time` | bazodanowe, tylko-odczyt |  | Czas powstania partii towaru, pobrany z dokumentu. |
| PartiaPierwotna.Data | `Date` | bazodanowe, tylko-odczyt |  | Data powstania partii towaru, pobrana z dokumentu. |
| PartiaPierwotna.Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe |  | Dokument, na podstawie którego powstała ta partia towaru. |
| PartiaPierwotna.IlośćWartość | `Soneta.Handel.IlośćWartość` | tylko-odczyt |  |  |
| PartiaPierwotna.KontrahentPartii | `Soneta.CRM.Kontrahent` | bazodanowe, tylko-odczyt |  | Kontrahent, który jest dostawcą/odbiorcą tej partii towaru. |
| PartiaPierwotna.PartiaTowaru | `Soneta.Magazyny.Dostawy.GrupaDostaw` | bazodanowe, tylko-odczyt |  | Partia towaru. |
| PartiaPierwotna.Pozycja | `Soneta.Handel.PozycjaDokHandlowego` | tylko-odczyt |  |  |
| PartiaPierwotna.PozycjaIdent | `int` | bazodanowe |  | Identyfikuje pozycje dokumentu handlowego, na wskutek którego powstała partia towaru. |
| PartiaPierwotna.Typ | `Soneta.Magazyny.TypPartii` (enum) | bazodanowe |  | Typ partii towaru, określający czy jest to rzeczywista partia towaru, czy jedynie zamówiona. |
| PartiaPierwotna.Wartosc | `decimal` | bazodanowe | Wartość | Wartość tej partii towaru. |
| PartiaPierwotna.WgDokument | `Key` | podlista |  |  |
| PartiaPierwotna.WgKontrahentPartii | `Key` | podlista |  |  |
| PartiaPierwotna.WgPartiaTowaru | `Key` | podlista |  |  |
| Podrzedne | `SubTable<Soneta.Magazyny.Zasob>` | podlista |  |  |
| Towar | `Soneta.Towary.Towar` | bazodanowe, tylko-odczyt |  | Towar, dla którego naliczony jest ten zasób. |
| TylkoZasób | `bool` | tylko-odczyt |  | Określa, czy dany zasób może być przekszkałcany do/z marży partii towarów. |
| Zamkniety | `bool` | tylko-odczyt |  |  |
| ZasobWorker | `Soneta.Magazyny.ZasobWorker` | tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KierunekPartii (`Soneta.Magazyny.KierunekPartii`)
- `Rozchód` = -1 — Rozchód
- `Brak` = 0 — Brak
- `Przychód` = 1 — Przychód

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
