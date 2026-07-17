# Pola i właściwości klasy biznesowej: `Soneta.Towary.KodSUP`
Nazwa tabeli: `KodySUP`
Opis: Słownik kodów SUP (Single Use Plastics) klasyfikujących opakowania jednorazowego użytku zgodnie z dyrektywą UE. Przechowuje kod, nazwę, rodzaj opakowania dla sprawozdań BDO, domyślną wagę w gramach oraz materiał, z którego wykonane jest opakowanie.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Jednostka | `Soneta.Towary.Jednostka` |  | Jednostka |  |
| Kod | `string` | bazodanowe |  |  |
| Material | `string` | bazodanowe | Materiał |  |
| Nazwa | `string` | bazodanowe |  |  |
| Rodzaj | `Soneta.Towary.RodzajOpakowaniaSprawozdanieBDO` | bazodanowe, enum |  |  |
| Waga | `Soneta.Towary.Quantity` | bazodanowe | Waga domyślna w gramach |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajOpakowaniaSprawozdanieBDO (`Soneta.Towary.RodzajOpakowaniaSprawozdanieBDO`)
- `KubkiNaNapoje` = 1 — Kubki na napoje
- `PojemnikiNaZywnosc` = 2 — Pojemniki na żywność
