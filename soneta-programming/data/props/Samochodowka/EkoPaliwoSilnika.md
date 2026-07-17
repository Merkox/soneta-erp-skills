# Pola i właściwości klasy biznesowej: `Soneta.Samochodowka.EkoPaliwoSilnika`
Nazwa tabeli: `EkoPaliwaSilnika`
Tytuł: Paliwa silnika
Opis: Konfiguracja powiązań między rodzajami silników a rodzajami paliw. Określa, jakie paliwa mogą być stosowane w danym typie silnika, z uwzględnieniem danych historycznych. Stanowi podstawę do prawidłowego przypisania stawek emisyjnych przy rozliczeniach środowiskowych.
Tabela konfiguracyjna: Tak
Implementuje interfejsy: `IRowWithHistory`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Historia | `Soneta.Business.HistorySubTable<Soneta.Samochodowka.EkoPaliwoStawka>` |  |  |  |
| Paliwo | `Soneta.Samochodowka.EkoRodzajPaliwa` | bazodanowe |  | Rodzaj paliwa |
| Silnik | `Soneta.Samochodowka.EkoRodzajSilnika` | bazodanowe |  | Rodzaj silnika |
| StawkaBiezaca | `Soneta.Samochodowka.EkoPaliwoStawka` |  | Stawka bieżąca |  |
