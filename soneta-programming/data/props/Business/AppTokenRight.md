# Pola i właściwości klasy biznesowej: `Soneta.Business.App.AppTokenRight`
Nazwa tabeli: `AppTokenRights`
Tytuł: Uprawnienia tokena aplikacyjnego
Opis: Uprawnienie przypisane do tokena aplikacyjnego. Określa nazwę prawa dostępu, jakie dany token posiada w kontekście API.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Name | `string` | bazodanowe | Nazwa uprawnienia |  |
| Token | `Soneta.Business.App.AppToken` | bazodanowe |  | Token, do którego należy uprawnienie |
