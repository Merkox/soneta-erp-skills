# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.ProductVersion`
Nazwa tabeli: `ProductVersions`
Tytuł: Wersje
Opis: Słownik wersji produktów obsługiwanych w module wsparcia technicznego. Umożliwia precyzyjne przypisanie zgłoszenia do konkretnej wersji produktu, z datą wydania i opcjonalnym linkiem do zasobów.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AvailableForDownload | `bool` |  |  |  |
| Default | `bool` | bazodanowe | Domyślna |  |
| Description | `string` | bazodanowe | Opis |  |
| Product | `Soneta.Support.Support.Product` | bazodanowe | Produkt |  |
| ReleaseDate | `Soneta.Types.Date` | bazodanowe | Data wydania |  |
| Url | `string` | bazodanowe | Link |  |
| Version | `string` | bazodanowe | Wersja |  |
| VisibleForClient | `bool` | bazodanowe | Widoczna dla klienta |  |
