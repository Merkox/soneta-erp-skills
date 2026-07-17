# Pola i właściwości klasy biznesowej: `Soneta.Business.App.Operator`
Nazwa tabeli: `Operators`
Tytuł: Operator
Opis: Konto użytkownika systemu. Przechowuje dane logowania (kod, hasło, logowanie zintegrowane), stan blokady oraz podstawowe dane identyfikacyjne operatora.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IŹródłoPowiązaniaStrukturyOrganizacyjnej`, `ITaskUser`, `IAuthorised`, `INoticeRecipient`, `IMfaOperator`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 16

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Credentials | `Soneta.Business.SubTable<Soneta.Business.CredentialKey>` |  |  |  |
| DBItems | `System.Collections.IList` |  |  |  |
| Email | `string` | bazodanowe | Adres e-mail | Określa adres e-mail operatora. |
| Entitles | `Soneta.Business.SubTable<Soneta.Business.Db.OperatorEntitle>` |  |  |  |
| Extension | `Soneta.Business.Db.OperatorEx` |  |  |  |
| FullName | `string` | bazodanowe | Nazwa | Imię i nazwisko operatora. |
| IsAccountLocked | `bool` | bazodanowe | Zablokowany (hasło) | Oznacza operatora zablokowane z powodu wielokrotnego wprowadzania niepoprawnego hasła |
| IsOperatorNet | `bool` | bazodanowe | Logowaniu multi | Oznacza konto z możliwością do logowania się do wersji multi (HTML/Mobile) |
| IsSchedulerOperator | `bool` |  |  |  |
| Kod | `string` |  |  |  |
| Locked | `bool` | bazodanowe | Zablokowany | Określa, czy konto jest aktualnie zablokowane. |
| LoginVisible | `bool` |  |  | Czy operator ma być widoczny na liscie loginów w oknie logowania |
| MfaMode | `Soneta.Types.MfaMode` | enum |  |  |
| Name | `string` | bazodanowe | Kod | Unikalny kod operatora wymagany podczas logowania się do bazy. |
| Nazwa | `string` |  |  |  |
| NewPassword | `string` |  |  |  |
| NoticeRecipientGroup | `Soneta.Business.NoticeRecipientGroup` | enum |  |  |
| Password | `string` | bazodanowe |  |  |
| Permissions | `Soneta.Business.SubTable<Soneta.Business.Db.Permissions.RecordPermission>` |  |  |  |
| PowiązaniaStrOrg | `Soneta.Business.SubTable` |  |  |  |
| PromptPassword | `string` | bazodanowe | Podpowiedź hasła | Informacja podpowiadająca użytkownikowi jakie ma hasło dostępu. |
| RecipientDesc | `string` |  |  |  |
| Trusted | `string` | bazodanowe | Logowanie zintegrowane | Nazwa operatora zintegrowanego, który może się logować na to konto. |
| UserGroupMembers | `Soneta.Business.SubTable<Soneta.Business.Db.Permissions.UserGroupMember>` |  |  |  |
| UserGroups | `System.Collections.Generic.IEnumerable<Soneta.Business.Db.Permissions.UserGroup>` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### NoticeRecipientGroup (`Soneta.Business.NoticeRecipientGroup`)
- `AllGroups` = 0 — Wszyscy
- `Operators` = 1 — Operatorzy
- `Employees` = 2 — Pracownicy
- `ContactPersons` = 4 — Osoby kontaktowe
- `Chosen` = 8 — Wybrani
- `PanelUsers` = 16 — Użytkownicy panelu

### MfaMode (`Soneta.Types.MfaMode`)
- `Unregistered` = 0 — Niezarejestrowana
- `Registered` = 1 — Zarejestrowana
- `Verified` = 2 — Potwierdzona
- `RegisterMore` = 3 — Ponowna rejestracja
- `Disabled` = 4 — Zablokowana
