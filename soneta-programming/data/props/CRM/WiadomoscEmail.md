# Pola i właściwości klasy biznesowej: `Soneta.CRM.WiadomoscEmail`
Nazwa tabeli: `WiadomosciEmail`
Tytuł: Wiadomości email
Opis: Wiadomość e-mail pobrana lub wysłana przez konto pocztowe w systemie CRM. Przechowuje pełną treść, nagłówki, informacje o załącznikach i statusie, umożliwiając prowadzenie korespondencji oraz powiązanie wiadomości z kontrahentami i dokumentami.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IPermissionClient`

- pola bazodanowe: 22
- pola kalkulowane (z klas biznesowych): 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DW | `Soneta.Business.MemoText` | bazodanowe | DW | Do wiadomości. |
| Data | `System.DateTime` | bazodanowe | Data | Data wiadomości. |
| DeliveryConfirmation | `Soneta.CRM.EmailConfirmation` |  |  |  |
| Do | `Soneta.Business.MemoText` | bazodanowe | Do | Adresaci wiadomości. |
| DostepnyHtml | `bool` | bazodanowe | Dostępna treść Html | Określa czy na serwerze dostępna jest treść html. |
| Dzien | `Soneta.Types.Date` |  | Dzień |  |
| ElementyPowiazane | `Soneta.Business.SubTable<Soneta.CRM.ElementEmail>` |  |  |  |
| ElementyPowiazaneView | `Soneta.Business.View` |  |  |  |
| Folder | `string` | bazodanowe |  | Folder, z którego pochodzi wiadomość. |
| InReplyTo | `string` | bazodanowe | InReplyTo | Identyfikator odpowiedzi. |
| KontoPocztowe | `Soneta.CRM.Config.KontoPocztowe` | bazodanowe | Konto | Konto pocztowe |
| MessageID | `string` | bazodanowe | MessageID | Identyfikator wiadomości na serwerze. |
| NotificationTo | `Soneta.Business.MemoText` | bazodanowe | NotificationTo | Potwierdzenie odczytu do. |
| Od | `Soneta.Business.MemoText` | bazodanowe | Od | Nadawca wiadomości. |
| Odpowiedzi | `Soneta.Business.SubTable<Soneta.CRM.WiadomoscEmail>` |  |  |  |
| Odpowiedziano | `bool` |  |  |  |
| Permissions | `Soneta.Business.SubTable<Soneta.Business.Db.Permissions.RecordPermission>` |  |  |  |
| PotwOdczytania | `bool` | bazodanowe | Potwierdzenie odczytania wiadomości | Określa czy mamy otrzymać potwierdzenie odczytania wiadomości. |
| PrawaExt | `System.Collections.ArrayList` |  |  |  |
| PrawaOperatorow | `System.Collections.ArrayList` |  |  |  |
| ReadingConfirmation | `Soneta.CRM.EmailConfirmation` |  |  |  |
| ReplyTo | `Soneta.Business.MemoText` | bazodanowe | ReplyTo | Odpowiedź do. |
| ReturnReceiptTo | `Soneta.Business.MemoText` | bazodanowe | ReturnReceiptTo | Potwierdzenie dostarczenia do. |
| RozmiarZalacznikow | `int` | bazodanowe | Rozmiar załączników [KB] | Określa rozmiar załączników w kilobajtach. |
| SaZalaczniki | `bool` | bazodanowe | Są załączniki | Określa czy wiadomość odebrana zawiera załączniki. |
| StatusWiadomosci | `Soneta.CRM.StatusWiadomosci` | bazodanowe, enum |  | Określa status wiadomości. |
| Temat | `string` | bazodanowe | Temat | Temat wiadomości. |
| Tresc | `Soneta.Business.MemoText` | bazodanowe | Treść | Treść wiadomości. |
| TypWiadomosci | `Soneta.CRM.TypWiadomości` | bazodanowe, enum | Typ wiadomości | Typ wiadomości. |
| UDW | `Soneta.Business.MemoText` | bazodanowe | UDW | Do wiadomości (Ukryte). |
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
