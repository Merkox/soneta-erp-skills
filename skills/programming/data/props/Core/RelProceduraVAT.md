# Pola i właściwości klasy biznesowej: `Soneta.Core.RelProceduraVAT`
Nazwa tabeli: `RelProceduryVAT`
Tytuł: Powiązania procedur VAT z dokumentami
Opis: Powiązanie procedury VAT z dokumentem. Realizuje relację wiele-do-wielu między dokumentami (hosta procedur VAT) a procedurami VAT, umożliwiając przypisanie wielu procedur do jednego dokumentu.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dokument | `Soneta.Core.IProceduraVATHost` | bazodanowe, tylko-odczyt, iface-ref | Dokument | Dokument |
| Procedura | `Soneta.Core.ProceduraVAT` | bazodanowe | Procedura | Procedura |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Dokument | `IProceduraVATHost` | `DokEwidencji`, `DokumentHandlowy` |
