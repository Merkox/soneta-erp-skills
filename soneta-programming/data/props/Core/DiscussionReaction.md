# Pola i właściwości klasy biznesowej: `Soneta.Core.Conversation.DiscussionReaction`
Nazwa tabeli: `DiscusReactions`
Opis: Reakcja użytkownika na element dyskusji (komentarz, temat). Przechowuje powiązanie z komentarzem, właścicielem reakcji i typem reakcji (np. polubienie). Zapewnia unikalność reakcji per użytkownik i komentarz.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Comment | `Soneta.Core.Conversation.IDiscussionItem` | bazodanowe, iface-ref |  |  |
| Owner | `Soneta.Business.IOwner` | bazodanowe |  |  |
| ReactionType | `Soneta.Core.Conversation.DiscussionReactionType` | bazodanowe, enum |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Comment | `IDiscussionItem` | `Comment`, `Discussion`, `DiscussionTopic`, `DiscussionUpdate` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DiscussionReactionType (`Soneta.Core.Conversation.DiscussionReactionType`)
- `Like` = 0
- `Favourite` = 1
- `Archive` = 2
