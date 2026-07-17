# Pola i właściwości klasy biznesowej: `Soneta.HR.UprawnienieDefinicjiSzkolenia`
Nazwa tabeli: `UprawnDefSzkol`
Tytuł: Uprawnienia
Opis: Element szczegółowy definicji szkolenia (DefinicjaSzkolenia). Wiąże szkolenie z uprawnieniem, które pracownik uzyskuje po jego ukończeniu, automatyzując proces nadawania kwalifikacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `DefinicjaSzkolenia` → `DefinicjaSzkolenia`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaSzkolenia | `Soneta.HR.DefinicjaSzkolenia` | bazodanowe, guided-parent |  |  |
| DefinicjaUprawnienia | `Soneta.HR.DefinicjaUprawnienia` | bazodanowe |  |  |
