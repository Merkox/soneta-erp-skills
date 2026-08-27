# Pola i właściwości klasy biznesowej: `Soneta.Samochodowka.EkoPaliwoSilnika`
Nazwa tabeli: `EkoPaliwaSilnika`
Tytuł: Paliwa silnika
Opis: Konfiguracja powiązań między rodzajami silników a rodzajami paliw. Określa, jakie paliwa mogą być stosowane w danym typie silnika, z uwzględnieniem danych historycznych. Stanowi podstawę do prawidłowego przypisania stawek emisyjnych przy rozliczeniach środowiskowych.
Tabela konfiguracyjna: Tak
Historyczna: Tak — wersje (historia) w tabeli `EkoPaliwoStawka`
Implementuje interfejsy: `IRowWithHistory`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Historia | `HistorySubTable<Soneta.Samochodowka.EkoPaliwoStawka>` | podlista |  |  |
| Paliwo | `Soneta.Samochodowka.EkoRodzajPaliwa` | bazodanowe, tylko-odczyt |  | Rodzaj paliwa |
| Silnik | `Soneta.Samochodowka.EkoRodzajSilnika` | bazodanowe, tylko-odczyt |  | Rodzaj silnika |
| StawkaBiezaca | `Soneta.Samochodowka.EkoPaliwoStawka` | tylko-odczyt | Stawka bieżąca |  |
