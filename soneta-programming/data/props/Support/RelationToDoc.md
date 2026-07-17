# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.RelationToDoc`
Nazwa tabeli: `RelationsToDoc`
Opis: Tabela relacji między zgłoszeniami serwisowymi a innymi dokumentami w systemie. Umożliwia powiązanie zgłoszenia z dokumentami nadrzędnymi i podrzędnymi, z rejestracją typu relacji oraz czasu realizacji powiązanego zadania.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Child | `Soneta.Core.IDokument` | bazodanowe, iface-ref | Dokument podrzędny | Podrzędny dokument. |
| Parent | `Soneta.Support.Support.Ticket` | bazodanowe | Dokument nadrzędny | Nadrzędny dokument. |
| RealizationTime | `Soneta.Types.TimeSec` | bazodanowe | Czas realizacji | Czas realizacji |
| Type | `Soneta.Core.ServiceDesk.DocumentRelationType` | bazodanowe, enum | Typ relacji | Określa typ relacji |

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
