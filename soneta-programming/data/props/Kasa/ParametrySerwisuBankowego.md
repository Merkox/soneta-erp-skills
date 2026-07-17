# Pola i właściwości klasy biznesowej: `Soneta.Kasa.BankowoscElektroniczna.ParametrySerwisuBankowego`
Nazwa tabeli: `ParametrySeBnk`
Tytuł: Parametry serwisów bankowych
Opis: Parametry konfiguracyjne serwisu bankowości elektronicznej przypisane do konkretnego operatora. Przechowuje dane uwierzytelniające (certyfikaty, hasła) i ustawienia połączenia niezbędne do autoryzacji operatora w usłudze bankowej online.
Tabela konfiguracyjna: Tak

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ClientCert | `Soneta.Kasa.BankowoscElektroniczna.BankOnlineCert` | bazodanowe |  |  |
| ClientCert.Body | `Soneta.Business.MemoText` | bazodanowe | Certyfikat |  |
| ClientCert.Issuer | `string` | bazodanowe | Wystawca certyfikatu |  |
| ClientCert.Name | `string` | bazodanowe | Nazwa certyfikatu |  |
| ClientCert.Obecnosc | `Soneta.Kasa.BankowoscElektroniczna.ObecnoscCertyfikatu` | enum |  |  |
| ClientCert.Pass | `string` | bazodanowe | Hasło certyfikatu |  |
| Operator | `Soneta.Business.App.Operator` | bazodanowe |  | Operator parametrów |
| SerwisBankowy | `Soneta.Kasa.BankowoscElektroniczna.SerwisBankowy` | bazodanowe |  | Serwis bankowy |
| Value | `Soneta.Business.MemoText` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ObecnoscCertyfikatu (`Soneta.Kasa.BankowoscElektroniczna.ObecnoscCertyfikatu`)
- `Nie` = 0
- `Tak` = 1
- `TakHaslo` = 2 — Tak, z hasłem
