# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFSzablonPolOpcjonalnychDefXmlNagStatus`
Nazwa tabeli: `KSeFSzblPolOpDef`
Tytuł: Status aktywności szablonu dla definicji eksportu XML
Opis: Element szczegółowy szablonu pól opcjonalnych KSeF (KSeFSzablonPolOpcjonalnych). Określa status aktywności szablonu dla poszczególnych definicji eksportu XML. Pozwala włączać lub wyłączać dany szablon w kontekście konkretnej definicji komunikatu e-faktury, umożliwiając selektywne stosowanie pól opcjonalnych do wybranych formatów eksportu.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe | Aktywny dla definicji | Aktywny dla definicji |
| DefinicjaXmlNagGuid | `System.Guid` | bazodanowe | Identyfikator definicji komunikatu KSeF | Identyfikator definicji komunikatu KSeF |
| SzablonPolOpcjonalnych | `Soneta.Core.KSeFSzablonPolOpcjonalnych` | bazodanowe |  |  |
