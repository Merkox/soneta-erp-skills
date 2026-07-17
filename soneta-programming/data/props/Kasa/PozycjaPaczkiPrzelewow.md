# Pola i właściwości klasy biznesowej: `Soneta.Kasa.PozycjaPaczkiPrzelewow`
Nazwa tabeli: `PozPaczPrz`
Tytuł: Pozycje paczek przelewów
Opis: Element szczegółowy paczki przelewów (PaczkaPrzelewow). Wiąże pojedynczy przelew z paczką, przechowując jego kolejność oraz ewentualny powód anulowania. Umożliwia śledzenie statusu poszczególnych przelewów w ramach eksportu zbiorczego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Paczka` → `PaczkaPrzelewow`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Lp | `int` | bazodanowe |  |  |
| Paczka | `Soneta.Kasa.PaczkaPrzelewow` | bazodanowe, guided-parent |  |  |
| PowodAnulowania | `string` | bazodanowe |  | Powód anulowania |
| Przelew | `Soneta.Kasa.PrzelewBase` | bazodanowe | Przelew |  |
| ZobowiazaniaIWplaty | `Soneta.Business.MemoText` | bazodanowe |  | Zobowiązania i wpłaty |
