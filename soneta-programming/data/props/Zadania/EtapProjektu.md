# Pola i właściwości klasy biznesowej: `Soneta.Zadania.EtapProjektu`
Nazwa tabeli: `EtapyProjektu`
Tytuł: Etapy projektu CRM
Opis: Element szczegółowy projektu (Projekt). Rzeczywisty etap realizacji projektu CRM z nazwą, datami, czasem trwania, osobą odpowiedzialną i stopniem realizacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Projekt` → `Projekt`

- pola bazodanowe (zapisywalne): 9
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 3
- podlisty: 3
- subrowy: 0
- razem: 16

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Zablokowany | Określa zablokowanie etapu. Zablokowane etapy dokumentów nie będą wyświetlane w liście wyboru. |
| CzasTrwania | `int` | bazodanowe | Czas trwania etapu | Czas trwania etapu. |
| DataDo | `Date` |  |  |  |
| DataOd | `Date` | bazodanowe | Data od |  |
| EtapyProjektu | `SubTable<Soneta.Zadania.EtapWykonujacy>` | podlista |  |  |
| Ident | `int` | bazodanowe | Identyfikator | Identyfikator etapu na definicji projektu. Wykorzystywany w relacji do projektu. |
| IsFirst | `bool` | tylko-odczyt |  |  |
| IsLast | `bool` | tylko-odczyt |  |  |
| Kod | `string` | tylko-odczyt |  |  |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa etapu w ramach projektu. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa etapu projektu |
| Projekt | `Soneta.Zadania.Projekt` | bazodanowe, guided-parent |  | Projekt, do której jest przypisany ten etap |
| Prowadzacy | `App.Operator` | bazodanowe | Odpowiedzialny | Osoba odpowiedzialna za prowadzenie projektu. |
| Realizacja | `Percent` | bazodanowe | Realizacja | Stopień realizacji projektu na wskazanym etapie. |
| WykonujacyEtap | `App.Operator[]` | podlista |  |  |
| Zadania | `View` | podlista |  |  |
