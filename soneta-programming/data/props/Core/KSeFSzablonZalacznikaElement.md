# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFSzablonZalacznikaElement`
Nazwa tabeli: `KSeFSzblZalElem`
Tytuł: Element szablonu załącznika KSeF
Opis: Zawiera listę elementów szablonów załączników zdefiniowanych dla konkretnych szablonów. Przechowuje informację o typie elementu załącznika oraz sposobie zwracania przez niego danych przy eksporcie do KSeF.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 15
- pola kalkulowane (zapisywalne): 6
- pola tylko-odczyt: 7
- podlisty: 7
- subrowy: 1
- razem: 36

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktualnaWartoscWiersza | `object` |  |  |  |
| AktywnyAlgorytmWidocznosci | `bool` | bazodanowe | Czy aktywny kod widoczności | Czy aktywny kod widoczności. |
| AlgorytmEksportu | `MemoText` | bazodanowe, podlista | Algorytm eksportu elementu załącznika KSeF | Algorytm eksportu elementu załącznika KSeF |
| AlgorytmEksportuEdytor | `Compiler.ICodeEditorSource` |  |  |  |
| AlgorytmWidocznosci | `MemoText` | bazodanowe, podlista | Własny algorytm widoczności dla elementu załącznika KSeF | Własny algorytm widoczności dla elementu załącznika KSeF |
| AlgorytmWidocznosciEdytor | `Compiler.ICodeEditorSource` |  |  |  |
| DefaultFileName | `string` | tylko-odczyt |  |  |
| DefaultIdentifier | `string` | tylko-odczyt |  |  |
| DefaultProject | `Compiler.RuntimeProject` | tylko-odczyt |  |  |
| DefinicjaXmlNag | `Soneta.Core.DefXmlNag` |  |  |  |
| DefinicjaXmlNagGuid | `System.Guid` | bazodanowe | Identyfikator definicji komunikatu KSeF | Identyfikator definicji komunikatu KSeF |
| Documents | `System.Collections.Generic.IEnumerable<Compiler.IRuntimeDocument>` | podlista |  |  |
| DodatkoweAtrybuty | `string` | bazodanowe | Dodatkowe atrybuty elementu załącznika KSeF | Dodatkowe atrybuty elementu załącznika KSeF |
| DodatkoweAtrybutyDict | `System.Collections.Generic.Dictionary<string, string>` | podlista |  |  |
| DokumentBazowy | `Row` |  |  |  |
| IloscWierszy | `int` | tylko-odczyt |  |  |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa elementu. |
| Nadrzedny | `Soneta.Core.KSeFSzablonZalacznikaElement` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| PodgladAlgorytmuWyliczaniaWartosci | `string` | tylko-odczyt |  |  |
| Podrzedne | `SubTable<Soneta.Core.KSeFSzablonZalacznikaElement>` | podlista |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| SciezkaProperty | `string` | bazodanowe | Wskazanie pola dla wartosci elementu załącznika KSeF | Wskazanie pola dla wartosci elementu załącznika KSeF |
| SlownikWartosciWgLp | `System.Collections.Generic.Dictionary<int, object>` | podlista |  |  |
| SposobWyliczaniaWartosci | `Soneta.Core.Enums.SposobWyliczaniaWartosciElementuZalacznikaKSeF` (enum) | bazodanowe | Sposób obliczania wartości elementu: Wartość stała klucza, wartość pola obiektu bazowego, algorytm własny | Sposób obliczania wartości elementu: Wartość stała klucza, wartość pola obiektu bazowego, algorytm własny |
| SzablonZalacznika | `Soneta.Core.KSeFSzablonZalacznika` | bazodanowe, tylko-odczyt |  |  |
| TableNameBazowegoObiektu | `string` | bazodanowe | Nazwa tabeli obiektu bazowego | Nazwa tabeli obiektu bazowego. |
| TableNameZwracanegoObiektu | `string` | bazodanowe | Nazwa tabeli obiektu zwracanego | Nazwa tabeli obiektu zwracanego. |
| Typ | `Soneta.Core.Enums.TypElementuZalacznikaKSeF` (enum) | bazodanowe, tylko-odczyt | Typ elementu | Typ elementu |
| WartoscStala | `string` | bazodanowe | Wartość stała elementu załącznika KSeF | Wartość stała elementu załącznika KSeF |
| WyliczonaWartosc | `object` |  |  |  |
| ZwracaKolekcje | `bool` | bazodanowe | Czy obiekt zwracany jest kolekcją | Czy obiekt zwracany jest kolekcją. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SposobWyliczaniaWartosciElementuZalacznikaKSeF (`Soneta.Core.Enums.SposobWyliczaniaWartosciElementuZalacznikaKSeF`)
- `Brak` = 0
- `WartoscStala` = 10 — Wartość stała
- `WartoscProperty` = 20 — Wartość pola obiektu bazowego wg ścieżki
- `Algorytm` = 30 — Algorytm

### TypElementuZalacznikaKSeF (`Soneta.Core.Enums.TypElementuZalacznikaKSeF`)
- `Brak` = 0
- `BlokDanych` = 10 — Załącznik
- `NaglowekBlokuDanych` = 20 — Nagłówek załącznika
- `MetaDane` = 30 — Meta dane (klucz i wartość)
- `KluczMetaDanych` = 40 — Klucz
- `WartoscKluczaMetaDanych` = 50 — Wartość
- `Akapit` = 60 — Akapit
- `Tabela` = 70 — Tabela
- `OpisTabeli` = 80 — Opis tabeli
- `DaneTabeli` = 90 — Dane tabeli
- `Kolumna` = 100 — Kolumna
- `NaglowekKolumny` = 110 — Nagłówek kolumny
- `WartoscWiersza` = 120 — Wartość wiersza
- `PodsumowanieKolumny` = 130 — Podsumowanie kolumny
