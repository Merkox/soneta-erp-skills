# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Podmioty_Zadania.PodmiotZadanie`
Nazwa tabeli: `PodmiotyZadania`
Tytuł: Podmioty powiązane z zadaniami.
Opis: Element szczegółowy zadania (Zadanie). Umożliwia przypisanie wielu kontrahentów i osób kontaktowych do jednego zadania CRM w scenariuszach wielopodmiotowych.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zadanie` → `Zadanie`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CanBeDeleted | `bool?` |  |  |  |
| Kontrahent | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref | Kontrahent | Kontrahent, któremu przyporządkowane jest zadanie. |
| Osoba | `Soneta.CRM.KontaktOsoba` | bazodanowe | Osoba | Osoba, której przyporządkowane jest zadanie. |
| Zadanie | `Soneta.Zadania.Zadanie` | bazodanowe, guided-parent |  | Zadania podmiotów (Kontrahentów lub osób) |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Kontrahent | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |
