# Pola i właściwości klasy biznesowej: `Soneta.Business.App.AppTokenItem`
Nazwa tabeli: `AppTokenItems`
Tytuł: Instancje tokena aplikacyjnego
Opis: Instancja wygenerowanego tokena aplikacyjnego. Przechowuje unikalny hash, czas generowania, datę ważności i stan aktywności konkretnego wydanego tokena.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Active | `bool` | bazodanowe |  |  |
| GenerateTime | `System.DateTime` | bazodanowe |  |  |
| Hash | `string` | bazodanowe | Unikalny hash tokena |  |
| Token | `Soneta.Business.App.AppToken` | bazodanowe |  | Token, do którego należy uprawnienie |
| ValidTo | `System.DateTime` | bazodanowe |  |  |
