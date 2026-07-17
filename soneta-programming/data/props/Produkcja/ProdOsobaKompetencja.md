# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.ProdOsobaKompetencja`
Nazwa tabeli: `ProdOsobaKom`
Tytuł: Powiązanie osoby produkcyjnej z kompetancjami
Opis: Powiązanie osoby produkcyjnej (wzorcowej lub rzeczywistej) z kompetencją ze słownika. Umożliwia ewidencjonowanie kwalifikacji i uprawnień pracowników produkcyjnych, co jest wykorzystywane przy przydzielaniu operacji wymagających określonych umiejętności.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ProdKompetencja | `Soneta.Produkcja.ProdKompetencja` | bazodanowe |  |  |
| ProdOsoba | `Soneta.Produkcja.IProdOsoba` | bazodanowe, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| ProdOsoba | `IProdOsoba` | `ProdOsoba`, `ProdOsobaWzorcowa` |
