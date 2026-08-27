# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.RodzajSzkolWyroznienie`
Nazwa tabeli: `RdzSzkWyroz`
Tytuł: Wyrożnienia wydawane w ramach szkolenia.
Opis: Konfiguracja wyróżnień przyznawanych w ramach danego rodzaju szkolenia. Określa, jakie certyfikaty mogą być wydane po ukończeniu kursu, wraz z wymaganiami dotyczącymi frekwencji i wyników egzaminów.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe |  | Określa, czy wyróżnienie ma być brane pod uwagę podczas generowania certyfikatów |
| DefWyroznienia | `Soneta.CzlonkowieSzkolenia.DefWyroznienia` | bazodanowe |  |  |
| IsOcenyModuleAvailable | `bool` | tylko-odczyt |  |  |
| MinimumEgzamin | `Percent` | bazodanowe |  |  |
| MinimumZajecia | `Percent` | bazodanowe |  |  |
| RodzajSzkol | `Soneta.CzlonkowieSzkolenia.RodzajSzkol` | bazodanowe |  |  |
| WymagaOcen | `bool` | bazodanowe |  |  |
| WymagaZaliczenia | `bool` | bazodanowe |  |  |
