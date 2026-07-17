# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Zespol`
Nazwa tabeli: `Zespoly`
Tytuł: Role które są widoczne w aktywnościach OPZ jako zespoły
Opis: Konfiguracja ról systemowych widocznych jako zespoły w aktywnościach OPZ. Umożliwia przypisywanie zadań do zespołów zamiast do indywidualnych operatorów.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 1
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Role | `Soneta.Business.App.Role` |  |  |  |
| RoleGuid | `System.Guid` | bazodanowe |  | Rola która jest zespołem w aktywnościach OPZ. |
