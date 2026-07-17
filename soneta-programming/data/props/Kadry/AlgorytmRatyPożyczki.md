# Pola i właściwości klasy biznesowej: `Soneta.Kadry.AlgorytmRatyPożyczki`
Nazwa tabeli: `AlgRatPozyczek`
Tytuł: Algorytmy rat pożyczek
Opis: Definicja algorytmu wyliczania rat pożyczki pracowniczej. Zawiera nazwę, algorytm obliczeniowy (jako skrypt) oraz opcję stosowania stopy procentowej z ustawień pożyczki.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| StopaWgPozyczki | `bool` | bazodanowe | Stopa procentowa wg pożyczki |  |
