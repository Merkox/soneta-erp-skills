# Pola i właściwości klasy biznesowej: `Soneta.Kasa.RachunekWirtualny`
Nazwa tabeli: `RachWirtualne`
Tytuł: Rachunki wirtualne
Opis: Numer rachunku wirtualnego przypisany do podmiotu kasowego w ramach ewidencji środków pieniężnych. Rachunki wirtualne służą do automatycznej identyfikacji wpłat od kontrahentów przy imporcie wyciągów bankowych na podstawie unikalnego numeru konta.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| EwidencjaSP | `Soneta.Kasa.EwidencjaSP` | bazodanowe, tylko-odczyt |  |  |
| Numer | `string` | bazodanowe |  |  |
| Podmiot | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, tylko-odczyt, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Podmiot | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |
