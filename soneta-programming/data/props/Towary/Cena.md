# Pola i właściwości klasy biznesowej: `Soneta.Towary.Cena`
Nazwa tabeli: `Ceny`
Tytuł: Ceny
Opis: Element szczegółowy towaru (Towar). Przechowuje cenę towaru dla konkretnej definicji cennika, zawierając kwoty netto i brutto, narzut, marżę, standardową ilość oraz okres obowiązywania. Stanowi podstawowy cennik towarowy używany przy wycenie pozycji dokumentów handlowych.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Towar` → `Towar`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Brutto | `DoubleCy` | bazodanowe |  | Kwota brutto ceny. |
| Definicja | `Soneta.Towary.DefinicjaCeny` | bazodanowe, tylko-odczyt |  | Definicja ceny określająca sposób wyliczania ceny. |
| Jednostka | `Soneta.Towary.Jednostka` |  |  |  |
| Korygowana | `bool` | bazodanowe |  | Umożliwia edycję ceny, jeżeli jest ona wyliczana na podstawie innej ceny. |
| Marza | `Percent` | bazodanowe | Marża bazowa % | Marża procentowa wykorzystywana do wyliczania ceny. |
| Narzut | `Percent` | bazodanowe | Narzut bazowy % | Narzut procentowy wykorzystywany do wyliczania ceny. |
| Netto | `DoubleCy` | bazodanowe |  | Kwota netto ceny. |
| Okres | `FromTo` | bazodanowe, podlista | Okres | Okres obowiązywania ceny. |
| Polacz | `bool` | bazodanowe | Połącz | Wymusza wzajemne przeliczanie ceny netto i brutto. |
| StandardowaIlosc | `Soneta.Towary.Quantity` | bazodanowe |  | Standardowa ilość i jednostka dla ceny. |
| StandardowaIlość | `double` |  |  |  |
| Towar | `Soneta.Towary.Towar` | bazodanowe, tylko-odczyt, guided-parent |  | Towar, któremu przyporządkowana jest cena. |
