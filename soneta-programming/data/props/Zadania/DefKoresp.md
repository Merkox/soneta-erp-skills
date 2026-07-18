# Pola i właściwości klasy biznesowej: `Soneta.Zadania.DefKoresp`
Nazwa tabeli: `DefsKoresp`
Tytuł: Definicje korespondencji
Opis: Szablon korespondencji seryjnej CRM. Konfiguruje numerację, sposób wysyłki e-mail, obsługę załączników, stany po wysyłce oraz powiązaną definicję zdarzenia.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`, `IWFDefinitionHost`

- pola bazodanowe (zapisywalne): 14
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 5
- podlisty: 1
- subrowy: 1
- razem: 22

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. Zablokowane definicje korespondencji nie będą wyświetlane w liście wyboru. |
| CreateProcess | `Soneta.Core.DbTuples.CreateProcessType` (enum) | bazodanowe | Uruchom procesy |  |
| DataType | `System.Type` | tylko-odczyt |  |  |
| DefZdarzenia | `Soneta.Zadania.DefZadania` | bazodanowe | Definicja zdarzenia | Definicja zdarzenia, które będzie generowane jako korespondencja. |
| Domyslna | `bool` | bazodanowe | Domyślna | Określa, że jest to domyślna definicja korespondencji. |
| IsEnabled | `bool` | tylko-odczyt |  |  |
| Key | `string` | tylko-odczyt |  |  |
| KontrolaAdresowEmail | `Soneta.Core.TypKontroli` (enum) | bazodanowe | Typ kontroli adresów e-mail | Określa typ kontroli adresów e-mail. |
| Nazwa | `string` | bazodanowe | Nazwa | Pełna nazwa definicji korespondencji. |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` (subrow) | bazodanowe | Numeracja | Ustawienia określające sposób numeracji korespondencji. |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| OpoznienieWysylki | `int` | bazodanowe | Opóźnienie wysyłki | Określa czas (w sekundach) przerw pomiędzy wysyłaniem maili indywidualnych. |
| OpoznienieWysylkiMilisekundy | `int` | tylko-odczyt |  |  |
| SposobWysylki | `Soneta.Core.SposobWysylkiMail` (enum) | bazodanowe | Sposób wysyłki maila | Określa w jaki sposób wysyłki maila. |
| StanKorespPoWysylce | `Soneta.Zadania.StanKoresp` | bazodanowe | Stan po wysyłce | Stan korespondencji po wysyłce wiadomości. |
| StanZdarzPoWysylce | `Soneta.Zadania.StanZadania` | bazodanowe | Definicja zdarzenia po wysyłce | Definicja zdarzenia po wysyłce korespondecji. |
| Stany | `LpSubTable<Soneta.Zadania.StanKoresp>` | podlista |  |  |
| Symbol | `string` | bazodanowe | Symbol | Skrótowa nazwa definicji korespondencji wykorzystywana do wyszukiwania definicji. |
| WFDefinition | `IWFDefinition` | tylko-odczyt, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| WFDefinition | `IWFDefinition` | `WFDefinition` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### CreateProcessType (`Soneta.Core.DbTuples.CreateProcessType`)
- `Default` = 0 — Podczas zapisu dokumentu
- `OnAdded` = 1 — Podczas dodawania dokumentu

### SposobWysylkiMail (`Soneta.Core.SposobWysylkiMail`)
- `Brak` = 0 — Brak
- `Grupowe` = 1
- `Indywidualne` = 2

### TypKontroli (`Soneta.Core.TypKontroli`)
- `Brak` = 0 — Brak
- `Ostrzegaj` = 1
- `Zabraniaj` = 2
