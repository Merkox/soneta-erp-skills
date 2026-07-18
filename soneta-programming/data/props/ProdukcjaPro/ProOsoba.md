# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProOsoba`
Nazwa tabeli: `ProOsoby`
Tytuł: Osoby produkcyjne
Opis: Kartoteka osób uczestniczących w procesach produkcyjnych. Przechowuje dane pracowników i operatorów, którzy mogą być przypisywani jako zasoby ludzkie do operacji na zleceniach produkcyjnych.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 17
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 1
- subrowy: 0
- razem: 19

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Zablokowanie osoby. |
| FiltrCechyDefinicja | `FeatureDefinition` | bazodanowe | Filtr definicji cechy | Filtr definicji cechy panelu meldunkowego dla osoby. |
| FiltrCechyWartosc | `string` | bazodanowe | Filtr wartości cechy | Filtr wartości cechy panelu meldunkowego dla osoby. |
| FiltrDefinicjiOperacji | `Soneta.ProdukcjaPro.ProDefinicjaOperacji` | bazodanowe | Filtr definicji operacji | Filtr definicji operacji panelu meldunkowego dla osoby. |
| FiltrDefinicjiOperacjiEdycja | `bool` | bazodanowe | Edycja filtru definicji operacji | Edycja filtru definicji operacji panelu meldunkowego dla osoby. |
| FiltrGniazda | `Soneta.ProdukcjaPro.ProZasob` | bazodanowe | Filtr gniazda | Filtr gniazda panelu meldunkowego dla osoby. |
| FiltrGniazdaEdycja | `bool` | bazodanowe | Edycja filtru gniazda | Edycja filtru gniazda panelu meldunkowego dla osoby. |
| FiltrJednostkiRoboczej | `Soneta.ProdukcjaPro.ProZasob` | bazodanowe | Filtr jednostki roboczej | Filtr jednostki roboczej panelu meldunkowego dla osoby. |
| FiltrJednostkiRoboczejEdycja | `bool` | bazodanowe | Edycja filtru jednostki roboczej | Edycja filtru jednostki roboczej panelu meldunkowego dla osoby. |
| FiltrSkanowania | `bool` | bazodanowe | Filtr skanowania | Filtr skanowania panelu meldunkowego dla osoby. |
| FiltrWydzialu | `Soneta.ProdukcjaPro.ProWydzial` | bazodanowe | Filtr wydziału | Filtr wydziału panelu meldunkowego dla osoby. |
| FiltrWydzialuEdycja | `bool` | bazodanowe | Edycja filtru wydziału | Edycja filtru wydziału panelu meldunkowego dla osoby. |
| FiltryPaneluAktywne | `bool` | bazodanowe | Filtry panelu aktywne | Aktywność filtrów panelu meldunkowego dla osoby. |
| Imie | `string` | bazodanowe | Imię | Imię osoby. |
| Kod | `string` | bazodanowe |  | Kod osoby. |
| Nazwa | `string` | tylko-odczyt |  | Nazwa osoby produkcyjnej. |
| Nazwisko | `string` | bazodanowe |  | Nazwisko osoby. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis osoby. |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
