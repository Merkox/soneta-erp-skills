# Pola i właściwości klasy biznesowej: `Soneta.Kadry.WydzialRef`
Nazwa tabeli: `WydzialyRef`
Tytuł: Zmiana jednostek nadrzędnych
Opis: Element szczegółowy wydziału (Wydzial). Historia podległości organizacyjnej rejestrująca zmiany jednostki nadrzędnej wydziału w czasie, z zachowaniem pełnej aktualności czasowej.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Wydzial` → `Wydzial`
Implementuje interfejsy: `IMetrykaWydziałuHost`

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 2
- podlisty: 2
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista |  |  |
| EfektywnyOkres | `FromTo` | podlista |  |  |
| Nadrzedny | `Soneta.Kadry.Wydzial` | bazodanowe, tylko-odczyt |  |  |
| Przyczyna | `string` |  |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe, tylko-odczyt, guided-parent |  |  |
