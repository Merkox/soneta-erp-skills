# Pola i właściwości klasy biznesowej: `k8s.KubeConfigModels.AuthProvider`
Nazwa tabeli: `AuthProviders`
Tytuł: Dostawcy autoryzacji
Opis: Konfiguracja dostawców autoryzacji dla kont pocztowych i integracji zewnętrznych (OAuth, SMTP, IMAP). Przechowuje parametry połączeń, klucze API i ustawienia szyfrowania, umożliwiając bezpieczną komunikację z serwerami poczty.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 9
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 3
- subrowy: 0
- razem: 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AuthType | `Soneta.CRM.AuthProviderType` (enum) | bazodanowe | Typ dostawcy | Typ dostawcy autoryzacji. |
| ClientId | `MemoText` | bazodanowe, podlista | Key | Key |
| ClientSecret | `MemoText` | bazodanowe, podlista | Secret | Secret |
| Config | `System.Collections.Generic.Dictionary<string, string>` | podlista |  |  |
| ImapEncryption | `bool` | bazodanowe | SSL/TLS | SSL/TLS |
| ImapPort | `int` | bazodanowe | IMAP Port | IMAP Port |
| ImapUrl | `string` | bazodanowe | IMAP Url | IMAP Url |
| Locked | `bool` | bazodanowe | Blokada | Określa czy dostawca jest zablokowany. |
| Name | `string` | bazodanowe | Nazwa | Nazwa dostawcy |
| SmtpEncryption | `bool` | bazodanowe | SSL/TLS | SSL/TLS |
| SmtpPort | `int` | bazodanowe | SMTP Port | SMTP Port |
| SmtpUrl | `string` | bazodanowe | SMTP Url | SMTP Url |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AuthProviderType (`Soneta.CRM.AuthProviderType`)
- `Password` = 1 — Login i Hasło
- `Gmail` = 2 — Gmail
- `Outlook` = 3 — Outlook
