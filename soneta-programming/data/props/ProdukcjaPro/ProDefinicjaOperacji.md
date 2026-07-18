# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProDefinicjaOperacji`
Nazwa tabeli: `ProDOperacji`
Tytuł: Definicje operacji produkcyjnych
Opis: Słownik definicji operacji produkcyjnych stanowiących wzorce dla operacji w technologiach i zleceniach. Określa domyślne parametry operacji, takie jak wydział, definicja meldunku i sposób raportowania wykonania.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 8
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 1
- podlisty: 6
- subrowy: 0
- razem: 16

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Zablokowanie definicji operacji. |
| Czas | `TimeSec` | bazodanowe |  | Czas definicji operacji. |
| CzasMiedzyoperacyjny | `TimeSec` | bazodanowe | Czas międzyoperacyjny | Czas międzyoperacyjny definicji operacji. |
| DefinicjaMeldunku | `Soneta.ProdukcjaPro.ProDefinicjaMeldunku` | bazodanowe | Definicja meldunku | Definicja meldunku dla definicji operacji. |
| Kalkulacja | `Soneta.ProdukcjaPro.ProKalkulacjaOperacjiTechnologii` | tylko-odczyt |  | Kalkulacja definicji operacji. |
| Kod | `string` | bazodanowe |  | Kod definicji operacji. |
| Materialy | `SubTable<Soneta.ProdukcjaPro.ProMaterialOperacjiTechnologii>` | podlista | Materiały | Materiały definicji operacji. |
| Nazwa | `string` | bazodanowe |  | Nazwa definicji operacji. |
| Odpady | `SubTable<Soneta.ProdukcjaPro.ProOdpadOperacjiTechnologii>` | podlista |  | Odpady definicji operacji. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis definicji operacji. |
| SposobWyceny | `Soneta.ProdukcjaPro.ProSposobWyceny` (enum) | bazodanowe | Sposób wyceny | Sposób wyceny definicji operacji. |
| TowarMeldowany | `Soneta.ProdukcjaPro.IProTowarMeldowany` |  | Towar meldowany | Towar meldowany definicji operacji. |
| Uslugi | `SubTable<Soneta.ProdukcjaPro.ProUslugaOperacjiTechnologii>` | podlista | Usługi | Usługi definicji operacji. |
| Wydzial | `Soneta.ProdukcjaPro.ProWydzial` | bazodanowe | Wydział | Wydział definicji operacji. |
| Wyroby | `SubTable<Soneta.ProdukcjaPro.ProWyrobOperacjiTechnologii>` | podlista |  | Wyroby definicji operacji. |
| Zasoby | `SubTable<Soneta.ProdukcjaPro.ProZasobOperacjiTechnologii>` | podlista |  | Zasoby definicji operacji. |

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
