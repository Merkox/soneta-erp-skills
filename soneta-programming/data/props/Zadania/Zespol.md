# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Zespol`
Nazwa tabeli: `Zespoly`
Tytuł: Role które są widoczne w aktywnościach OPZ jako zespoły
Opis: Konfiguracja ról systemowych widocznych jako zespoły w aktywnościach OPZ. Umożliwia przypisywanie zadań do zespołów zamiast do indywidualnych operatorów.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Role | `App.Role` |  |  |  |
| RoleGuid | `System.Guid` | bazodanowe, tylko-odczyt |  | Rola która jest zespołem w aktywnościach OPZ. |
