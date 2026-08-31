# Pola i właściwości klasy biznesowej: `Soneta.Core.TerminalPlatniczy`
Nazwa tabeli: `TerminalePlat`
Tytuł: Lista terminali płatniczych
Opis: Konfiguracja terminala płatniczego. Zawiera nazwę, identyfikator terminala, symbol, system POS, protokół komunikacji, port, adres IP, ciąg połączenia oraz flagi domyślności i obsługi kolejki.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AdresIP | `string` | bazodanowe |  |  |
| BaudRate | `int` |  |  |  |
| ConnectionString | `string` | bazodanowe |  |  |
| Domyslna | `bool` | bazodanowe |  |  |
| IP | `string` |  |  |  |
| IdTerminala | `string` | bazodanowe |  |  |
| Key | `string` |  |  |  |
| Kolejka | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Port | `string` | bazodanowe |  |  |
| PortCOM | `string` |  |  |  |
| PortTCP | `int` |  |  |  |
| ProtokolTerminala | `Soneta.POS.ProtokolTraminala` (enum) | bazodanowe | Protokół |  |
| RodzajPolaczenia | `Soneta.ProtocolECR_EFT.ECR.RodzajPolaczenia` (enum) |  |  |  |
| Stanowiska | `SubTable<Soneta.Core.TerminalPlatStanowisko>` | podlista |  |  |
| Symbol | `string` | bazodanowe |  |  |
| SystemPOS | `Soneta.POS.SystemPos` (enum) | bazodanowe | System |  |
| Szyfrowane | `string` | tylko-odczyt |  |  |
| TerminalProvider | `Soneta.Core.TerminalProvider` (enum) |  |  |  |
| Timeout | `int` |  |  |  |
| isCOM | `bool` | tylko-odczyt |  |  |
| isHelper | `bool` | tylko-odczyt |  |  |
| isTCP | `bool` | tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TerminalProvider (`Soneta.Core.TerminalProvider`)
- `inny` = 0
- `Elavon` = 1

### ProtokolTraminala (`Soneta.POS.ProtokolTraminala`)
- `POS` = 0
- `ETHECR` = 1

### SystemPos (`Soneta.POS.SystemPos`)
- `Verifone` = 1

### RodzajPolaczenia (`Soneta.ProtocolECR_EFT.ECR.RodzajPolaczenia`)
- `tcp` = 0
- `com` = 1
- `helper` = 2
