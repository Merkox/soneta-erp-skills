# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProMeldunek`
Nazwa tabeli: `ProMeldunki`
Tytuł: Meldunki produkcyjne
Opis: Element szczegółowy meldunku produkcyjnego (ProOperacjaZlecenia). Reprezentuje meldunek z realizacji operacji zlecenia produkcyjnego, zawierający informacje o dacie utworzenia i złożenia, operatorze, stanie oraz ilości. Meldunek agreguje materiały, odpady, usługi, zasoby i wyroby powstałe w trakcie produkcji.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 22
- pola kalkulowane (z klas biznesowych): 19

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Context | `Soneta.Business.Context` |  |  |  |
| CzasUtworzenia | `Soneta.Types.TimeSec` | bazodanowe | Czas utworzenia | Czas utworzenia meldunku. |
| CzasZlozenia | `Soneta.Types.TimeSec` | bazodanowe | Czas złożenia | Czas złożenia meldunku. |
| DataUtworzenia | `Soneta.Types.Date` | bazodanowe | Data utworzenia | Data utworzenia meldunku. |
| DataZlozenia | `Soneta.Types.Date` | bazodanowe | Data złożenia | Data złożenia meldunku. |
| DefinicjaMeldunku | `Soneta.ProdukcjaPro.ProDefinicjaMeldunku` | bazodanowe | Definicja meldunku | Definicja meldunku dla meldunku. |
| Ilosc | `Soneta.Types.Amount` | bazodanowe | Ilość | Ilość meldunku. |
| IloscPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla meldunku. |
| Kalkulacja | `Soneta.ProdukcjaPro.ProKalkulacjaMeldunku` |  |  | Kalkulacja meldunku. |
| Kalkulacje | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProKalkulacjaMeldunku>` |  |  |  |
| Materialy | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProMaterialMeldunku>` |  |  |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  | Numer meldunku. |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| Odpady | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProOdpadMeldunku>` |  |  |  |
| Operacja | `Soneta.ProdukcjaPro.ProOperacjaZlecenia` | bazodanowe |  | Operacja dla meldunku. |
| Operator | `Soneta.Business.App.Operator` | bazodanowe |  | Operator tworzący meldunek. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis meldunku. |
| Osoba | `Soneta.ProdukcjaPro.ProOsoba` | bazodanowe |  | Osoba dla meldunku. |
| Otwarty | `bool` |  |  | Meldunek otwarty. |
| RozliczenieMaterialow | `bool` |  | Rozliczenie materiałów | Stan rozliczenia ilościowego materiałów meldunku. |
| RozliczenieOdpadow | `bool` |  | Rozliczenie odpadów | Stan rozliczenia ilościowego odpadów meldunku. |
| RozliczenieWartosciowe | `bool` |  | Rozliczenie wartościowe | Stan rozliczenia wartościowego meldunku. |
| RozliczenieWyrobow | `bool` |  | Rozliczenie wyrobów | Stan rozliczenia ilościowego odpadów wyrobów. |
| SposobWyceny | `Soneta.ProdukcjaPro.ProSposobWyceny` | bazodanowe, enum | Sposób wyceny | Sposób wyceny meldunku. |
| Stan | `Soneta.ProdukcjaPro.ProStanMeldunku` | bazodanowe, enum |  | Stan meldunku. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar meldunku. |
| Uslugi | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProUslugaMeldunku>` |  |  |  |
| Uzytkownik | `Soneta.ProdukcjaPro.ProUzytkownikPaneluMeldunkowego` | bazodanowe | Użytkownik | Użytkownik panelu meldunkowego tworzący meldunek. |
| WycenaMaterialow | `Soneta.ProdukcjaPro.ProWycenaMaterialow` | bazodanowe, enum | Wycena materiałów | Wycena materiałów dla meldunku. |
| WycenaWyrobow | `Soneta.ProdukcjaPro.ProWycenaWyrobow` | bazodanowe, enum | Wycena wyrobów | Wycena wyrobów dla meldunku. |
| WycenaZasobow | `Soneta.ProdukcjaPro.ProWycenaZasobow` | bazodanowe, enum | Wycena zasobów | Wycena zasobów dla meldunku. |
| Wydzial | `Soneta.ProdukcjaPro.ProWydzial` |  | Wydział | Wydział meldunku wskazany na zleceniu produkcyjnym. |
| Wyroby | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProWyrobMeldunku>` |  |  |  |
| Zamkniety | `bool` |  | Zamknięty | Meldunek zamknięty. |
| Zasoby | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProZasobMeldunku>` |  |  |  |
| Zlecenie | `Soneta.ProdukcjaPro.ProZlecenie` |  | Zlecenie | Zlecenie meldunku wskazane na operacji zlecenia. |

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
