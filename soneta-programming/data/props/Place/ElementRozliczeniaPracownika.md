# Pola i właściwości klasy biznesowej: `Soneta.Place.ElementRozliczeniaPracownika`
Nazwa tabeli: `ElementyRozlPrac`
Tytuł: Elementy rozliczenia
Opis: Element szczegółowy rozliczenia pracownika (DokumentRozliczeniaPracownika). Przechowuje naliczoną wartość pojedynczego składnika rozliczenia z parametrami obliczeniowymi (podstawy, czas, ułamek).
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 18
- pola kalkulowane (z klas biznesowych): 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BaseCzas | `Soneta.Types.Time` |  |  |  |
| BaseData | `Soneta.Types.Date` |  |  |  |
| BaseDni | `int` |  |  |  |
| BaseDokument | `Soneta.Place.DokumentRozliczeniaPracownika` |  |  |  |
| BaseOkres | `Soneta.Types.FromTo` |  |  |  |
| BasePodstawa | `Soneta.Types.DoubleCy` |  |  |  |
| Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Definicja | `Soneta.Place.DefinicjaElementuRozliczenia` | bazodanowe |  |  |
| Dni | `int` | bazodanowe |  |  |
| DodHistoria | `Soneta.Kadry.InformacjeDoRozliczeniaHistoria` |  |  |  |
| Dokument | `Soneta.Place.DokumentRozliczeniaPracownika` | bazodanowe |  |  |
| Ilosc | `double` | bazodanowe |  |  |
| Informacja | `Soneta.Kadry.InformacjaDoRozliczenia` | bazodanowe |  |  |
| Korekta | `bool` | bazodanowe | Wartość | Określa, czy element rozliczenia jest zmodyfikowany ręcznie przez operatora. |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Podstawa | `Soneta.Types.DoubleCy` | bazodanowe |  |  |
| Podstawa2 | `Soneta.Types.DoubleCy` | bazodanowe |  |  |
| Podstawa3 | `Soneta.Types.DoubleCy` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Procent | `Soneta.Types.Percent` | bazodanowe |  |  |
| Ulamek | `Soneta.Types.Fraction` | bazodanowe |  |  |
| Umowa | `Soneta.Kadry.UmowaZewnetrzna` | bazodanowe |  |  |
| WartoscCy | `Soneta.Types.Currency` | bazodanowe |  |  |
| Wspolczynnik | `double` | bazodanowe |  |  |
| Zatwierdzony | `bool` |  |  |  |
