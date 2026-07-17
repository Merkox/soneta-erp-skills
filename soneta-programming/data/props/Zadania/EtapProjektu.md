# Pola i właściwości klasy biznesowej: `Soneta.Zadania.EtapProjektu`
Nazwa tabeli: `EtapyProjektu`
Tytuł: Etapy projektu CRM
Opis: Element szczegółowy projektu (Projekt). Rzeczywisty etap realizacji projektu CRM z nazwą, datami, czasem trwania, osobą odpowiedzialną i stopniem realizacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Projekt` → `Projekt`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Zablokowany | Określa zablokowanie etapu. Zablokowane etapy dokumentów nie będą wyświetlane w liście wyboru. |
| CzasTrwania | `int` | bazodanowe | Czas trwania etapu | Czas trwania etapu. |
| DataDo | `Soneta.Types.Date` |  |  |  |
| DataOd | `Soneta.Types.Date` | bazodanowe | Data od |  |
| EtapyProjektu | `Soneta.Business.SubTable<Soneta.Zadania.EtapWykonujacy>` |  |  |  |
| Ident | `int` | bazodanowe | Identyfikator | Identyfikator etapu na definicji projektu. Wykorzystywany w relacji do projektu. |
| IsFirst | `bool` |  |  |  |
| IsLast | `bool` |  |  |  |
| Kod | `string` |  |  |  |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa etapu w ramach projektu. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa etapu projektu |
| Projekt | `Soneta.Zadania.Projekt` | bazodanowe, guided-parent |  | Projekt, do której jest przypisany ten etap |
| Prowadzacy | `Soneta.Business.App.Operator` | bazodanowe | Odpowiedzialny | Osoba odpowiedzialna za prowadzenie projektu. |
| Realizacja | `Soneta.Types.Percent` | bazodanowe | Realizacja | Stopień realizacji projektu na wskazanym etapie. |
| WykonujacyEtap | `Soneta.Business.App.Operator[]` |  |  |  |
| Zadania | `Soneta.Business.View` |  |  |  |
