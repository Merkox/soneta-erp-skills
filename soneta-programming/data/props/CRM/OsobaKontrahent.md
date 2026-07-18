# Pola i właściwości klasy biznesowej: `Soneta.CRM.Osoba_Kontrahent.OsobaKontrahent`
Nazwa tabeli: `OsobyKontrahenci`
Tytuł: Kontrahent powiązany z osobą kontaktową.
Opis: Powiązanie osoby kontaktowej z wieloma kontrahentami jednocześnie. Umożliwia modelowanie sytuacji, gdy jedna osoba reprezentuje kilku kontrahentów, z oznaczeniem kontrahenta głównego i stanowiska w każdej relacji.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 0
- podlisty: 2
- subrowy: 0
- razem: 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Glowny | `bool` | bazodanowe | Główny | Wskazuje czy kontrahent jest głównym Kontrahentem osoby kontaktowej. |
| IsOperatorPulpituKB | `bool` |  |  |  |
| Kontrahent | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref | Kontrahent | Kontrahent, powiązany z osobą kontaktową. |
| Nieaktualny | `bool` | bazodanowe | Nieaktualny | Wskazuje aktywność osoby kontaktowej. |
| OsobaKontaktowa | `Soneta.CRM.KontaktOsoba` | bazodanowe | Osoba kontaktowa | Osoba kontaktowa, której przyporządkowany jest kontrahent. |
| Projekty | `SubTable` | podlista |  |  |
| Stanowisko | `string` | bazodanowe | Stanowisko | Wskazuje stanowisko dla osoby kontaktowej. |
| Zadania | `SubTable` | podlista |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Kontrahent | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |
