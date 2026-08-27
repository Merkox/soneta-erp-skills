# Pola i właściwości klasy biznesowej: `Soneta.Business.App.AppTokenItem`
Nazwa tabeli: `AppTokenItems`
Tytuł: Instancje tokena aplikacyjnego
Opis: Instancja wygenerowanego tokena aplikacyjnego. Przechowuje unikalny hash, czas generowania, datę ważności i stan aktywności konkretnego wydanego tokena.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Active | `bool` | bazodanowe |  |  |
| GenerateTime | `System.DateTime` | bazodanowe, tylko-odczyt |  |  |
| Hash | `string` | bazodanowe | Unikalny hash tokena |  |
| Token | `App.AppToken` | bazodanowe, tylko-odczyt |  | Token, do którego należy uprawnienie |
| ValidTo | `System.DateTime` | bazodanowe, tylko-odczyt |  |  |
