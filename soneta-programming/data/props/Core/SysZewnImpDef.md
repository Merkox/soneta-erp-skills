# Pola i właściwości klasy biznesowej: `Soneta.Core.SysZewnImpDef`
Nazwa tabeli: `SysZewnImpDefs`
Tytuł: Elementy definicji pobierania danych
Opis: Definicja elementu pobierania danych z systemu zewnętrznego. Określa symbol, tabelę docelową, akcję, priorytet oraz schematy pobierania, aktualizacji i synchronizacji danych między systemami.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AfterSyncSchema | `string` | bazodanowe | Schemat usuwania zadań synchronizacji |  |
| Akcja | `string` | bazodanowe | Akcja |  |
| DownloadSchema | `string` | bazodanowe | Schemat pobierania |  |
| Priorytet | `int` | bazodanowe | Priorytet |  |
| Symbol | `string` | bazodanowe |  |  |
| Tabela | `string` | bazodanowe | Tabela |  |
| UpdateSchema | `string` | bazodanowe | Schemat aktualizacji |  |
