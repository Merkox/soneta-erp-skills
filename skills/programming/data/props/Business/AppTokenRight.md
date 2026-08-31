# Pola i właściwości klasy biznesowej: `Soneta.Business.App.AppTokenRight`
Nazwa tabeli: `AppTokenRights`
Tytuł: Uprawnienia tokena aplikacyjnego
Opis: Uprawnienie przypisane do tokena aplikacyjnego. Określa nazwę prawa dostępu, jakie dany token posiada w kontekście API.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Name | `string` | bazodanowe | Nazwa uprawnienia |  |
| Token | `App.AppToken` | bazodanowe, tylko-odczyt |  | Token, do którego należy uprawnienie |
