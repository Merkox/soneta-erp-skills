# Pola i właściwości klasy biznesowej: `Soneta.Core.NoticeChannel`
Nazwa tabeli: `NoticeChannels`
Tytuł: Kanały komunikatów
Opis: Kanał dystrybucji komunikatów i powiadomień. Określa nazwę, opis, usługę serwisową, częstotliwość synchronizacji, priorytet, flagę blokady, wymaganie zgody odbiorcy oraz ustawienia połączenia.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe (zapisywalne): 9
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 2
- subrowy: 0
- razem: 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Desc | `string` | bazodanowe |  |  |
| IsLocked | `bool` | bazodanowe |  |  |
| LastSyncTime | `System.DateTime` | bazodanowe |  |  |
| Name | `string` | bazodanowe |  |  |
| Notices | `SubTable<Soneta.Core.Notice>` | podlista |  |  |
| Permissions | `SubTable<Soneta.Core.NoticePermission>` | podlista |  |  |
| Priority | `int` | bazodanowe |  |  |
| RequiresRecipientApproval | `bool` | bazodanowe |  |  |
| ServiceName | `string` | bazodanowe |  |  |
| SettingsString | `string` | bazodanowe |  |  |
| SyncFrequency | `int` | bazodanowe |  |  |
