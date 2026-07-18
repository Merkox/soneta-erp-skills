# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.MatrycaPodmiot`
Nazwa tabeli: `MatrycePodmioty`
Tytuł: MatrycePodmioty
Opis: Powiązanie matrycy dokumentu z podmiotem kasowym (np. kontrahentem). Umożliwia automatyczne stosowanie matrycy przy tworzeniu dokumentów dla danego podmiotu, zapewniając domyślne ustawienia księgowe i ewidencyjne.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Matryca | `Soneta.Ksiega.MatrycaBase` | bazodanowe |  | Matryca łącznika |
| Podmiot | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  | Podmiot łącznika |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Podmiot | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |
