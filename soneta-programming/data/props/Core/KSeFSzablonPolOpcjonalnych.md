# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFSzablonPolOpcjonalnych`
Nazwa tabeli: `KSeFSzblPolOp`
Tytuł: Szablony pól opcjonalnych KSeF
Opis: Definicja szablonu pól opcjonalnych dla komunikatów Krajowego Systemu e-Faktur. Każdy szablon posiada unikalny kod, nazwę oraz opcję zastosowania pól dodatkowych. Szablony definiują zestaw pól opcjonalnych używanych podczas generowania e-faktur w formacie KSeF.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicje | `SubTable<Soneta.Core.KSeFSzablonPolOpcjonalnychDefXmlNagStatus>` | podlista |  |  |
| Kod | `string` | bazodanowe |  | Kod szablonu |
| Nazwa | `string` | bazodanowe | Nazwa szablonu | Nazwa identyfikatora |
| Pozycje | `SubTable<Soneta.Core.KSeFSzablonPolOpcjonalnychPozycja>` | podlista |  |  |
| SzablonZalacznika | `Soneta.Core.KSeFSzablonZalacznika` | bazodanowe |  |  |
| ZastosujPolaDodatkowe | `bool` | bazodanowe | Zastosuj pola dodatkowe |  |
