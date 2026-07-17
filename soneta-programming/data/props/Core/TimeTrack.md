# Pola i właściwości klasy biznesowej: `Soneta.Core.TimeTrack`
Nazwa tabeli: `TimeTracks`
Tytuł: Rejestracja pracy hybrydowej
Opis: Rejestracja czasu pracy hybrydowej (zdalnej). Przechowuje informację o wykonującym, dacie, czasie rozpoczęcia i wykonania, uwagach, oznaczeniu pracy twórczej, rozliczeniu oraz opcjonalnym powiązaniu z obiektem źródłowym.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllDayEvent | `bool` |  |  |  |
| Context | `Soneta.Business.Context` |  |  |  |
| CzasRozpoczecia | `Soneta.Types.Time` | bazodanowe |  |  |
| CzasWykonania | `Soneta.Types.Time` | bazodanowe |  |  |
| CzasZakonczenia | `Soneta.Types.Time` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Description | `string` |  |  |  |
| End | `System.DateTime` |  |  |  |
| Host | `Soneta.Core.ITimeTrackHost` |  |  |  |
| HostGuid | `System.Guid` | bazodanowe |  |  |
| HostType | `string` | bazodanowe |  |  |
| PracaAutorska | `bool` |  |  |  |
| PracaTworcza | `bool` | bazodanowe |  |  |
| Resource | `object` |  |  |  |
| Rozliczone | `bool` | bazodanowe |  |  |
| Settings | `Soneta.Business.SchedulerSettings` |  |  |  |
| Start | `System.DateTime` |  |  |  |
| Text | `string` |  |  |  |
| TimeTracks | `Soneta.Business.SubTable` |  |  |  |
| Uwagi | `string` | bazodanowe |  |  |
| Wykonujacy | `Soneta.Business.IWykonujacy` | bazodanowe |  |  |
