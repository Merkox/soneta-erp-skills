# Pola i właściwości klasy biznesowej: `Soneta.HR.DefinicjaSzkolenia`
Nazwa tabeli: `DefinicjeSzkolen`
Tytuł: Definicje szkoleń
Opis: Definicja rodzaju szkolenia w danej kategorii. Stanowi szablon opisujący temat szkolenia, na podstawie którego tworzone są oferty, wnioski i realizacje szkoleń.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`, `IPozycjaKonfiguratora`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| GrupaKSU | `Soneta.HR.ZKL.Slowniki.KSU.GrupaSzkolenIUprawnien` | bazodanowe | Grupa KSU |  |
| GrupaNazwa | `string` | tylko-odczyt |  |  |
| GrupyStanowiskDisplay | `string` | tylko-odczyt |  |  |
| Kategoria | `Soneta.HR.KategoriaSzkolenia` | bazodanowe |  |  |
| KategoriaDisplay | `string` | tylko-odczyt |  |  |
| KsuCelSzkolenia | `string` |  |  |  |
| KsuGrupyStanowisk | `Soneta.HR.GrupaStanowisk[]` | podlista | Grupy stanowisk |  |
| KsuObszaryFunkcjonalne | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.ObszarFunkcjonalny[]` | podlista | Obszary funkcjonalne |  |
| KsuSzkoleniaPoprzedzajace | `Soneta.HR.DefinicjaSzkolenia[]` | podlista | Szkolenie poprzedzające |  |
| KsuTyp | `Soneta.HR.ZKL.Enums.KsuPozycjaTyp` (enum) | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| ObszaryFunkcjonalneDisplay | `string` | tylko-odczyt |  |  |
| PoprzedzajaceDisplay | `string` | tylko-odczyt |  |  |
| Symbol | `string` | bazodanowe | Symbol |  |
| Uprawnienia | `SubTable<Soneta.HR.UprawnienieDefinicjiSzkolenia>` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KsuPozycjaTyp (`Soneta.HR.ZKL.Enums.KsuPozycjaTyp`)
- `None` = 0 — Brak
- `Szkolenie` = 10 — Szkolenie
- `Uprawnienie` = 20 — Uprawnienie
- `SzkolenieBhp` = 30 — Szkolenie BHP
