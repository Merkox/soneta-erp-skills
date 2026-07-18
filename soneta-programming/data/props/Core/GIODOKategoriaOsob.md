# Pola i właściwości klasy biznesowej: `Soneta.Core.GIODO.GIODOKategoriaOsob`
Nazwa tabeli: `GIODOKategOsob`
Tytuł: Kategorie osób
Opis: Słownik kategorii osób w kontekście RODO (np. pracownicy, klienci, kontrahenci). Każda kategoria posiada nazwę, typ, opis i flagę blokady. Wykorzystywana w zbiorach danych osobowych.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe | Nazwa kategorii | Nazwa kategorii |
| Opis | `MemoText` | bazodanowe, podlista | Opis kategorii | Opis kategorii |
| Typ | `Soneta.Core.GIODO.TypKategoriiOsob` (enum) | bazodanowe | Typ kategorii osób | Typ kategorii osób |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypKategoriiOsob (`Soneta.Core.GIODO.TypKategoriiOsob`)
- `Pracownik` = 1
- `Osoba` = 2
- `Kontrahent` = 3
- `Uczestnik` = 4
- `Inny` = 5
