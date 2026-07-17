# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.PozycjaTechn`
Nazwa tabeli: `PozycjeTechn`
Tytuł: Pozycje technologii
Opis: Pozycja technologii produkcyjnej określająca surowiec lub produkt przypisany do operacji. Definiuje towar, jego ilość, rodzaj pozycji (surowiec/produkt/odpad), magazyn źródłowy lub docelowy, koszt wytworzenia, współczynnik podziału kosztu oraz mechanizmy aktywności i kalkulacji. Pozwala modelować receptury i specyfikacje materiałowe procesu wytwórczego.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 22
- pola kalkulowane (z klas biznesowych): 16

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywna | `bool` |  |  | Określa aktywność pozycji. |
| Aktywnosc | `Soneta.Produkcja.Aktywnosc` | bazodanowe, enum | Aktywność | Sposób wyznaczania aktywności dla pozycji. |
| CechaAktywnosc | `Soneta.Business.FeatureDefinition` | bazodanowe | Cecha aktywności | Definicja cechy algorytmicznej, służąca do wyliczenia aktywności. |
| CechaIlosc | `Soneta.Business.FeatureDefinition` | bazodanowe | Cecha ilości | Definicja cechy algorytmicznej, służąca do wyliczenia ilości. |
| CechaTowar | `Soneta.Business.FeatureDefinition` | bazodanowe | Cecha towaru | Definicja cechy algorytmicznej, służąca do wyliczenia towaru. |
| CechaWartosc | `Soneta.Business.FeatureDefinition` | bazodanowe | Cecha wartości | Definicja cechy algorytmicznej, służąca do wyliczenia wartości. |
| Ilosc | `Soneta.Types.Amount` | bazodanowe | Ilość | Ilość towaru. |
| IloscPozostalaDoPrzyjecia | `Soneta.Types.Amount` |  | Ilość pozostała do przyjęcia | Ilość pozostała do przyjęcia dla pozycji. |
| IloscPozostalaDoRozchodowania | `Soneta.Types.Amount` |  | Ilość pozostała do rozchodowania | Ilość pozostała do rozchodowania dla pozycji. |
| IloscPozostalaDoZamowienia | `Soneta.Types.Amount` |  | Ilość pozostała do zamówienia | Ilość pozostała do zamówienia dla pozycji. Uwzględnia ilość rozchodów i rezerwacji. |
| IloscPrzyjeta | `Soneta.Types.Amount` |  | Ilość przyjęta | Ilość przyjęta dla pozycji. |
| IloscRozchodowana | `Soneta.Types.Amount` |  | Ilość rozchodowana | Ilość rozchodowana dla pozycji. |
| IloscRzeczywista | `Soneta.Types.Amount` | bazodanowe | Ilość rzeczywista | Ilość zapisana podczas wykonywania algorytmu kalkulacji kosztów. |
| IloscZamowiona | `Soneta.Types.Amount` |  | Ilość zamówiona | Ilość zamówiona dla pozycji. |
| JestPolProdukt | `bool` |  |  |  |
| JestProdukt | `bool` |  |  |  |
| JestProduktLubPolProdukt | `bool` |  |  |  |
| JestSurowiec | `bool` |  |  |  |
| KosztWspolczynnik | `int` | bazodanowe | Współczynnik podziału kosztu | Współczynnik do algorytmu proporcjonalnego podziału kosztu na części przypadające na produkowane produkty. |
| KosztWytworzenia | `Soneta.Types.Currency` | bazodanowe | Koszt wytworzenia | Koszt wytworzenia zapisany podczas wykonywania algorytmu kalkulacji kosztów. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe |  | Magazyn docelowy produktów lub źródłowy surowców. |
| Operacja | `Soneta.Produkcja.Operacja` | bazodanowe | Operacja | Określa operację dla danej pozycji. |
| Podrzędne | `Soneta.Produkcja.RealizacjaRelacji<Soneta.Produkcja.PozycjaTechn>` |  |  |  |
| PominWKalkukacji | `bool` | bazodanowe | Pomiń w kalkulacji | Pomiń podczas wykonywania algorytmu kalkulacji kosztów. |
| PowiazanePozycjeDok | `Soneta.Handel.PozycjaDokHandlowego[]` |  | Powiązane pozycje dokumentów | Powiązane pozycje dokumentów RWP i PWP. |
| PozycjaTechnologiiZlozonej | `Soneta.Produkcja.PozycjaTechn.TechnologieZlozona` |  |  |  |
| Produkt | `Soneta.Produkcja.PozycjaTechn` | bazodanowe |  | Produkt do którego przypisany jest surowiec. |
| RezerwacjaSurowca | `Soneta.Business.SubTable<Soneta.Produkcja.RezerwacjaSurowca>` |  |  |  |
| Rodzaj | `Soneta.Produkcja.RodzajPozycjiTechn` | bazodanowe, enum |  | Rodzaj pozycji. |
| RodzajIlosci | `Soneta.Produkcja.RodzajIlosciPozycji` | bazodanowe, enum | Rodzaj ilości | Określa sposób wyznaczania ilości. |
| RodzajTowaru | `Soneta.Produkcja.RodzajTowaruPozycji` | bazodanowe, enum | Rodzaj towaru | Określa sposób wyznaczania towaru. |
| RodzajWartosci | `Soneta.Produkcja.RodzajWartosciPozycji` | bazodanowe, enum | Rodzaj wartości | Określa sposób wyznaczania wartości. |
| SzacunkowyKosztWytworzenia | `Soneta.Types.Currency` | bazodanowe | Szacunkowy koszt wytworzenia | Szacunkowy koszt wytworzenia zapisany podczas wykonywania algorytmu kalkulacji kosztów. |
| Technologia | `Soneta.Produkcja.Technologia` | bazodanowe | Technologia | Określa technologię dla danej pozycji. |
| TechnologiaPodrzedna | `Soneta.Produkcja.Technologia` | bazodanowe | Technologia podrzędna | Określa technologię podrzędną dla danej pozycji. |
| Towar | `Soneta.Towary.Towar` | bazodanowe | Towar | Symbol i nazwa towaru. |
| Wartosc | `Soneta.Types.Currency` |  | Wartość | Wartość wg ostatniej ceny zakupu w PLN. |
| Zamiennik | `Soneta.Produkcja.PozycjaTechn` | bazodanowe |  | Nadrzędna pozycja technologiczna z której powstała obecna w ramach zamiennika. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### Aktywnosc (`Soneta.Produkcja.Aktywnosc`)
- `Tak` = 0 — Tak
- `Nie` = 1
- `Warunkowo` = 2

### RodzajIlosciPozycji (`Soneta.Produkcja.RodzajIlosciPozycji`)
- `Jednostkowa` = 0 — Jednostkowa
- `Stała` = 1
- `Wyliczana` = 2

### RodzajPozycjiTechn (`Soneta.Produkcja.RodzajPozycjiTechn`)
- `Surowiec` = 0 — Surowiec
- `Produkt` = 1
- `Półprodukt` = 2

### RodzajTowaruPozycji (`Soneta.Produkcja.RodzajTowaruPozycji`)
- `Standardowy` = 0 — Standardowy
- `Wyliczany` = 1

### RodzajWartosciPozycji (`Soneta.Produkcja.RodzajWartosciPozycji`)
- `Standardowy` = 0 — Standardowy
- `Wyliczany` = 1
