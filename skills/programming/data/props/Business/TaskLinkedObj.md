# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.TaskLinkedObj`
Nazwa tabeli: `TaskLinkedObjs`
Tytuł: Kolekcja obiektów do których task będzie podpięty.
Opis: Powiązanie zadania z dodatkowymi obiektami biznesowymi. Umożliwia wielowidoczność — wyświetlanie jednego zadania przy wielu powiązanych obiektach.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| IsParent | `bool` | bazodanowe, tylko-odczyt |  | Określa czy obiekt podpięty do taska jest obiektem głównym taska. |
| LinkedObject | `IGuidedRow` | bazodanowe, tylko-odczyt | Obiekt typu GuidedRow | Obiekt typu GuidedRow podpięty do taska. |
| Task | `Db.Task` | bazodanowe, tylko-odczyt | Obiekt taska | Task do którego podpinane są obiekty. |
