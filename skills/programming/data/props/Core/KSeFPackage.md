# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFPackage`
Nazwa tabeli: `KSeFPackages`
Tytuł: Paczki dokumentów wysyłanych do KSeF
Opis: Paczka grupująca dokumenty do wysyłki do Krajowego Systemu e-Faktur. Zawiera datę utworzenia paczki. Elementy paczki (dokumenty) przechowywane są w tabeli KSeFPackageElem.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Date | `Date` | bazodanowe | Data | Data utworzenia paczki |
| Elements | `SubTable<Soneta.Core.KSeFPackageElem>` | podlista |  |  |
| Logs | `System.Collections.Generic.List<Soneta.Core.KSeFPackagesForWorkflowLog>` | podlista |  |  |
