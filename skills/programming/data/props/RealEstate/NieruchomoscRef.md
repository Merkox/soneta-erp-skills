# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.NieruchomoscRef`
Nazwa tabeli: `NieruchomosciRef`
Tytuł: Struktura nieruchomości
Opis: Element szczegółowy nieruchomości (Nieruchomosc). Przechowuje historię podległości nieruchomości w strukturze hierarchicznej z uwzględnieniem okresów aktualności. Umożliwia śledzenie zmian przynależności obiektu podrzędnego do obiektu nadrzędnego w czasie.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Nieruchomosc` → `Nieruchomosc`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista |  |  |
| Element | `Soneta.RealEstate.Models.Database.Nieruchomosc` | tylko-odczyt |  |  |
| Nadrzedny | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe, tylko-odczyt |  |  |
| Nieruchomosc | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe, tylko-odczyt, guided-parent |  |  |
