# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFSzablonPolOpcjonalnychPozycja`
Nazwa tabeli: `KSeFSzblPolOpPoz`
Tytuł: Pozycja szablonu pól opcjonalnych KSeF
Opis: Element szczegółowy szablonu pól opcjonalnych KSeF (KSeFSzablonPolOpcjonalnych). Każda pozycja definiuje konkretny element komunikatu e-faktury z jego typem, wartością stałą lub cechą oraz algorytmem eksportu i widoczności. Pozycje określają sposób wypełniania opcjonalnych pól w strukturze XML komunikatu KSeF.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 16
- pola kalkulowane (z klas biznesowych): 17

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktywnyAlgorytmKluczaPolaDodatkowego | `bool` |  |  |  |
| AktywnyAlgorytmWartosciPolaDodatkowego | `bool` |  |  |  |
| AktywnyKodWidocznosci | `bool` | bazodanowe | Czy aktywny kod widoczności | Czy aktywny kod widoczności. |
| AlgorytmExportuEdytor | `Soneta.Business.Compiler.ICodeEditorSource` |  |  |  |
| AlgorytmExportuPodglad | `string` |  |  |  |
| AlgorytmKluczaPolaDodatkowego | `string` |  |  |  |
| AlgorytmKluczaPolaDodatkowegoEdytor | `Soneta.Business.Compiler.ICodeEditorSource` |  |  |  |
| AlgorytmWartosciPolaDodatkowego | `string` |  |  |  |
| AlgorytmWartosciPolaDodatkowegoEdytor | `Soneta.Business.Compiler.ICodeEditorSource` |  |  |  |
| AlgorytmWidocznosciEdytor | `Soneta.Business.Compiler.ICodeEditorSource` |  |  |  |
| AlgorytmWidocznosciPodglad | `string` |  |  |  |
| Cecha | `Soneta.Business.FeatureDefinition` | bazodanowe | Cecha | Cecha |
| CodeExport | `Soneta.Business.MemoText` | bazodanowe | Kod eksportu | Kod dla eksportu. |
| CodeVisible | `Soneta.Business.MemoText` | bazodanowe | Kod widoczności | Kod dla widoczności. |
| DefaultFileName | `string` |  |  |  |
| DefaultIdentifier | `string` |  |  |  |
| DefaultProject | `Soneta.Business.Compiler.RuntimeProject` |  |  |  |
| DefinicjaXmlElement | `Soneta.Core.DefXmlElem` |  |  |  |
| DefinicjaXmlElementGuid | `System.Guid` | bazodanowe | Identyfikator definicji elementu komunikatu KSeF | Identyfikator definicji elementu komunikatu KSeF |
| Documents | `System.Collections.Generic.IEnumerable<Soneta.Business.Compiler.IRuntimeDocument>` |  |  |  |
| Edycja | `bool` | bazodanowe | Edycja | Edycja algorytmu eksportu |
| Element | `string` | bazodanowe | Nazwa elementu komunikatu KSeF | Nazwa elementu komunikatu KSeF |
| PoleOpcjonalneDodatkowe | `Soneta.Core.Enums.PoleOpcjonalneDodatkoweKSeF` | bazodanowe, enum | Pole opcjonalne dodatkowe (klucz-wartość) | Pole opcjonalne dodatkowe (klucz-wartość) |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| SzablonPolOpcjonalnych | `Soneta.Core.KSeFSzablonPolOpcjonalnych` | bazodanowe |  |  |
| Typ | `Soneta.Core.Enums.PoleOpcjonalneTypKseF` | bazodanowe, enum | Typ pola opcjonalnego | Typ pola opcjonalnego |
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
