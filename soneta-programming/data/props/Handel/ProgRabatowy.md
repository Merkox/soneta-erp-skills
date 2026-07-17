# Pola i właściwości klasy biznesowej: `Soneta.Handel.ProgRabatowy`
Nazwa tabeli: `ProgiRabatowe`
Opis: Próg rabatowy powiązany z hostem (np. definicją ceny). Definiuje wartość procentową rabatu dla określonego progu ilościowego.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Domyslny | `bool` | bazodanowe | Domyślny | Domyślny próg rabatu. |
| Host | `Soneta.Business.IProgRabatowyHost` | bazodanowe |  |  |
| Prog | `int` | bazodanowe | Ilość | Próg rabatu. |
| Rabat | `Soneta.Types.Percent` | bazodanowe | Rabat | Procent rabatu. |
