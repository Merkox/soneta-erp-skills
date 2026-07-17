# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ZestawieniePracy`
Nazwa tabeli: `ZestawieniaPracy`
Tytuł: Zestawienia czasu pracy
Opis: Element szczegółowy pracownika (Pracownik). Okresowe zestawienie czasu pracy pracownika — agreguje dane o przepracowanych dniach i strefach w ramach danego okresu rozliczeniowego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nadgodziny100 | `Soneta.Types.Time` |  |  |  |
| Nadgodziny50 | `Soneta.Types.Time` |  |  |  |
| NadgodzinySW | `Soneta.Types.Time` |  |  |  |
| NocCzas | `Soneta.Types.Time` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| PracaCzas | `Soneta.Types.Time` |  |  |  |
| PracaDni | `int` | bazodanowe |  |  |
| PracaWNormie | `Soneta.Types.Time` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, guided-parent |  |  |
| PrzerwaNaKarmienie | `Soneta.Types.Time` |  |  |  |
| PrzestójEkonomiczny | `Soneta.Types.Time` |  |  |  |
| PrzestójKP | `Soneta.Types.Time` |  |  |  |
| Strefy | `Soneta.Business.SubTable<Soneta.Kalend.StrefaZestawienia>` |  |  |  |
| SwietaCzas | `Soneta.Types.Time` |  |  |  |
| WolneCzas | `Soneta.Types.Time` |  |  |  |
