# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.KomorkaWynikuZestKS`
Nazwa tabeli: `KomorkiWynZestKS`
Tytuł: Komórki wyników zestawień księgowych
Opis: Element szczegółowy wyniku zestawienia księgowego (WynikZestKS). Przechowuje pojedynczą wartość liczbową na przecięciu pozycji (wiersza) i kolumny w zapisanym wyniku raportu. Umożliwia ręczną korektę wartości oraz przechowuje informacje diagnostyczne.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Wynik` → `WynikZestKS`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Color | `System.Drawing.Color` |  |  |  |
| Info | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Kolumna | `Soneta.Ksiega.KolumnaWynikuZestKS` | bazodanowe |  |  |
| Korekta | `bool` | bazodanowe |  |  |
| Pozycja | `Soneta.Ksiega.PozycjaWynikuZestKS` | bazodanowe |  |  |
| Wartosc | `decimal` | bazodanowe |  |  |
| Wynik | `Soneta.Ksiega.WynikZestKS` | bazodanowe, guided-parent |  |  |
