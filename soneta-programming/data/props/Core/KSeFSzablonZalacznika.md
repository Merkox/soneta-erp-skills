# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFSzablonZalacznika`
Nazwa tabeli: `KSeFSzblZal`
Tytuł: Szablon zalączników KSeF
Opis: Zawiera listę zdefiniowanych przez użytkowników szablonów załączników KSeF. Szablony są używane przy eksporcie dokumentów do KSeF generując odpowiednią strukturę w pliku XML.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 2
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicje | `SubTable<Soneta.Core.KSeFSzablonZalacznikaDefXmlNagRelation>` | podlista |  |  |
| Elementy | `SubTable<Soneta.Core.KSeFSzablonZalacznikaElement>` | podlista |  |  |
| Kod | `string` | bazodanowe |  | Kod szablonu |
| Nazwa | `string` | bazodanowe | Nazwa szablonu | Nazwa identyfikatora |
