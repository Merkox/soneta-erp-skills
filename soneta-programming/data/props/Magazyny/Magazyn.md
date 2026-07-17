# Pola i właściwości klasy biznesowej: `Soneta.Magazyny.Magazyn`
Nazwa tabeli: `Magazyny`
Opis: Definicja magazynu określająca jego symbol, nazwę, algorytm rozchodu (FIFO, LIFO, wg cechy), politykę stanów ujemnych, rezerwacji oraz marży. Powiązany z oddziałem firmy i lokalizacją.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`, `IElementSlownika`

- pola bazodanowe: 18
- pola kalkulowane (z klas biznesowych): 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `Soneta.Magazyny.AlgorytmMagazynowy` | bazodanowe, enum |  | Określa algorytm rozchodu zasobów w tym magazynie. |
| CechaAlgorytmu | `string` | bazodanowe |  | Nazwa cechy pozycji lub dokumentu, wg której ma być realizowany rozchód z magazynu (algorytm wg cechy). |
| CtxOddziałFirmy | `Soneta.Core.OddzialFirmy` |  |  |  |
| ElementyPodzielnika | `Soneta.Business.SubTable<Soneta.Core.ElementPodzielnika>` |  |  |  |
| FiltrTowaru | `string` | bazodanowe |  | Filtr dostępności towarów dla magazynu. |
| FiltrTowaruCondition | `Soneta.Business.RowCondition` |  |  |  |
| FiltrTowaruDlaDokMag | `bool` | bazodanowe | Filtr towaru tylko dla dokumentów magazynowych | Filtr towaru tylko dla dokumentów magazynowych. |
| JestFiltrTowaru | `bool` |  |  |  |
| KMMPBufor | `bool` | bazodanowe |  | Możliwość wystawiania dokumentów KMMP w buforze, gdy nadrzędny MMP jest w buforze. |
| Kod | `string` |  |  |  |
| Licz | `bool` |  |  | Określa, czy dla danego magazynu mają być liczone zasoby i obroty. |
| Lokalizacja | `Soneta.CRM.Lokalizacja` | bazodanowe | Lokalizacja magazynu | Lokalizacja magazynu. |
| MarzaUjemna | `Soneta.Magazyny.StanyUjemne` | bazodanowe, enum |  | Określa sposób działania programu w przypadku rozchodu (sprzedaży) towaru z magazynu po cenie niższej niż cena przychodu (zakupu). |
| Nazwa | `string` | bazodanowe |  | Nazwa wykorzystywania do wyszukiwania dokumentów, wyświetlana w polach wprowadzania magazynu. |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  | Oddział firmy do którego należy magazyn. |
| OkresDostepnosci | `Soneta.Types.FromTo` | bazodanowe |  | Określa, okres dostępności, w którym magazyn jest widoczny na filtrach. |
| OkresDostępności | `Soneta.Types.FromTo` |  |  |  |
| Opis | `string` | bazodanowe |  | Opis magazynu. |
| PodlegaGeneratorZamowien | `bool` | bazodanowe |  | Określa, czy magazyn będzie uwzględniany w generatorze zamówień. |
| PowiazaniaKontElementu | `Soneta.Business.SubTable` |  |  |  |
| Pozabilansowy | `bool` | bazodanowe | Magazyn pozabilansowy | Określa, czy magazyn jest pozabilansowy. Dokumenty z tego magazynu nie trafiają do Ewidencji Dokumentów, nawet jeśli definicja dokumentu ją wskazuje. |
| PrawaDoMagazynow | `Soneta.Business.SubTable<Soneta.Handel.MagDefDokRight>` |  |  |  |
| RezerwacjePonizejStanu | `Soneta.Magazyny.StanyUjemne` | bazodanowe, enum |  | Określa sposób działania programu w przypadku gdy ilość rezerwowanego towaru przekracza stan magazynowy. |
| RozchodyPoPrzychodach | `bool` | bazodanowe |  | Wymusza łączenie rozchodów tylko z przychodami, które są wcześniej. |
| StanyUjemne | `Soneta.Magazyny.StanyUjemne` | bazodanowe, enum |  | Określa sposób działania programu w przypadku wystąpienia stanu ujemnego w magazynie. |
| StanyUjemneKorygowanieRozchodu | `bool` | bazodanowe |  | Możliwość operowania na stanach ujemnych, także przy wystawianiu korekt sprzedaży. |
| Symbol | `string` | bazodanowe |  | Krótki symbol magazynu wykorzystywany do wyszukiwania i numeracji dokumentów handlowych. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AlgorytmMagazynowy (`Soneta.Magazyny.AlgorytmMagazynowy`)
- `FIFO` = 0 — FIFO - kolejka
- `LIFO` = 1 — LIFO - stos
- `NieLiczyćStanów` = 2
- `WgDostawy` = 3
- `WgDostawyPrzyZatwierdzaniu` = 10
- `OdNajdroższych` = 4
- `OdNajtańszych` = 5
- `WgCechyPozycji` = 6
- `WgCechyPozycjiMalejąco` = 7
- `WgCechyDokumentu` = 8
- `WgCechyDokumentuMalejąco` = 9

### StanyUjemne (`Soneta.Magazyny.StanyUjemne`)
- `Zabraniaj` = 0 — Zabraniaj
- `PozwalajWOtwartymOkresie` = 1
- `Pozwalaj` = 2
- `Ostrzegaj` = 16
