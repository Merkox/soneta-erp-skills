# Pola i właściwości klasy biznesowej: `Soneta.Business.CredentialKey`
Nazwa tabeli: `CredentialKeys`
Tytuł: Klucze Mfa
Opis: Klucz uwierzytelniania dwuskładnikowego (MFA) przypisany do operatora. Przechowuje typ, nazwę opisową i zaszyfrowany klucz rejestracji.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Key | `string` | bazodanowe | Klucz | Aktualny klucz rejestracji uwierzytelniania dwuskładnikowego. |
| Name | `string` | bazodanowe | Nazwa | Nazwa opisowa klucza. |
| Operator | `IMfaOperator` | bazodanowe, iface-ref |  | Operator upoważniony do wykonywania operacji dla wygenerowanego tokena. |
| Type | `MfaType` (enum) | bazodanowe | Typ | Określa przeznaczenie klucza. |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Operator | `IMfaOperator` | `Operator`, `WebUser` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### MfaType (`MfaType`)
- `None` = 0 — Brak
- `Totp` = 1 — Uwierzytelnianie oparte o kody czasowe TOTP
- `Fido` = 2 — Uwierzytelnianie oparte o FIDO2
