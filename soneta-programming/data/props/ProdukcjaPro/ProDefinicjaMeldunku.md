# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProDefinicjaMeldunku`
Nazwa tabeli: `ProDMeldunkow`
Tytuł: Definicje meldunku produkcyjnego
Opis: Szablon konfiguracyjny meldunku produkcyjnego określający reguły raportowania wykonania operacji. Definiuje domyślne ilości, warunki zakończenia operacji, schematy dokumentów magazynowych, sposób wyceny materiałów, wyrobów i zasobów oraz algorytmy weryfikacji i numeracji dostaw.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 31
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 0
- razem: 32

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AlgorytmWeryfikacjiMeldunku | `Soneta.ProdukcjaPro.ProAlgorytmWeryfikacjiMeldunku` (enum) | bazodanowe | Algorytm weryfikacji meldunku | Algorytm weryfikacji meldunku dla definicji meldunku. |
| AutomatyczneRozliczanieRejestracji | `bool` | bazodanowe | Automatyczne rozliczanie rejestracji | Automatyczne rozliczanie rejestracji dla definicji meldunku. |
| Blokada | `bool` | bazodanowe |  | Zablokowanie definicji meldunku. |
| CechaNumeracjiDostawy | `FeatureDefinition` | bazodanowe | Cecha numeracji dostawy | Cecha numeracji dostawy dla definicji meldunku. |
| CechaWeryfikacjiMeldunku | `FeatureDefinition` | bazodanowe | Cecha weryfikacji meldunku | Cecha weryfikacji meldunku dla definicji meldunku. |
| CechaWycenyWyrobow | `FeatureDefinition` | bazodanowe | Cecha wyceny wyrobów | Cecha wyceny wyrobów dla definicji meldunku. |
| DataPrzychodow | `Soneta.ProdukcjaPro.ProDataWystawianiaDokumentow` (enum) | bazodanowe | Data przychodów | Data wystawiania dokumentów przychodów dla definicji meldunku. |
| DataRozchodow | `Soneta.ProdukcjaPro.ProDataWystawianiaDokumentow` (enum) | bazodanowe | Data rozchodów | Data wystawiania dokumentów rozchodów dla definicji meldunku. |
| DefinicjaBrakow | `Soneta.Handel.DefDokHandlowego` | bazodanowe | Definicja braków | Definicja braków dla definicji meldunku. |
| DefinicjaOdpadow | `Soneta.Handel.DefDokHandlowego` | bazodanowe | Definicja odpadów | Definicja odpadów dla definicji meldunku. |
| DefinicjaPrzychodow | `Soneta.Handel.DefDokHandlowego` | bazodanowe | Definicja przychodów | Definicja przychodów dla definicji meldunku. |
| DefinicjaRozchodow | `Soneta.Handel.DefDokHandlowego` | bazodanowe | Definicja rozchodów | Definicja rozchodów dla definicji meldunku. |
| DokumentyMaterialow | `Soneta.ProdukcjaPro.ProSposobWystawianiaDokumentow` (enum) | bazodanowe | Dokumenty materiałów | Sposób wystawiania dokumentów materiałów dla definicji meldunku. |
| DokumentyOdpadow | `Soneta.ProdukcjaPro.ProSposobWystawianiaDokumentow` (enum) | bazodanowe | Dokumenty odpadów | Sposób wystawiania dokumentów odpadów dla definicji meldunku. |
| DokumentyWyrobow | `Soneta.ProdukcjaPro.ProSposobWystawianiaDokumentow` (enum) | bazodanowe | Dokumenty wyrobów | Sposób wystawiania dokumentów wyrobów dla definicji meldunku. |
| IloscDomyslna | `Soneta.ProdukcjaPro.ProIloscDomyslna` (enum) | bazodanowe | Ilość domyślna | Ilość domyślna definicji meldunku. |
| Kod | `string` | bazodanowe |  | Kod definicji meldunku. |
| Nazwa | `string` | bazodanowe |  | Nazwa definicji meldunku. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis definicji meldunku. |
| PominZgodnoscDaty | `bool` | bazodanowe | Pomiń zgodność daty | Pomiń zgodność daty dla definicji meldunku. |
| PrzepiszMaterialyZero | `bool` | bazodanowe | Przepisz materiały z ilością zero | Parametr przepisywania materiałów operacji zlecenia z ilością zero na materiały meldunku dla definicji meldunku. |
| PrzepiszOdpadyZero | `bool` | bazodanowe | Przepisz odpady z ilością zero | Parametr przepisywania odpadów operacji zlecenia z ilością zero na odpady meldunku dla definicji meldunku. |
| PrzepiszUslugiZero | `bool` | bazodanowe | Przepisz usługi z ilością zero | Parametr przepisywania usług operacji zlecenia z ilością zero na usługi meldunku dla definicji meldunku. |
| PrzepiszWyrobyZero | `bool` | bazodanowe | Przepisz wyroby z ilością zero | Parametr przepisywania wyrobów operacji zlecenia z ilością zero na wyroby meldunku dla definicji meldunku. |
| RozliczZatwierdzone | `bool` | bazodanowe | Rozlicz zatwierdzone | Rozlicz zatwierdzone pozycje dokumentów dla definicji meldunku. |
| SposobNumeracjiDostawy | `Soneta.ProdukcjaPro.ProSposobNumeracjiDostawy` (enum) | bazodanowe | Sposób numeracji dostawy | Sposób numeracji dostawy dla definicji meldunku. |
| SposobRozliczaniaRejestracji | `Soneta.ProdukcjaPro.ProSposobRozliczaniaRejestracji` (enum) | bazodanowe | Sposób rozliczania rejestracji | Sposób rozliczania rejestracji dla definicji meldunku. |
| WarunekZakonczeniaOperacji | `Soneta.ProdukcjaPro.ProWarunekZakonczeniaOperacji` (enum) | bazodanowe | Warunek zakończenia operacji | Warunek zakończenia operacji dla definicji meldunku. |
| WycenaMaterialow | `Soneta.ProdukcjaPro.ProWycenaMaterialow` (enum) | bazodanowe | Wycena materiałów | Wycena materiałów dla definicji meldunku. |
| WycenaWyrobow | `Soneta.ProdukcjaPro.ProWycenaWyrobow` (enum) | bazodanowe | Wycena wyrobów | Wycena wyrobów dla definicji meldunku. |
| WycenaZasobow | `Soneta.ProdukcjaPro.ProWycenaZasobow` (enum) | bazodanowe | Wycena zasobów | Wycena zasobów dla definicji meldunku. |
| ZakonczRozpoczeteRejestracje | `bool` | bazodanowe | Zakończ rozpoczęte rejestracje | Parametr zakańczania rozpoczętych rejestracji dla definicji meldunku. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProAlgorytmWeryfikacjiMeldunku (`Soneta.ProdukcjaPro.ProAlgorytmWeryfikacjiMeldunku`)
- `None` = 0
- `Brak` = 1
- `Cecha` = 2
- `RozchodMaterialow` = 4 — Ilość magazynowa możliwa do rozchodowania
- `IloscPoprzedzajaca` = 8 — Ilość z operacji poprzedzających
- `All` = 15 — Wszystkie

### ProDataWystawianiaDokumentow (`Soneta.ProdukcjaPro.ProDataWystawianiaDokumentow`)
- `None` = 0
- `DataAktualna` = 1 — Data aktualna
- `DataZlozeniaMeldunku` = 2 — Data złożenia meldunku
- `All` = 3 — Wszystkie

### ProIloscDomyslna (`Soneta.ProdukcjaPro.ProIloscDomyslna`)
- `None` = 0
- `Zero` = 1
- `Jeden` = 2
- `Planowana` = 4
- `Pozostala` = 8 — Pozostała
- `Zarejestrowana` = 16
- `All` = 15 — Wszystkie

### ProSposobNumeracjiDostawy (`Soneta.ProdukcjaPro.ProSposobNumeracjiDostawy`)
- `None` = 0
- `Brak` = 1
- `Cecha` = 2
- `NumerMeldunku` = 4 — Numer meldunku
- `DataMeldunku` = 8 — Data meldunku
- `DataAktualna` = 16 — Aktualna data
- `Identyfikator` = 32 — Identyfikator wyrobu
- `All` = 63 — Wszystkie

### ProSposobRozliczaniaRejestracji (`Soneta.ProdukcjaPro.ProSposobRozliczaniaRejestracji`)
- `None` = 0
- `Brak` = 1
- `Calosc` = 2 — Całość
- `Osoba` = 4 — Dla osoby z meldunku
- `All` = 7 — Wszystkie

### ProSposobWystawianiaDokumentow (`Soneta.ProdukcjaPro.ProSposobWystawianiaDokumentow`)
- `None` = 0
- `Brak` = 1 — Rozliczaj ręcznie
- `Automatycznie` = 2 — Rozliczaj automatycznie przy meldunku
- `OperacjaZaraportowana` = 4 — Rozliczaj przy pełnym zaraportowaniu operacji
- `All` = 7 — Wszystkie

### ProWarunekZakonczeniaOperacji (`Soneta.ProdukcjaPro.ProWarunekZakonczeniaOperacji`)
- `None` = 0
- `Brak` = 1
- `CaloscZameldowana` = 2 — Całość zameldowana
- `WystawionyMeldunek` = 4 — Wystawiony meldunek
- `All` = 7 — Wszystkie

### ProWycenaMaterialow (`Soneta.ProdukcjaPro.ProWycenaMaterialow`)
- `None` = 0
- `CenaPlanowana` = 1 — Wg ceny planowanej
- `WartoscRozchodow` = 2 — Wg wartości rzeczywistej
- `All` = 3 — Wszystkie

### ProWycenaWyrobow (`Soneta.ProdukcjaPro.ProWycenaWyrobow`)
- `None` = 0
- `CenaMeldunku` = 1 — Wg ceny wyrobów meldunku
- `CenaZlecenia` = 2 — Wg ceny wyrobów zlecenia
- `OstatniaCenaPrzyjecia` = 4 — Wg ostatniej ceny przyjęcia
- `CenaTechnologiczna` = 8 — Wg ceny technologicznej
- `CenaStala` = 16 — Wg ceny stałej
- `Cecha` = 32 — Wg cechy
- `All` = 63 — Wszystkie

### ProWycenaZasobow (`Soneta.ProdukcjaPro.ProWycenaZasobow`)
- `None` = 0
- `Planowana` = 1 — Wg planowanej ilości i czasu
- `Zarejestrowana` = 2 — Wg zarejestrowanej ilości i czasu
- `All` = 3 — Wszystkie
