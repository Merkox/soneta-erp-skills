# Pola i właściwości klasy biznesowej: `Soneta.Business.App.SingleUseToken`
Nazwa tabeli: `SingleUseTokens`
Tytuł: Tokeny jednorazowe
Opis: Token jednorazowego użytku oparty o JWT. Przechowuje identyfikator, zawartość i datę ważności tokena służącego do jednorazowej autoryzacji operacji.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ExpirationDate | `System.DateTime` | bazodanowe | Data ważności | Data ważności tokena. |
| Jti | `string` | bazodanowe | Identyfikator tokena | Identyfikator tokena tworzony na podstawie JWT |
| Token | `Soneta.Business.MemoText` | bazodanowe | Token jednorazowy | Zawartość token w postaci base64. |
