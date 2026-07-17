# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProDefinicjaOperacji`
Nazwa tabeli: `ProDOperacji`
Tytuł: Definicje operacji produkcyjnych
Opis: Słownik definicji operacji produkcyjnych stanowiących wzorce dla operacji w technologiach i zleceniach. Określa domyślne parametry operacji, takie jak wydział, definicja meldunku i sposób raportowania wykonania.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Zablokowanie definicji operacji. |
| Czas | `Soneta.Types.TimeSec` | bazodanowe |  | Czas definicji operacji. |
| CzasMiedzyoperacyjny | `Soneta.Types.TimeSec` | bazodanowe | Czas międzyoperacyjny | Czas międzyoperacyjny definicji operacji. |
| DefinicjaMeldunku | `Soneta.ProdukcjaPro.ProDefinicjaMeldunku` | bazodanowe | Definicja meldunku | Definicja meldunku dla definicji operacji. |
| Kalkulacja | `Soneta.ProdukcjaPro.ProKalkulacjaOperacjiTechnologii` |  |  | Kalkulacja definicji operacji. |
| Kod | `string` | bazodanowe |  | Kod definicji operacji. |
| Materialy | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProMaterialOperacjiTechnologii>` |  | Materiały | Materiały definicji operacji. |
| Nazwa | `string` | bazodanowe |  | Nazwa definicji operacji. |
| Odpady | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProOdpadOperacjiTechnologii>` |  |  | Odpady definicji operacji. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis definicji operacji. |
| SposobWyceny | `Soneta.ProdukcjaPro.ProSposobWyceny` | bazodanowe, enum | Sposób wyceny | Sposób wyceny definicji operacji. |
| TowarMeldowany | `Soneta.ProdukcjaPro.IProTowarMeldowany` |  | Towar meldowany | Towar meldowany definicji operacji. |
| Uslugi | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProUslugaOperacjiTechnologii>` |  | Usługi | Usługi definicji operacji. |
| Wydzial | `Soneta.ProdukcjaPro.ProWydzial` | bazodanowe | Wydział | Wydział definicji operacji. |
| Wyroby | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProWyrobOperacjiTechnologii>` |  |  | Wyroby definicji operacji. |
| Zasoby | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProZasobOperacjiTechnologii>` |  |  | Zasoby definicji operacji. |

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
