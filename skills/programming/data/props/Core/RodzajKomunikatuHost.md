# Pola i właściwości klasy biznesowej: `Soneta.Core.RodzajKomunikatuHost`
Nazwa tabeli: `RodzajeKomHost`
Tytuł: Rodzaje komunikatów
Opis: Konfiguracja rodzajów komunikatów EDI przypisanych do definicji dokumentów. Określa rodzaj, kierunek (import/eksport) i zastosowanie komunikatu dla danego typu dokumentu, z liczbą porządkową.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Host | `Soneta.Core.IDefinicjaKomunikatuEDIHost` | bazodanowe, iface-ref | Obiekt, dla którego zdefionowano komunikat |  |
| Kierunek | `Soneta.Core.RodzajOperacji` (enum) | bazodanowe | Kierunek komunikatu | Kierunek definiowanego komunikatu. |
| Lp | `int` | bazodanowe |  |  |
| Rodzaj | `Soneta.Core.RodzajDefXml` (enum) | bazodanowe | Rodzaj komunikatu | Rodzaj definiowanego komunikatu. |
| Zastosowanie | `Soneta.Core.ZastosowanieKomunikatu` (enum) | bazodanowe | Zastosowanie komunikatu | Zastosowanie komunikatu. |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IDefinicjaKomunikatuEDIHost` | `DefDokHandlowego`, `DefinicjaDokumentu` |

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

### RodzajOperacji (`Soneta.Core.RodzajOperacji`)
- `None` = 0
- `Export` = 1 — Eksport
- `Import` = 2

### ZastosowanieKomunikatu (`Soneta.Core.ZastosowanieKomunikatu`)
- `Razem` = 0
- `EDI` = 1 — EDI
- `KSeF` = 2 — KSeF
