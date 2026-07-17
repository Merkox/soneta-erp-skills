# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFPackage`
Nazwa tabeli: `KSeFPackages`
Tytuł: Paczki dokumentów wysyłanych do KSeF
Opis: Paczka grupująca dokumenty do wysyłki do Krajowego Systemu e-Faktur. Zawiera datę utworzenia paczki. Elementy paczki (dokumenty) przechowywane są w tabeli KSeFPackageElem.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 1
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Date | `Soneta.Types.Date` | bazodanowe | Data | Data utworzenia paczki |
| Elements | `Soneta.Business.SubTable<Soneta.Core.KSeFPackageElem>` |  |  |  |
| Logs | `System.Collections.Generic.List<Soneta.Core.KSeFPackagesForWorkflowLog>` |  |  |  |
