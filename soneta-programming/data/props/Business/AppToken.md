# Pola i właściwości klasy biznesowej: `Soneta.Business.App.AppToken`
Nazwa tabeli: `AppTokens`
Tytuł: Tokeny aplikacyjne
Opis: Token aplikacyjny do autoryzacji dostępu API. Przechowuje nazwę, typ, zawartość tokena, datę ważności i powiązanie z operatorem uprawnionym do jego użycia.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ExpirationDate | `Soneta.Types.Date` | bazodanowe | Data ważności | Data ważności tokena aplikacyjnego. |
| IsWebOperator | `bool` |  |  |  |
| Locked | `bool` | bazodanowe | Zablokowany | Blokada tokena. |
| Name | `string` | bazodanowe | Nazwa |  |
| Operator | `Soneta.Business.IWebOperator` | bazodanowe, iface-ref |  | Operator upoważniony do wykonywania operacji dla wygenerowanego tokena. |
| Token | `Soneta.Business.MemoText` | bazodanowe | Token aplikacyjny | Zawartość token w postaci base64. |
| TokenItems | `Soneta.Business.SubTable<Soneta.Business.App.AppTokenItem>` |  |  |  |
| TokenJson | `string` |  |  |  |
| TokenRights | `Soneta.Business.SubTable<Soneta.Business.App.AppTokenRight>` |  |  |  |
| Type | `Soneta.Business.AppTokenType` | bazodanowe, enum | Typ | Określa przeznaczenie tokena. |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Operator | `IWebOperator` | `KontaktOsoba`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AppTokenType (`Soneta.Business.AppTokenType`)
- `WebApi` = 0 — WebApi
- `Biometric` = 1 — Biometric
- `Other` = 2
