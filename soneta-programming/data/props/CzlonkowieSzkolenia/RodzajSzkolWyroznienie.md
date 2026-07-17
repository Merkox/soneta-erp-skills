# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.RodzajSzkolWyroznienie`
Nazwa tabeli: `RdzSzkWyroz`
Tytuł: Wyrożnienia wydawane w ramach szkolenia.
Opis: Konfiguracja wyróżnień przyznawanych w ramach danego rodzaju szkolenia. Określa, jakie certyfikaty mogą być wydane po ukończeniu kursu, wraz z wymaganiami dotyczącymi frekwencji i wyników egzaminów.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe |  | Określa, czy wyróżnienie ma być brane pod uwagę podczas generowania certyfikatów |
| DefWyroznienia | `Soneta.CzlonkowieSzkolenia.DefWyroznienia` | bazodanowe |  |  |
| IsOcenyModuleAvailable | `bool` |  |  |  |
| MinimumEgzamin | `Soneta.Types.Percent` | bazodanowe |  |  |
| MinimumZajecia | `Soneta.Types.Percent` | bazodanowe |  |  |
| RodzajSzkol | `Soneta.CzlonkowieSzkolenia.RodzajSzkol` | bazodanowe |  |  |
| WymagaOcen | `bool` | bazodanowe |  |  |
| WymagaZaliczenia | `bool` | bazodanowe |  |  |
