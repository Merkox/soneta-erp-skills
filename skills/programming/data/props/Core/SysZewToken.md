# Pola i właściwości klasy biznesowej: `Soneta.Core.SysZewToken`
Nazwa tabeli: `SysZewTokeny`
Tytuł: Autoryzacje systemów zewnętrznych
Opis: Konfiguracja autoryzacji (tokenu) systemu zewnętrznego, w szczególności KSeF. Przechowuje system zewnętrzny, nazwę, token, rodzaj uwierzytelniania, certyfikaty, RefreshToken, wersję API, przeznaczenie oraz uprawnienia pobierania i wysyłania.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Certyfikat | `MemoBin` | bazodanowe |  |  |
| CertyfikatHasloValue | `MemoBin` | bazodanowe |  |  |
| CertyfikatKey | `MemoBin` | bazodanowe |  |  |
| DataWaznosciUwierzytelnienia | `System.DateTime` | tylko-odczyt |  |  |
| IdentyfikatorWewnetrzny | `Soneta.Core.KSeFIdentWewn` |  | Identyfikator wewnętrzny |  |
| IdentyfikatoryWewnetrzne | `Soneta.Core.KSeFIdentWewn[]` | podlista | Identyfikatory wewnętrzne |  |
| KontekstAutentykacjiKSeF | `Soneta.Core.KSeF.Models.KontekstAutentykacjiKSeF` | tylko-odczyt | Kontekst autentykacji certyfikatu na podstawie zapisanego ostatniego logowania |  |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa |
| Operator | `IWebUser[]` | podlista |  |  |
| OperatorzyGuids | `MemoText` | bazodanowe, podlista | Operatorzy | Operatorzy |
| Pobieranie | `bool` | bazodanowe | Pobieranie | Pobieranie |
| Przeznaczenie | `Soneta.Core.PrzeznaczenieAutoryzacjiKSeF` (enum) | bazodanowe | Przeznaczenie autoryzacji KSeF | Przeznaczenie autoryzacji KSeF. |
| RefreshTokenRequestRefNumber | `string` | bazodanowe |  |  |
| RefreshTokenRequestTempTokenValue | `MemoBin` | bazodanowe |  |  |
| RefreshTokenValidUntil | `System.DateTime` | bazodanowe |  |  |
| RefreshTokenValidUntilOffset | `string` | bazodanowe |  |  |
| RefreshTokenValue | `MemoBin` | bazodanowe |  |  |
| RelacjeDoIdentWewnKseF | `SubTable<Soneta.Core.KSeFTokenIdentWewnRel>` | podlista |  |  |
| Rodzaj | `Soneta.Core.RodzajSysZewToken` (enum) | bazodanowe | Rodzaj uwierzytelniania | Rodzaj uwierzytelniania. |
| SposobIdentyfikacjiPodmiotuUwierzytelniajacego | `Soneta.Core.Enums.SposobIdentyfikacjiPodmiotuUwierzytelniajacego` (enum) | bazodanowe | Sposób identyfikacji podmiotu uwierzytelniającego | Sposób identyfikacji podmiotu uwierzytelniającego. |
| StatusUwierzytelnienia | `Soneta.Core.SysZewToken.StanUwierzytelnieniaTokenuKSeF` (enum) | tylko-odczyt |  |  |
| SystemZewn | `Soneta.Core.SystemZewn` | bazodanowe, tylko-odczyt | System zewnętrzny | System zewnętrzny |
| Token | `string` | bazodanowe | Numer | Numer |
| TokenToString | `string` | tylko-odczyt |  |  |
| WersjaAPI | `string` | bazodanowe | Wersja API | Wersja API, dla której działa token. |
| Wysylanie | `bool` | bazodanowe | Wysyłanie | Wysyłanie |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SposobIdentyfikacjiPodmiotuUwierzytelniajacego (`Soneta.Core.Enums.SposobIdentyfikacjiPodmiotuUwierzytelniajacego`)
- `NIPPESELZCertyfikatu` = 0 — NIP/PESEL z certyfikatu
- `OdciskPalcaCertyfikatu` = 1 — Odcisk palca certyfikatu

### PrzeznaczenieAutoryzacjiKSeF (`Soneta.Core.PrzeznaczenieAutoryzacjiKSeF`)
- `Uwierzytelnienie` = 0 — Uwierzytelnienie w systemie KSeF
- `WeryfikacjaWystawcy` = 1 — Podpis linku do weryfikacji wystawcy

### RodzajSysZewToken (`Soneta.Core.RodzajSysZewToken`)
- `TokenKSeF` = 1 — Token
- `CertyfikatKSeF` = 2 — Certyfikat

### StanUwierzytelnieniaTokenuKSeF (`Soneta.Core.SysZewToken.StanUwierzytelnieniaTokenuKSeF`)
- `NieDotyczy` = 0 — Nie dotyczy
- `Brak` = 1 — Brak
- `Aktualne` = 2 — Aktualne
- `Wygaslo` = 3 — Wygasło
