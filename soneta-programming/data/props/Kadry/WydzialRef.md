# Pola i właściwości klasy biznesowej: `Soneta.Kadry.WydzialRef`
Nazwa tabeli: `WydzialyRef`
Tytuł: Zmiana jednostek nadrzędnych
Opis: Element szczegółowy wydziału (Wydzial). Historia podległości organizacyjnej rejestrująca zmiany jednostki nadrzędnej wydziału w czasie, z zachowaniem pełnej aktualności czasowej.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Wydzial` → `Wydzial`
Implementuje interfejsy: `IMetrykaWydziałuHost`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Soneta.Types.FromTo` | bazodanowe |  |  |
| EfektywnyOkres | `Soneta.Types.FromTo` |  |  |  |
| Nadrzedny | `Soneta.Kadry.Wydzial` | bazodanowe |  |  |
| Przyczyna | `string` |  |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe, guided-parent |  |  |
