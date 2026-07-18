# Pola i właściwości klasy biznesowej: `Soneta.Business.App.SingleUseToken`
Nazwa tabeli: `SingleUseTokens`
Tytuł: Tokeny jednorazowe
Opis: Token jednorazowego użytku oparty o JWT. Przechowuje identyfikator, zawartość i datę ważności tokena służącego do jednorazowej autoryzacji operacji.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 1
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ExpirationDate | `System.DateTime` | bazodanowe, tylko-odczyt | Data ważności | Data ważności tokena. |
| Jti | `string` | bazodanowe | Identyfikator tokena | Identyfikator tokena tworzony na podstawie JWT |
| Token | `MemoText` | bazodanowe, podlista | Token jednorazowy | Zawartość token w postaci base64. |
