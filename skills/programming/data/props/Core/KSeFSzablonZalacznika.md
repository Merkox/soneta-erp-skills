# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFSzablonZalacznika`
Nazwa tabeli: `KSeFSzblZal`
Tytuł: Szablon zalączników KSeF
Opis: Zawiera listę zdefiniowanych przez użytkowników szablonów załączników KSeF. Szablony są używane przy eksporcie dokumentów do KSeF generując odpowiednią strukturę w pliku XML.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicje | `SubTable<Soneta.Core.KSeFSzablonZalacznikaDefXmlNagRelation>` | podlista |  |  |
| Elementy | `SubTable<Soneta.Core.KSeFSzablonZalacznikaElement>` | podlista |  |  |
| Kod | `string` | bazodanowe |  | Kod szablonu |
| Nazwa | `string` | bazodanowe | Nazwa szablonu | Nazwa identyfikatora |
