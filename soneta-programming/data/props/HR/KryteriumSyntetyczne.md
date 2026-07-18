# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Wartosciowanie.Konfiguracja.KryteriumSyntetyczne`
Nazwa tabeli: `ZklKrytSynt`
Tytuł: Kryteria syntetyczne
Opis: Tabela przechowuje kryteria syntetyczne agregujące wartościowanie stanowisk. Wspiera tworzenie końcowych wyników wartościowania stanowisk.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| KryteriaAnalityczne | `SubTable<Soneta.HR.ZKL.Wartosciowanie.Konfiguracja.KryteriumAnalityczne>` | podlista |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
