# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Korespondencja`
Nazwa tabeli: `Korespondencje`
Tytuł: Tabela korespondencji
Opis: Korespondencja seryjna CRM umożliwiająca masową komunikację z kontrahentami. Zawiera treść, uwagi, datę, stan realizacji oraz osobę odpowiedzialną za prowadzenie korespondencji.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IEmailElement`

- pola bazodanowe (zapisywalne): 9
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 5
- podlisty: 9
- subrowy: 1
- razem: 25

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe, tylko-odczyt | Aktywny | Wskazuje, czy korespondencja w tym stanie jest aktywna (otwarta). |
| Data | `Date` | bazodanowe | Data korespondencji | Data korespondencji. |
| Definicja | `Soneta.Zadania.DefKoresp` | bazodanowe |  | Definicja korespondencji. |
| DuplikatyEMAIL | `System.Collections.Generic.List<string>` | podlista |  |  |
| IDokumentNumerPelny | `string` | tylko-odczyt | Numer pełny |  |
| MailTo | `string` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe | Nazwa korespondencji | Krótka nazwa korespondencji, na podstawie której będzie można ją wyszukiwać. |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| OddzialFirmy | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy do którego przypisana jest korespondencja. |
| Prawo1 | `bool` | tylko-odczyt |  |  |
| Prowadzacy | `App.Operator` | bazodanowe | Prowadzacy | Osoba odpowiedzialna za korespondencje. |
| StanIdent | `int` | bazodanowe | Stan | Stan korespondencji. Relacja do property Ident w liście stanów powiązanych z definicją korespondencji. |
| StanKoresp | `Soneta.Zadania.StanKoresp` | bazodanowe |  | Stan korespondencji. |
| Tresc | `MemoText` | bazodanowe, podlista | Tresc | Tresc korespondencji. |
| TrescAsp | `MemoText` | podlista |  |  |
| TrescRich | `MemoText` | podlista |  |  |
| Uwagi | `MemoText` | bazodanowe, podlista | Uwagi | Uwagi korespondencji. |
| WiadomosciPowiazane | `SubTable<Soneta.CRM.ElementEmail>` | podlista |  |  |
| Zdarzenia | `SubTable<Soneta.Zadania.Zadanie>` | podlista |  |  |
