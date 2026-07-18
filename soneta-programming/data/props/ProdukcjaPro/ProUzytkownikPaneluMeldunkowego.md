# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProUzytkownikPaneluMeldunkowego`
Nazwa tabeli: `ProUzytkownicyPM`
Tytuł: Użytkownicy paneli meldunkowych
Opis: Słownik użytkowników panelu meldunkowego produkcji. Definiuje uprawnienia operatorów do raportowania wykonania na panelu produkcyjnym, wraz z przypisaniem do zasobów i dozwolonych operacji.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IWebOperator`, `ITaskUser`

- pola bazodanowe (zapisywalne): 27
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 3
- subrowy: 0
- razem: 30

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dokumentacja | `bool` | bazodanowe |  | Aktywna zakładka dokumentacji panelu meldunkowego. |
| FiltrCechyDefinicja | `FeatureDefinition` | bazodanowe | Filtr definicji cechy | Filtr definicji cechy panelu meldunkowego dla użytkownika. |
| FiltrCechyWartosc | `string` | bazodanowe | Filtr wartości cechy | Filtr wartości cechy panelu meldunkowego dla użytkownika. |
| FiltrDefinicjiOperacji | `Soneta.ProdukcjaPro.ProDefinicjaOperacji` | bazodanowe | Filtr definicji operacji | Filtr definicji operacji panelu meldunkowego dla użytkownika. |
| FiltrDefinicjiOperacjiEdycja | `bool` | bazodanowe | Edycja filtru definicji operacji | Edycja filtru definicji operacji panelu meldunkowego dla użytkownika. |
| FiltrGniazda | `Soneta.ProdukcjaPro.ProZasob` | bazodanowe | Filtr gniazda | Filtr gniazda panelu meldunkowego dla użytkownika. |
| FiltrGniazdaEdycja | `bool` | bazodanowe | Edycja filtru gniazda | Edycja filtru gniazda panelu meldunkowego dla użytkownika. |
| FiltrJednostkiRoboczej | `Soneta.ProdukcjaPro.ProZasob` | bazodanowe | Filtr jednostki roboczej | Filtr jednostki roboczej panelu meldunkowego dla użytkownika. |
| FiltrJednostkiRoboczejEdycja | `bool` | bazodanowe | Edycja filtru jednostki roboczej | Edycja filtru jednostki roboczej panelu meldunkowego dla użytkownika. |
| FiltrSkanowania | `bool` | bazodanowe | Filtr skanowania | Filtr skanowania panelu meldunkowego dla użytkownika. |
| FiltrWydzialu | `Soneta.ProdukcjaPro.ProWydzial` | bazodanowe | Filtr wydziału | Filtr wydziału panelu meldunkowego dla użytkownika. |
| FiltrWydzialuEdycja | `bool` | bazodanowe | Edycja filtru wydziału | Edycja filtru wydziału panelu meldunkowego dla użytkownika. |
| Kod | `string` | bazodanowe |  | Kod użytkownika panelu meldunkowego. |
| Nazwa | `string` | bazodanowe |  | Nazwa użytkownika panelu meldunkowego. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis użytkownika panelu meldunkowego. |
| PoświadczeniaOdbioru | `SubTable<Soneta.Core.PoświadczenieOdbioru>` | podlista |  |  |
| Raportowanie | `bool` | bazodanowe |  | Aktywna zakładka raportowania panelu meldunkowego. |
| RaportowanieWJednostce | `bool` | bazodanowe |  | Aktywne pole jednostki na ekranie raportowania panelu meldunkowego. |
| Realizacja | `bool` | bazodanowe |  | Aktywna zakładka realizacji panelu meldunkowego. |
| RealizacjaRozliczMaterialy | `bool` | bazodanowe | Rozlicz materiały | Rozlicz materiały panelu meldunkowego. |
| RealizacjaRozliczMeldunek | `bool` | bazodanowe | Rozlicz meldunek | Rozlicz meldunek panelu meldunkowego. |
| RealizacjaRozliczOdpady | `bool` | bazodanowe | Rozlicz odpady | Rozlicz odpady panelu meldunkowego. |
| RealizacjaRozliczWyroby | `bool` | bazodanowe | Rozlicz wyroby | Rozlicz wyroby panelu meldunkowego. |
| RealizacjaZmianaIlosciMeldunku | `bool` | bazodanowe | Zmiana ilości meldunku | Zmiana ilości meldunku panelu meldunkowego. |
| Rejestracja | `bool` | bazodanowe |  | Aktywna zakładka rejestracji panelu meldunkowego. |
| RejestracjaRaportuj | `bool` | bazodanowe | Rejestracja raportuj | Aktywny przycisk Raportuj na zakładce rejestracji panelu meldunkowego. |
| TypZalacznika | `Soneta.ProdukcjaPro.ProTypZalacznika` (enum) | bazodanowe | Typ załącznika | Typ załącznika panelu meldunkowego. |
| WyborDostaw | `Soneta.ProdukcjaPro.ProWyborDostaw` (enum) | bazodanowe | Wybór dostaw | Wybór dostaw na ekranie raportowania panelu meldunkowego. |
| WyborOperacji | `bool` | bazodanowe | Wybór operacji | Wybór operacji na ekranie raportowania panelu meldunkowego. |
| ZgloszSygnalisty | `SubTable<Soneta.Kadry.ZgloszenieSygnalisty>` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProTypZalacznika (`Soneta.ProdukcjaPro.ProTypZalacznika`)
- `None` = 0
- `Towar` = 1
- `Zasob` = 2 — Zasób
- `Operacja` = 4
- `Technologia` = 8
- `Zlecenie` = 16
- `All` = 31 — Wszystkie

### ProWyborDostaw (`Soneta.ProdukcjaPro.ProWyborDostaw`)
- `None` = 0
- `Brak` = 1
- `Zasoby` = 2
- `Partie` = 4
- `Razem` = 8
- `All` = 15 — Wszystkie
