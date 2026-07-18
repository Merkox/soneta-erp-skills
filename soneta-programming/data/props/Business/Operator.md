# Pola i właściwości klasy biznesowej: `Soneta.Business.App.Operator`
Nazwa tabeli: `Operators`
Tytuł: Operator
Opis: Konto użytkownika systemu. Przechowuje dane logowania (kod, hasło, logowanie zintegrowane), stan blokady oraz podstawowe dane identyfikacyjne operatora.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IŹródłoPowiązaniaStrukturyOrganizacyjnej`, `ITaskUser`, `IAuthorised`, `INoticeRecipient`, `IMfaOperator`

- pola bazodanowe (zapisywalne): 8
- pola kalkulowane (zapisywalne): 3
- pola tylko-odczyt: 6
- podlisty: 7
- subrowy: 0
- razem: 24

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Credentials | `SubTable<CredentialKey>` | podlista |  |  |
| DBItems | `System.Collections.IList` | podlista |  |  |
| Email | `string` | bazodanowe | Adres e-mail | Określa adres e-mail operatora. |
| Entitles | `SubTable<Db.OperatorEntitle>` | podlista |  |  |
| Extension | `Db.OperatorEx` | tylko-odczyt |  |  |
| FullName | `string` | bazodanowe | Nazwa | Imię i nazwisko operatora. |
| IsAccountLocked | `bool` | bazodanowe | Zablokowany (hasło) | Oznacza operatora zablokowane z powodu wielokrotnego wprowadzania niepoprawnego hasła |
| IsOperatorNet | `bool` | bazodanowe | Logowaniu multi | Oznacza konto z możliwością do logowania się do wersji multi (HTML/Mobile) |
| IsSchedulerOperator | `bool` | tylko-odczyt |  |  |
| Kod | `string` | tylko-odczyt |  |  |
| Locked | `bool` | bazodanowe | Zablokowany | Określa, czy konto jest aktualnie zablokowane. |
| LoginVisible | `bool` |  |  | Czy operator ma być widoczny na liscie loginów w oknie logowania |
| MfaMode | `MfaMode` (enum) |  |  |  |
| Name | `string` | bazodanowe | Kod | Unikalny kod operatora wymagany podczas logowania się do bazy. |
| Nazwa | `string` | tylko-odczyt |  |  |
| NewPassword | `string` |  |  |  |
| NoticeRecipientGroup | `NoticeRecipientGroup` (enum) | tylko-odczyt |  |  |
| Password | `string` | bazodanowe |  |  |
| Permissions | `SubTable<Db.Permissions.RecordPermission>` | podlista |  |  |
| PowiązaniaStrOrg | `SubTable` | podlista |  |  |
| RecipientDesc | `string` | tylko-odczyt |  |  |
| Trusted | `string` | bazodanowe | Logowanie zintegrowane | Nazwa operatora zintegrowanego, który może się logować na to konto. |
| UserGroupMembers | `SubTable<Db.Permissions.UserGroupMember>` | podlista |  |  |
| UserGroups | `System.Collections.Generic.IEnumerable<Db.Permissions.UserGroup>` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### NoticeRecipientGroup (`NoticeRecipientGroup`)
- `AllGroups` = 0 — Wszyscy
- `Operators` = 1 — Operatorzy
- `Employees` = 2 — Pracownicy
- `ContactPersons` = 4 — Osoby kontaktowe
- `Chosen` = 8 — Wybrani
- `PanelUsers` = 16 — Użytkownicy panelu

### MfaMode (`MfaMode`)
- `Unregistered` = 0 — Niezarejestrowana
- `Registered` = 1 — Zarejestrowana
- `Verified` = 2 — Potwierdzona
- `RegisterMore` = 3 — Ponowna rejestracja
- `Disabled` = 4 — Zablokowana
