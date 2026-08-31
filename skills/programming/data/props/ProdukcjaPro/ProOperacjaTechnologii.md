# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProOperacjaTechnologii`
Nazwa tabeli: `ProOperacjeTech`
Tytuł: Operacje technologii
Opis: Element szczegółowy technologii produkcyjnej (ProTechnologia). Reprezentuje pojedynczy krok marszruty technologicznej z przypisaną definicją operacji, definicją meldunku, sposobem wyceny oraz normami czasowymi.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Technologia` → `ProTechnologia`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CechaDostepnosci | `FeatureDefinition` | bazodanowe | Cecha dostępności | Cecha dostępności operacji technologii. |
| Czas | `TimeSec` | bazodanowe |  | Czas operacji technologii. |
| CzasMiedzyoperacyjny | `TimeSec` | bazodanowe | Czas międzyoperacyjny | Czas międzyoperacyjny operacji technologii. |
| DefinicjaMeldunku | `Soneta.ProdukcjaPro.ProDefinicjaMeldunku` | bazodanowe | Definicja meldunku | Definicja meldunku dla operacji technologii. |
| DefinicjaOperacji | `Soneta.ProdukcjaPro.ProDefinicjaOperacji` | bazodanowe | Definicja operacji | Definicja operacji dla operacji technologii. |
| Kalkulacja | `Soneta.ProdukcjaPro.ProKalkulacjaOperacjiTechnologii` | tylko-odczyt |  | Kalkulacja operacji technologii. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa operacji technologii. |
| Materialy | `SubTable<Soneta.ProdukcjaPro.ProMaterialOperacjiTechnologii>` | podlista | Materiały | Materiały operacji technologii. |
| Odpady | `SubTable<Soneta.ProdukcjaPro.ProOdpadOperacjiTechnologii>` | podlista |  | Odpady operacji technologii. |
| OperacjeNastepujace | `SubTable<Soneta.ProdukcjaPro.ProOperacjaTechnologiiPoprzedzajaca>` | podlista | Operacje następujące | Operacje następujące dla operacji technologii. |
| OperacjePoprzedzajace | `LpSubTable<Soneta.ProdukcjaPro.ProOperacjaTechnologiiPoprzedzajaca>` | podlista |  |  |
| OperacjeZlecen | `SubTable<Soneta.ProdukcjaPro.ProOperacjaZlecenia>` | podlista |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis operacji technologii. |
| SposobWyceny | `Soneta.ProdukcjaPro.ProSposobWyceny` (enum) | bazodanowe | Sposób wyceny | Sposób wyceny operacji technologii. |
| Technologia | `Soneta.ProdukcjaPro.ProTechnologia` | bazodanowe, guided-parent |  | Technologia dla operacji technologii. |
| TowarMeldowany | `Soneta.ProdukcjaPro.IProTowarMeldowany` |  | Towar meldowany | Towar meldowany operacji technologii. |
| Uslugi | `SubTable<Soneta.ProdukcjaPro.ProUslugaOperacjiTechnologii>` | podlista | Usługi | Usługi operacji technologii. |
| Wydzial | `Soneta.ProdukcjaPro.ProWydzial` | tylko-odczyt | Wydział | Wydział operacji technologii wskazany na technologii produkcyjnej. |
| Wyroby | `SubTable<Soneta.ProdukcjaPro.ProWyrobOperacjiTechnologii>` | podlista |  | Wyroby operacji technologii. |
| Zasoby | `SubTable<Soneta.ProdukcjaPro.ProZasobOperacjiTechnologii>` | podlista |  | Zasoby operacji technologii. |

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
