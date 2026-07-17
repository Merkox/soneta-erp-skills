# Pola i właściwości klasy biznesowej: `Soneta.Core.NoticeChannel`
Nazwa tabeli: `NoticeChannels`
Tytuł: Kanały komunikatów
Opis: Kanał dystrybucji komunikatów i powiadomień. Określa nazwę, opis, usługę serwisową, częstotliwość synchronizacji, priorytet, flagę blokady, wymaganie zgody odbiorcy oraz ustawienia połączenia.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Desc | `string` | bazodanowe |  |  |
| IsLocked | `bool` | bazodanowe |  |  |
| LastSyncTime | `System.DateTime` | bazodanowe |  |  |
| Name | `string` | bazodanowe |  |  |
| Notices | `Soneta.Business.SubTable<Soneta.Core.Notice>` |  |  |  |
| Permissions | `Soneta.Business.SubTable<Soneta.Core.NoticePermission>` |  |  |  |
| Priority | `int` | bazodanowe |  |  |
| RequiresRecipientApproval | `bool` | bazodanowe |  |  |
| ServiceName | `string` | bazodanowe |  |  |
| SettingsString | `string` | bazodanowe |  |  |
| SyncFrequency | `int` | bazodanowe |  |  |
