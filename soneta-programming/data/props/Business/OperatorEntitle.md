# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.OperatorEntitle`
Nazwa tabeli: `OperatorEntitles`
Tytuł: Uprawnienia operatora
Opis: Powiązanie operatora z uprawnieniem (oddziałem praw). Określa, do których oddziałów operator ma dostęp i który jest domyślny przy logowaniu.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Operator` → `Operator`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Entitle | `App.Entitle` | bazodanowe |  | Uprawnienia przypisane operatorowi. |
| IsDefaultForOperator | `bool` | bazodanowe |  | Ustawienie standardowego uprawnienia dla logowania w wielooddziałowości |
| Operator | `App.Operator` | bazodanowe, guided-parent |  | Operator przypisany do uprawnień. |
