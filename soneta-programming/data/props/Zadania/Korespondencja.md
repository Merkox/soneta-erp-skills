# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Korespondencja`
Nazwa tabeli: `Korespondencje`
Tytuł: Tabela korespondencji
Opis: Korespondencja seryjna CRM umożliwiająca masową komunikację z kontrahentami. Zawiera treść, uwagi, datę, stan realizacji oraz osobę odpowiedzialną za prowadzenie korespondencji.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IEmailElement`

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe | Aktywny | Wskazuje, czy korespondencja w tym stanie jest aktywna (otwarta). |
| Data | `Soneta.Types.Date` | bazodanowe | Data korespondencji | Data korespondencji. |
| Definicja | `Soneta.Zadania.DefKoresp` | bazodanowe |  | Definicja korespondencji. |
| DuplikatyEMAIL | `System.Collections.Generic.List<string>` |  |  |  |
| IDokumentNumerPelny | `string` |  | Numer pełny |  |
| MailTo | `string` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa korespondencji | Krótka nazwa korespondencji, na podstawie której będzie można ją wyszukiwać. |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| OddzialFirmy | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy do którego przypisana jest korespondencja. |
| Prawo1 | `bool` |  |  |  |
| Prowadzacy | `Soneta.Business.App.Operator` | bazodanowe | Prowadzacy | Osoba odpowiedzialna za korespondencje. |
| StanIdent | `int` | bazodanowe | Stan | Stan korespondencji. Relacja do property Ident w liście stanów powiązanych z definicją korespondencji. |
| StanKoresp | `Soneta.Zadania.StanKoresp` | bazodanowe |  | Stan korespondencji. |
| Tresc | `Soneta.Business.MemoText` | bazodanowe | Tresc | Tresc korespondencji. |
| TrescAsp | `Soneta.Business.MemoText` |  |  |  |
| TrescRich | `Soneta.Business.MemoText` |  |  |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe | Uwagi | Uwagi korespondencji. |
| WiadomosciPowiazane | `Soneta.Business.SubTable<Soneta.CRM.ElementEmail>` |  |  |  |
| Zdarzenia | `Soneta.Business.SubTable<Soneta.Zadania.Zadanie>` |  |  |  |
