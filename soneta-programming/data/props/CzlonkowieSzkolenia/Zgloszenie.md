# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.Zgloszenie`
Nazwa tabeli: `Zgloszenia`
Tytuł: Zgłoszenia
Opis: Dokumenty zgłoszeń uczestników na szkolenia. Rejestruje formalne zapisy na kursy z datą, kontrahentem zgłaszającym i numerem dokumentu, stanowiąc podstawę procesu rekrutacji na szkolenie.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe | Data zgłoszenia | Data zgłoszenia na szkolenie. |
| DefZgloszenia | `Soneta.CzlonkowieSzkolenia.DefZgloszenia` | bazodanowe |  |  |
| DlaModulow | `bool` |  |  |  |
| DokumentyHan | `Soneta.Business.View` |  |  |  |
| IDokumentNumerPelny | `string` |  | Numer pełny |  |
| JestJednoZgloszenieUczestnik | `bool` |  |  |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
| MailTo | `string` |  |  |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy. |
| Uczestnicy | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik>` |  |  |  |
| Zbiorcze | `bool` | bazodanowe | Zgłoszenie zbiorcze | Zgłoszenie zbiorcze. |
| ZgloszenieUczestnik | `Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik` |  |  |  |
| ZgloszenieUczestnikRow | `Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik` |  |  |  |
