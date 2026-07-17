# Pola i właściwości klasy biznesowej: `Soneta.Core.SysZewnStatus`
Nazwa tabeli: `SysZewnStatusy`
Opis: Mapowanie statusów zamówień w systemie zewnętrznym. Określa status źródłowy, docelowy i nazwę wyświetlaną oraz flagę pobierania - zamówienia z tym statusem będą pobrane i przetworzone z systemu zewnętrznego.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kod | `string` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa statusu |  |
| Pobieranie | `bool` | bazodanowe |  | Zamówienia z tym statusem będą pobrane i przetworzone. |
| StatusPo | `string` | bazodanowe | Status po w systemie zewnętrznym |  |
| StatusPrzed | `string` | bazodanowe | Status w systemie zewnętrznym |  |
| SystemZewn | `Soneta.Core.SystemZewn` | bazodanowe | System zewnętrzny |  |
