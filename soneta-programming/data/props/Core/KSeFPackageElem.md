# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFPackageElem`
Nazwa tabeli: `KSeFPackageElems`
Tytuł: Elementy paczek wysyłanych do KSeF
Opis: Tabela przechowuje elementy paczek wysyłanych do Krajowego Systemu e-Faktur. Każdy element reprezentuje pojedynczy dokument skierowany do wysyłki w ramach konkretnej paczki KSeF.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Document | `Soneta.Core.IKomunikatKSeFHost` | bazodanowe | Dokument | Dokument skierowany do wysyłki do KSeF |
| Package | `Soneta.Core.KSeFPackage` | bazodanowe | Paczka wysyłki do KSeF | Paczka, w której dokument jest skierowany do wysyłki do KSeF. |
