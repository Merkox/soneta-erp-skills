# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFSzablonZalacznika`
Nazwa tabeli: `KSeFSzblZal`
Tytuł: Szablon zalączników KSeF
Opis: Zawiera listę zdefiniowanych przez użytkowników szablonów załączników KSeF. Szablony są używane przy eksporcie dokumentów do KSeF generując odpowiednią strukturę w pliku XML.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicje | `Soneta.Business.SubTable<Soneta.Core.KSeFSzablonZalacznikaDefXmlNagRelation>` |  |  |  |
| Elementy | `Soneta.Business.SubTable<Soneta.Core.KSeFSzablonZalacznikaElement>` |  |  |  |
| Kod | `string` | bazodanowe |  | Kod szablonu |
| Nazwa | `string` | bazodanowe | Nazwa szablonu | Nazwa identyfikatora |
