# Pola i właściwości klasy biznesowej: `Soneta.CRM.Osoba_Kontrahent.PodmiotTransakcja`
Nazwa tabeli: `PodmiotyTran`
Tytuł: Podmioty powiązane z transakcjami.
Opis: Element szczegółowy transakcji CRM (PodmiotTransakcja). Umożliwia powiązanie transakcji z dodatkowymi kontrahentami i osobami kontaktowymi, gdy w transakcję zaangażowanych jest kilka podmiotów.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Transakcja` → `Transakcja`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CanBeDeleted | `bool?` |  |  |  |
| Kontrahent | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref | Kontrahent | Kontrahent, któremu przyporządkowana jest transakcja. |
| Osoba | `Soneta.CRM.KontaktOsoba` | bazodanowe | Osoba | Osoba, której przyporządkowana jest transakcja. |
| Transakcja | `Soneta.CRM.Transakcja` | bazodanowe, guided-parent |  | Transakcje podmiotów (Kontrahentów lub osób) |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Kontrahent | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |
