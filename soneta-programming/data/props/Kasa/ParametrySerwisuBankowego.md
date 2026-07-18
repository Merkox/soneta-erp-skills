# Pola i właściwości klasy biznesowej: `Soneta.Kasa.BankowoscElektroniczna.ParametrySerwisuBankowego`
Nazwa tabeli: `ParametrySeBnk`
Tytuł: Parametry serwisów bankowych
Opis: Parametry konfiguracyjne serwisu bankowości elektronicznej przypisane do konkretnego operatora. Przechowuje dane uwierzytelniające (certyfikaty, hasła) i ustawienia połączenia niezbędne do autoryzacji operatora w usłudze bankowej online.
Tabela konfiguracyjna: Tak

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 6
- podlisty: 2
- subrowy: 1
- razem: 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ClientCert | `Soneta.Kasa.BankowoscElektroniczna.BankOnlineCert` (subrow) | bazodanowe |  |  |
| ClientCert.Body | `MemoText` | bazodanowe, podlista | Certyfikat |  |
| ClientCert.Issuer | `string` | bazodanowe, tylko-odczyt | Wystawca certyfikatu |  |
| ClientCert.Name | `string` | bazodanowe, tylko-odczyt | Nazwa certyfikatu |  |
| ClientCert.Obecnosc | `Soneta.Kasa.BankowoscElektroniczna.ObecnoscCertyfikatu` (enum) | tylko-odczyt |  |  |
| ClientCert.Pass | `string` | bazodanowe, tylko-odczyt | Hasło certyfikatu |  |
| Operator | `App.Operator` | bazodanowe, tylko-odczyt |  | Operator parametrów |
| SerwisBankowy | `Soneta.Kasa.BankowoscElektroniczna.SerwisBankowy` | bazodanowe, tylko-odczyt |  | Serwis bankowy |
| Value | `MemoText` | bazodanowe, podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ObecnoscCertyfikatu (`Soneta.Kasa.BankowoscElektroniczna.ObecnoscCertyfikatu`)
- `Nie` = 0
- `Tak` = 1
- `TakHaslo` = 2 — Tak, z hasłem
