# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.OperatorEx`
Nazwa tabeli: `OperatorsEx`
Tytuł: Dodatkowe ustawienia operatora
Opis: Rozszerzone ustawienia operatora. Określa uprawnienia administracyjne, logowanie zewnętrzne, polityka bezpieczeństwa haseł, MFA oraz preferencje interfejsu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operator` → `Operator`

- pola bazodanowe: 20
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllowConversion | `bool` | bazodanowe | Dozwolona konwersja | Określa operatora, który może wykonywać konwersję bazy danych. |
| AllowDataObfuscation | `bool` | bazodanowe | Zaciemnianie danych | Umożliwia operatorowi zaciemnianie wybranych wrażliwych danych. |
| AllowDevelopment | `bool` | bazodanowe | Funkcje programistyczne | Zezwala na zarządzanie funkcjami programistycznymi. |
| AllowEnova365 | `bool` | bazodanowe | Funkcje wersji serwerowej | Zezwala na dostęp do aplikacji serwerowej (HTML/Mobilna). |
| AllowExternalProviders | `bool` | bazodanowe | Zewnętrzne logowanie | Zezwala na dostęp do aplikacji serwerowej za pośrednictwem loginów zewnętrznych (facebook, google etc.) |
| AllowOperatorsManagment | `bool` | bazodanowe | Edycja operatorów | Umożliwia operatorowi zarządzanie innymi operatorami. |
| ClientLicenceNumber | `string` | bazodanowe | Numer licencji klienta | Umożliwia operatorowi logowanie na licencji innej niż podstawowa licencja bazy danych. |
| ExcludeFromPassSecPolicy | `bool` | bazodanowe | Wykluczenie z polityki bezpieczeństwa haseł | Wyklucza operatora z polityki bezpieczeństwa haseł. |
| ExternalProvider | `string` | bazodanowe | Nazwa zewnętrznego provider'a | Nazwa zewnętrznego providera, który odpowiada za wstępną autentykacje użytkownika. |
| ExternalProviderUserId | `string` | bazodanowe | Identyfikator użytkownika dla zewnętrznego provider'a | Identyfikator użytkownika zewnętrznego providera, z którym powiązane jest konto. |
| InvalidLoginCounter | `int` | bazodanowe | Niepoprawne logowanie | Liczba ostatnich błędnych logowań na konto operatora. |
| IsSupervisor | `bool` | bazodanowe | Przełożony | Czy operator jest przełożonym. |
| KnowledgeBaseID | `string` | bazodanowe | Login do Bazy Wiedzy | Adres email stanowiący ID dla Bazy Wiedzy |
| LoginVisible | `bool` | bazodanowe | Widoczny na liście logowania | Czy operator ma być widoczny na liscie loginów w oknie logowania |
| MfaMode | `int` | bazodanowe | Stan rejestracji uwierzytelniania dwuskładnikowego | Aktualny stan rejestracji metody uwierzytelniania dwuskładnikowego |
| Operator | `Soneta.Business.App.Operator` | bazodanowe, guided-parent |  |  |
| PasswordHistory | `Soneta.Business.MemoText` | bazodanowe |  |  |
| RecentInvalidLogin | `System.DateTime` | bazodanowe | Ostatnie niepoprawne logowanie | Czas ostatniego niepoprawnego logowania. |
| RecentPasswordChange | `System.DateTime` | bazodanowe | Ostatnia zmiana hasła | Czas ostatniej zmiany hasła przez operatora. |
| UICulture | `string` | bazodanowe | Język interface-u | Język wyświetlania interface-u użytkownika aplikacji. |
| UICultureInfo | `System.Globalization.CultureInfo` |  |  |  |
| UICultureName | `string` |  | Język interface-u |  |
