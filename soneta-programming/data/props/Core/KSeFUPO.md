# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFUPO`
Nazwa tabeli: `KSeFUPOs`
Tytuł: KSeF UPO
Opis: Urzędowe potwierdzenia odbioru (UPO) z Krajowego Systemu e-Faktur. Przechowuje numer referencyjny sesji, numer UPO, treść potwierdzenia oraz powiązanie z dokumentem, którego dotyczy.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  | Data sesji |
| Dokument | `Soneta.Core.IKomunikatKSeFHost` | bazodanowe | Dokument | Dokument, którego dotyczy UPO |
| UPO | `MemoText` | bazodanowe, podlista |  | Urzędowe potwierdzenie odbioru |
| sessionReferenceNumber | `string` | bazodanowe |  | Numer referencyjny sesji |
| upoReferenceNumber | `string` | bazodanowe |  | Numer referencyjny UPO |
