# Pola i właściwości klasy biznesowej: `Soneta.HR2.OfertaPracy`
Nazwa tabeli: `OfertyPracy`
Tytuł: Ogłoszenia o pracę
Opis: Ogłoszenie o pracę publikowane na potrzeby rekrutacji. Zawiera dane stanowiska, numery referencyjne, daty wystawienia i wycofania oraz opcjonalnie proponowane wynagrodzenie i powiązanie z wakatem.
Tabela konfiguracyjna: Nie
Implementuje interfejsy: `IŹródłoRekrutacji`, `IŹródłoKartyOpisuStanowiska`

- pola bazodanowe: 21
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DataPoziomuWynagrodzenia | `Soneta.Types.Date` | bazodanowe |  |  |
| DataWycofania | `Soneta.Types.Date` | bazodanowe |  |  |
| DataWystawienia | `Soneta.Types.Date` | bazodanowe |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| KartyOpisuStanowiska | `Soneta.Business.SubTable<Soneta.HR2.KartaOpisuStanowiskaBase>` |  |  |  |
| NazwaStanowiska | `string` | bazodanowe |  |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| NumerReferencyjny | `string` | bazodanowe |  |  |
| Odpowiedzialny | `Soneta.Oceny.IOceniający` | bazodanowe, iface-ref |  |  |
| Oferty | `Soneta.Business.SubTable<Soneta.HR2.RekrutacjaAplikacja>` |  |  |  |
| PlanowanaDataWycofania | `Soneta.Types.Date` | bazodanowe |  |  |
| ProponowaneWynagrodzenieBrutto | `Soneta.Types.Currency` | bazodanowe |  |  |
| Seria | `string` | bazodanowe |  |  |
| Stan | `Soneta.HR2.StanOfertyPracy` | bazodanowe, enum |  |  |
| Stanowisko | `Soneta.HR.DefinicjaStanowiska` | bazodanowe |  |  |
| Wakat | `Soneta.HR2.RekrutacjaWakat` | bazodanowe |  |  |
| WidocznoscPoziomuWynagrodzenia | `bool` | bazodanowe |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |

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
