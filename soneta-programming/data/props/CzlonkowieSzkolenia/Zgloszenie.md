# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.Zgloszenie`
Nazwa tabeli: `Zgloszenia`
Tytuł: Zgłoszenia
Opis: Dokumenty zgłoszeń uczestników na szkolenia. Rejestruje formalne zapisy na kursy z datą, kontrahentem zgłaszającym i numerem dokumentu, stanowiąc podstawę procesu rekrutacji na szkolenie.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 7
- podlisty: 4
- subrowy: 1
- razem: 20

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe | Data zgłoszenia | Data zgłoszenia na szkolenie. |
| DefZgloszenia | `Soneta.CzlonkowieSzkolenia.DefZgloszenia` | bazodanowe |  |  |
| DlaModulow | `bool` | tylko-odczyt |  |  |
| DokumentyHan | `View` | podlista |  |  |
| IDokumentNumerPelny | `string` | tylko-odczyt | Numer pełny |  |
| JestJednoZgloszenieUczestnik | `bool` | tylko-odczyt |  |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
| MailTo | `string` | tylko-odczyt |  |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy. |
| Uczestnicy | `SubTable<Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik>` | podlista |  |  |
| Zbiorcze | `bool` | bazodanowe | Zgłoszenie zbiorcze | Zgłoszenie zbiorcze. |
| ZgloszenieUczestnik | `Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik` | tylko-odczyt |  |  |
| ZgloszenieUczestnikRow | `Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik` | tylko-odczyt |  |  |
