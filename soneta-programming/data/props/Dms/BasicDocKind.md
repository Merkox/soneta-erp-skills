# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.BasicDocKind`
Nazwa tabeli: `BasicDocKinds`
Tytuł: Rodzaje dokumentów podstawowych
Opis: Przechowuje zdefiniowane rodzaje dokumentów. Służy do kategoryzacji i określania rodzajów obiektów nadrzędnych (dokumentów podstawowych) w systemie.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Locked | `bool` | bazodanowe | Zablokowane | Rodzaj dokumentu zablokowana |
| Name | `string` | bazodanowe | Nazwa | Nazwa rodzaju dokumentu postawowego |
| Symbol | `string` | bazodanowe | Symbol | Symbol rodzaju dokumentu |
