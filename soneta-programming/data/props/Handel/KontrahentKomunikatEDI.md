# Pola i właściwości klasy biznesowej: `Soneta.Handel.KontrahentKomunikatEDI`
Nazwa tabeli: `KontrahKonEDI`
Tytuł: Komunikaty EDI dla kontrahenta
Opis: Konfiguracja komunikatów EDI przypisana do kontrahenta. Określa definicję komunikatu, sposób generowania i wysyłania oraz platformę EDI dla wymiany dokumentów elektronicznych.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BaseSerwer | `string` | tylko-odczyt |  |  |
| DefinicjaEDI | `Soneta.Core.DefXmlNag` | bazodanowe | Definicja komunikatu |  |
| Generowanie | `Soneta.Handel.EDI.GenerowanieEdi` (enum) | bazodanowe | Generowanie | Sposób generowania komunikatu |
| Komunikat | `Soneta.Core.RodzajDefXml` (enum) | bazodanowe | Rodzaj komunikatu |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe | Kontrahent |  |
| PlatformaEDI | `Soneta.Core.SystemZewn` | bazodanowe | Platforma EDI | Platforma EDI, za pomocą której następuje wymiana komunikatów. |
| Serwer | `string` | bazodanowe | Serwer | Adres IP oraz port serwera (domyślny port: 22003) |
| SerwerIP | `string` | tylko-odczyt | IP serwera |  |
| SerwerPort | `int` | tylko-odczyt | Port serwera |  |
| Wysylanie | `Soneta.Handel.EDI.WysylanieEdi` (enum) | bazodanowe | Sposób wysyłania | Sposób wysyłania komunikatu |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajDefXml (`Soneta.Core.RodzajDefXml`)
- `None` = 0
- `ORDER` = 1
- `ORDRSP` = 2
- `DESADV` = 3
- `RECADV` = 4
- `INVOICE` = 5
- `ANYDOC` = 8
- `INVRPT` = 9
- `PRICAT` = 10
- `METADATA` = 6
- `GM24` = 7
- `ANYDATA` = 11

### GenerowanieEdi (`Soneta.Handel.EDI.GenerowanieEdi`)
- `Ręczne` = 0
- `Automatyczne` = 1

### WysylanieEdi (`Soneta.Handel.EDI.WysylanieEdi`)
- `Brak` = 0
- `Ręczne` = 1
- `Automatyczne` = 2
