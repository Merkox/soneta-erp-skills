# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProWydzial`
Nazwa tabeli: `ProWydzialy`
Tytuł: Wydziały produkcyjne
Opis: Słownik wydziałów produkcyjnych w strukturze organizacyjnej zakładu. Definiuje podział zakładu na wydziały wraz z przypisanymi magazynami surowców, produktów, odpadów i braków oraz schematami dokumentów rozchodowych i przychodowych.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`, `IElementSlownika`

- pola bazodanowe: 32
- pola kalkulowane (z klas biznesowych): 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AlgorytmIlosciMaterial | `Soneta.ProdukcjaPro.ProAlgorytmWyliczaniaIlosci` | bazodanowe, enum | Algorytm ilości materiał | Algorytm wyliczania ilości materiału dla wydziału. |
| AutomatyczneGenerowanieZapotrzebowan | `Soneta.ProdukcjaPro.ProGenerowanieZapotrzebowan` | bazodanowe, enum | Automatyczne generowanie zapotrzebowań | Parametr automatycznego generowania zapotrzebowań dla wydziału. |
| AutomatyczneZlecenieMaterial | `Soneta.ProdukcjaPro.ProParametrAutomatycznegoZlecenia` | bazodanowe, enum | Automatyczne generowania zleceń z materiałów | Parametr automatycznego generowania zleceń z materiałów dla wydziału. |
| AutomatyczneZlecenieWyrob | `Soneta.ProdukcjaPro.ProParametrAutomatycznegoZlecenia` | bazodanowe, enum | Automatyczne generowania zleceń z wyrobów | Parametr automatycznego generowania zleceń z wyrobów dla wydziału. |
| Blokada | `bool` | bazodanowe |  | Zablokowanie wydziału. |
| CechaIlosciMaterial | `Soneta.Business.FeatureDefinition` | bazodanowe | Cecha ilości materiał | Cecha wyliczająca ilość materiału dla wydziału. |
| DefinicjaBrakow | `Soneta.Handel.DefDokHandlowego` | bazodanowe | Definicja braków | Definicja braków dla wydziału. |
| DefinicjaOdpadow | `Soneta.Handel.DefDokHandlowego` | bazodanowe | Definicja odpadów | Definicja odpadów dla wydziału. |
| DefinicjaPrzychodow | `Soneta.Handel.DefDokHandlowego` | bazodanowe | Definicja przychodów | Definicja przychodów dla wydziału. |
| DefinicjaRozchodow | `Soneta.Handel.DefDokHandlowego` | bazodanowe | Definicja rozchodów | Definicja rozchodów dla wydziału. |
| DefinicjaZapotrzebowan | `Soneta.Handel.DefDokHandlowego` | bazodanowe | Definicja zapotrzebowań | Definicja zapotrzebowań dla wydziału. |
| DoRealizacji | `bool` | bazodanowe | Do realizacji | Parametr automatycznej zmiany stanu zlecenia na do realizacji dla wydziału. |
| ElementyPodzielnika | `Soneta.Business.SubTable<Soneta.Core.ElementPodzielnika>` |  |  |  |
| Kod | `string` | bazodanowe |  | Kod wydziału. |
| MagazynBrakow | `Soneta.Magazyny.Magazyn` | bazodanowe | Magazyn braków | Magazyn braków dla wydziału. |
| MagazynOdpadow | `Soneta.Magazyny.Magazyn` | bazodanowe | Magazyn odpadów | Magazyn odpadów dla wydziału. |
| MagazynPolproduktow | `Soneta.Magazyny.Magazyn` | bazodanowe | Magazyn półproduktów | Magazyn półproduktów dla wydziału. |
| MagazynPrefabrykatow | `Soneta.Magazyny.Magazyn` | bazodanowe | Magazyn prefabrykatów | Magazyn prefabrykatów dla wydziału. |
| MagazynProduktow | `Soneta.Magazyny.Magazyn` | bazodanowe | Magazyn produktów | Magazyn produktów dla wydziału. |
| MagazynSurowcow | `Soneta.Magazyny.Magazyn` | bazodanowe | Magazyn surowców | Magazyn surowców dla wydziału. |
| MeldunekPrzepiszNarzut | `bool` | bazodanowe | Przepisz narzut na meldunek | Parametr przepisywania narzutu na meldunek (materiały, odpady, koszty dodatkowe) dla wydziału. |
| Miedzywydzialowosc | `bool` | bazodanowe | Międzywydziałowość | Międzywydziałowość wydziału. |
| MomentGenerowaniaZapotrzebowan | `Soneta.ProdukcjaPro.ProMomentGenerowania` | bazodanowe, enum | Moment generowania zapotrzebowań | Moment generowania zapotrzebowań dla wydziału. |
| Nazwa | `string` | bazodanowe |  | Nazwa wydziału. |
| NumeracjaMeldunku | `Soneta.ProdukcjaPro.ProNumeracjaMeldunku` |  |  | Numeracja meldunku. |
| NumeracjaTechnologii | `Soneta.ProdukcjaPro.ProNumeracjaTechnologii` |  |  | Numeracja technologii. |
| NumeracjaZlecenia | `Soneta.ProdukcjaPro.ProNumeracjaZlecenia` |  |  | Numeracja zlecenia. |
| NumeracjeMeldunku | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProNumeracjaMeldunku>` |  |  |  |
| NumeracjeTechnologii | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProNumeracjaTechnologii>` |  |  |  |
| NumeracjeZlecenia | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProNumeracjaZlecenia>` |  |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział | Oddział wydziału. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis wydziału. |
| PowiazaniaKontElementu | `Soneta.Business.SubTable` |  |  |  |
| PozycjaGlowna | `Soneta.ProdukcjaPro.ProParametrPozycjiGlownej` | bazodanowe, enum | Pozycja główna | Parametr pozycji głównej dla wydziału. |
| RozliczFantomowo | `bool` | bazodanowe | Rozlicz fantomowo | Parametr rozliczenia fantomowego dla wydziału. |
| SymbolMeldunku | `string` |  | Symbol meldunku | Symbol numeracji meldunku. |
| SymbolTechnologii | `string` |  | Symbol technologii | Symbol numeracji technologii. |
| SymbolZlecenia | `string` |  | Symbol zlecenia | Symbol numeracji zlecenia. |
| TowarMeldowany | `Soneta.ProdukcjaPro.ProParametrTowaruMeldowanego` | bazodanowe, enum | Towar meldowany | Parametr towaru meldowanego dla wydziału. |
| UstawMagazynMaterial | `bool` | bazodanowe | Ustaw magazyn materiał | Parametr ustawiania magazynów wyrobów zgodnie z magazynem materiału dla wydziału. |
| UstawMagazynWyrob | `bool` | bazodanowe | Ustaw magazyn wyrób | Parametr ustawiania magazynów materiałów zgodnie z magazynem wyrobu dla wydziału. |
| WiazanieOperacjiTechnologii | `bool` | bazodanowe | Automatyczne wiązanie operacji technologii | Parametr automatycznego wiązania operacji technologii szeregowo dla wydziału. |
| WiazanieOperacjiZlecenia | `bool` | bazodanowe | Automatyczne wiązanie operacji zlecenia | Parametr automatycznego wiązania operacji zlecenia szeregowo dla wydziału. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProAlgorytmWyliczaniaIlosci (`Soneta.ProdukcjaPro.ProAlgorytmWyliczaniaIlosci`)
- `None` = 0
- `Pozostala` = 1 — Pozostała
- `Pelna` = 2 — Pełna
- `Cecha` = 4 — Wg cechy
- `StanMagazynu` = 8 — Wg stanu magazynu
- `StanDostepny` = 16 — Wg stanu dostępnego
- `All` = 31 — Wszystkie

### ProGenerowanieZapotrzebowan (`Soneta.ProdukcjaPro.ProGenerowanieZapotrzebowan`)
- `None` = 0
- `Brak` = 2
- `Operacja` = 4
- `Zlecenie` = 8
- `Zaznaczenie` = 16
- `All` = 30 — Wszystkie

### ProMomentGenerowania (`Soneta.ProdukcjaPro.ProMomentGenerowania`)
- `None` = 0
- `Brak` = 2
- `UtworzenieZlecenia` = 4 — Utworzenie zlecenia
- `ZlecenieDoRealizacji` = 8 — Zmiana stanu zlecenia "Do realizacji"
- `All` = 14 — Wszystkie

### ProParametrAutomatycznegoZlecenia (`Soneta.ProdukcjaPro.ProParametrAutomatycznegoZlecenia`)
- `None` = 0
- `Brak` = 1
- `GenerujIPowiaz` = 2 — Uruchom i powiąż
- `GenerujINiewiaz` = 4 — Uruchom bez wiązania
- `All` = 7 — Wszystkie

### ProParametrPozycjiGlownej (`Soneta.ProdukcjaPro.ProParametrPozycjiGlownej`)
- `None` = 0
- `Brak` = 1
- `Material` = 2 — Materiał
- `Wyrob` = 4 — Wyrób
- `All` = 7 — Wszystkie

### ProParametrTowaruMeldowanego (`Soneta.ProdukcjaPro.ProParametrTowaruMeldowanego`)
- `None` = 0
- `Brak` = 1
- `Material` = 2 — Materiał
- `Wyrob` = 4 — Wyrób
- `All` = 7 — Wszystkie
