# Pola i właściwości klasy biznesowej: `Soneta.Kadry.WydziałDefFundPozy`
Nazwa tabeli: `WydDefFundPozy`
Tytuł: Jednostki organizacyjne definicji funduszu pożyczkowego
Opis: Element szczegółowy definicji funduszu pożyczkowego (DefinicjaFunduszuPozyczkowego). Powiązanie funduszu z jednostką organizacyjną, określające zakres wydziałów uprawnionych do korzystania z funduszu wraz z ilością miejsc.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DefinicjaFunduszuPozyczkowego` → `DefinicjaFunduszuPozyczkowego`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaFunduszuPozyczkowego | `Soneta.Kadry.DefinicjaFunduszuPozyczkowego` | bazodanowe, guided-parent | Definicja funduszu pozyczkowego |  |
| Ilosc | `Soneta.Types.Fraction` | bazodanowe | Ilość |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
