# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.WykladowcaSzkol`
Nazwa tabeli: `WykladowcySzkol`
Tytuł: Wykładowcy
Opis: Kartoteka wykładowców i trenerów prowadzących szkolenia. Przechowuje dane personalne, tytuły naukowe, doświadczenie zawodowe oraz uprawnienia (wizytator, egzaminator) osób prowadzących zajęcia.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IOceniający`, `ITaskUser`

- pola bazodanowe (zapisywalne): 12
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 1
- podlisty: 10
- subrowy: 1
- razem: 25

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Doswiadczenie | `MemoText` | bazodanowe, podlista | Doświadczenie zawodowe | Doświadczenie zawodowe. |
| Egzaminator | `bool` | bazodanowe | Egzaminator |  |
| EtapyRekrutacji | `SubTable<Soneta.HR.EtapRekrutacji>` | podlista |  |  |
| Imie | `string` | bazodanowe | Imie pracownika | Imie pracownika. |
| Kod | `string` | bazodanowe |  | Kod wykładowcy. |
| Kontakt | `Soneta.Core.Kontakt` (subrow) | bazodanowe |  |  |
| Kontakt.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Kontakt.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Kontakt.Skype | `string` |  |  |  |
| Kontakt.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Kontakt.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| Nazwisko | `string` | bazodanowe | Nazwisko pracownika | Nazwa pracownika. |
| Oceniający | `SubTable` | podlista |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy do którego przypisana jest sala. |
| OfertyPracy | `SubTable` | podlista |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Rekrutacje | `SubTable<Soneta.HR.Rekrutacja>` | podlista |  |  |
| Settings | `SchedulerSettings` | tylko-odczyt |  |  |
| TytulNaukowy | `string` | bazodanowe | Tytul naukowy | Tytul naukowy. |
| View | `View` | podlista |  |  |
| Wakaty | `SubTable` | podlista |  |  |
| Wizytator | `bool` | bazodanowe | Wizytator |  |
| Zajecia | `View` | podlista |  |  |
| ZajeciaWykladowcy | `SubTable` | podlista |  |  |
| ZgloszSygnalisty | `SubTable<Soneta.Kadry.ZgloszenieSygnalisty>` | podlista |  |  |
