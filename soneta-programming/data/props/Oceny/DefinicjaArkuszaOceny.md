# Pola i właściwości klasy biznesowej: `Soneta.Oceny.DefinicjaArkuszaOceny`
Nazwa tabeli: `DefArkuszyOcen`
Tytuł: Definicje arkuszy ocen
Opis: Definicja wzorca arkusza oceny wypełnianego przez jednego oceniającego. Określa kierunek oceny (samoocena, przełożony, współpracownicy), parametry udostępniania wyników oraz powiązanie z procesem workflow.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AkceptowanyPrzezOcenianego | `bool` | bazodanowe |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| DefinicjaProcesu | `System.Guid` | bazodanowe |  |  |
| DependentWfDefinition | `Soneta.Business.IDependentWfDefinition` |  |  |  |
| KierunekOceny | `Soneta.Oceny.KierunkiOceny` | bazodanowe, enum |  |  |
| Kod | `string` |  |  |  |
| Konsolidacyjny | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Podstawa | `decimal` |  |  |  |
| Pozycje | `Soneta.Business.SubTable<Soneta.Oceny.PozycjaDefinicjiArkuszaOceny>` |  |  |  |
| PrzeznaczonyDla | `Soneta.Oceny.TableRef` |  |  |  |
| RodzajZrodla | `string` | bazodanowe |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` | bazodanowe, enum |  |  |
| UdostepnijOceniajacemu | `bool` | bazodanowe |  |  |
| UdostepnijOcenianemu | `bool` | bazodanowe |  |  |
| UdostepnijOcenianemuOdEtapu | `Soneta.Oceny.EtapyArkuszaOceny` | bazodanowe, enum |  |  |
| WartoscWgKategorii | `bool` | bazodanowe |  |  |
| Wielokrotny | `bool` | bazodanowe |  |  |

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
