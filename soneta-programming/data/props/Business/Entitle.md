# Pola i właściwości klasy biznesowej: `Soneta.Business.App.Entitle`
Nazwa tabeli: `Entitles`
Tytuł: Uprawnienia
Opis: Oddział praw (uprawnienie) w systemie wielooddziałowości. Definiuje hierarchiczną strukturę uprawnień powiązaną z oddziałami firmy i rolami systemowymi.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IEntitle`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Children | `Soneta.Business.SubTable<Soneta.Business.App.Entitle>` |  |  |  |
| ConnectedRoles | `Soneta.Business.SubTable<Soneta.Business.Db.EntitleRef>` |  |  |  |
| CurrentOddzial | `Soneta.Business.App.IOddzialFirmy` | bazodanowe, iface-ref |  | Aktualny oddział firmy przypisany do uprawnienia. |
| CurrentRole | `Soneta.Business.App.Role` |  |  |  |
| Destiny | `Soneta.Business.Db.SystemRoleDestiny` | enum |  |  |
| FullName | `string` | bazodanowe | Nazwa | Pełna nazwa oddziału praw. |
| LegacyRole | `Soneta.Business.MemoText` | bazodanowe |  | Wynikowa rola standardowego systemu praw. |
| Name | `string` | bazodanowe | Kod | Unikalny kod oddziału praw. |
| Operators | `Soneta.Business.SubTable<Soneta.Business.Db.OperatorEntitle>` |  |  |  |
| Parent | `Soneta.Business.App.Entitle` | bazodanowe |  |  |
| Rights | `Soneta.Business.SubTable<Soneta.Business.Db.Right>` |  |  |  |
| RightsSystem | `Soneta.Business.App.RightsSystem` | bazodanowe, enum |  |  |
| Roles | `Soneta.Business.SubTable<Soneta.Business.Db.EntitleRole>` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| CurrentOddzial | `IOddzialFirmy` | `OddzialFirmy` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RightsSystem (`Soneta.Business.App.RightsSystem`)
- `Standard` = 0 — Standardowy
- `Extended` = 1 — Rozszerzony

### SystemRoleDestiny (`Soneta.Business.Db.SystemRoleDestiny`)
- `Neutral` = 0 — Neutralna
- `Forms` = 1 — Dla operatorów
- `Net` = 2 — Dla pulpitów
- `Common` = 3 — Wszystkie
