# Pola i właściwości klasy biznesowej: `Soneta.Web.Business.App.WebUser`
Nazwa tabeli: `WebUsers`
Opis: Użytkownik aplikacji webowej enova365. Przechowuje dane uwierzytelniające, typ konta, przypisane licencje modułowe (CRM, ZMN, PLN, BI itp.) oraz powiązania z operatorem enova365 i obiektem biznesowym (np. pracownikiem). Stanowi podstawę kontroli dostępu do interfejsu webowego.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `INoticeRecipient`, `IMfaOperator`

- pola bazodanowe: 21
- pola kalkulowane (z klas biznesowych): 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllowConfig | `bool` |  |  |  |
| Credentials | `Soneta.Business.SubTable<Soneta.Business.CredentialKey>` |  |  |  |
| Department | `string` |  | Wydział |  |
| Email | `string` | bazodanowe | Adres e-mail | Określa adres e-mail webusera. |
| FirstPassword | `string` | bazodanowe |  |  |
| FullName | `string` | bazodanowe | Pełna nazwa | Imię i nazwisko użytkownia. |
| HasLicenceBIN | `bool` | bazodanowe | Licencja BIN | Licencja BIN przypisana do użytkownika. |
| HasLicenceCRN | `bool` | bazodanowe | Licencja CRM | Licencja CRM przypisana do użytkownika. |
| HasLicenceKBN | `bool` | bazodanowe | Pulpit klienta BR | Licencja KBN przypisana do użytkownika. |
| HasLicencePKN | `bool` | bazodanowe | Pulpit kierownika | Licencja PKN przypisana do użytkownika. |
| HasLicencePLN | `bool` | bazodanowe | Licencja PLN | Licencja PLN przypisana do użytkownika. |
| HasLicencePMN | `bool` | bazodanowe | Pulpit manadżera | Licencja PMN przypisana do użytkownika. |
| HasLicencePXN | `bool` | bazodanowe | Licencja PXN | Licencja PXN przypisana do użytkownika. |
| HasLicencePZN | `bool` | bazodanowe | Licencja PZN | Licencja PZN przypisana do użytkownika. |
| HasLicenceWFN | `bool` | bazodanowe | Licencja WFN | Licencja WFN przypisana do użytkownika. |
| HasLicenceZMN | `bool` | bazodanowe | Licencja ZMN | Licencja ZMN przypisana do użytkownika. |
| Host | `Soneta.Business.IWebOperator` | bazodanowe, iface-ref | Obiekt powiązany | Podpięty obiekt związany z użytkownikiem web (np. Pracownik, KontaktOsoba) |
| IsAccountLocked | `bool` | bazodanowe | Zablokowany (hasło) | Oznacza konto zablokowane z powodu wielokrotnego wprowadzania niepoprawnego hasła |
| KnowledgeBaseID | `string` | bazodanowe | Login do Bazy Wiedzy | Adres email stanowiący ID dla Bazy Wiedzy |
| Locked | `bool` | bazodanowe | Zablokowany | Określa, czy konto jest aktualnie zablokowane. |
| MfaMode | `Soneta.Types.MfaMode` | enum |  |  |
| Name | `string` | bazodanowe | Kod | Unikalny kod użytkownika wymagany podczas logowania się do aplikacji web'owej. |
| Operator | `Soneta.Business.App.Operator` | bazodanowe | Operator enova365 | Powiązany z użytkownikiem enovaNet operator |
| Password | `string` | bazodanowe |  |  |
| Profile | `Soneta.Web.Business.App.WebProfile` |  |  |  |
| Type | `Soneta.Web.Business.Utils.WebUserType` | bazodanowe, enum | Typ użytkownika | Typ użytkownika korzystającego z aplikacji web'owej. |
| Upn | `string` |  |  |  |
| WebUserType | `Soneta.Web.Business.Utils.WebUserType` | enum |  |  |
| ZarejestrowaneLicencje | `Soneta.Business.Licence.LicencjaProgramu[]` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IWebOperator` | `KontaktOsoba`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### MfaMode (`Soneta.Types.MfaMode`)
- `Unregistered` = 0 — Niezarejestrowana
- `Registered` = 1 — Zarejestrowana
- `Verified` = 2 — Potwierdzona
- `RegisterMore` = 3 — Ponowna rejestracja
- `Disabled` = 4 — Zablokowana

### WebUserType (`Soneta.Web.Business.Utils.WebUserType`)
- `Administrator` = 1
- `Demo` = 2
- `Pracownik` = 3
- `Kontakt` = 4
- `Operator` = 5
- `Uzytkownik` = 6
