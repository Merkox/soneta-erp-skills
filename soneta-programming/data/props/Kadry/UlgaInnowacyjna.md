# Pola i właściwości klasy biznesowej: `Soneta.Kadry.UlgaInnowacyjna`
Nazwa tabeli: `UlgiInnowacyjne`
Tytuł: Ulga innowacyjna
Opis: Element szczegółowy pracownika (Pracownik). Miesięczna ewidencja procentów ulgi innowacyjnej (IP Box) stosowanych przy zaliczkach na podatek dochodowy, z rozbiciem na poszczególne miesiące roku podatkowego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czerwiec | `Percent` | bazodanowe |  |  |
| Grudzien | `Percent` | bazodanowe |  |  |
| Kwiecien | `Percent` | bazodanowe |  |  |
| Lipiec | `Percent` | bazodanowe |  |  |
| Listopad | `Percent` | bazodanowe |  |  |
| Luty | `Percent` | bazodanowe |  |  |
| Maj | `Percent` | bazodanowe |  |  |
| Marzec | `Percent` | bazodanowe |  |  |
| Pazdziernik | `Percent` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Rok | `int` | bazodanowe |  |  |
| Sierpien | `Percent` | bazodanowe |  |  |
| Styczen | `Percent` | bazodanowe |  |  |
| Wrzesien | `Percent` | bazodanowe |  |  |
