# Pola i właściwości klasy biznesowej: `Soneta.HR.DefinicjaUprawnienia`
Nazwa tabeli: `DefUprawnien`
Tytuł: Definicje uprawnień
Opis: Definicja konkretnego typu uprawnienia pracowniczego. Określa kategorię, okres ważności, wymagalność numeru oraz czy uprawnienie jest bezterminowe, stanowiąc szablon do rejestracji uprawnień pracowników.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IManagedRowDefinion`, `IZklPozycjaSlownika`, `IPozycjaKonfiguratora`

- pola bazodanowe (zapisywalne): 13
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 6
- podlisty: 4
- subrowy: 0
- razem: 25

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bezterminowe | `bool` | bazodanowe |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| GrupaKSU | `Soneta.HR.ZKL.Slowniki.KSU.GrupaSzkolenIUprawnien` | bazodanowe | Grupa KSU |  |
| GrupaNazwa | `string` | tylko-odczyt |  |  |
| GrupyStanowiskDisplay | `string` | tylko-odczyt |  |  |
| Kategoria | `Soneta.HR.KategoriaUprawnienia` | bazodanowe |  |  |
| KategoriaDisplay | `string` | tylko-odczyt |  |  |
| Kreatory | `SubTable<Soneta.Core.ManagedRowCreator>` | podlista |  |  |
| KsuCelSzkolenia | `string` |  |  |  |
| KsuGrupyStanowisk | `Soneta.HR.GrupaStanowisk[]` | podlista | Grupy stanowisk |  |
| KsuObszaryFunkcjonalne | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.ObszarFunkcjonalny[]` | podlista | Obszary funkcjonalne |  |
| KsuSzkoleniaPoprzedzajace | `Soneta.HR.DefinicjaSzkolenia[]` | podlista | Szkolenia poprzedzające |  |
| KsuTyp | `Soneta.HR.ZKL.Enums.KsuPozycjaTyp` (enum) | tylko-odczyt |  |  |
| KsuUprawnieniePoprzedzajace | `Soneta.HR.DefinicjaUprawnienia` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| ObszaryFunkcjonalneDisplay | `string` | tylko-odczyt |  |  |
| Opis | `string` | bazodanowe |  |  |
| Ostrzezenie | `int` | bazodanowe |  |  |
| PoprzedzajaceDisplay | `string` | tylko-odczyt |  |  |
| Symbol | `string` | bazodanowe | Symbol |  |
| TylkoPosrednio | `bool` | bazodanowe | Utwórz tylko pośrednio |  |
| WaznyDoKoncaMiesiaca | `bool` | bazodanowe |  |  |
| WaznyLata | `int` | bazodanowe | Ważny lata |  |
| WaznyMiesiace | `int` | bazodanowe | Ważny miesiące |  |
| WymaganyNumer | `bool` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KsuPozycjaTyp (`Soneta.HR.ZKL.Enums.KsuPozycjaTyp`)
- `None` = 0 — Brak
- `Szkolenie` = 10 — Szkolenie
- `Uprawnienie` = 20 — Uprawnienie
- `SzkolenieBhp` = 30 — Szkolenie BHP
