# Pola i właściwości klasy biznesowej: `Soneta.CRM.Config.AuthToken`
Nazwa tabeli: `AuthTokens`
Tytuł: Tokeny Autoryzacji
Opis: Przechowuje tokeny autoryzacyjne OAuth używane do uwierzytelniania kont pocztowych. Zawiera token dostępu, token odświeżania oraz informacje o czasie życia, umożliwiając bezpieczne i automatyczne odnawianie sesji.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Created | `System.DateTime` | bazodanowe |  |  |
| IsTokenCreated | `bool` |  |  |  |
| LiveTime | `decimal` | bazodanowe |  |  |
| RefreshToken | `Soneta.Business.MemoText` | bazodanowe | Obsolete RefreshToken OAuth | Obsolete RefreshToken OAuth |
| RefreshTokenValue | `Soneta.Business.MemoBin` | bazodanowe |  |  |
| Token | `Soneta.Business.MemoText` | bazodanowe | Token OAuth | Token OAuth |
