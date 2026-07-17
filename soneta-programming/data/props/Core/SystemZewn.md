# Pola i właściwości klasy biznesowej: `Soneta.Core.SystemZewn`
Nazwa tabeli: `SystemyZewn`
Tytuł: Lista systemów zewnętrznych
Opis: Definicja systemu zewnętrznego zintegrowanego z enova365 (np. sklep internetowy, platforma EDI, KSeF). Zawiera typ systemu, symbol, opis, flagę blokady i domyślności oraz powiązanie z kontrahentem.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Blokada | Blokada systemu zewnętrznego |
| Config | `Soneta.Core.Config.SystemZewnSettingsKomunikacja` |  |  |  |
| DefinicjeXml | `Soneta.Business.SubTable<Soneta.Core.SystemZewnDefXmlNag>` |  |  |  |
| Domyslny | `bool` | bazodanowe | Domyślny |  |
| ElementySysZewn | `Soneta.Business.SubTable<Soneta.Core.ElemSysZewn>` |  |  |  |
| Kontrahent | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref | Kontrahent | Kontrahent związany z systemem zewnętrznym |
| OgolneConfig | `Soneta.Core.Config.SystemZewnSettingsOgolne` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis | Opis systemu zewnętrznego |
| PaczkiWzorcowe | `Soneta.Business.SubTable` |  |  |  |
| Symbol | `string` | bazodanowe | Symbol | Symbol dokumentu |
| SysZewnStatusy | `Soneta.Business.SubTable<Soneta.Core.SysZewnStatus>` |  |  |  |
| TokenySysZewn | `Soneta.Business.SubTable<Soneta.Core.SysZewToken>` |  |  |  |
| Typ | `Soneta.Core.TypSystemuZewn` | bazodanowe, enum | Typ systemu | Typ systemu zewnętrznego |
| UslugiDodatkowe | `Soneta.Business.SubTable<Soneta.Core.SysZewnUsDodatkowa>` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Kontrahent | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypSystemuZewn (`Soneta.Core.TypSystemuZewn`)
- `Inny` = 1 — Inny
- `eSklep` = 2 — e-Sklep
- `SerwisAukcyjny` = 3 — Serwis aukcyjny
- `Enova` = 4 — Soneta
- `PlatformaEDI` = 5 — Platforma EDI
- `Spedytor` = 6 — Spedytor
- `PUESC` = 7 — PUESC
- `WMS` = 8 — WMS
- `BDO` = 9 — BDO
- `PlatformaIntegracyjna` = 10 — Platforma integracyjna
- `PlatformaOCR` = 11 — Platforma Soneta OCR AI
