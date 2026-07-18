# Pola i właściwości klasy biznesowej: `Soneta.PracaZdalna.RCP.Models.Database.DefinicjaWerRCP`
Nazwa tabeli: `DefinicjeWerRCP`
Tytuł: Definicje weryfikatorow rejestracji czasu pracy
Opis: Szablon weryfikatora rejestracji czasu pracy. Definiuje reguły walidacji i algorytmy kontrolne sprawdzające poprawność danych ewidencji czasu pracy pracowników.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 2
- podlisty: 3
- subrowy: 2
- razem: 15

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktywnyAlgorytmWeryfikacji | `bool` |  |  |  |
| AlgorytmWeryfikacji | `Soneta.PracaZdalna.RCP.Models.Database.AlgorytmWer` (subrow) | bazodanowe |  | Algorytm weryfikacji dla definicji weryfikatorów rejestracji czasu pracy |
| AlgorytmWeryfikacji.Aktywny | `bool` | bazodanowe |  | Określa czy istnieje algorytm dla definicji rejestracji czasu pracy |
| AlgorytmWeryfikacji.Kod | `MemoText` | bazodanowe, podlista | Kod algorytmu | Kod algorytmów dla rejestracji czasu pracy |
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. Zablokowane definicje weryfikatorów rejestracji czasu pracy nie będą wyświetlane w liście wyboru. |
| ClassName | `string` | tylko-odczyt |  |  |
| KodAlgorytmuWeryfikacji | `MemoText` | podlista |  |  |
| Namespace | `object` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Pełna nazwa definicji weryfikatora rejestracji czasu pracy |
| Opis | `string` | bazodanowe | Opis | Opis definicji weryfikatora rejestracji czasu pracy |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
