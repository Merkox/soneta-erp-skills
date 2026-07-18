# Pola i właściwości klasy biznesowej: `Soneta.Core.DbTuples.DbTupleRel`
Nazwa tabeli: `TuplesRelations`
Tytuł: Relacje dokumentów dodatkowych
Opis: Relacja dokumentu dodatkowego z obiektem biznesowym. Powiązuje dokument dodatkowy (DbTuple) z dowolnym rekordem systemu na podstawie definicji pola, z oznaczeniem czy jest to relacja podstawowa.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `DbTuple` → `DbTuple`

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DbTuple | `Soneta.Core.DbTuples.DbTuple` | bazodanowe, tylko-odczyt, guided-parent | Zdarzenie | Zdarzenie |
| Definicja | `Runtime.RuntimeFieldDefinition` | bazodanowe, tylko-odczyt | Definicja | Definicja pola dokumentu |
| Host | `IGuidedRow` | bazodanowe | Rekord | Rekord powiązany |
| Podstawowa | `bool` | bazodanowe, tylko-odczyt | Podstawowa | Relacja podstawowa |
