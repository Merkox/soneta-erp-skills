# Pola i właściwości klasy biznesowej: `Soneta.Business.Runtime.RuntimeEnum`
Nazwa tabeli: `RuntimeEnums`
Tytuł: Enumy dla runtime
Opis: Wartość enumeracji definiowanej dynamicznie w runtime. Powiązana z definicją pola dynamicznego i zawiera nazwę, wartość liczbową oraz etykietę.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Definition` → `RuntimeFieldDefinition`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definition | `Soneta.Business.Runtime.RuntimeFieldDefinition` | bazodanowe, guided-parent | Definicja pola |  |
| EnumCaption | `string` | bazodanowe | Nagłówek |  |
| Locked | `bool` | bazodanowe | Zablokowana |  |
| Name | `string` | bazodanowe | Nazwa |  |
| Value | `int` | bazodanowe | Wartość |  |
