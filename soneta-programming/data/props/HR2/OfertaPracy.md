# Pola i właściwości klasy biznesowej: `Soneta.HR2.OfertaPracy`
Nazwa tabeli: `OfertyPracy`
Tytuł: Ogłoszenia o pracę
Opis: Ogłoszenie o pracę publikowane na potrzeby rekrutacji. Zawiera dane stanowiska, numery referencyjne, daty wystawienia i wycofania oraz opcjonalnie proponowane wynagrodzenie i powiązanie z wakatem.
Tabela konfiguracyjna: Nie
Implementuje interfejsy: `IŹródłoRekrutacji`, `IŹródłoKartyOpisuStanowiska`

- pola bazodanowe (zapisywalne): 16
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 4
- podlisty: 4
- subrowy: 1
- razem: 26

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  |  |
| DataPoziomuWynagrodzenia | `Date` | bazodanowe |  |  |
| DataWycofania | `Date` | bazodanowe |  |  |
| DataWystawienia | `Date` | bazodanowe |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| KartyOpisuStanowiska | `SubTable<Soneta.HR2.KartaOpisuStanowiskaBase>` | podlista |  |  |
| NazwaStanowiska | `string` | bazodanowe |  |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| NumerReferencyjny | `string` | bazodanowe |  |  |
| Odpowiedzialny | `Soneta.Oceny.IOceniający` | bazodanowe, iface-ref |  |  |
| Oferty | `SubTable<Soneta.HR2.RekrutacjaAplikacja>` | podlista |  |  |
| PlanowanaDataWycofania | `Date` | bazodanowe |  |  |
| ProponowaneWynagrodzenieBrutto | `Currency` | bazodanowe |  |  |
| Seria | `string` | bazodanowe |  |  |
| Stan | `Soneta.HR2.StanOfertyPracy` (enum) | bazodanowe |  |  |
| Stanowisko | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, tylko-odczyt |  |  |
| Wakat | `Soneta.HR2.RekrutacjaWakat` | bazodanowe, tylko-odczyt |  |  |
| WidocznoscPoziomuWynagrodzenia | `bool` | bazodanowe |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe, tylko-odczyt | Jednostka organizacyjna |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Odpowiedzialny | `IOceniający` | `KontaktOsoba`, `Pracownik`, `WykladowcaSzkol` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanOfertyPracy (`Soneta.HR2.StanOfertyPracy`)
- `Wprowadzona` = 1
- `Zakończona` = 2
- `Anulowana` = 3
