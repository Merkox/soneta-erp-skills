# Pola i właściwości klasy biznesowej: `Soneta.BI.DashboardViewLocation`
Nazwa tabeli: `DashbrdViewLocs`
Tytuł: Lokalizacje paneli BI formularzy
Opis: Przypisanie panelu BI (DashboardView) do formularza aplikacji. Określa, na którym formularzu i dla jakiego typu danych ma być wyświetlany dany panel analityczny, umożliwiając osadzanie wizualizacji BI w kontekście dokumentów biznesowych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DashboardView | `System.Guid` | bazodanowe, tylko-odczyt |  |  |
| DataType | `string` | bazodanowe, tylko-odczyt |  |  |
| Identity | `System.Guid` | bazodanowe, tylko-odczyt |  |  |
