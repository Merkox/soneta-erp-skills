# Pola i właściwości klasy biznesowej: `Soneta.Kadry.HistoriaDanychWydziału`
Nazwa tabeli: `HstDanychWydzial`
Tytuł: Historia danych jednostek organizacyjnych
Opis: Element szczegółowy wydziału (Wydzial). Historia zmian danych jednostki organizacyjnej – rejestruje kolejne wersje nazwy, kodu i kategorii wydziału z zachowaniem okresu aktualności każdej wersji.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Wydzial` → `Wydzial`
Implementuje interfejsy: `IMetrykaWydziałuHost`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista |  |  |
| Definicja | `Soneta.Kadry.DefinicjaWydziału` | bazodanowe | Kategoria |  |
| EfektywnyOkres | `FromTo` | podlista |  |  |
| Kod | `string` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaPomocnicza | `string` | bazodanowe |  |  |
| Przyczyna | `string` |  |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe, tylko-odczyt, guided-parent |  |  |
