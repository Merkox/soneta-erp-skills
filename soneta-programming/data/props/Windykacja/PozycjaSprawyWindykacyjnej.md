# Pola i właściwości klasy biznesowej: `Soneta.Windykacja.PozycjaSprawyWindykacyjnej`
Nazwa tabeli: `PozSprawWind`
Tytuł: Pozycje spraw windykacyjnych
Opis: Element szczegółowy sprawy windykacyjnej (SprawaWindykacyjna). Wiąże konkretną należność (IRozliczalny) ze sprawą windykacyjną, tworząc listę dokumentów objętych danym postępowaniem windykacyjnym.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Sprawa` → `SprawaWindykacyjna`

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Lp | `int` | bazodanowe |  |  |
| Naleznosc | `Soneta.Kasa.IRozliczalny` | bazodanowe, tylko-odczyt, iface-ref | Należność |  |
| Numer | `string` | tylko-odczyt |  |  |
| Sprawa | `Soneta.Windykacja.SprawaWindykacyjna` | bazodanowe, tylko-odczyt, guided-parent |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Naleznosc | `IRozliczalny` | `Platnosc`, `Zaplata` |
