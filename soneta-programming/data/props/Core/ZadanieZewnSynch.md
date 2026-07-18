# Pola i właściwości klasy biznesowej: `Soneta.Core.ZadanieZewnSynch`
Nazwa tabeli: `ZadaniaZewnSynch`
Tytuł: Zadania do synchronizacji
Opis: Kolejka zadań synchronizacji danych z systemami zewnętrznymi. Każde zadanie zawiera identyfikator obiektu programu, typ tabeli, akcję do wykonania, system zewnętrzny, datę zarejestrowania i dodatkowe informacje.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Akcja | `string` | bazodanowe | Akcja | Rodzaj zadania synchronizacji |
| Data | `System.DateTime` | bazodanowe | Data | Data zarejestrowania zadania |
| Info | `string` | bazodanowe | Info | Dodatkowe informacje |
| SystemZewn | `Soneta.Core.SystemZewn` | bazodanowe | System zewnętrzny | Wskazanie na system zewnętrzny |
| Zapis | `System.Guid` | bazodanowe | Identyfikator obiektu programu | Wskazanie na obiekt programu |
| ZapisTabela | `string` | bazodanowe | Typ obiektu programu | Typ obiektu programu |
