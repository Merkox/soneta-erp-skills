# Pola i właściwości klasy biznesowej: `Soneta.Kadry.WydzialRef`
Nazwa tabeli: `WydzialyRef`
Tytuł: Zmiana jednostek nadrzędnych
Opis: Element szczegółowy wydziału (Wydzial). Historia podległości organizacyjnej rejestrująca zmiany jednostki nadrzędnej wydziału w czasie, z zachowaniem pełnej aktualności czasowej.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Wydzial` → `Wydzial`
Implementuje interfejsy: `IMetrykaWydziałuHost`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista |  |  |
| EfektywnyOkres | `FromTo` | podlista |  |  |
| Nadrzedny | `Soneta.Kadry.Wydzial` | bazodanowe, tylko-odczyt |  |  |
| Przyczyna | `string` |  |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe, tylko-odczyt, guided-parent |  |  |
