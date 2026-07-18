# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFSzablonZalacznikaDefXmlNagRelation`
Nazwa tabeli: `KSeFSzblZalDefs`
Tytuł: Status aktywności szablonu dla definicji eksportu XML
Opis: Zawiera listę powiązań szablonów załączników do definicji eksportu do KSeF. Zawiera informację o statusie aktywności szablonu dla danej definicji.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe | Aktywny dla definicji | Aktywny dla definicji |
| DefinicjaXmlNagGuid | `System.Guid` | bazodanowe | Identyfikator definicji komunikatu KSeF | Identyfikator definicji komunikatu KSeF |
| SzablonZalacznika | `Soneta.Core.KSeFSzablonZalacznika` | bazodanowe, tylko-odczyt |  |  |
