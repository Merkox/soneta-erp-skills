# Pola i właściwości klasy biznesowej: `Soneta.Towary.Jednostka`
Nazwa tabeli: `Jednostki`
Tytuł: Jednostki
Opis: Definicja jednostki miary stosowanej do wyrażania ilości towarów. Określa kod (symbol), typ zastosowania (masa, długość, czas itp.), precyzję zaokrąglenia oraz informację, czy jest jednostką uzupełniającą dla deklaracji UE.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Jendostka nie będzie wyświetlana na listach podpowiedzi. |
| JednostkaDlugosci | `Soneta.Towary.Jednostka` | bazodanowe |  | Powiązana jednostka długości. |
| Kod | `string` | bazodanowe |  | Nazwa jednostki wykorzystywana przy wprowadzaniu ilości. |
| Opis | `string` | bazodanowe |  | Opis jednostki. |
| Precyzja | `int` | bazodanowe |  | Precyzja zaokrąglenia ilości towaru |
| Przeliczniki | `SubTable<Soneta.Towary.Przelicznik>` | podlista |  |  |
| PrzelicznikiBazowe | `SubTable<Soneta.Towary.Przelicznik>` | podlista |  |  |
| Typ | `Soneta.Towary.TypJednostki` (enum) | bazodanowe |  | Typ jednostki określający jej zastosowanie: masa, długość, czas, itp. |
| Uzupelniajaca | `bool` | bazodanowe |  | Informuje, czy jednostka jest uzupełniająca wykorzystywana na deklaracji UE. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypJednostki (`Soneta.Towary.TypJednostki`)
- `Pozostałe` = 0 — Pozostałe
- `Masa` = 1
- `Długość` = 2
- `Powierzchnia` = 3
- `Objętość` = 4
- `Czas` = 5
- `Ilość` = 6
