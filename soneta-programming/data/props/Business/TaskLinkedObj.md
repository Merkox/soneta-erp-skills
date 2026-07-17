# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.TaskLinkedObj`
Nazwa tabeli: `TaskLinkedObjs`
Tytuł: Kolekcja obiektów do których task będzie podpięty.
Opis: Powiązanie zadania z dodatkowymi obiektami biznesowymi. Umożliwia wielowidoczność — wyświetlanie jednego zadania przy wielu powiązanych obiektach.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| IsParent | `bool` | bazodanowe |  | Określa czy obiekt podpięty do taska jest obiektem głównym taska. |
| LinkedObject | `Soneta.Business.IGuidedRow` | bazodanowe | Obiekt typu GuidedRow | Obiekt typu GuidedRow podpięty do taska. |
| Task | `Soneta.Business.Db.Task` | bazodanowe | Obiekt taska | Task do którego podpinane są obiekty. |
