# Pola i właściwości klasy biznesowej: `Soneta.Core.SysZewnUsDodatkowa`
Nazwa tabeli: `SysZewnUsDod`
Tytuł: Lista usług dodatkowych
Opis: Konfiguracja usług dodatkowych dostępnych w systemie zewnętrznym. Powiązuje usługę (z elementu słownika) z systemem zewnętrznym i hostem, z opcją domyślnego wyboru przy tworzeniu zamówień.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Host | `Soneta.Core.ISysZewnUsDodatkowaHost` | bazodanowe | Host |  |
| SystemZewn | `Soneta.Core.SystemZewn` | bazodanowe | System zewnętrzny |  |
| UslugaDodatkowa | `Soneta.Core.SlownikElem` | bazodanowe | Usługa dodatkowa |  |
| WybierajDomyslnie | `bool` | bazodanowe | Wybieraj domyślnie |  |
