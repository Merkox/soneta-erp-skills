# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.IK.DmsArchInfo`
Nazwa tabeli: `DmsArchInfos`
Tytuł: Informacje o archiwum dokumentów
Opis: Tabela zawiera dane dotyczące parametrów, które określają stan dokumentów podstawowych oraz spraw. Służy do określenia czy dany obiekt ma ustawiony parametr W archiwum lub Zbrakowano. Na podstawie przypisanego parametru dokumenty oraz sprawy są wyświetlane na odpowiedniej liście w module DMS.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Host | `Soneta.Workflow.Dms.IK.Interfaces.IDmsArchInfoHost` | bazodanowe, tylko-odczyt, iface-ref | Host | Obiekt hostujący relację archiwum |
| IsArchived | `bool` | bazodanowe, tylko-odczyt | W archiwum | Flaga archiwizacji obiektu |
| IsDisposed | `bool` | bazodanowe, tylko-odczyt | Zbrakowane | Flaga zbrakowania obiektu |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IDmsArchInfoHost` | `BasicDocument`, `ChronoOrderElem`, `Matter` |
