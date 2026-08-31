# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Wartosciowanie.Konfiguracja.KryteriumSyntetyczne`
Nazwa tabeli: `ZklKrytSynt`
Tytuł: Kryteria syntetyczne
Opis: Tabela przechowuje kryteria syntetyczne agregujące wartościowanie stanowisk. Wspiera tworzenie końcowych wyników wartościowania stanowisk.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| KryteriaAnalityczne | `SubTable<Soneta.HR.ZKL.Wartosciowanie.Konfiguracja.KryteriumAnalityczne>` | podlista |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
