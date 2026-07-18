# Pola i właściwości klasy biznesowej: `Soneta.CRM.WiadomoscEmail`
Nazwa tabeli: `WiadomosciEmail`
Tytuł: Wiadomości email
Opis: Wiadomość e-mail pobrana lub wysłana przez konto pocztowe w systemie CRM. Przechowuje pełną treść, nagłówki, informacje o załącznikach i statusie, umożliwiając prowadzenie korespondencji oraz powiązanie wiadomości z kontrahentami i dokumentami.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IPermissionClient`

- pola bazodanowe (zapisywalne): 14
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 14
- subrowy: 0
- razem: 32

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DW | `MemoText` | bazodanowe, podlista | DW | Do wiadomości. |
| Data | `System.DateTime` | bazodanowe | Data | Data wiadomości. |
| DeliveryConfirmation | `Soneta.CRM.EmailConfirmation` | tylko-odczyt |  |  |
| Do | `MemoText` | bazodanowe, podlista | Do | Adresaci wiadomości. |
| DostepnyHtml | `bool` | bazodanowe | Dostępna treść Html | Określa czy na serwerze dostępna jest treść html. |
| Dzien | `Date` | tylko-odczyt | Dzień |  |
| ElementyPowiazane | `SubTable<Soneta.CRM.ElementEmail>` | podlista |  |  |
| ElementyPowiazaneView | `View` | podlista |  |  |
| Folder | `string` | bazodanowe |  | Folder, z którego pochodzi wiadomość. |
| InReplyTo | `string` | bazodanowe | InReplyTo | Identyfikator odpowiedzi. |
| KontoPocztowe | `Soneta.CRM.Config.KontoPocztowe` | bazodanowe | Konto | Konto pocztowe |
| MessageID | `string` | bazodanowe | MessageID | Identyfikator wiadomości na serwerze. |
| NotificationTo | `MemoText` | bazodanowe, podlista | NotificationTo | Potwierdzenie odczytu do. |
| Od | `MemoText` | bazodanowe, podlista | Od | Nadawca wiadomości. |
| Odpowiedzi | `SubTable<Soneta.CRM.WiadomoscEmail>` | podlista |  |  |
| Odpowiedziano | `bool` | tylko-odczyt |  |  |
| Permissions | `SubTable<Db.Permissions.RecordPermission>` | podlista |  |  |
| PotwOdczytania | `bool` | bazodanowe | Potwierdzenie odczytania wiadomości | Określa czy mamy otrzymać potwierdzenie odczytania wiadomości. |
| PrawaExt | `System.Collections.ArrayList` | podlista |  |  |
| PrawaOperatorow | `System.Collections.ArrayList` | podlista |  |  |
| ReadingConfirmation | `Soneta.CRM.EmailConfirmation` | tylko-odczyt |  |  |
| ReplyTo | `MemoText` | bazodanowe, podlista | ReplyTo | Odpowiedź do. |
| ReturnReceiptTo | `MemoText` | bazodanowe, podlista | ReturnReceiptTo | Potwierdzenie dostarczenia do. |
| RozmiarZalacznikow | `int` | bazodanowe | Rozmiar załączników [KB] | Określa rozmiar załączników w kilobajtach. |
| SaZalaczniki | `bool` | bazodanowe | Są załączniki | Określa czy wiadomość odebrana zawiera załączniki. |
| StatusWiadomosci | `Soneta.CRM.StatusWiadomosci` (enum) | bazodanowe |  | Określa status wiadomości. |
| Temat | `string` | bazodanowe | Temat | Temat wiadomości. |
| Tresc | `MemoText` | bazodanowe, podlista | Treść | Treść wiadomości. |
| TypWiadomosci | `Soneta.CRM.TypWiadomości` (enum) | bazodanowe | Typ wiadomości | Typ wiadomości. |
| UDW | `MemoText` | bazodanowe, podlista | UDW | Do wiadomości (Ukryte). |
| UID | `decimal` | bazodanowe |  | Unikalny identyfikator wiadomości w skrzynce. |
| WiadomoscZrodlowa | `Soneta.CRM.WiadomoscEmail` | bazodanowe | Wiadomość źródłowa | Identyfikator wiadomości, na którą odpowiadamy. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusWiadomosci (`Soneta.CRM.StatusWiadomosci`)
- `Nieprzeczytana` = 0 — Nieprzeczytana
- `Przeczytana` = 1

### TypWiadomości (`Soneta.CRM.TypWiadomości`)
- `Odebrana` = 0 — Odebrana
- `Wysłana` = 1
- `Robocza` = 2
- `DoWysłania` = 3
- `WysłanaAsystentem` = 4
