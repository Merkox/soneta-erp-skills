# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.BDocBusEnt`
Nazwa tabeli: `BDocBusEnts`
Tytuł: Podmioty związane z dokumentem
Opis: Tabela przechowuje powiązania dokumentu podstawowego z podmiotami lub osobami kontaktowymi wskazanymi jako odbiorcy w obiegu DMS. Pozwala obsłużyć wielu adresatów jednego dokumentu bez dublowania danych dokumentu podstawowego.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 4
- podlisty: 0
- subrowy: 0
- razem: 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Address | `string` | tylko-odczyt |  |  |
| AdresDoKorespondencji | `string` | tylko-odczyt |  |  |
| BDocBusEntType | `Soneta.Workflow.Enums.EditableFieldEnum` (enum) | bazodanowe | Rodzaj podmiotu | Które pole jest edytowane (podmiot lub osoba) |
| BasicDoc | `Soneta.Workflow.Dms.BasicDocument` | bazodanowe, tylko-odczyt | Dokument podstawowy | Dokument podstawowy |
| BusinessEntity | `Soneta.Core.IPodmiot` | bazodanowe, iface-ref | Podmiot | Podmiot związany z dokumentem podstawowym |
| CorrespondenceAddress | `string` | tylko-odczyt |  |  |
| Lp | `int` | bazodanowe | Lp | Numer odbiorcy |
| Person | `Soneta.CRM.KontaktOsoba` | bazodanowe | Osoba | Osoba związana z dokumentem podstawowym |
| Recipient | `IRow` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| BusinessEntity | `IPodmiot` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### EditableFieldEnum (`Soneta.Workflow.Enums.EditableFieldEnum`)
- `BusinessEntity` = 0 — Podmiot
- `Person` = 1 — Osoba
