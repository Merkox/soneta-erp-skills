# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.PozycjaTechn`
Nazwa tabeli: `PozycjeTechn`
Tytuł: Pozycje technologii
Opis: Pozycja technologii produkcyjnej określająca surowiec lub produkt przypisany do operacji. Definiuje towar, jego ilość, rodzaj pozycji (surowiec/produkt/odpad), magazyn źródłowy lub docelowy, koszt wytworzenia, współczynnik podziału kosztu oraz mechanizmy aktywności i kalkulacji. Pozwala modelować receptury i specyfikacje materiałowe procesu wytwórczego.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywna | `bool` | tylko-odczyt |  | Określa aktywność pozycji. |
| Aktywnosc | `Soneta.Produkcja.Aktywnosc` (enum) | bazodanowe | Aktywność | Sposób wyznaczania aktywności dla pozycji. |
| CechaAktywnosc | `FeatureDefinition` | bazodanowe | Cecha aktywności | Definicja cechy algorytmicznej, służąca do wyliczenia aktywności. |
| CechaIlosc | `FeatureDefinition` | bazodanowe | Cecha ilości | Definicja cechy algorytmicznej, służąca do wyliczenia ilości. |
| CechaTowar | `FeatureDefinition` | bazodanowe | Cecha towaru | Definicja cechy algorytmicznej, służąca do wyliczenia towaru. |
| CechaWartosc | `FeatureDefinition` | bazodanowe | Cecha wartości | Definicja cechy algorytmicznej, służąca do wyliczenia wartości. |
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość towaru. |
| IloscPozostalaDoPrzyjecia | `Amount` | tylko-odczyt | Ilość pozostała do przyjęcia | Ilość pozostała do przyjęcia dla pozycji. |
| IloscPozostalaDoRozchodowania | `Amount` | tylko-odczyt | Ilość pozostała do rozchodowania | Ilość pozostała do rozchodowania dla pozycji. |
| IloscPozostalaDoZamowienia | `Amount` | tylko-odczyt | Ilość pozostała do zamówienia | Ilość pozostała do zamówienia dla pozycji. Uwzględnia ilość rozchodów i rezerwacji. |
| IloscPrzyjeta | `Amount` | tylko-odczyt | Ilość przyjęta | Ilość przyjęta dla pozycji. |
| IloscRozchodowana | `Amount` | tylko-odczyt | Ilość rozchodowana | Ilość rozchodowana dla pozycji. |
| IloscRzeczywista | `Amount` | bazodanowe | Ilość rzeczywista | Ilość zapisana podczas wykonywania algorytmu kalkulacji kosztów. |
| IloscZamowiona | `Amount` | tylko-odczyt | Ilość zamówiona | Ilość zamówiona dla pozycji. |
| JestPolProdukt | `bool` | tylko-odczyt |  |  |
| JestProdukt | `bool` | tylko-odczyt |  |  |
| JestProduktLubPolProdukt | `bool` | tylko-odczyt |  |  |
| JestSurowiec | `bool` | tylko-odczyt |  |  |
| KosztWspolczynnik | `int` | bazodanowe | Współczynnik podziału kosztu | Współczynnik do algorytmu proporcjonalnego podziału kosztu na części przypadające na produkowane produkty. |
| KosztWytworzenia | `Currency` | bazodanowe | Koszt wytworzenia | Koszt wytworzenia zapisany podczas wykonywania algorytmu kalkulacji kosztów. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe |  | Magazyn docelowy produktów lub źródłowy surowców. |
| Operacja | `Soneta.Produkcja.Operacja` | bazodanowe | Operacja | Określa operację dla danej pozycji. |
| Podrzędne | `Soneta.Produkcja.RealizacjaRelacji<Soneta.Produkcja.PozycjaTechn>` | tylko-odczyt |  |  |
| PominWKalkukacji | `bool` | bazodanowe | Pomiń w kalkulacji | Pomiń podczas wykonywania algorytmu kalkulacji kosztów. |
| PowiazanePozycjeDok | `Soneta.Handel.PozycjaDokHandlowego[]` | podlista | Powiązane pozycje dokumentów | Powiązane pozycje dokumentów RWP i PWP. |
| PozycjaTechnologiiZlozonej | `Soneta.Produkcja.PozycjaTechn.TechnologieZlozona` | tylko-odczyt |  |  |
| Produkt | `Soneta.Produkcja.PozycjaTechn` | bazodanowe |  | Produkt do którego przypisany jest surowiec. |
| RezerwacjaSurowca | `SubTable<Soneta.Produkcja.RezerwacjaSurowca>` | podlista |  |  |
| Rodzaj | `Soneta.Produkcja.RodzajPozycjiTechn` (enum) | bazodanowe |  | Rodzaj pozycji. |
| RodzajIlosci | `Soneta.Produkcja.RodzajIlosciPozycji` (enum) | bazodanowe | Rodzaj ilości | Określa sposób wyznaczania ilości. |
| RodzajTowaru | `Soneta.Produkcja.RodzajTowaruPozycji` (enum) | bazodanowe | Rodzaj towaru | Określa sposób wyznaczania towaru. |
| RodzajWartosci | `Soneta.Produkcja.RodzajWartosciPozycji` (enum) | bazodanowe | Rodzaj wartości | Określa sposób wyznaczania wartości. |
| SzacunkowyKosztWytworzenia | `Currency` | bazodanowe | Szacunkowy koszt wytworzenia | Szacunkowy koszt wytworzenia zapisany podczas wykonywania algorytmu kalkulacji kosztów. |
| Technologia | `Soneta.Produkcja.Technologia` | bazodanowe | Technologia | Określa technologię dla danej pozycji. |
| TechnologiaPodrzedna | `Soneta.Produkcja.Technologia` | bazodanowe | Technologia podrzędna | Określa technologię podrzędną dla danej pozycji. |
| Towar | `Soneta.Towary.Towar` | bazodanowe | Towar | Symbol i nazwa towaru. |
| Wartosc | `Currency` | tylko-odczyt | Wartość | Wartość wg ostatniej ceny zakupu w PLN. |
| Zamiennik | `Soneta.Produkcja.PozycjaTechn` | bazodanowe, tylko-odczyt |  | Nadrzędna pozycja technologiczna z której powstała obecna w ramach zamiennika. |

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
