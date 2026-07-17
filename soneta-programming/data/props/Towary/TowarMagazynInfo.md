# Pola i właściwości klasy biznesowej: `Soneta.Towary.TowarMagazynInfo`
Nazwa tabeli: `TowarMagazyn`
Opis: Element szczegółowy towaru (Towar). Przechowuje indywidualne parametry towaru dla poszczególnych magazynów: minimalny i maksymalny stan magazynowy oraz cenę minimalną. Umożliwia różnicowanie polityki magazynowej i cenowej tego samego towaru w zależności od lokalizacji magazynowej.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Towar` → `Towar`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CenaMinimalna | `Soneta.Types.Currency` | bazodanowe |  | Cena minimalna netto w magazynie. W przypadku użycia na liście wyboru towarów zalecane użycie: Workers.TowarMagazynInfo.[Magazyn].CenaMinimum |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe |  |  |
| StanMaximum | `Soneta.Towary.Quantity` | bazodanowe |  | Stan maksymalny w magazynie. W przypadku użycia na liście wyboru towarów zalecane użycie: Workers.TowarMagazynInfo.[Magazyn].Maximum |
| StanMinimum | `Soneta.Towary.Quantity` | bazodanowe |  | Stan minimalny w magazynie. W przypadku użycia na liście wyboru towarów zalecane użycie: Workers.TowarMagazynInfo.[Magazyn].Minimum |
| Towar | `Soneta.Towary.Towar` | bazodanowe, guided-parent |  | Indywidualne parametry towaru dla magazynów. |
