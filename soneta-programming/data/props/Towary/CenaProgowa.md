# Pola i właściwości klasy biznesowej: `Soneta.Towary.CenaProgowa`
Nazwa tabeli: `CenyProgowe`
Tytuł: Ceny progowe
Opis: Element szczegółowy towaru (Towar). Definiuje cenę progową uzależnioną od ilości zakupionego towaru, co umożliwia stosowanie rabatów ilościowych. Każdy próg określa minimalną ilość, od której obowiązuje dana cena netto/brutto, z opcją naliczania jednostkowego lub wielokrotnego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Towar` → `Towar`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Brutto | `DoubleCy` | bazodanowe |  | Kwota brutto ceny. |
| Definicja | `Soneta.Towary.DefinicjaCeny` | bazodanowe, tylko-odczyt | Definicja ceny | Definicja ceny określająca sposób wyliczania ceny. |
| Jednostkowa | `bool` | bazodanowe | Naliczaj dla jednostki | Naliczaj dla jednostki. |
| NaliczajWielokrotnie | `bool` | bazodanowe |  | Naliczaj wielokrotnie. |
| Netto | `DoubleCy` | bazodanowe |  | Kwota netto ceny. |
| Polacz | `bool` | bazodanowe | Połącz | Wymusza wzajemne przeliczanie ceny netto i brutto. |
| Prog | `Soneta.Towary.Quantity` | bazodanowe | Próg | Próg ilościowy od jakiego obowiązuje cena. |
| StandardowaIlosc | `Soneta.Towary.Quantity` | bazodanowe | Standardowa ilość | Standardowa ilość i jednostka dla ceny. |
| Towar | `Soneta.Towary.Towar` | bazodanowe, tylko-odczyt, guided-parent |  | Towar, któremu przyporządkowana jest cena progowa. |
| WszystkiePozycje | `bool` | bazodanowe | Zliczaj ze wszystkich pozycji | Zliczaj ze wszystkich pozycji. |
