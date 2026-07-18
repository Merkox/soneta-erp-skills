# Pola i właściwości klasy biznesowej: `Soneta.CRM.Config.AuthToken`
Nazwa tabeli: `AuthTokens`
Tytuł: Tokeny Autoryzacji
Opis: Przechowuje tokeny autoryzacyjne OAuth używane do uwierzytelniania kont pocztowych. Zawiera token dostępu, token odświeżania oraz informacje o czasie życia, umożliwiając bezpieczne i automatyczne odnawianie sesji.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 2
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Created | `System.DateTime` | bazodanowe |  |  |
| IsTokenCreated | `bool` | tylko-odczyt |  |  |
| LiveTime | `decimal` | bazodanowe |  |  |
| RefreshToken | `MemoText` | bazodanowe, podlista | Obsolete RefreshToken OAuth | Obsolete RefreshToken OAuth |
| RefreshTokenValue | `MemoBin` | bazodanowe |  |  |
| Token | `MemoText` | bazodanowe, podlista | Token OAuth | Token OAuth |
