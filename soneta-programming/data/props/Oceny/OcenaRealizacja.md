# Pola i właściwości klasy biznesowej: `Soneta.Oceny.OcenaRealizacja`
Nazwa tabeli: `OcenyRealizacje`
Tytuł: Oceny
Opis: Realizacja oceny okresowej przeprowadzanej w organizacji. Reprezentuje konkretny proces oceniania z określonym terminem, okresem, etapem realizacji i osobą odpowiedzialną, powiązany ze strukturą organizacyjną firmy.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IŹródłoPowiązaniaStrukturyOrganizacyjnej`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Arkusze | `Soneta.Business.SubTable<Soneta.Oceny.OcenaArkusz>` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Definicja | `Soneta.Oceny.DefinicjaOceny` | bazodanowe |  |  |
| ElementStrukturyFirmy | `Soneta.Core.IElementStrukturyFirmy` | bazodanowe, iface-ref |  |  |
| ElementStrukturyOrganizacyjnej | `Soneta.Core.ElementStrukturyOrganizacyjnej` |  |  |  |
| Etap | `Soneta.Oceny.EtapyRealizacjiOceny` | bazodanowe, enum |  |  |
| IsMiesiąc | `bool` |  |  |  |
| IsRok | `bool` |  |  |  |
| KwartałNumer | `int` |  |  |  |
| KwartałRok | `int` |  |  |  |
| Miesiąc | `Soneta.Types.YearMonth` |  |  |  |
| Nazwa | `string` |  |  |  |
| Oceniający | `Soneta.Business.SubTable<Soneta.Oceny.OcenaOceniający>` |  |  |  |
| Oceniani | `Soneta.Business.SubTable<Soneta.Oceny.OcenaOceniany>` |  |  |  |
| Odpowiedzialny | `Soneta.Oceny.IOdpowiedzialnyZaOcenę` | bazodanowe, iface-ref |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| PowiązaniaStrOrg | `Soneta.Business.SubTable<Soneta.Core.PowiązanieStrukturyOrganizacyjnej>` |  |  |  |
| Rok | `int` |  |  |  |
| Termin | `Soneta.Types.Date` | bazodanowe |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` | bazodanowe, enum |  |  |
| Zrodlo | `Soneta.Oceny.IŹródłoOceny` | bazodanowe, iface-ref |  |  |

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
