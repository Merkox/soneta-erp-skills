# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Cti.Models.CtiAccount`
Nazwa tabeli: `CtiAccounts`
Opis: Tabela przechowująca dane logowania i konfiguracji związane z centralą telefoniczną Slican. Dane obejmują operatorów, adresy, porty, loginy oraz hasła.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Address | `string` | bazodanowe |  |  |
| ConnectedSince | `System.DateTime` | bazodanowe |  |  |
| IsConnected | `bool` | tylko-odczyt |  |  |
| Login | `string` | bazodanowe |  |  |
| Operator | `App.Operator` | bazodanowe |  |  |
| Password | `string` | bazodanowe |  |  |
| Port | `int` | bazodanowe |  |  |
