# Pola i właściwości klasy biznesowej: `Soneta.Business.Runtime.RuntimeEnum`
Nazwa tabeli: `RuntimeEnums`
Tytuł: Enumy dla runtime
Opis: Wartość enumeracji definiowanej dynamicznie w runtime. Powiązana z definicją pola dynamicznego i zawiera nazwę, wartość liczbową oraz etykietę.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Definition` → `RuntimeFieldDefinition`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definition | `Runtime.RuntimeFieldDefinition` | bazodanowe, tylko-odczyt, guided-parent | Definicja pola |  |
| EnumCaption | `string` | bazodanowe | Nagłówek |  |
| Locked | `bool` | bazodanowe | Zablokowana |  |
| Name | `string` | bazodanowe | Nazwa |  |
| Value | `int` | bazodanowe | Wartość |  |
