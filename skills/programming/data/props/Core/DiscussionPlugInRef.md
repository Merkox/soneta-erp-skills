# Pola i właściwości klasy biznesowej: `Soneta.Core.Conversation.DiscussionPlugInRef`
Nazwa tabeli: `DiscPlugInRefs`
Tytuł: Powiązania rozszerzeń
Opis: Element szczegółowy hosta rozszerzeń dyskusji (IDiscussionPlugInHost). Powiązuje rozszerzenie z definicją dyskusji, określając typ, priorytet, blokadę, konfigurację oraz uprawnienia (dołączanie, edycja, usuwanie, konfigurowanie).
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Definition` → `IDiscussionPlugInHost`
Selektor: pole `Type` (`Soneta.Core.Conversation.DiscussionPlugInRefType`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Attachable | `bool` | bazodanowe |  |  |
| Config | `Soneta.Core.Conversation.DiscussionPlugInConfig` | tylko-odczyt |  |  |
| ConfigXml | `MemoText` | bazodanowe, podlista |  |  |
| Configurable | `bool` | bazodanowe |  |  |
| Definition | `Soneta.Core.Conversation.IDiscussionPlugInHost` | bazodanowe, tylko-odczyt, guided-parent, iface-ref | Rozszerzenie dla |  |
| Editable | `bool` | bazodanowe |  |  |
| Locked | `bool` | bazodanowe |  |  |
| PlugIn | `Soneta.Core.Conversation.DiscussionPlugIn` | bazodanowe, tylko-odczyt | Rozszerzenie |  |
| Priority | `int` | bazodanowe |  |  |
| Removable | `bool` | bazodanowe |  |  |
| Type | `Soneta.Core.Conversation.DiscussionPlugInRefType` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Type`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Definition` | 1 | `Soneta.Core.Conversation.DiscussionPlugInDefRef` | Referencja do definicji |
| `Discussion` | 2 | `Soneta.Core.Conversation.DiscussionPlugInDisRef` | Referencja do dyskusji |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Definition | `IDiscussionPlugInHost` | `DefDiscussion`, `Discussion` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DiscussionPlugInRefType (`Soneta.Core.Conversation.DiscussionPlugInRefType`)
- `Definition` = 1
- `Discussion` = 2
