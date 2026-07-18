# Pola i właściwości klasy biznesowej: `Soneta.Core.SysZewnStatus`
Nazwa tabeli: `SysZewnStatusy`
Opis: Mapowanie statusów zamówień w systemie zewnętrznym. Określa status źródłowy, docelowy i nazwę wyświetlaną oraz flagę pobierania - zamówienia z tym statusem będą pobrane i przetworzone z systemu zewnętrznego.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kod | `string` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe | Nazwa statusu |  |
| Pobieranie | `bool` | bazodanowe |  | Zamówienia z tym statusem będą pobrane i przetworzone. |
| StatusPo | `string` | bazodanowe | Status po w systemie zewnętrznym |  |
| StatusPrzed | `string` | bazodanowe | Status w systemie zewnętrznym |  |
| SystemZewn | `Soneta.Core.SystemZewn` | bazodanowe | System zewnętrzny |  |
