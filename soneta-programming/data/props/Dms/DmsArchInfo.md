# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.IK.DmsArchInfo`
Nazwa tabeli: `DmsArchInfos`
Tytuł: Informacje o archiwum dokumentów
Opis: Tabela zawiera dane dotyczące parametrów, które określają stan dokumentów podstawowych oraz spraw. Służy do określenia czy dany obiekt ma ustawiony parametr W archiwum lub Zbrakowano. Na podstawie przypisanego parametru dokumenty oraz sprawy są wyświetlane na odpowiedniej liście w module DMS.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Host | `Soneta.Workflow.Dms.IK.Interfaces.IDmsArchInfoHost` | bazodanowe, iface-ref | Host | Obiekt hostujący relację archiwum |
| IsArchived | `bool` | bazodanowe | W archiwum | Flaga archiwizacji obiektu |
| IsDisposed | `bool` | bazodanowe | Zbrakowane | Flaga zbrakowania obiektu |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IDmsArchInfoHost` | `BasicDocument`, `ChronoOrderElem`, `Matter` |
