# Pola i właściwości klasy biznesowej: `Soneta.PracaZdalna.RCP.Models.Database.DefinicjaWerRCP`
Nazwa tabeli: `DefinicjeWerRCP`
Tytuł: Definicje weryfikatorow rejestracji czasu pracy
Opis: Szablon weryfikatora rejestracji czasu pracy. Definiuje reguły walidacji i algorytmy kontrolne sprawdzające poprawność danych ewidencji czasu pracy pracowników.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktywnyAlgorytmWeryfikacji | `bool` |  |  |  |
| AlgorytmWeryfikacji | `Soneta.PracaZdalna.RCP.Models.Database.AlgorytmWer` | bazodanowe |  | Algorytm weryfikacji dla definicji weryfikatorów rejestracji czasu pracy |
| AlgorytmWeryfikacji.Aktywny | `bool` | bazodanowe |  | Określa czy istnieje algorytm dla definicji rejestracji czasu pracy |
| AlgorytmWeryfikacji.Kod | `Soneta.Business.MemoText` | bazodanowe | Kod algorytmu | Kod algorytmów dla rejestracji czasu pracy |
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. Zablokowane definicje weryfikatorów rejestracji czasu pracy nie będą wyświetlane w liście wyboru. |
| ClassName | `string` |  |  |  |
| KodAlgorytmuWeryfikacji | `Soneta.Business.MemoText` |  |  |  |
| Namespace | `object` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Pełna nazwa definicji weryfikatora rejestracji czasu pracy |
| Opis | `string` | bazodanowe | Opis | Opis definicji weryfikatora rejestracji czasu pracy |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
