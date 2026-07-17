# Pola i właściwości klasy biznesowej: `Soneta.HR.DefinicjaSzkolenia`
Nazwa tabeli: `DefinicjeSzkolen`
Tytuł: Definicje szkoleń
Opis: Definicja rodzaju szkolenia w danej kategorii. Stanowi szablon opisujący temat szkolenia, na podstawie którego tworzone są oferty, wnioski i realizacje szkoleń.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`, `IPozycjaKonfiguratora`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| GrupaKSU | `Soneta.HR.ZKL.Slowniki.KSU.GrupaSzkolenIUprawnien` | bazodanowe | Grupa KSU |  |
| GrupaNazwa | `string` |  |  |  |
| GrupyStanowiskDisplay | `string` |  |  |  |
| Kategoria | `Soneta.HR.KategoriaSzkolenia` | bazodanowe |  |  |
| KategoriaDisplay | `string` |  |  |  |
| KsuCelSzkolenia | `string` |  |  |  |
| KsuGrupyStanowisk | `Soneta.HR.GrupaStanowisk[]` |  | Grupy stanowisk |  |
| KsuObszaryFunkcjonalne | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.ObszarFunkcjonalny[]` |  | Obszary funkcjonalne |  |
| KsuSzkoleniaPoprzedzajace | `Soneta.HR.DefinicjaSzkolenia[]` |  | Szkolenie poprzedzające |  |
| KsuTyp | `Soneta.HR.ZKL.Enums.KsuPozycjaTyp` | enum |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| ObszaryFunkcjonalneDisplay | `string` |  |  |  |
| PoprzedzajaceDisplay | `string` |  |  |  |
| Symbol | `string` | bazodanowe | Symbol |  |
| Uprawnienia | `Soneta.Business.SubTable<Soneta.HR.UprawnienieDefinicjiSzkolenia>` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KsuPozycjaTyp (`Soneta.HR.ZKL.Enums.KsuPozycjaTyp`)
- `None` = 0 — Brak
- `Szkolenie` = 10 — Szkolenie
- `Uprawnienie` = 20 — Uprawnienie
- `SzkolenieBhp` = 30 — Szkolenie BHP
