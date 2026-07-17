# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.KolumnaWynikuZestKS`
Nazwa tabeli: `KolumnyWynZestKS`
Tytuł: Kolumny wyników zestawień księgowych
Opis: Element szczegółowy wyniku zestawienia księgowego (WynikZestKS). Przechowuje definicję kolumny w zapisanym wyniku raportu, zawierającą numer porządkowy, nazwę wewnętrzną i tytuł wyświetlany.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Wynik` → `WynikZestKS`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Klucz | `Soneta.Core.IZestawienieKSKolumnaKlucz` |  |  |  |
| Komorki | `Soneta.Business.SubTable<Soneta.Ksiega.KomorkaWynikuZestKS>` |  |  |  |
| Lp | `int` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Tytul | `string` | bazodanowe | Tytuł |  |
| Wynik | `Soneta.Ksiega.WynikZestKS` | bazodanowe, guided-parent |  |  |
