# Pola i właściwości klasy biznesowej: `Soneta.Handel.ProgRabatowy`
Nazwa tabeli: `ProgiRabatowe`
Opis: Próg rabatowy powiązany z hostem (np. definicją ceny). Definiuje wartość procentową rabatu dla określonego progu ilościowego.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Domyslny | `bool` | bazodanowe | Domyślny | Domyślny próg rabatu. |
| Host | `IProgRabatowyHost` | bazodanowe, tylko-odczyt |  |  |
| Prog | `int` | bazodanowe | Ilość | Próg rabatu. |
| Rabat | `Percent` | bazodanowe | Rabat | Procent rabatu. |
