# Pola i właściwości klasy biznesowej: `Soneta.CRM.Config.AuthAzureConfig`
Nazwa tabeli: `AuthAzureConfigs`
Tytuł: Konfiguracja Aplikacji AAD
Opis: Konfiguracja integracji z Azure Active Directory dla dostawcy autoryzacji. Definiuje parametry aplikacji AAD (TenantId, tryb pozyskiwania tokenu, grupę odbiorców), niezbędne do uwierzytelniania OAuth w usługach Microsoft 365.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AcquireTokenMode | `Soneta.CRM.AuthAzureAcquireTokenMode` (enum) | bazodanowe |  |  |
| AuthProvider | `Soneta.CRM.Config.AuthProvider` | bazodanowe | AuthProvider | AuthProvider |
| AuthorityAudience | `Soneta.CRM.AuthAzureAuthorityAudience` (enum) | bazodanowe |  |  |
| TenantId | `MemoText` | bazodanowe, podlista | TenantId | TenantId |
| UseDeviceCode | `bool` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AuthAzureAcquireTokenMode (`Soneta.CRM.AuthAzureAcquireTokenMode`)
- `ByUsernamePassword` = 0 — Login i hasło
- `IntegratedWindowsAuth` = 1 — Logowanie zintegrowane Windows
- `WithDeviceCode` = 2 — Kod urządzenia
- `Interactive` = 3 — Interaktywne okno logowania

### AuthAzureAuthorityAudience (`Soneta.CRM.AuthAzureAuthorityAudience`)
- `None` = 0 — Nie Dotyczy
- `AzureAdMyOrg` = 1 — Moja organizacja (Single tenant)
- `AzureAdAndPersonalMicrosoftAccount` = 2 — Dowolna organizacja i konta prywatne
- `AzureAdMultipleOrgs` = 3 — Dowolna organizacja (Multitenant)
- `PersonalMicrosoftAccount` = 4 — Konta prywatne (np. Hotmail, Outlook)
