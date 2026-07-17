# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ObiektDoPlanowania`
Nazwa tabeli: `ObiektyDoPlan`
Tytuł: Obiekty do planowania
Opis: Element szczegółowy obiektu do planowania (IObiektDoPlanowania). Reprezentuje zasób (np. maszynę, pomieszczenie) wykorzystywany w planowaniu czasu pracy, powiązany z elementem struktury organizacyjnej.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czynnosci | `Soneta.Business.SubTable<Soneta.Kalend.CzynnoscNaObiekcieDoPlanowania>` |  |  |  |
| ElementStruktury | `Soneta.Core.ElementStrukturyOrganizacyjnej` | bazodanowe |  |  |
| Obiekt | `Soneta.Kalend.IObiektDoPlanowania` | bazodanowe, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Obiekt | `IObiektDoPlanowania` | `Nieruchomosc` |
