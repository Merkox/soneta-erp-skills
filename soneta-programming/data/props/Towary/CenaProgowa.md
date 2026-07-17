# Pola i właściwości klasy biznesowej: `Soneta.Towary.CenaProgowa`
Nazwa tabeli: `CenyProgowe`
Tytuł: Ceny progowe
Opis: Element szczegółowy towaru (Towar). Definiuje cenę progową uzależnioną od ilości zakupionego towaru, co umożliwia stosowanie rabatów ilościowych. Każdy próg określa minimalną ilość, od której obowiązuje dana cena netto/brutto, z opcją naliczania jednostkowego lub wielokrotnego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Towar` → `Towar`

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Brutto | `Soneta.Types.DoubleCy` | bazodanowe |  | Kwota brutto ceny. |
| Definicja | `Soneta.Towary.DefinicjaCeny` | bazodanowe | Definicja ceny | Definicja ceny określająca sposób wyliczania ceny. |
| Jednostkowa | `bool` | bazodanowe | Naliczaj dla jednostki | Naliczaj dla jednostki. |
| NaliczajWielokrotnie | `bool` | bazodanowe |  | Naliczaj wielokrotnie. |
| Netto | `Soneta.Types.DoubleCy` | bazodanowe |  | Kwota netto ceny. |
| Polacz | `bool` | bazodanowe | Połącz | Wymusza wzajemne przeliczanie ceny netto i brutto. |
| Prog | `Soneta.Towary.Quantity` | bazodanowe | Próg | Próg ilościowy od jakiego obowiązuje cena. |
| StandardowaIlosc | `Soneta.Towary.Quantity` | bazodanowe | Standardowa ilość | Standardowa ilość i jednostka dla ceny. |
| Towar | `Soneta.Towary.Towar` | bazodanowe, guided-parent |  | Towar, któremu przyporządkowana jest cena progowa. |
| WszystkiePozycje | `bool` | bazodanowe | Zliczaj ze wszystkich pozycji | Zliczaj ze wszystkich pozycji. |
