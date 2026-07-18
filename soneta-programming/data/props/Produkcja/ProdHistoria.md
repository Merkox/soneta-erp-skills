# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.ProdHistoria`
Nazwa tabeli: `ProdHistorie`
Tytuł: Rejestracja czasu operacji
Opis: Dziennik zdarzeń produkcyjnych rejestrujący przebieg realizacji operacji i technologii. Każdy wpis zawiera typ zdarzenia, zaraportowaną ilość, osobę wykonującą, datę i czas oraz stan realizacji po zdarzeniu, co umożliwia pełną historię i rozliczenie prac produkcyjnych.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `TimeSec` | bazodanowe, tylko-odczyt |  | Czas zdarzenia. |
| Data | `Date` | bazodanowe, tylko-odczyt |  | Data zdarzenia. |
| Ilosc | `Soneta.Towary.Quantity` | bazodanowe, tylko-odczyt | Ilość | Zaraportowana ilość wykonana. |
| Operacja | `Soneta.Produkcja.Operacja` | tylko-odczyt |  | Operacja zarejestrowanego zdarzenia. |
| Operator | `App.Operator` | bazodanowe, tylko-odczyt |  | Operator dokonujący rejestracji zdarzenia. |
| ProdMeldBrakow | `SubTable<Soneta.Produkcja.ProdMeldunekBraku>` | podlista |  |  |
| ProdOsoba | `Soneta.Produkcja.ProdOsoba` | bazodanowe, tylko-odczyt | Osoba rzeczywista | Osoba rzeczywista dokonująca rejestracji zdarzenia. |
| StanPo | `Soneta.Handel.StanRealizacji` (enum) | bazodanowe, tylko-odczyt | Stan realizacji | Stan realizacji zdarzenia. |
| TypZdarzenia | `Soneta.Produkcja.TypZdarzenia` (enum) | bazodanowe, tylko-odczyt | Typ zdarzenia | Typ zarejestrowanego zdarzenia. |
| Wyeksportowano | `bool` | bazodanowe |  | Zdarzenie wyeksportowane do modułu KiP. |
| Zapis | `Soneta.Produkcja.IProdHistoriaZapis` | bazodanowe, iface-ref |  | Identyfikator obiektu, którego dotyczy zdarzenie. |
| Zarejestrowal | `string` | tylko-odczyt | Zarejestrował | Osoba rzeczywista lub operator dokonujący rejestracji. |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Zapis | `IProdHistoriaZapis` | `Operacja` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanRealizacji (`Soneta.Handel.StanRealizacji`)
- `Brak` = 0
- `Planowana` = 10
- `Rozpoczęta` = 20
- `Wstrzymana` = 30
- `Wznowiona` = 40
- `Zakończona` = 50
- `Anulowana` = 60
- `Wszystkie` = 999

### TypZdarzenia (`Soneta.Produkcja.TypZdarzenia`)
- `Brak` = 0
- `ZmianaStanu` = 1 — Zmiana stanu
- `Dolaczenie` = 2 — Dołączenie
- `Opuszczenie` = 3 — Opuszczenie
- `RaportowaniePostepu` = 4 — Raportowanie postępu
- `RejestracjaBraku` = 5 — Rejestracja braku
- `ZgloszenieAwarii` = 6 — Zgłoszenie awarii
