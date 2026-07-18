# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFSzablonPolOpcjonalnychPozycja`
Nazwa tabeli: `KSeFSzblPolOpPoz`
Tytuł: Pozycja szablonu pól opcjonalnych KSeF
Opis: Element szczegółowy szablonu pól opcjonalnych KSeF (KSeFSzablonPolOpcjonalnych). Każda pozycja definiuje konkretny element komunikatu e-faktury z jego typem, wartością stałą lub cechą oraz algorytmem eksportu i widoczności. Pozycje określają sposób wypełniania opcjonalnych pól w strukturze XML komunikatu KSeF.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 12
- pola kalkulowane (zapisywalne): 10
- pola tylko-odczyt: 6
- podlisty: 4
- subrowy: 1
- razem: 33

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktywnyAlgorytmKluczaPolaDodatkowego | `bool` |  |  |  |
| AktywnyAlgorytmWartosciPolaDodatkowego | `bool` |  |  |  |
| AktywnyKodWidocznosci | `bool` | bazodanowe | Czy aktywny kod widoczności | Czy aktywny kod widoczności. |
| AlgorytmExportuEdytor | `Compiler.ICodeEditorSource` |  |  |  |
| AlgorytmExportuPodglad | `string` | tylko-odczyt |  |  |
| AlgorytmKluczaPolaDodatkowego | `string` |  |  |  |
| AlgorytmKluczaPolaDodatkowegoEdytor | `Compiler.ICodeEditorSource` |  |  |  |
| AlgorytmWartosciPolaDodatkowego | `string` |  |  |  |
| AlgorytmWartosciPolaDodatkowegoEdytor | `Compiler.ICodeEditorSource` |  |  |  |
| AlgorytmWidocznosciEdytor | `Compiler.ICodeEditorSource` |  |  |  |
| AlgorytmWidocznosciPodglad | `string` | tylko-odczyt |  |  |
| Cecha | `FeatureDefinition` | bazodanowe | Cecha | Cecha |
| CodeExport | `MemoText` | bazodanowe, podlista | Kod eksportu | Kod dla eksportu. |
| CodeVisible | `MemoText` | bazodanowe, podlista | Kod widoczności | Kod dla widoczności. |
| DefaultFileName | `string` | tylko-odczyt |  |  |
| DefaultIdentifier | `string` | tylko-odczyt |  |  |
| DefaultProject | `Compiler.RuntimeProject` | tylko-odczyt |  |  |
| DefinicjaXmlElement | `Soneta.Core.DefXmlElem` |  |  |  |
| DefinicjaXmlElementGuid | `System.Guid` | bazodanowe | Identyfikator definicji elementu komunikatu KSeF | Identyfikator definicji elementu komunikatu KSeF |
| Documents | `System.Collections.Generic.IEnumerable<Compiler.IRuntimeDocument>` | podlista |  |  |
| Edycja | `bool` | bazodanowe | Edycja | Edycja algorytmu eksportu |
| Element | `string` | bazodanowe | Nazwa elementu komunikatu KSeF | Nazwa elementu komunikatu KSeF |
| PoleOpcjonalneDodatkowe | `Soneta.Core.Enums.PoleOpcjonalneDodatkoweKSeF` (enum) | bazodanowe | Pole opcjonalne dodatkowe (klucz-wartość) | Pole opcjonalne dodatkowe (klucz-wartość) |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| SzablonPolOpcjonalnych | `Soneta.Core.KSeFSzablonPolOpcjonalnych` | bazodanowe, tylko-odczyt |  |  |
| Typ | `Soneta.Core.Enums.PoleOpcjonalneTypKseF` (enum) | bazodanowe | Typ pola opcjonalnego | Typ pola opcjonalnego |
| Wartosc | `string` | bazodanowe |  | Wartość stała |
| WybranyWpisPolaDodatkowego | `Soneta.Core.KSeFSzablonPolOpcjonalnychPozycja.WybranyWpisPolaDodatkowegoSzablonuPolOpcjonalnych` |  |  |  |
| Wysylaj | `bool` | bazodanowe | Wysyłaj | Czy wysyłać element |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PoleOpcjonalneDodatkoweKSeF (`Soneta.Core.Enums.PoleOpcjonalneDodatkoweKSeF`)
- `Brak` = 0
- `Cecha` = 1
- `Opis` = 2 — Opis z dokumentu handlowego
- `IloscOpakowanZSystemuKaucyjnego` = 3 — Ilości opakowań z systemu kaucyjnego

### PoleOpcjonalneTypKseF (`Soneta.Core.Enums.PoleOpcjonalneTypKseF`)
- `Brak` = 0
- `PolePodstawowe` = 1
- `PoleDodatkowe` = 2
