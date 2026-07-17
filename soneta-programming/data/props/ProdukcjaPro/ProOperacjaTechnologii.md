# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProOperacjaTechnologii`
Nazwa tabeli: `ProOperacjeTech`
Tytuł: Operacje technologii
Opis: Element szczegółowy technologii produkcyjnej (ProTechnologia). Reprezentuje pojedynczy krok marszruty technologicznej z przypisaną definicją operacji, definicją meldunku, sposobem wyceny oraz normami czasowymi.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Technologia` → `ProTechnologia`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CechaDostepnosci | `Soneta.Business.FeatureDefinition` | bazodanowe | Cecha dostępności | Cecha dostępności operacji technologii. |
| Czas | `Soneta.Types.TimeSec` | bazodanowe |  | Czas operacji technologii. |
| CzasMiedzyoperacyjny | `Soneta.Types.TimeSec` | bazodanowe | Czas międzyoperacyjny | Czas międzyoperacyjny operacji technologii. |
| DefinicjaMeldunku | `Soneta.ProdukcjaPro.ProDefinicjaMeldunku` | bazodanowe | Definicja meldunku | Definicja meldunku dla operacji technologii. |
| DefinicjaOperacji | `Soneta.ProdukcjaPro.ProDefinicjaOperacji` | bazodanowe | Definicja operacji | Definicja operacji dla operacji technologii. |
| Kalkulacja | `Soneta.ProdukcjaPro.ProKalkulacjaOperacjiTechnologii` |  |  | Kalkulacja operacji technologii. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa operacji technologii. |
| Materialy | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProMaterialOperacjiTechnologii>` |  | Materiały | Materiały operacji technologii. |
| Odpady | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProOdpadOperacjiTechnologii>` |  |  | Odpady operacji technologii. |
| OperacjeNastepujace | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProOperacjaTechnologiiPoprzedzajaca>` |  | Operacje następujące | Operacje następujące dla operacji technologii. |
| OperacjePoprzedzajace | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProOperacjaTechnologiiPoprzedzajaca>` |  |  |  |
| OperacjeZlecen | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProOperacjaZlecenia>` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis operacji technologii. |
| SposobWyceny | `Soneta.ProdukcjaPro.ProSposobWyceny` | bazodanowe, enum | Sposób wyceny | Sposób wyceny operacji technologii. |
| Technologia | `Soneta.ProdukcjaPro.ProTechnologia` | bazodanowe, guided-parent |  | Technologia dla operacji technologii. |
| TowarMeldowany | `Soneta.ProdukcjaPro.IProTowarMeldowany` |  | Towar meldowany | Towar meldowany operacji technologii. |
| Uslugi | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProUslugaOperacjiTechnologii>` |  | Usługi | Usługi operacji technologii. |
| Wydzial | `Soneta.ProdukcjaPro.ProWydzial` |  | Wydział | Wydział operacji technologii wskazany na technologii produkcyjnej. |
| Wyroby | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProWyrobOperacjiTechnologii>` |  |  | Wyroby operacji technologii. |
| Zasoby | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProZasobOperacjiTechnologii>` |  |  | Zasoby operacji technologii. |

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
