# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.WykladowcaSzkol`
Nazwa tabeli: `WykladowcySzkol`
Tytuł: Wykładowcy
Opis: Kartoteka wykładowców i trenerów prowadzących szkolenia. Przechowuje dane personalne, tytuły naukowe, doświadczenie zawodowe oraz uprawnienia (wizytator, egzaminator) osób prowadzących zajęcia.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IOceniający`, `ITaskUser`

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Doswiadczenie | `Soneta.Business.MemoText` | bazodanowe | Doświadczenie zawodowe | Doświadczenie zawodowe. |
| Egzaminator | `bool` | bazodanowe | Egzaminator |  |
| EtapyRekrutacji | `Soneta.Business.SubTable<Soneta.HR.EtapRekrutacji>` |  |  |  |
| Imie | `string` | bazodanowe | Imie pracownika | Imie pracownika. |
| Kod | `string` | bazodanowe |  | Kod wykładowcy. |
| Kontakt | `Soneta.Core.Kontakt` | bazodanowe |  |  |
| Kontakt.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Kontakt.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Kontakt.Skype | `string` |  |  |  |
| Kontakt.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Kontakt.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| Nazwisko | `string` | bazodanowe | Nazwisko pracownika | Nazwa pracownika. |
| Oceniający | `Soneta.Business.SubTable` |  |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy do którego przypisana jest sala. |
| OfertyPracy | `Soneta.Business.SubTable` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Rekrutacje | `Soneta.Business.SubTable<Soneta.HR.Rekrutacja>` |  |  |  |
| Settings | `Soneta.Business.SchedulerSettings` |  |  |  |
| TytulNaukowy | `string` | bazodanowe | Tytul naukowy | Tytul naukowy. |
| View | `Soneta.Business.View` |  |  |  |
| Wakaty | `Soneta.Business.SubTable` |  |  |  |
| Wizytator | `bool` | bazodanowe | Wizytator |  |
| Zajecia | `Soneta.Business.View` |  |  |  |
| ZajeciaWykladowcy | `Soneta.Business.SubTable` |  |  |  |
| ZgloszSygnalisty | `Soneta.Business.SubTable<Soneta.Kadry.ZgloszenieSygnalisty>` |  |  |  |
