# Pola i właściwości klasy biznesowej: `Soneta.Core.ElemTeczki`
Nazwa tabeli: `ElemTeczek`
Tytuł: Elementy teczek
Opis: Pozycja teczki reprezentująca powiązanie dowolnego obiektu biznesowego (dokumentu, kontrahenta itp.) z teczką. Każdy element posiada liczbę porządkową określającą kolejność w teczce.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Teczka` → `Teczka`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe | Data elementu | Data elementu |
| Element | `Soneta.Business.IGuidedRow` | bazodanowe |  | Element teczki |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa elementu w ramach teczki. |
| Nazwa | `string` | bazodanowe | Nazwa, opis elementu | Krótka nazwa, opis elementu. |
| Teczka | `Soneta.Core.Teczka` | bazodanowe, guided-parent |  | Teczka do której należy element |
| TypElementu | `string` |  |  |  |
| ZrodloElementu | `Soneta.Business.GuidedRow` |  |  |  |
