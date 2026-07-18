# Pola i właściwości klasy biznesowej: `Soneta.Kadry.DefinicjaSzkoleniaBHP`
Nazwa tabeli: `DefSzkolenBHP`
Tytuł: Definicje szkoleń BHP
Opis: Definicja typu szkolenia BHP (wstępne, okresowe, stanowiskowe). Określa cykliczność szkoleń, termin kolejnego szkolenia, powiązanie z następną definicją oraz sposób wyliczania terminu ważności.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IManagedRowDefinion`, `IZklPozycjaSlownika`, `IPozycjaKonfiguratora`

- pola bazodanowe (zapisywalne): 9
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 8
- podlisty: 4
- subrowy: 0
- razem: 21

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Cykliczne | `bool` | bazodanowe |  |  |
| GrupaKSU | `Soneta.HR.ZKL.Slowniki.KSU.GrupaSzkolenIUprawnien` | bazodanowe | Grupa KSU |  |
| GrupaNazwa | `string` | tylko-odczyt |  |  |
| GrupyStanowiskDisplay | `string` | tylko-odczyt |  |  |
| Kategoria | `string` | tylko-odczyt |  |  |
| KategoriaDisplay | `string` | tylko-odczyt |  |  |
| Kreatory | `SubTable<Soneta.Core.ManagedRowCreator>` | podlista |  |  |
| KsuCelSzkolenia | `string` | tylko-odczyt |  |  |
| KsuGrupyStanowisk | `Soneta.HR.GrupaStanowisk[]` | podlista | Grupy stanowisk |  |
| KsuObszaryFunkcjonalne | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.ObszarFunkcjonalny[]` | podlista | Obszary funkcjonalne |  |
| KsuSzkoleniaPoprzedzajace | `Soneta.Kadry.DefinicjaSzkoleniaBHP[]` | podlista | Szkolenie poprzedzające |  |
| KsuTyp | `Soneta.HR.ZKL.Enums.KsuPozycjaTyp` (enum) | tylko-odczyt |  |  |
| NastepneDefinicja | `Soneta.Kadry.DefinicjaSzkoleniaBHP` | bazodanowe |  |  |
| NastepneTermin | `int` | bazodanowe |  |  |
| NastepneTerminOd | `Soneta.Kadry.SposóbWyliczaniaTerminu` (enum) | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| ObszaryFunkcjonalneDisplay | `string` | tylko-odczyt |  |  |
| PoprzedzajaceDisplay | `string` | tylko-odczyt |  |  |
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
