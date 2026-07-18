# Pola i właściwości klasy biznesowej: `Soneta.Core.RodzajKontaktu`
Nazwa tabeli: `RodzajeKontaktow`
Tytuł: Rodzaj kontaktu
Opis: Słownik rodzajów kontaktu (np. telefon, e-mail, fax, komunikator). Każdy rodzaj posiada nazwę i typ określający kategorię kanału komunikacji.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nazwa | `string` | bazodanowe | Nazwa rodzaju kontaktu | Nazwa rodzaju kontaktu. |
| Typ | `Soneta.Core.TypRodzajuKontaktu` (enum) | bazodanowe | Typ rodzaju kontaktu | Określa typ rodzaju kontaku. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypRodzajuKontaktu (`Soneta.Core.TypRodzajuKontaktu`)
- `Inne` = 0
- `TelStac` = 1
- `TelKom` = 2
- `Email` = 3
- `Faks` = 4
- `Skrytka` = 5
- `Skype` = 6
