# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFUPO`
Nazwa tabeli: `KSeFUPOs`
Tytuł: KSeF UPO
Opis: Urzędowe potwierdzenia odbioru (UPO) z Krajowego Systemu e-Faktur. Przechowuje numer referencyjny sesji, numer UPO, treść potwierdzenia oraz powiązanie z dokumentem, którego dotyczy.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  | Data sesji |
| Dokument | `Soneta.Core.IKomunikatKSeFHost` | bazodanowe | Dokument | Dokument, którego dotyczy UPO |
| UPO | `Soneta.Business.MemoText` | bazodanowe |  | Urzędowe potwierdzenie odbioru |
| sessionReferenceNumber | `string` | bazodanowe |  | Numer referencyjny sesji |
| upoReferenceNumber | `string` | bazodanowe |  | Numer referencyjny UPO |
