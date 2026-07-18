# Pola i właściwości klasy biznesowej: `Soneta.CRM.SzablonEmail`
Nazwa tabeli: `SzablonyEmail`
Tytuł: Szablony Email
Opis: Szablon wiadomości e-mail wykorzystywany do szybkiego tworzenia korespondencji. Definiuje predefiniowaną treść, temat, adresatów i typ dokumentu, umożliwiając standaryzację komunikacji w ramach oddziałów firmy.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `ITemplate`

- pola bazodanowe (zapisywalne): 8
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 0
- podlisty: 4
- subrowy: 0
- razem: 13

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| DO | `MemoText` | bazodanowe, podlista |  |  |
| DW | `MemoText` | bazodanowe, podlista |  |  |
| Domyslny | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy do którego przypisany jest szablon. |
| PotwOdczytania | `bool` | bazodanowe | Potwierdzenie odczytania wiadomości | Określa czy mamy otrzymać potwierdzenie odczytania wiadomości. |
| Temat | `string` | bazodanowe |  |  |
| Tresc | `MemoText` | bazodanowe, podlista | Treść |  |
| Typ | `Soneta.CRM.TypDlaSzablonuEmail` (enum) | bazodanowe |  | Określa typ, dla którego szablon jest dostępny |
| TypDanych | `string` | bazodanowe |  |  |
| UDW | `MemoText` | bazodanowe, podlista |  |  |
| UstawTypMetatagu | `bool` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypDlaSzablonuEmail (`Soneta.CRM.TypDlaSzablonuEmail`)
- `Brak` = 0 — Brak
- `Zadanie` = 1
- `Kontrahent` = 2
- `KontaktOsoba` = 3
- `DokumentHandlowy` = 4
- `PracHistoria` = 5 — Pracownik (PracHistoria)
- `Projekt` = 6
- `SprawaWindykacyjna` = 7
- `WiadomoscEmail` = 8
- `BasicDocument` = 9
- `DokEwidencji` = 10
- `Task` = 11
- `Matter` = 12 — Sprawa
- `Lead` = 13
- `Transakcja` = 14
- `Report` = 15 — Raport
- `DokRozliczBase` = 16
- `UczestnikBase` = 17
- `ZgloszenieUczestnik` = 18
- `GrupaSzkol` = 19
- `WebUser` = 20
- `ReportDashboardBI` = 21 — Raport (Panel BI)
- `Deklaracja` = 22
- `DamageEvent` = 23 — Szkody komunikacyjne
- `Ticket` = 24 — Zgłoszenie
- `DaneEParagonu` = 25 — e-paragon
- `Reservation` = 26 — Rezerwacja pojazdu
- `Insurance` = 27 — Ubezpieczenia pojazdów
- `DBItem` = 28 — DBItem
- `Wszystkie` = 9999 — Wszystkie
