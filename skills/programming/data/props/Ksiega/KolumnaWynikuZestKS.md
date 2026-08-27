# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.KolumnaWynikuZestKS`
Nazwa tabeli: `KolumnyWynZestKS`
Tytuł: Kolumny wyników zestawień księgowych
Opis: Element szczegółowy wyniku zestawienia księgowego (WynikZestKS). Przechowuje definicję kolumny w zapisanym wyniku raportu, zawierającą numer porządkowy, nazwę wewnętrzną i tytuł wyświetlany.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Wynik` → `WynikZestKS`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Klucz | `Soneta.Core.IZestawienieKSKolumnaKlucz` | tylko-odczyt |  |  |
| Komorki | `SubTable<Soneta.Ksiega.KomorkaWynikuZestKS>` | podlista |  |  |
| Lp | `int` | bazodanowe, tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe, tylko-odczyt |  |  |
| Tytul | `string` | bazodanowe, tylko-odczyt | Tytuł |  |
| Wynik | `Soneta.Ksiega.WynikZestKS` | bazodanowe, tylko-odczyt, guided-parent |  |  |
