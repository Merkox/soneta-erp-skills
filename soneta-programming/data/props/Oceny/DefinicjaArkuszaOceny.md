# Pola i właściwości klasy biznesowej: `Soneta.Oceny.DefinicjaArkuszaOceny`
Nazwa tabeli: `DefArkuszyOcen`
Tytuł: Definicje arkuszy ocen
Opis: Definicja wzorca arkusza oceny wypełnianego przez jednego oceniającego. Określa kierunek oceny (samoocena, przełożony, współpracownicy), parametry udostępniania wyników oraz powiązanie z procesem workflow.
Tabela konfiguracyjna: Tak
Guided: root
Selektor: pole `TypOceny` (`Soneta.Oceny.TypOceny`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AkceptowanyPrzezOcenianego | `bool` | bazodanowe |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| DefinicjaProcesu | `System.Guid` | bazodanowe |  |  |
| DependentWfDefinition | `IDependentWfDefinition` |  |  |  |
| KierunekOceny | `Soneta.Oceny.KierunkiOceny` (enum) | bazodanowe |  |  |
| Kod | `string` | tylko-odczyt |  |  |
| Konsolidacyjny | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| Podstawa | `decimal` | tylko-odczyt |  |  |
| Pozycje | `SubTable<Soneta.Oceny.PozycjaDefinicjiArkuszaOceny>` | podlista |  |  |
| PrzeznaczonyDla | `Soneta.Oceny.TableRef` |  |  |  |
| RodzajZrodla | `string` | bazodanowe |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| UdostepnijOceniajacemu | `bool` | bazodanowe |  |  |
| UdostepnijOcenianemu | `bool` | bazodanowe |  |  |
| UdostepnijOcenianemuOdEtapu | `Soneta.Oceny.EtapyArkuszaOceny` (enum) | bazodanowe |  |  |
| WartoscWgKategorii | `bool` | bazodanowe |  |  |
| Wielokrotny | `bool` | bazodanowe |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `TypOceny`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Ocena` | 1 | `Soneta.Oceny.DefinicjaArkuszaOceny` |  |
| `Ankieta` | 2 | `Soneta.Ankiety.DefinicjaArkuszaAnkiety` |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### EtapyArkuszaOceny (`Soneta.Oceny.EtapyArkuszaOceny`)
- `Przygotowywany` = 1
- `Wypełniany` = 2
- `Niezaakceptowany` = 3
- `DoAkceptacji` = 4
- `Wypełniony` = 5
- `Zatwierdzony` = 10
- `Anulowany` = 11
- `Oczekujący` = 12

### KierunkiOceny (`Soneta.Oceny.KierunkiOceny`)
- `Samoocena` = 1
- `PrzezPrzełożonego` = 2
- `PrzezWspółpracowników` = 3
- `PrzezKlientów` = 4
- `Pozostałe` = 10

### TypOceny (`Soneta.Oceny.TypOceny`)
- `Ocena` = 1
- `Ankieta` = 2
