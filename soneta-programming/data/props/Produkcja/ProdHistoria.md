# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.ProdHistoria`
Nazwa tabeli: `ProdHistorie`
Tytuł: Rejestracja czasu operacji
Opis: Dziennik zdarzeń produkcyjnych rejestrujący przebieg realizacji operacji i technologii. Każdy wpis zawiera typ zdarzenia, zaraportowaną ilość, osobę wykonującą, datę i czas oraz stan realizacji po zdarzeniu, co umożliwia pełną historię i rozliczenie prac produkcyjnych.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.TimeSec` | bazodanowe |  | Czas zdarzenia. |
| Data | `Soneta.Types.Date` | bazodanowe |  | Data zdarzenia. |
| Ilosc | `Soneta.Towary.Quantity` | bazodanowe | Ilość | Zaraportowana ilość wykonana. |
| Operacja | `Soneta.Produkcja.Operacja` |  |  | Operacja zarejestrowanego zdarzenia. |
| Operator | `Soneta.Business.App.Operator` | bazodanowe |  | Operator dokonujący rejestracji zdarzenia. |
| ProdMeldBrakow | `Soneta.Business.SubTable<Soneta.Produkcja.ProdMeldunekBraku>` |  |  |  |
| ProdOsoba | `Soneta.Produkcja.ProdOsoba` | bazodanowe | Osoba rzeczywista | Osoba rzeczywista dokonująca rejestracji zdarzenia. |
| StanPo | `Soneta.Handel.StanRealizacji` | bazodanowe, enum | Stan realizacji | Stan realizacji zdarzenia. |
| TypZdarzenia | `Soneta.Produkcja.TypZdarzenia` | bazodanowe, enum | Typ zdarzenia | Typ zarejestrowanego zdarzenia. |
| Wyeksportowano | `bool` | bazodanowe |  | Zdarzenie wyeksportowane do modułu KiP. |
| Zapis | `Soneta.Produkcja.IProdHistoriaZapis` | bazodanowe, iface-ref |  | Identyfikator obiektu, którego dotyczy zdarzenie. |
| Zarejestrowal | `string` |  | Zarejestrował | Osoba rzeczywista lub operator dokonujący rejestracji. |

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
