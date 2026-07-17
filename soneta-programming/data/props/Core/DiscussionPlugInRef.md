# Pola i właściwości klasy biznesowej: `Soneta.Core.Conversation.DiscussionPlugInRef`
Nazwa tabeli: `DiscPlugInRefs`
Tytuł: Powiązania rozszerzeń
Opis: Element szczegółowy hosta rozszerzeń dyskusji (IDiscussionPlugInHost). Powiązuje rozszerzenie z definicją dyskusji, określając typ, priorytet, blokadę, konfigurację oraz uprawnienia (dołączanie, edycja, usuwanie, konfigurowanie).
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Definition` → `IDiscussionPlugInHost`

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Attachable | `bool` | bazodanowe |  |  |
| Config | `Soneta.Core.Conversation.DiscussionPlugInConfig` |  |  |  |
| ConfigXml | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Configurable | `bool` | bazodanowe |  |  |
| Definition | `Soneta.Core.Conversation.IDiscussionPlugInHost` | bazodanowe, guided-parent, iface-ref | Rozszerzenie dla |  |
| Editable | `bool` | bazodanowe |  |  |
| Locked | `bool` | bazodanowe |  |  |
| PlugIn | `Soneta.Core.Conversation.DiscussionPlugIn` | bazodanowe | Rozszerzenie |  |
| Priority | `int` | bazodanowe |  |  |
| Removable | `bool` | bazodanowe |  |  |
| Type | `Soneta.Core.Conversation.DiscussionPlugInRefType` | bazodanowe, enum |  |  |

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
