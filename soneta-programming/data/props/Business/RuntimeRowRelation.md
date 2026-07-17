# Pola i właściwości klasy biznesowej: `Soneta.Business.Runtime.RuntimeRowRelation`
Nazwa tabeli: `RuntimeRowRels`
Tytuł: Relacje wierszy runtime
Opis: Powiązanie wiersza dynamicznego (runtime) z rekordem biznesowym. Umożliwia tworzenie relacji między zdarzeniami a obiektami z modułów programu.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definition | `Soneta.Business.Runtime.RuntimeFieldDefinition` | bazodanowe | Definicja | Definicja pola dokumentu |
| Host | `Soneta.Business.IGuidedRow` | bazodanowe | Rekord powiązany | Rekord powiązany |
| Primary | `bool` | bazodanowe | Podstawowa | Relacja podstawowa |
| RuntimeRowHost | `Soneta.Business.Runtime.IRuntimeRow` | bazodanowe | Wiersz runtime | Wiersz runtime |
