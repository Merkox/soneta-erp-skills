# Pola i właściwości klasy biznesowej: `Soneta.Towary.Cena`
Nazwa tabeli: `Ceny`
Tytuł: Ceny
Opis: Element szczegółowy towaru (Towar). Przechowuje cenę towaru dla konkretnej definicji cennika, zawierając kwoty netto i brutto, narzut, marżę, standardową ilość oraz okres obowiązywania. Stanowi podstawowy cennik towarowy używany przy wycenie pozycji dokumentów handlowych.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Towar` → `Towar`

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Brutto | `Soneta.Types.DoubleCy` | bazodanowe |  | Kwota brutto ceny. |
| Definicja | `Soneta.Towary.DefinicjaCeny` | bazodanowe |  | Definicja ceny określająca sposób wyliczania ceny. |
| Jednostka | `Soneta.Towary.Jednostka` |  |  |  |
| Korygowana | `bool` | bazodanowe |  | Umożliwia edycję ceny, jeżeli jest ona wyliczana na podstawie innej ceny. |
| Marza | `Soneta.Types.Percent` | bazodanowe | Marża bazowa % | Marża procentowa wykorzystywana do wyliczania ceny. |
| MarżaOstatniejCeny | `Soneta.Types.DoubleCy` |  | Marża | Marża kwotowa wyliczona w stosunku do ostatniej ceny zakupu (netto) |
| Narzut | `Soneta.Types.Percent` | bazodanowe | Narzut bazowy % | Narzut procentowy wykorzystywany do wyliczania ceny. |
| Netto | `Soneta.Types.DoubleCy` | bazodanowe |  | Kwota netto ceny. |
| Okres | `Soneta.Types.FromTo` | bazodanowe | Okres | Okres obowiązywania ceny. |
| Polacz | `bool` | bazodanowe | Połącz | Wymusza wzajemne przeliczanie ceny netto i brutto. |
| ProcentMarżyOstatniejCeny | `Soneta.Types.Percent` |  | Marża % | Procent marży liczony od tej ceny (wstecz) w stosunku do ostatniej ceny zakupu. |
| ProcentNarzutuOstatniejCeny | `Soneta.Types.Percent` |  | Narzut % | Narzut procentowy wyliczony w stosunku do ostatniej ceny zakupu |
| StandardowaIlosc | `Soneta.Towary.Quantity` | bazodanowe |  | Standardowa ilość i jednostka dla ceny. |
| StandardowaIlość | `double` |  |  |  |
| Towar | `Soneta.Towary.Towar` | bazodanowe, guided-parent |  | Towar, któremu przyporządkowana jest cena. |
