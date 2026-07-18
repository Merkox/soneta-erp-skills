# Pola i właściwości klasy biznesowej: `Soneta.Zadania.EtapDefProjektu`
Nazwa tabeli: `EtapyDefProjektu`
Tytuł: Etapy definicji projektu CRM
Opis: Element szczegółowy definicji projektu (DefProjektu). Definiuje etap w szablonie projektu CRM z nazwą, kolejnością i domyślnym czasem trwania, na podstawie którego tworzone są rzeczywiste etapy na projektach.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Definicja` → `DefProjektu`

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 0
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzasTrwania | `int` | bazodanowe | Domyślny czas trwania etapu | Domyślny czas trwania etapu. |
| Definicja | `Soneta.Zadania.DefProjektu` | bazodanowe, tylko-odczyt, guided-parent |  | Definicja projektu, do której jest przypisany ten etap |
| Ident | `int` | bazodanowe, tylko-odczyt | Identyfikator | Identyfikator etapu na definicji projektu. Wykorzystywany w relacji do projektu. |
| Kod | `string` | tylko-odczyt |  |  |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa etapu w ramach projektu. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa etapu projektu |
| Realizacja | `Percent` | bazodanowe | Realizacja | Stopień realizacji projektu na wskazanym etapie. |
