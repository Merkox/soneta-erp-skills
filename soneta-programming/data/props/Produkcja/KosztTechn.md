# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.KosztTechn`
Nazwa tabeli: `KosztyTechn`
Tytuł: Koszty technologii
Opis: Dodatkowy koszt technologii produkcyjnej przypisany do technologii, operacji lub pozycji. Definiuje towary kosztowe (np. media, robocizna pośrednia) z wartością i sposobem jej wyznaczania, umożliwiając kalkulację pełnego kosztu wytworzenia produktu z uwzględnieniem kosztów pośrednich.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywnosc | `Soneta.Produkcja.Aktywnosc` (enum) | bazodanowe | Aktywność | Sposób wyznaczanie aktywności dla kosztu. |
| Aktywny | `bool` | tylko-odczyt |  | Określa aktywność kosztu. |
| CechaAktywnosc | `FeatureDefinition` | bazodanowe | Cecha aktywności | Definicja cechy algorytmicznej, służąca do wyliczenia aktywności. |
| CechaWartosc | `FeatureDefinition` | bazodanowe | Cecha wartości | Definicja cechy algorytmicznej, służąca do wyliczenia wartości. |
| Host | `Soneta.Produkcja.IKosztTechnHost` | bazodanowe, iface-ref |  |  |
| Produkt | `Soneta.Produkcja.PozycjaTechn` | bazodanowe |  | Produkt do którego przypisany jest koszt. |
| RodzajWartosci | `Soneta.Produkcja.RodzajWartosciKosztu` (enum) | bazodanowe | Rodzaj wartości | Określa sposób wyznaczania wartości. |
| Technologia | `Soneta.Produkcja.Technologia` | bazodanowe |  | Określa technologię dla danego kosztu. |
| Towar | `Soneta.Towary.Towar` | bazodanowe | Towar | Towar przypisany do kosztu. |
| Wartosc | `Currency` | bazodanowe | Wartość | Wartość wg ostatniej ceny zakupu w PLN. |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IKosztTechnHost` | `Operacja`, `Technologia` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### Aktywnosc (`Soneta.Produkcja.Aktywnosc`)
- `Tak` = 0 — Tak
- `Nie` = 1
- `Warunkowo` = 2

### RodzajWartosciKosztu (`Soneta.Produkcja.RodzajWartosciKosztu`)
- `Jednostkowa` = 0 — Jednostkowa
- `Stała` = 1
- `Wyliczana` = 2
