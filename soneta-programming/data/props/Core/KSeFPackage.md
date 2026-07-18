# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFPackage`
Nazwa tabeli: `KSeFPackages`
Tytuł: Paczki dokumentów wysyłanych do KSeF
Opis: Paczka grupująca dokumenty do wysyłki do Krajowego Systemu e-Faktur. Zawiera datę utworzenia paczki. Elementy paczki (dokumenty) przechowywane są w tabeli KSeFPackageElem.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 2
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Date | `Date` | bazodanowe | Data | Data utworzenia paczki |
| Elements | `SubTable<Soneta.Core.KSeFPackageElem>` | podlista |  |  |
| Logs | `System.Collections.Generic.List<Soneta.Core.KSeFPackagesForWorkflowLog>` | podlista |  |  |
