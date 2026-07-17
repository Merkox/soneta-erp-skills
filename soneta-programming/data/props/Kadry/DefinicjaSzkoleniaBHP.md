# Pola i właściwości klasy biznesowej: `Soneta.Kadry.DefinicjaSzkoleniaBHP`
Nazwa tabeli: `DefSzkolenBHP`
Tytuł: Definicje szkoleń BHP
Opis: Definicja typu szkolenia BHP (wstępne, okresowe, stanowiskowe). Określa cykliczność szkoleń, termin kolejnego szkolenia, powiązanie z następną definicją oraz sposób wyliczania terminu ważności.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IManagedRowDefinion`, `IZklPozycjaSlownika`, `IPozycjaKonfiguratora`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Cykliczne | `bool` | bazodanowe |  |  |
| GrupaKSU | `Soneta.HR.ZKL.Slowniki.KSU.GrupaSzkolenIUprawnien` | bazodanowe | Grupa KSU |  |
| GrupaNazwa | `string` |  |  |  |
| GrupyStanowiskDisplay | `string` |  |  |  |
| Kategoria | `string` |  |  |  |
| KategoriaDisplay | `string` |  |  |  |
| Kreatory | `Soneta.Business.SubTable<Soneta.Core.ManagedRowCreator>` |  |  |  |
| KsuCelSzkolenia | `string` |  |  |  |
| KsuGrupyStanowisk | `Soneta.HR.GrupaStanowisk[]` |  | Grupy stanowisk |  |
| KsuObszaryFunkcjonalne | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.ObszarFunkcjonalny[]` |  | Obszary funkcjonalne |  |
| KsuSzkoleniaPoprzedzajace | `Soneta.Kadry.DefinicjaSzkoleniaBHP[]` |  | Szkolenie poprzedzające |  |
| KsuTyp | `Soneta.HR.ZKL.Enums.KsuPozycjaTyp` | enum |  |  |
| NastepneDefinicja | `Soneta.Kadry.DefinicjaSzkoleniaBHP` | bazodanowe |  |  |
| NastepneTermin | `int` | bazodanowe |  |  |
| NastepneTerminOd | `Soneta.Kadry.SposóbWyliczaniaTerminu` | bazodanowe, enum |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| ObszaryFunkcjonalneDisplay | `string` |  |  |  |
| PoprzedzajaceDisplay | `string` |  |  |  |
| Symbol | `string` | bazodanowe | Symbol |  |
| TylkoPosrednio | `bool` | bazodanowe | Utwórz tylko pośrednio |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KsuPozycjaTyp (`Soneta.HR.ZKL.Enums.KsuPozycjaTyp`)
- `None` = 0 — Brak
- `Szkolenie` = 10 — Szkolenie
- `Uprawnienie` = 20 — Uprawnienie
- `SzkolenieBhp` = 30 — Szkolenie BHP

### SposóbWyliczaniaTerminu (`Soneta.Kadry.SposóbWyliczaniaTerminu`)
- `OdTerminu` = 0 — Od terminu
- `OdDatyWykonania` = 1
