# Pola i właściwości klasy biznesowej: `Soneta.BI.DashboardViewLocation`
Nazwa tabeli: `DashbrdViewLocs`
Tytuł: Lokalizacje paneli BI formularzy
Opis: Przypisanie panelu BI (DashboardView) do formularza aplikacji. Określa, na którym formularzu i dla jakiego typu danych ma być wyświetlany dany panel analityczny, umożliwiając osadzanie wizualizacji BI w kontekście dokumentów biznesowych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DashboardView | `System.Guid` | bazodanowe |  |  |
| DataType | `string` | bazodanowe |  |  |
| Identity | `System.Guid` | bazodanowe |  |  |
