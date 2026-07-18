# Pola i właściwości klasy biznesowej: `Soneta.Core.TimeTrack`
Nazwa tabeli: `TimeTracks`
Tytuł: Rejestracja pracy hybrydowej
Opis: Rejestracja czasu pracy hybrydowej (zdalnej). Przechowuje informację o wykonującym, dacie, czasie rozpoczęcia i wykonania, uwagach, oznaczeniu pracy twórczej, rozliczeniu oraz opcjonalnym powiązaniu z obiektem źródłowym.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllDayEvent | `bool` | tylko-odczyt |  |  |
| Context | `Context` | podlista |  |  |
| CzasRozpoczecia | `Time` | bazodanowe |  |  |
| CzasWykonania | `Time` | bazodanowe |  |  |
| CzasZakonczenia | `Time` |  |  |  |
| Data | `Date` | bazodanowe |  |  |
| Description | `string` | tylko-odczyt |  |  |
| End | `System.DateTime` | tylko-odczyt |  |  |
| Host | `Soneta.Core.ITimeTrackHost` |  |  |  |
| HostGuid | `System.Guid` | bazodanowe |  |  |
| HostType | `string` | bazodanowe |  |  |
| PracaTworcza | `bool` | bazodanowe |  |  |
| Resource | `object` | tylko-odczyt |  |  |
| Rozliczone | `bool` | bazodanowe |  |  |
| Settings | `SchedulerSettings` | tylko-odczyt |  |  |
| Start | `System.DateTime` | tylko-odczyt |  |  |
| Text | `string` |  |  |  |
| TimeTracks | `SubTable` | podlista |  |  |
| Uwagi | `string` | bazodanowe |  |  |
| Wykonujacy | `IWykonujacy` | bazodanowe |  |  |
