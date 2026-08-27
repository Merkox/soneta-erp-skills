# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.OperatorToTeam`
Nazwa tabeli: `OperatorsToTeam`
Tytuł: Operator Moduł
Opis: Tabela przypisań operatorów systemu do zespołów wsparcia technicznego. Określa przynależność operatora do jednego lub wielu zespołów, ze wskazaniem zespołu głównego używanego jako domyślny przy obsłudze zgłoszeń.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| MainTeam | `bool` | bazodanowe | Zespół główny |  |
| Operator | `App.Operator` | bazodanowe | Operator | Operator wsparcia |
| Team | `Soneta.Support.Support.Team` | bazodanowe | Zespół |  |
