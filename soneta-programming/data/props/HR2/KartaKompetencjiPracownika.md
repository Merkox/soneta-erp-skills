# Pola i właściwości klasy biznesowej: `Soneta.HR2.KartaKompetencjiPracownika`
Nazwa tabeli: `KartyKompPrac`
Tytuł: Karty kompetencji
Opis: Karta kompetencji pracownika tworzona na określoną datę. Dokumentuje aktualny poziom kompetencji pracownika i może być powiązana z procesem rekrutacji lub oceną okresową.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Kompetencje | `Soneta.Business.SubTable<Soneta.HR2.KompetencjaPracownika>` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| RazemElementyOceny | `Soneta.Business.View` |  |  |  |
| TylkoKompetencje | `Soneta.Business.View` |  |  |  |
| TylkoZachowania | `Soneta.Business.View` |  |  |  |
| Zrodlo | `Soneta.Kadry.IŹródłoKartyCharakterystykiPracownika` | bazodanowe, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Zrodlo | `IŹródłoKartyCharakterystykiPracownika` | `Rekrutacja` |
