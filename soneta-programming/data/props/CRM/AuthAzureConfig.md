# Pola i właściwości klasy biznesowej: `Soneta.CRM.Config.AuthAzureConfig`
Nazwa tabeli: `AuthAzureConfigs`
Tytuł: Konfiguracja Aplikacji AAD
Opis: Konfiguracja integracji z Azure Active Directory dla dostawcy autoryzacji. Definiuje parametry aplikacji AAD (TenantId, tryb pozyskiwania tokenu, grupę odbiorców), niezbędne do uwierzytelniania OAuth w usługach Microsoft 365.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AcquireTokenMode | `Soneta.CRM.AuthAzureAcquireTokenMode` | bazodanowe, enum |  |  |
| AuthProvider | `Soneta.CRM.Config.AuthProvider` | bazodanowe | AuthProvider | AuthProvider |
| AuthorityAudience | `Soneta.CRM.AuthAzureAuthorityAudience` | bazodanowe, enum |  |  |
| TenantId | `Soneta.Business.MemoText` | bazodanowe | TenantId | TenantId |
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
