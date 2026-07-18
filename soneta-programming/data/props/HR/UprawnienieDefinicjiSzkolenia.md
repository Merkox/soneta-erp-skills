# Pola i właściwości klasy biznesowej: `Soneta.HR.UprawnienieDefinicjiSzkolenia`
Nazwa tabeli: `UprawnDefSzkol`
Tytuł: Uprawnienia
Opis: Element szczegółowy definicji szkolenia (DefinicjaSzkolenia). Wiąże szkolenie z uprawnieniem, które pracownik uzyskuje po jego ukończeniu, automatyzując proces nadawania kwalifikacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `DefinicjaSzkolenia` → `DefinicjaSzkolenia`

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaSzkolenia | `Soneta.HR.DefinicjaSzkolenia` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| DefinicjaUprawnienia | `Soneta.HR.DefinicjaUprawnienia` | bazodanowe |  |  |
