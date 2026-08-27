# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.RelationToDoc`
Nazwa tabeli: `RelationsToDoc`
Opis: Tabela relacji między zgłoszeniami serwisowymi a innymi dokumentami w systemie. Umożliwia powiązanie zgłoszenia z dokumentami nadrzędnymi i podrzędnymi, z rejestracją typu relacji oraz czasu realizacji powiązanego zadania.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Child | `Soneta.Core.IDokument` | bazodanowe, tylko-odczyt, iface-ref | Dokument podrzędny | Podrzędny dokument. |
| Parent | `Soneta.Support.Support.Ticket` | bazodanowe, tylko-odczyt | Dokument nadrzędny | Nadrzędny dokument. |
| RealizationTime | `TimeSec` | bazodanowe | Czas realizacji | Czas realizacji |
| Type | `Soneta.Core.ServiceDesk.DocumentRelationType` (enum) | bazodanowe, tylko-odczyt | Typ relacji | Określa typ relacji |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Child | `IDokument` | `BasicDocument`, `ChronoOrderElem`, `DbTuple`, `DocPkg`, `DokumentAktualizacjiKalendarza`, `DokumentUL`, `DokumentZdarzenia`, `GIODONaruszenie`, `Matter`, `PaczkaPrzelewow`, `RozliczenieCzasuPracy`, `Ticket`, `WFWorkflow`, `WersjaPlanu`, `WniosekZwrotOplSkl`, `ZgloszenieSygnalisty`, `ZleDlugiDokument` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DocumentRelationType (`Soneta.Core.ServiceDesk.DocumentRelationType`)
- `AgreementSettlement` = 1 — Rozliczenie umowy
