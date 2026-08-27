# Pola i właściwości klasy biznesowej: `Soneta.Web.Business.App.WebProfile`
Nazwa tabeli: `WebProfiles`
Opis: Element szczegółowy użytkownika webowego (WebUser). Profil przechowuje preferencje interfejsu (styl, język), historię aktywności i logowań, politykę haseł oraz konfigurację uwierzytelniania zewnętrznego i dwuskładnikowego. Służy do personalizacji i zabezpieczania sesji użytkownika.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllowConfig | `bool` | bazodanowe | Dostęp do konfiguracji | Określa, czy konto ma uprawnienia do modyfikowania konfiguracji. |
| AllowExternalProviders | `bool` | bazodanowe | Logowanie zewnętrzne | Zezwala na dostęp do enova365 za pośrednictwem loginów zewnętrznych (facebook, google etc.) |
| ExternalProvider | `string` | bazodanowe | Nazwa zewnętrznego provideraa | Nazwa zewnętrznego providera, który odpowiada za wstępną autentykacje użytkownika. |
| ExternalProviderUserId | `string` | bazodanowe | Identyfikator użytkownika dla zewnętrznego providera | Identyfikator użytkownika zewnętrznego providera, z którym powiązane jest konto. |
| InvalidLoginCounter | `int` | bazodanowe | Niepoprawne logowanie | Liczba ostatnich błędnych logowań na konto operatora. |
| LastActivityDate | `System.DateTime` | bazodanowe | Ostatnia data aktywności | Ostatnia data aktywności użytkownika. |
| LastActivityIP | `string` | bazodanowe | Ostatni adres IP | Ostatni adres IP aktywności użytkownika. |
| MfaMode | `int` | bazodanowe | Stan rejestracji uwierzytelniania dwuskładnikowego | Aktualny stan rejestracji metody uwierzytelniania dwuskładnikowego |
| NumberOfVisits | `int` | bazodanowe | Ilość wejść | Ilość wejść do aplikacji przez użytkownika. |
| PasswordHistory | `MemoText` | bazodanowe, podlista |  |  |
| PreviousActivityDate | `System.DateTime` | bazodanowe | Poprzednia data aktywności | Poprzednia data aktywności użytkownika. |
| PreviousActivityIP | `string` | bazodanowe | Poprzedni adres IP | Poprzedni adres IP aktywności użytkownika. |
| RecentInvalidLogin | `System.DateTime` | bazodanowe | Ostatnie niepoprawne logowanie | Czas ostatniego niepoprawnego logowania. |
| RecentPasswordChange | `System.DateTime` | bazodanowe, tylko-odczyt | Ostatnia zmiana hasła | Czas ostatniej zmiany hasła przez operatora. |
| Theme | `string` | bazodanowe | Styl | Preferowany styl strony. |
| UICulture | `string` | bazodanowe | Język | Preferowany kultura (język) interface'u. |
| UICultureInfo | `System.Globalization.CultureInfo` | tylko-odczyt |  |  |
| User | `Soneta.Web.Business.App.WebUser` | bazodanowe |  |  |
