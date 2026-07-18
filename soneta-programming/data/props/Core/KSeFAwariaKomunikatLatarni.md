# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFAwariaKomunikatLatarni`
Nazwa tabeli: `KSeFAwarieKomLat`
Tytuł: Komunikaty z latarnika KSeF
Opis: Tabela przechowuje komunikaty z latarnika KSeF powiązane z awariami systemu. Każdy komunikat zawiera identyfikator, kategorię, typ, tytuł, treść oraz daty rozpoczęcia, zakończenia i opublikowania zdarzenia awaryjnego.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 10
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 7
- podlisty: 0
- subrowy: 0
- razem: 17

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Awaria | `Soneta.Core.KSeFAwaria` | bazodanowe, tylko-odczyt | Awaria | Awaria |
| Category | `string` | bazodanowe | Kategoria wiadomości | Kategoria wiadomości |
| End | `DateShortTime` | tylko-odczyt |  |  |
| EndOffset | `string` | bazodanowe |  |  |
| EndUtc | `System.DateTime` | tylko-odczyt |  |  |
| EventId | `int` | bazodanowe | Id zdarzenia | Id zdarzenia |
| MessageId | `string` | bazodanowe | Id wiadomości | Id wiadomości |
| Published | `DateShortTime` | tylko-odczyt |  |  |
| PublishedOffset | `string` | bazodanowe |  |  |
| PublishedUtc | `System.DateTime` | tylko-odczyt |  |  |
| Start | `DateShortTime` | tylko-odczyt |  |  |
| StartOffset | `string` | bazodanowe |  |  |
| StartUtc | `System.DateTime` | tylko-odczyt |  |  |
| Text | `string` | bazodanowe | Treść wiadomości | Treść wiadomości |
| Title | `string` | bazodanowe | Tytuł wiadomości | Tytuł wiadomości |
| Type | `string` | bazodanowe | Typ wiadomości | Typ wiadomości |
| Version | `int` | bazodanowe | Wersja | Wersja |
