# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.DokumentPowiazanyUL`
Nazwa tabeli: `DokumentyPowiazaneUL`
Tytuł: Dokumenty powiązane UL
Opis: Powiązania dokumentów zewnętrznych z umowami leasingowymi. Umożliwiają dołączenie faktur, not i innych dokumentów do umowy leasingu wraz z ich kategoryzacją. Służą do kompletowania dokumentacji leasingowej w jednym miejscu.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dokument | `Soneta.Core.IDokumentPowiazanyUL` | bazodanowe |  |  |
| DokumentUL | `Soneta.SrodkiTrwale.DokumentUL` | bazodanowe, tylko-odczyt |  |  |
| Kategoria | `Soneta.SrodkiTrwale.KategoriaPowiazanyUL` (enum) | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KategoriaPowiazanyUL (`Soneta.SrodkiTrwale.KategoriaPowiazanyUL`)
- `Wszystkie` = -1
- `RataLeasingowa` = 0 — Rata leasingowa
- `OplataWstepna` = 10 — Opłata wstępna
- `Wykup` = 20 — Wykup
- `KosztyUbezpieczenia` = 30 — Koszty ubezpieczenia
- `KosztyDodatkowe` = 40 — Koszty dodatkowe
- `PłatnoscRatyLeasingowej` = 50 — Płatność raty leasingowej
