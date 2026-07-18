# Pola i właściwości klasy biznesowej: `Soneta.Business.App.AppTokenRight`
Nazwa tabeli: `AppTokenRights`
Tytuł: Uprawnienia tokena aplikacyjnego
Opis: Uprawnienie przypisane do tokena aplikacyjnego. Określa nazwę prawa dostępu, jakie dany token posiada w kontekście API.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Name | `string` | bazodanowe | Nazwa uprawnienia |  |
| Token | `App.AppToken` | bazodanowe, tylko-odczyt |  | Token, do którego należy uprawnienie |
