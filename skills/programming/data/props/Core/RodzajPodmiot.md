# Pola i właściwości klasy biznesowej: `Soneta.Core.RodzajPodmiot`
Nazwa tabeli: `RodzajePodmioty`
Tytuł: Podmioty rodzaju dokumentu KSeF
Opis: Powiązanie rodzaju dokumentu KSeF z kontrahentem. Tworzy relację łączącą konfigurację rodzaju dokumentu z podmiotem, umożliwiając automatyczne przypisanie rodzaju dokumentu KSeF dla konkretnego kontrahenta.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Podmiot | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  | Podmiot łącznika |
| RodzajDokKSeF | `Soneta.Core.RodzajDokumentuKseF` | bazodanowe |  | Rodzaj dokumentu KSeF łącznika |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Podmiot | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |
