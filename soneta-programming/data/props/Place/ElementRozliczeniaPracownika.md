# Pola i właściwości klasy biznesowej: `Soneta.Place.ElementRozliczeniaPracownika`
Nazwa tabeli: `ElementyRozlPrac`
Tytuł: Elementy rozliczenia
Opis: Element szczegółowy rozliczenia pracownika (DokumentRozliczeniaPracownika). Przechowuje naliczoną wartość pojedynczego składnika rozliczenia z parametrami obliczeniowymi (podstawy, czas, ułamek).
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BaseCzas | `Time` |  |  |  |
| BaseData | `Date` |  |  |  |
| BaseDni | `int` |  |  |  |
| BaseDokument | `Soneta.Place.DokumentRozliczeniaPracownika` |  |  |  |
| BaseOkres | `FromTo` | podlista |  |  |
| BasePodstawa | `DoubleCy` |  |  |  |
| Czas | `Time` | bazodanowe |  |  |
| Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| Definicja | `Soneta.Place.DefinicjaElementuRozliczenia` | bazodanowe, tylko-odczyt |  |  |
| Dni | `int` | bazodanowe |  |  |
| DodHistoria | `Soneta.Kadry.InformacjeDoRozliczeniaHistoria` | tylko-odczyt |  |  |
| Dokument | `Soneta.Place.DokumentRozliczeniaPracownika` | bazodanowe, tylko-odczyt |  |  |
| Ilosc | `double` | bazodanowe |  |  |
| Informacja | `Soneta.Kadry.InformacjaDoRozliczenia` | bazodanowe, tylko-odczyt |  |  |
| Korekta | `bool` | bazodanowe | Wartość | Określa, czy element rozliczenia jest zmodyfikowany ręcznie przez operatora. |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Podstawa | `DoubleCy` | bazodanowe |  |  |
| Podstawa2 | `DoubleCy` | bazodanowe |  |  |
| Podstawa3 | `DoubleCy` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Procent | `Percent` | bazodanowe |  |  |
| Ulamek | `Fraction` | bazodanowe |  |  |
| Umowa | `Soneta.Kadry.UmowaZewnetrzna` | bazodanowe, tylko-odczyt |  |  |
| WartoscCy | `Currency` | bazodanowe, tylko-odczyt |  |  |
| Wspolczynnik | `double` | bazodanowe |  |  |
| Zatwierdzony | `bool` | tylko-odczyt |  |  |
