# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ObiektDoPlanowania`
Nazwa tabeli: `ObiektyDoPlan`
Tytuł: Obiekty do planowania
Opis: Element szczegółowy obiektu do planowania (IObiektDoPlanowania). Reprezentuje zasób (np. maszynę, pomieszczenie) wykorzystywany w planowaniu czasu pracy, powiązany z elementem struktury organizacyjnej.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czynnosci | `SubTable<Soneta.Kalend.CzynnoscNaObiekcieDoPlanowania>` | podlista |  |  |
| ElementStruktury | `Soneta.Core.ElementStrukturyOrganizacyjnej` | bazodanowe |  |  |
| Obiekt | `Soneta.Kalend.IObiektDoPlanowania` | bazodanowe, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Obiekt | `IObiektDoPlanowania` | `Nieruchomosc` |
