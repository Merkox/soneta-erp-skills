# Pola i właściwości klasy biznesowej: `Soneta.Zadania.DokumentCRM`
Nazwa tabeli: `DokumentyCRM`
Tytuł: Dokumenty powiązane
Opis: Element szczegółowy hosta dokumentów CRM (IDocumentHostCRM). Łączy dokument (np. handlowy, księgowy) z zadaniem, projektem lub kampanią CRM, umożliwiając śledzenie dokumentacji biznesowej.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Host` → `IDocumentHostCRM`

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzyZadaniePoprawne | `bool` |  |  |  |
| Data | `Soneta.Types.Date` |  |  |  |
| Dokument | `Soneta.Core.IDokumentCRM` | bazodanowe, iface-ref |  |  |
| Domyslny | `bool` | bazodanowe |  |  |
| Host | `Soneta.Zadania.IDocumentHostCRM` | bazodanowe, guided-parent, iface-ref |  |  |
| KopiowanieDokCRM | `Soneta.Core.KopiowanieDokCRM` | bazodanowe, enum |  |  |
| PozycjaDokHandl | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe |  |  |
| RodzajDokCRM | `Soneta.Zadania.RodzajDokCRM` | bazodanowe, enum |  |  |
| SumowanieWartosci | `Soneta.Core.SumowanieWartosciCRM` | bazodanowe, enum |  |  |
| Wartosc | `Soneta.Types.Currency` |  |  |  |
| Zadanie | `Soneta.Zadania.Zadanie` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Dokument | `IDokumentCRM` | `DokEwidencji`, `DokKasowyBase`, `DokRozliczBase`, `DokumentHandlowy`, `SprawaWindykacyjna`, `Zaplata` |
| Host | `IDocumentHostCRM` | `Nieruchomosc`, `NieruchomoscHis`, `Projekt`, `Reservation`, `RozliczenieMediow`, `Urzadzenie`, `VehicleDetails`, `Zadanie` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KopiowanieDokCRM (`Soneta.Core.KopiowanieDokCRM`)
- `Brak` = 0 — Brak
- `Kopiowanie` = 1

### SumowanieWartosciCRM (`Soneta.Core.SumowanieWartosciCRM`)
- `Brak` = 0 — Brak
- `Przychód` = 1
- `Koszt` = 2
- `PrzychódKoszt` = 3
- `CenaZakupuKoszt` = 4

### RodzajDokCRM (`Soneta.Zadania.RodzajDokCRM`)
- `Brak` = 0
- `DokHandlowy` = 1 — Dokument handlowy
- `Część` = 2
- `Usługa` = 3
