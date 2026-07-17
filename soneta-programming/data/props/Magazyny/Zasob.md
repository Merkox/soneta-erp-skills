# Pola i właściwości klasy biznesowej: `Soneta.Magazyny.Zasob`
Nazwa tabeli: `Zasoby`
Tytuł: Zasób
Opis: Zasób magazynowy reprezentujący stan towaru w danym magazynie i okresie. Przechowuje ilość, ilość zarezerwowaną, partię towaru (przychodową lub rozchodową), kierunek oraz hierarchię zasobów nadrzędnych i podrzędnych.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 25
- pola kalkulowane (z klas biznesowych): 17

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Gratis | `bool` | bazodanowe | Zasób gratisowy | Zasób gratisowy. |
| HasPodrzedne | `bool` |  | Zasób nadrzędny | Wskazuje na to, czy zasób posiada zasoby podrzędne. |
| Ilosc | `Soneta.Towary.Quantity` | bazodanowe | Ilość | Ilość towaru z partii w tym zasobie. |
| IloscRezerwowana | `Soneta.Towary.Quantity` | bazodanowe | Rezerwacja | Ilość towaru zarezerwowana na tym zasobie. |
| IlośćZasobu | `Soneta.Towary.Quantity` |  |  | Ilość zasobu towaru uwzględniający znak wynikający z kierunku (przychód, rozchód). |
| JestPodrzedny | `bool` |  | Zasób podrzędny | Wskazuje na to, czy zasób jest zasobem podrzędnym względem innego zasobu. |
| Kierunek | `Soneta.Magazyny.KierunekPartii` | bazodanowe, enum |  | Określa kierunek partii towaru, czy jest to partia towaru na magazynie, czy towar sprzedany na stanie ujemnym. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe |  | Magazyn, w którym znajduje się partia towaru tego zasobu. |
| Nadrzedny | `Soneta.Magazyny.Zasob` | bazodanowe |  | Zasób nadrzędny. |
| Okres | `Soneta.Magazyny.OkresMagazynowy` | bazodanowe |  | Okres magazynowy, do którego został naliczony zasób magazynowy. |
| ParametryRezerwacji | `Soneta.Magazyny.ParametryRezerwacji` | bazodanowe | Parametry rezerwacji zasobu | Parametry rezerwacji zasóbu (w przypadku zamówień algorytmicznych). |
| ParametryRezerwacji.CzasDo | `Soneta.Types.Time` | bazodanowe | Czas końca rezerwacji. |  |
| ParametryRezerwacji.CzasOd | `Soneta.Types.Time` | bazodanowe | Czas początku rezerwacji. |  |
| ParametryRezerwacji.DataDo | `Soneta.Types.Date` | bazodanowe | Data końca rezerwacji. |  |
| ParametryRezerwacji.DataOd | `Soneta.Types.Date` | bazodanowe | Data początku rezerwacji. |  |
| ParametryRezerwacji.JestUsluga | `bool` |  |  |  |
| ParametryRezerwacji.Priorytet | `Soneta.Core.SlownikElem` | bazodanowe | Priorytet rezerwacji. |  |
| ParametryRezerwacji.WgPriorytet | `Soneta.Business.Key` |  |  |  |
| Partia | `Soneta.Magazyny.PartiaTowaru` | bazodanowe |  | Informacja o partii towaru (przychodowej lub rozchodowej). |
| PartiaKontrahent | `Soneta.CRM.Kontrahent` |  |  |  |
| PartiaPierwotna | `Soneta.Magazyny.PartiaTowaru` | bazodanowe |  | Informacja o pierwotnej partii towaru (przychodowej lub rozchodowej). |
| PartiaPierwotna.Cena | `double` |  |  |  |
| PartiaPierwotna.Czas | `Soneta.Types.Time` | bazodanowe |  | Czas powstania partii towaru, pobrany z dokumentu. |
| PartiaPierwotna.Data | `Soneta.Types.Date` | bazodanowe |  | Data powstania partii towaru, pobrana z dokumentu. |
| PartiaPierwotna.DataZasobu | `Soneta.Types.Date` |  |  |  |
| PartiaPierwotna.Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe |  | Dokument, na podstawie którego powstała ta partia towaru. |
| PartiaPierwotna.IlośćWartość | `Soneta.Handel.IlośćWartość` |  |  |  |
| PartiaPierwotna.KontrahentPartii | `Soneta.CRM.Kontrahent` | bazodanowe |  | Kontrahent, który jest dostawcą/odbiorcą tej partii towaru. |
| PartiaPierwotna.PartiaTowaru | `Soneta.Magazyny.Dostawy.GrupaDostaw` | bazodanowe |  | Partia towaru. |
| PartiaPierwotna.Pozycja | `Soneta.Handel.PozycjaDokHandlowego` |  |  |  |
| PartiaPierwotna.PozycjaIdent | `int` | bazodanowe |  | Identyfikuje pozycje dokumentu handlowego, na wskutek którego powstała partia towaru. |
| PartiaPierwotna.Typ | `Soneta.Magazyny.TypPartii` | bazodanowe, enum |  | Typ partii towaru, określający czy jest to rzeczywista partia towaru, czy jedynie zamówiona. |
| PartiaPierwotna.Wartosc | `decimal` | bazodanowe | Wartość | Wartość tej partii towaru. |
| PartiaPierwotna.WgDokument | `Soneta.Business.Key` |  |  |  |
| PartiaPierwotna.WgKontrahentPartii | `Soneta.Business.Key` |  |  |  |
| PartiaPierwotna.WgPartiaTowaru | `Soneta.Business.Key` |  |  |  |
| PartiaTowaru | `Soneta.Magazyny.Dostawy.GrupaDostaw` | bazodanowe |  |  |
| Podrzedne | `Soneta.Business.SubTable<Soneta.Magazyny.Zasob>` |  |  |  |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar, dla którego naliczony jest ten zasób. |
| TylkoZasób | `bool` |  |  | Określa, czy dany zasób może być przekszkałcany do/z marży partii towarów. |
| Zamkniety | `bool` |  |  |  |
| ZasobWorker | `Soneta.Magazyny.ZasobWorker` |  |  |  |

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
