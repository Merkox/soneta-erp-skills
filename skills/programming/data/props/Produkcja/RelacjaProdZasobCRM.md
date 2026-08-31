# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.RelacjaProdZasobCRM`
Nazwa tabeli: `RelProdZasobCRM`
Tytuł: Relacje zasobow produkcujnych z zasobami CRM
Opis: Relacja łącząca zasób produkcyjny rzeczywisty (ProdZasob) z zasobem modułu CRM. Umożliwia synchronizację kalendarzy i dostępności między planowaniem produkcji a zarządzaniem zasobami w CRM, co pozwala unikać konfliktów rezerwacji maszyn i stanowisk.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ProdZasob | `Soneta.Produkcja.ProdZasob` | bazodanowe | Zasób | Zasób produkcyjny. |
| ZasobCRM | `Soneta.Core.IZasobCRM` | bazodanowe, iface-ref | Zasób CRM | Zasób modułu CRM. |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| ZasobCRM | `IZasobCRM` | `Nieruchomosc`, `Pojazd`, `Pracownik`, `SrodekTrwalyBase`, `Urzadzenie`, `Wyposazenie` |
