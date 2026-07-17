# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.NieruchomoscRef`
Nazwa tabeli: `NieruchomosciRef`
Tytuł: Struktura nieruchomości
Opis: Element szczegółowy nieruchomości (Nieruchomosc). Przechowuje historię podległości nieruchomości w strukturze hierarchicznej z uwzględnieniem okresów aktualności. Umożliwia śledzenie zmian przynależności obiektu podrzędnego do obiektu nadrzędnego w czasie.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Nieruchomosc` → `Nieruchomosc`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Element | `Soneta.RealEstate.Models.Database.Nieruchomosc` |  |  |  |
| Nadrzedny | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe |  |  |
| Nieruchomosc | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe, guided-parent |  |  |
