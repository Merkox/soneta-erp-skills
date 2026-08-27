# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProMeldunek`
Nazwa tabeli: `ProMeldunki`
Tytuł: Meldunki produkcyjne
Opis: Element szczegółowy meldunku produkcyjnego (ProOperacjaZlecenia). Reprezentuje meldunek z realizacji operacji zlecenia produkcyjnego, zawierający informacje o dacie utworzenia i złożenia, operatorze, stanie oraz ilości. Meldunek agreguje materiały, odpady, usługi, zasoby i wyroby powstałe w trakcie produkcji.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Context | `Context` | podlista |  |  |
| CzasUtworzenia | `TimeSec` | bazodanowe | Czas utworzenia | Czas utworzenia meldunku. |
| CzasZlozenia | `TimeSec` | bazodanowe | Czas złożenia | Czas złożenia meldunku. |
| DataUtworzenia | `Date` | bazodanowe | Data utworzenia | Data utworzenia meldunku. |
| DataZlozenia | `Date` | bazodanowe | Data złożenia | Data złożenia meldunku. |
| DefinicjaMeldunku | `Soneta.ProdukcjaPro.ProDefinicjaMeldunku` | bazodanowe | Definicja meldunku | Definicja meldunku dla meldunku. |
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość meldunku. |
| IloscPrzeliczona | `Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla meldunku. |
| Kalkulacja | `Soneta.ProdukcjaPro.ProKalkulacjaMeldunku` | tylko-odczyt |  | Kalkulacja meldunku. |
| Kalkulacje | `SubTable<Soneta.ProdukcjaPro.ProKalkulacjaMeldunku>` | podlista |  |  |
| Materialy | `LpSubTable<Soneta.ProdukcjaPro.ProMaterialMeldunku>` | podlista |  |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  | Numer meldunku. |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| Odpady | `LpSubTable<Soneta.ProdukcjaPro.ProOdpadMeldunku>` | podlista |  |  |
| Operacja | `Soneta.ProdukcjaPro.ProOperacjaZlecenia` | bazodanowe |  | Operacja dla meldunku. |
| Operator | `App.Operator` | bazodanowe |  | Operator tworzący meldunek. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis meldunku. |
| Osoba | `Soneta.ProdukcjaPro.ProOsoba` | bazodanowe |  | Osoba dla meldunku. |
| Otwarty | `bool` | tylko-odczyt |  | Meldunek otwarty. |
| RozliczenieMaterialow | `bool` | tylko-odczyt | Rozliczenie materiałów | Stan rozliczenia ilościowego materiałów meldunku. |
| RozliczenieOdpadow | `bool` | tylko-odczyt | Rozliczenie odpadów | Stan rozliczenia ilościowego odpadów meldunku. |
| RozliczenieWartosciowe | `bool` | tylko-odczyt | Rozliczenie wartościowe | Stan rozliczenia wartościowego meldunku. |
| RozliczenieWyrobow | `bool` | tylko-odczyt | Rozliczenie wyrobów | Stan rozliczenia ilościowego odpadów wyrobów. |
| SposobWyceny | `Soneta.ProdukcjaPro.ProSposobWyceny` (enum) | bazodanowe | Sposób wyceny | Sposób wyceny meldunku. |
| Stan | `Soneta.ProdukcjaPro.ProStanMeldunku` (enum) | bazodanowe |  | Stan meldunku. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar meldunku. |
| Uslugi | `LpSubTable<Soneta.ProdukcjaPro.ProUslugaMeldunku>` | podlista |  |  |
| Uzytkownik | `Soneta.ProdukcjaPro.ProUzytkownikPaneluMeldunkowego` | bazodanowe | Użytkownik | Użytkownik panelu meldunkowego tworzący meldunek. |
| WycenaMaterialow | `Soneta.ProdukcjaPro.ProWycenaMaterialow` (enum) | bazodanowe | Wycena materiałów | Wycena materiałów dla meldunku. |
| WycenaWyrobow | `Soneta.ProdukcjaPro.ProWycenaWyrobow` (enum) | bazodanowe | Wycena wyrobów | Wycena wyrobów dla meldunku. |
| WycenaZasobow | `Soneta.ProdukcjaPro.ProWycenaZasobow` (enum) | bazodanowe | Wycena zasobów | Wycena zasobów dla meldunku. |
| Wydzial | `Soneta.ProdukcjaPro.ProWydzial` | tylko-odczyt | Wydział | Wydział meldunku wskazany na zleceniu produkcyjnym. |
| Wyroby | `LpSubTable<Soneta.ProdukcjaPro.ProWyrobMeldunku>` | podlista |  |  |
| Zamkniety | `bool` | tylko-odczyt | Zamknięty | Meldunek zamknięty. |
| Zasoby | `LpSubTable<Soneta.ProdukcjaPro.ProZasobMeldunku>` | podlista |  |  |
| Zlecenie | `Soneta.ProdukcjaPro.ProZlecenie` | tylko-odczyt | Zlecenie | Zlecenie meldunku wskazane na operacji zlecenia. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProSposobWyceny (`Soneta.ProdukcjaPro.ProSposobWyceny`)
- `None` = 0
- `Ilosc` = 1 — Wg ilości
- `Wspolczynnik` = 2 — Wg współczynnika
- `IloscWspolczynnik` = 4 — Wg ilości i współczynnika
- `MasaNetto` = 8 — Wg masy netto
- `MasaBrutto` = 16 — Wg masy brutto
- `CenaStala` = 32 — Wg ceny stałej
- `CenaReczna` = 64 — Wg ceny podanej ręcznie
- `All` = 127 — Wszystkie

### ProStanMeldunku (`Soneta.ProdukcjaPro.ProStanMeldunku`)
- `None` = 0
- `Otwarty` = 1
- `Zamkniety` = 2 — Zamknięty
- `All` = 3 — Wszystkie

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
