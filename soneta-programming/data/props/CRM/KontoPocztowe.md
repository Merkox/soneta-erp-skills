# Pola i właściwości klasy biznesowej: `Soneta.CRM.Config.KontoPocztowe`
Nazwa tabeli: `KontaPocztowe`
Tytuł: Konta pocztowe
Opis: Konfiguracja konta pocztowego e-mail operatora systemu. Przechowuje parametry serwerów IMAP/SMTP, dane uwierzytelniania, ustawienia synchronizacji i pobierania wiadomości, stanowiąc podstawę obsługi poczty elektronicznej w module CRM.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe: 32
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AccountType | `Soneta.CRM.AuthProviderType` | bazodanowe, enum | Typ dostawcy | Typ dostawcy autoryzacji |
| Algorytm | `bool` | bazodanowe |  | Określa czy istnieje algorytm dla konta pocztowego. |
| AuthProvider | `Soneta.CRM.Config.AuthProvider` | bazodanowe | Dostawca Autoryzacji | Dostawca Autoryzacji |
| Blokada | `bool` | bazodanowe | Blokada | Określa czy konto jest zablokowane. |
| ClassName | `string` |  |  |  |
| Code | `Soneta.Business.MemoText` | bazodanowe | Kod kalkulatora konta pocztowego | Kod klasy kalkulatora dla konta pocztowego. |
| DataOd | `Soneta.Types.Date` | bazodanowe |  | Określa datę, od której należy ściągać wiadomości. |
| Foldery | `Soneta.Business.SubTable<Soneta.CRM.Config.FolderPocztowy>` |  |  |  |
| Haslo | `string` | bazodanowe | Hasło | Hasło użytkownika. |
| IMAPEncryption | `bool` | bazodanowe | SSL/TLS | Określa czy używane jest szyfrowanie SSL/TLS. |
| IMAPPort | `int` | bazodanowe | Port | Numer portu dla protokołu IMAP. |
| IMAPServer | `string` | bazodanowe | Serwer | Nazwa serwera IMAP. |
| IsSource | `bool` |  |  |  |
| Login | `string` | bazodanowe | Login | Login użytkownika. |
| MarkAsSeen | `bool` | bazodanowe | Ściągane wiadomości oznaczaj jako przeczytane | Określa czy system powinien automatycznie oznaczać ściągane wiadomości jako przeczytane na serwerze. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa użytkownika (adres e-mail). |
| NazwaNadawcy | `string` | bazodanowe | Nazwa nadawcy | Nazwa, która pojawi się w polu OD. |
| PobierajZalaczniki | `bool` | bazodanowe |  | Określa czy pobierać załączniki do wiadomości. |
| ReceiveTimeout | `int` | bazodanowe | Czas oczekiwania na odpowiedź z serwera | Określa czas oczekiwania na odpowiedź z serwera w sekudach. |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| SMTPEncryption | `bool` | bazodanowe | SSL/TLS | Określa czy używane jest szyfrowanie SSL/TLS. |
| SMTPPort | `int` | bazodanowe | Port | Numer portu dla protokołu SMTP. |
| SMTPServer | `string` | bazodanowe | Serwer | Nazwa serwera SMTP. |
| SaveAsSent | `bool` | bazodanowe | Zapisz wiadomości z folderu wysłane jako wysłane | Określa czy wiadomości z folderu wysłane mają być zapisane jako wiadomości wysłane w systemie. |
| SkipCertErrors | `bool` | bazodanowe | Ignoruj błędy SSL | Określa czy ignorowane mają być błędy certyfikatów SSL. |
| SkipSmtpAuth | `bool` | bazodanowe | Pomiń uwierzytelnianie | Określa czy podczas tworzenia połączenia SMTP pomijać uwierzytelnianie. |
| SmtpWymagaUwierzytelniania | `bool` |  |  |  |
| SyncDelete | `bool` | bazodanowe | Usuwaj wiadomości z serwera | Określa czy po usunięciu wiadomości w systemie usunąć ją także z serwera. |
| SyncSeen | `bool` | bazodanowe | Oznaczaj wiadomości na serwerze | Określa czy po oznaczeniu wiadomości w systemie oznaczyć ją także na serwerze |
| Token | `Soneta.CRM.Config.AuthToken` | bazodanowe | Token | Token |
| TylkoTekst | `bool` | bazodanowe | Tylko tekst | Określa czy treść wiadomości ma być zapisywana jako czysty tekst. |
| UploadSentMail | `bool` | bazodanowe | Po udanej wysyłce wiadomości zapisz ją w folderze wiadomości wysłanych na serwerze |  |
| Wiadomosci | `Soneta.Business.SubTable<Soneta.CRM.WiadomoscEmail>` |  |  |  |
| ZamienZKL | `bool` | bazodanowe | Zamień znaki końca linii | Określa czy znaki końca linii mają zostać zamienione. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AuthProviderType (`Soneta.CRM.AuthProviderType`)
- `Password` = 1 — Login i Hasło
- `Gmail` = 2 — Gmail
- `Outlook` = 3 — Outlook
