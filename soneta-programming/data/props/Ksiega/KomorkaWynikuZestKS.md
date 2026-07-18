# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.KomorkaWynikuZestKS`
Nazwa tabeli: `KomorkiWynZestKS`
Tytuł: Komórki wyników zestawień księgowych
Opis: Element szczegółowy wyniku zestawienia księgowego (WynikZestKS). Przechowuje pojedynczą wartość liczbową na przecięciu pozycji (wiersza) i kolumny w zapisanym wyniku raportu. Umożliwia ręczną korektę wartości oraz przechowuje informacje diagnostyczne.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Wynik` → `WynikZestKS`

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 5
- podlisty: 1
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Color | `System.Drawing.Color` | tylko-odczyt |  |  |
| Info | `MemoText` | bazodanowe, podlista |  |  |
| Kolumna | `Soneta.Ksiega.KolumnaWynikuZestKS` | bazodanowe, tylko-odczyt |  |  |
| Korekta | `bool` | bazodanowe, tylko-odczyt |  |  |
| Pozycja | `Soneta.Ksiega.PozycjaWynikuZestKS` | bazodanowe, tylko-odczyt |  |  |
| Wartosc | `decimal` | bazodanowe |  |  |
| Wynik | `Soneta.Ksiega.WynikZestKS` | bazodanowe, tylko-odczyt, guided-parent |  |  |
