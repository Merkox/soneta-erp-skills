# Pola i właściwości klasy biznesowej: `Soneta.Kadry.UlgaInnowacyjna`
Nazwa tabeli: `UlgiInnowacyjne`
Tytuł: Ulga innowacyjna
Opis: Element szczegółowy pracownika (Pracownik). Miesięczna ewidencja procentów ulgi innowacyjnej (IP Box) stosowanych przy zaliczkach na podatek dochodowy, z rozbiciem na poszczególne miesiące roku podatkowego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czerwiec | `Soneta.Types.Percent` | bazodanowe |  |  |
| Grudzien | `Soneta.Types.Percent` | bazodanowe |  |  |
| Kwiecien | `Soneta.Types.Percent` | bazodanowe |  |  |
| Lipiec | `Soneta.Types.Percent` | bazodanowe |  |  |
| Listopad | `Soneta.Types.Percent` | bazodanowe |  |  |
| Luty | `Soneta.Types.Percent` | bazodanowe |  |  |
| Maj | `Soneta.Types.Percent` | bazodanowe |  |  |
| Marzec | `Soneta.Types.Percent` | bazodanowe |  |  |
| Pazdziernik | `Soneta.Types.Percent` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, guided-parent |  |  |
| Rok | `int` | bazodanowe |  |  |
| Sierpien | `Soneta.Types.Percent` | bazodanowe |  |  |
| Styczen | `Soneta.Types.Percent` | bazodanowe |  |  |
| Wrzesien | `Soneta.Types.Percent` | bazodanowe |  |  |
