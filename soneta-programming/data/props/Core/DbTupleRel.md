# Pola i właściwości klasy biznesowej: `Soneta.Core.DbTuples.DbTupleRel`
Nazwa tabeli: `TuplesRelations`
Tytuł: Relacje dokumentów dodatkowych
Opis: Relacja dokumentu dodatkowego z obiektem biznesowym. Powiązuje dokument dodatkowy (DbTuple) z dowolnym rekordem systemu na podstawie definicji pola, z oznaczeniem czy jest to relacja podstawowa.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `DbTuple` → `DbTuple`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DbTuple | `Soneta.Core.DbTuples.DbTuple` | bazodanowe, guided-parent | Zdarzenie | Zdarzenie |
| Definicja | `Soneta.Business.Runtime.RuntimeFieldDefinition` | bazodanowe | Definicja | Definicja pola dokumentu |
| Host | `Soneta.Business.IGuidedRow` | bazodanowe | Rekord | Rekord powiązany |
| Podstawowa | `bool` | bazodanowe | Podstawowa | Relacja podstawowa |
