# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ZestawieniePracy`
Nazwa tabeli: `ZestawieniaPracy`
Tytuł: Zestawienia czasu pracy
Opis: Element szczegółowy pracownika (Pracownik). Okresowe zestawienie czasu pracy pracownika — agreguje dane o przepracowanych dniach i strefach w ramach danego okresu rozliczeniowego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 11
- pola tylko-odczyt: 1
- podlisty: 2
- subrowy: 0
- razem: 15

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nadgodziny100 | `Time` |  |  |  |
| Nadgodziny50 | `Time` |  |  |  |
| NadgodzinySW | `Time` |  |  |  |
| NocCzas | `Time` |  |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| PracaCzas | `Time` |  |  |  |
| PracaDni | `int` | bazodanowe |  |  |
| PracaWNormie | `Time` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| PrzerwaNaKarmienie | `Time` |  |  |  |
| PrzestójEkonomiczny | `Time` |  |  |  |
| PrzestójKP | `Time` |  |  |  |
| Strefy | `SubTable<Soneta.Kalend.StrefaZestawienia>` | podlista |  |  |
| SwietaCzas | `Time` |  |  |  |
| WolneCzas | `Time` |  |  |  |
