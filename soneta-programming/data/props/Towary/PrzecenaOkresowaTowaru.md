# Pola i właściwości klasy biznesowej: `Soneta.Towary.PrzecenaOkresowaTowaru`
Nazwa tabeli: `PrzecenyOkresTwr`
Opis: Pozycja promocji okresowej przypisująca konkretny towar do przeceny. Określa promocyjne ceny netto i brutto, rabat procentowy oraz progi ilościowe dla danego towaru w ramach aktywnej promocji, z opcjami naliczania jednostkowego, wielokrotnego i zliczania ze wszystkich pozycji dokumentu.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Brutto | `Soneta.Types.DoubleCy` | bazodanowe | Cena promocyjna brutto | Promocyjna cena brutto. |
| Jednostkowa | `bool` | bazodanowe | Naliczaj dla jednostki | Naliczaj dla jednostki. |
| NaliczajWielokrotnie | `bool` | bazodanowe |  | Naliczaj wielokrotnie. |
| Netto | `Soneta.Types.DoubleCy` | bazodanowe | Cena promocyjna netto | Promocyjna cena netto. |
| Prog | `Soneta.Towary.Quantity` | bazodanowe | Ilość | Próg minimalny rabatu ilościowego. |
| PrzecenaOkresowa | `Soneta.Towary.PrzecenaOkresowa` | bazodanowe |  |  |
| Rabat | `Soneta.Types.Percent` | bazodanowe | Rabat promocyjny | Procent rabatu promocyjnego. |
| Rabatowana | `bool` | bazodanowe |  | Wskazuje na to, czy promocja podlega rabatowaniu. |
| StandardowaIlosc | `Soneta.Towary.Quantity` |  |  |  |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar, którego dotyczy przecena okresowa. |
| WszystkiePozycje | `bool` | bazodanowe | Zliczaj ze wszystkich pozycji | Zliczaj ze wszystkich pozycji. |
