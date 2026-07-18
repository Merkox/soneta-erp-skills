# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.EntitleRef`
Nazwa tabeli: `EntitleRefs`
Tytuł: Referencje uprawnień
Opis: Powiązanie uprawnienia (oddziału praw) z rolą systemową. Określa, która rola jest przypisana do danego uprawnienia.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Entitle` → `Entitle`

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Entitle | `App.Entitle` | bazodanowe, tylko-odczyt, guided-parent | Uprawnienie |  |
| Role | `Db.SystemRole` | bazodanowe, tylko-odczyt | Powiązana rola |  |
