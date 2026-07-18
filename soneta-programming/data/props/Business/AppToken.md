# Pola i właściwości klasy biznesowej: `Soneta.Business.App.AppToken`
Nazwa tabeli: `AppTokens`
Tytuł: Tokeny aplikacyjne
Opis: Token aplikacyjny do autoryzacji dostępu API. Przechowuje nazwę, typ, zawartość tokena, datę ważności i powiązanie z operatorem uprawnionym do jego użycia.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 3
- subrowy: 0
- razem: 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ExpirationDate | `Date` | bazodanowe, tylko-odczyt | Data ważności | Data ważności tokena aplikacyjnego. |
| IsWebOperator | `bool` | tylko-odczyt |  |  |
| Locked | `bool` | bazodanowe | Zablokowany | Blokada tokena. |
| Name | `string` | bazodanowe | Nazwa |  |
| Operator | `IWebOperator` | bazodanowe, iface-ref |  | Operator upoważniony do wykonywania operacji dla wygenerowanego tokena. |
| Token | `MemoText` | bazodanowe, podlista | Token aplikacyjny | Zawartość token w postaci base64. |
| TokenItems | `SubTable<App.AppTokenItem>` | podlista |  |  |
| TokenJson | `string` | tylko-odczyt |  |  |
| TokenRights | `SubTable<App.AppTokenRight>` | podlista |  |  |
| Type | `AppTokenType` (enum) | bazodanowe | Typ | Określa przeznaczenie tokena. |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Operator | `IWebOperator` | `KontaktOsoba`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AppTokenType (`AppTokenType`)
- `WebApi` = 0 — WebApi
- `Biometric` = 1 — Biometric
- `Other` = 2
