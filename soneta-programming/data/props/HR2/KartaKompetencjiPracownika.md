# Pola i właściwości klasy biznesowej: `Soneta.HR2.KartaKompetencjiPracownika`
Nazwa tabeli: `KartyKompPrac`
Tytuł: Karty kompetencji
Opis: Karta kompetencji pracownika tworzona na określoną datę. Dokumentuje aktualny poziom kompetencji pracownika i może być powiązana z procesem rekrutacji lub oceną okresową.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 4
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  |  |
| Kompetencje | `SubTable<Soneta.HR2.KompetencjaPracownika>` | podlista |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| RazemElementyOceny | `View` | podlista |  |  |
| TylkoKompetencje | `View` | podlista |  |  |
| TylkoZachowania | `View` | podlista |  |  |
| Zrodlo | `Soneta.Kadry.IŹródłoKartyCharakterystykiPracownika` | bazodanowe, tylko-odczyt, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Zrodlo | `IŹródłoKartyCharakterystykiPracownika` | `Rekrutacja` |
