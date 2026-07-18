# Pola i właściwości klasy biznesowej: `Soneta.Oceny.OcenaRealizacja`
Nazwa tabeli: `OcenyRealizacje`
Tytuł: Oceny
Opis: Realizacja oceny okresowej przeprowadzanej w organizacji. Reprezentuje konkretny proces oceniania z określonym terminem, okresem, etapem realizacji i osobą odpowiedzialną, powiązany ze strukturą organizacyjną firmy.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IŹródłoPowiązaniaStrukturyOrganizacyjnej`
Selektor: pole `TypOceny` (`Soneta.Oceny.TypOceny`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Arkusze | `SubTable<Soneta.Oceny.OcenaArkusz>` | podlista |  |  |
| Data | `Date` | bazodanowe |  |  |
| Definicja | `Soneta.Oceny.DefinicjaOceny` | bazodanowe |  |  |
| ElementStrukturyFirmy | `Soneta.Core.IElementStrukturyFirmy` | bazodanowe, iface-ref |  |  |
| ElementStrukturyOrganizacyjnej | `Soneta.Core.ElementStrukturyOrganizacyjnej` |  |  |  |
| Etap | `Soneta.Oceny.EtapyRealizacjiOceny` (enum) | bazodanowe, tylko-odczyt |  |  |
| IsMiesiąc | `bool` | tylko-odczyt |  |  |
| IsRok | `bool` | tylko-odczyt |  |  |
| KwartałNumer | `int` |  |  |  |
| KwartałRok | `int` |  |  |  |
| Miesiąc | `YearMonth` |  |  |  |
| Nazwa | `string` | tylko-odczyt |  |  |
| Oceniający | `SubTable<Soneta.Oceny.OcenaOceniający>` | podlista |  |  |
| Oceniani | `SubTable<Soneta.Oceny.OcenaOceniany>` | podlista |  |  |
| Odpowiedzialny | `Soneta.Oceny.IOdpowiedzialnyZaOcenę` | bazodanowe, iface-ref |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| PowiązaniaStrOrg | `SubTable<Soneta.Core.PowiązanieStrukturyOrganizacyjnej>` | podlista |  |  |
| Rok | `int` |  |  |  |
| Termin | `Date` | bazodanowe |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| Zrodlo | `Soneta.Oceny.IŹródłoOceny` | bazodanowe, tylko-odczyt, iface-ref |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `TypOceny`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Ocena` | 1 | `Soneta.Oceny.OcenaRealizacja` |  |
| `Ankieta` | 2 | `Soneta.Ankiety.AnkietaRealizacja` | Ankieta |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| ElementStrukturyFirmy | `IElementStrukturyFirmy` | `OddzialFirmy`, `Wydzial` |
| Odpowiedzialny | `IOdpowiedzialnyZaOcenę` | `KontaktOsoba`, `Pracownik` |
| Zrodlo | `IŹródłoOceny` | `GrupaSzkol`, `OcenaPowiaz`, `RealizacjaSzkolenia`, `ZajecieSzkolBase` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### EtapyRealizacjiOceny (`Soneta.Oceny.EtapyRealizacjiOceny`)
- `Przygotowywana` = 1
- `Przygotowana` = 2
- `Zrealizowana` = 3
- `Zatwierdzona` = 10
- `Anulowana` = 11

### TypOceny (`Soneta.Oceny.TypOceny`)
- `Ocena` = 1
- `Ankieta` = 2
