# Pola i właściwości klasy biznesowej: `Soneta.Kadry.AlgorytmRatyPożyczki`
Nazwa tabeli: `AlgRatPozyczek`
Tytuł: Algorytmy rat pożyczek
Opis: Definicja algorytmu wyliczania rat pożyczki pracowniczej. Zawiera nazwę, algorytm obliczeniowy (jako skrypt) oraz opcję stosowania stopy procentowej z ustawień pożyczki.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `MemoText` | bazodanowe, podlista |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| StopaWgPozyczki | `bool` | bazodanowe | Stopa procentowa wg pożyczki |  |
