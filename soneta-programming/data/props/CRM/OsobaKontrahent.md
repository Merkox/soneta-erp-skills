# Pola i właściwości klasy biznesowej: `Soneta.CRM.Osoba_Kontrahent.OsobaKontrahent`
Nazwa tabeli: `OsobyKontrahenci`
Tytuł: Kontrahent powiązany z osobą kontaktową.
Opis: Powiązanie osoby kontaktowej z wieloma kontrahentami jednocześnie. Umożliwia modelowanie sytuacji, gdy jedna osoba reprezentuje kilku kontrahentów, z oznaczeniem kontrahenta głównego i stanowiska w każdej relacji.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Glowny | `bool` | bazodanowe | Główny | Wskazuje czy kontrahent jest głównym Kontrahentem osoby kontaktowej. |
| IsOperatorPulpituKB | `bool` |  |  |  |
| Kontrahent | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref | Kontrahent | Kontrahent, powiązany z osobą kontaktową. |
| Nieaktualny | `bool` | bazodanowe | Nieaktualny | Wskazuje aktywność osoby kontaktowej. |
| OsobaKontaktowa | `Soneta.CRM.KontaktOsoba` | bazodanowe | Osoba kontaktowa | Osoba kontaktowa, której przyporządkowany jest kontrahent. |
| Projekty | `Soneta.Business.SubTable` |  |  |  |
| Stanowisko | `string` | bazodanowe | Stanowisko | Wskazuje stanowisko dla osoby kontaktowej. |
| Zadania | `Soneta.Business.SubTable` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Kontrahent | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |
