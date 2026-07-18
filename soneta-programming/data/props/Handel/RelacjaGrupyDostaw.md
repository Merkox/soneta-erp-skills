# Pola i właściwości klasy biznesowej: `Soneta.Handel.Dostawy.RelacjaGrupyDostaw`
Nazwa tabeli: `RelacjeGrupDostw`
Tytuł: Relacje do partii
Opis: Powiązanie pozycji dokumentu handlowego z partią (grupą dostaw) towaru na magazynie. Określa kierunek operacji (przychód/rozchód) oraz ilość towaru pobraną z partii.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 0
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Ilosc | `Soneta.Towary.Quantity` | bazodanowe | Pobrano ilość | Ilość wskazana do pobrania przez pozycję wydania. |
| Kierunek | `Soneta.Magazyny.KierunekPartii` (enum) | bazodanowe, tylko-odczyt | Kierunek partii | Kierunek partii. Przychód - zakup partii. Rozchód - wydanie partii ze wskazaniem pozycji. |
| Kopia | `bool` | bazodanowe, tylko-odczyt | Kopia | Flaga oznacza, że relacja jest kopią innej relacji. Nie blokuje możliwości edycji. |
| Partia | `Soneta.Magazyny.Dostawy.GrupaDostaw` | bazodanowe | Partia | Partia towaru. |
| Pozycja | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe, tylko-odczyt | Pozycja | Pozycja dostawy towaru. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KierunekPartii (`Soneta.Magazyny.KierunekPartii`)
- `Rozchód` = -1 — Rozchód
- `Brak` = 0 — Brak
- `Przychód` = 1 — Przychód
