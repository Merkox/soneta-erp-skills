# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFAwariaKomunikatLatarni`
Nazwa tabeli: `KSeFAwarieKomLat`
Tytuł: Komunikaty z latarnika KSeF
Opis: Tabela przechowuje komunikaty z latarnika KSeF powiązane z awariami systemu. Każdy komunikat zawiera identyfikator, kategorię, typ, tytuł, treść oraz daty rozpoczęcia, zakończenia i opublikowania zdarzenia awaryjnego.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Awaria | `Soneta.Core.KSeFAwaria` | bazodanowe | Awaria | Awaria |
| Category | `string` | bazodanowe | Kategoria wiadomości | Kategoria wiadomości |
| End | `Soneta.Types.DateShortTime` |  |  |  |
| EndOffset | `string` | bazodanowe |  |  |
| EndUtc | `System.DateTime` |  |  |  |
| EventId | `int` | bazodanowe | Id zdarzenia | Id zdarzenia |
| MessageId | `string` | bazodanowe | Id wiadomości | Id wiadomości |
| Published | `Soneta.Types.DateShortTime` |  |  |  |
| PublishedOffset | `string` | bazodanowe |  |  |
| PublishedUtc | `System.DateTime` |  |  |  |
| Start | `Soneta.Types.DateShortTime` |  |  |  |
| StartOffset | `string` | bazodanowe |  |  |
| StartUtc | `System.DateTime` |  |  |  |
| Text | `string` | bazodanowe | Treść wiadomości | Treść wiadomości |
| Title | `string` | bazodanowe | Tytuł wiadomości | Tytuł wiadomości |
| Type | `string` | bazodanowe | Typ wiadomości | Typ wiadomości |
| Version | `int` | bazodanowe | Wersja | Wersja |
