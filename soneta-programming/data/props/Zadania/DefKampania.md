# Pola i właściwości klasy biznesowej: `Soneta.Zadania.DefKampania`
Nazwa tabeli: `DefKampanii`
Tytuł: Definicje kampanii CRM
Opis: Szablon kampanii marketingowej CRM. Określa numerację, kontrolę dat i stanów oraz domyślne parametry nowych kampanii.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe: 13
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. Zablokowane definicje kampanii nie będą wyświetlane w liście wyboru. |
| DataType | `System.Type` |  |  |  |
| Domyslna | `bool` | bazodanowe | Domyślna | Określa, że jest to domyślna definicja kampanii. |
| FormularzUzytkownika | `bool` | bazodanowe | Formularz użytkownika | Formularz użytkownika. |
| IsEnabled | `bool` |  |  |  |
| Key | `string` |  |  |  |
| KontrolaDat | `Soneta.Core.TypKontroli` | bazodanowe, enum | Typ kontroli dat | Określa typ kontroli dat na kampanii. |
| KontrolaStanu | `Soneta.Core.TypKontroli` | bazodanowe, enum | Typ kontroli stanu | Określa typ kontroli stanu na kampanii. |
| Nazwa | `string` | bazodanowe | Nazwa | Pełna nazwa definicji kampanii. |
| NazwaZakladkiUz | `string` | bazodanowe | Nazwa zakładki użytkownika |  |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` | bazodanowe | Numeracja | Ustawienia określające sposób numeracji kampanii. |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe | Symbol | Skrótowa nazwa definicji kampanii wykorzystywana do wyszukiwania definicji oraz numeracji projektów CRM. |
| XmlForm | `Soneta.Business.MemoText` | bazodanowe | Definicja zakładki użytkownika. |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypKontroli (`Soneta.Core.TypKontroli`)
- `Brak` = 0 — Brak
- `Ostrzegaj` = 1
- `Zabraniaj` = 2
