# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.OperatorEntitle`
Nazwa tabeli: `OperatorEntitles`
Tytuł: Uprawnienia operatora
Opis: Powiązanie operatora z uprawnieniem (oddziałem praw). Określa, do których oddziałów operator ma dostęp i który jest domyślny przy logowaniu.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Operator` → `Operator`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Entitle | `Soneta.Business.App.Entitle` | bazodanowe |  | Uprawnienia przypisane operatorowi. |
| IsDefaultForOperator | `bool` | bazodanowe |  | Ustawienie standardowego uprawnienia dla logowania w wielooddziałowości |
| Operator | `Soneta.Business.App.Operator` | bazodanowe, guided-parent |  | Operator przypisany do uprawnień. |
