# Pola i właściwości klasy biznesowej: `Soneta.Business.App.Entitle`
Nazwa tabeli: `Entitles`
Tytuł: Uprawnienia
Opis: Oddział praw (uprawnienie) w systemie wielooddziałowości. Definiuje hierarchiczną strukturę uprawnień powiązaną z oddziałami firmy i rolami systemowymi.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IEntitle`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Children | `SubTable<App.Entitle>` | podlista |  |  |
| ConnectedRoles | `SubTable<Db.EntitleRef>` | podlista |  |  |
| CurrentOddzial | `App.IOddzialFirmy` | bazodanowe, iface-ref |  | Aktualny oddział firmy przypisany do uprawnienia. |
| CurrentRole | `App.Role` | tylko-odczyt |  |  |
| Destiny | `Db.SystemRoleDestiny` (enum) | tylko-odczyt |  |  |
| FullName | `string` | bazodanowe | Nazwa | Pełna nazwa oddziału praw. |
| LegacyRole | `MemoText` | bazodanowe, podlista |  | Wynikowa rola standardowego systemu praw. |
| Name | `string` | bazodanowe | Kod | Unikalny kod oddziału praw. |
| Operators | `SubTable<Db.OperatorEntitle>` | podlista |  |  |
| Parent | `App.Entitle` | bazodanowe |  |  |
| Rights | `SubTable<Db.Right>` | podlista |  |  |
| RightsSystem | `App.RightsSystem` (enum) | bazodanowe, tylko-odczyt |  |  |
| Roles | `SubTable<Db.EntitleRole>` | podlista |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| CurrentOddzial | `IOddzialFirmy` | `OddzialFirmy` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RightsSystem (`App.RightsSystem`)
- `Standard` = 0 — Standardowy
- `Extended` = 1 — Rozszerzony

### SystemRoleDestiny (`Db.SystemRoleDestiny`)
- `Neutral` = 0 — Neutralna
- `Forms` = 1 — Dla operatorów
- `Net` = 2 — Dla pulpitów
- `Common` = 3 — Wszystkie
