# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Wartosciowanie.Konfiguracja.KryteriumSyntetyczne`
Nazwa tabeli: `ZklKrytSynt`
Tytuł: Kryteria syntetyczne
Opis: Tabela przechowuje kryteria syntetyczne agregujące wartościowanie stanowisk. Wspiera tworzenie końcowych wyników wartościowania stanowisk.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| KryteriaAnalityczne | `Soneta.Business.SubTable<Soneta.HR.ZKL.Wartosciowanie.Konfiguracja.KryteriumAnalityczne>` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
