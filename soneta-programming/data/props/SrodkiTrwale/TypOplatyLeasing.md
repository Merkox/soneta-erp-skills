# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.TypOplatyLeasing`
Nazwa tabeli: `TypyOplLeasingi`
Tytuł: Typ opłaty
Opis: Tabela przechowuje typy opłat leasingowych przypisane do środka trwałego w leasingu. Każda pozycja określa typ opłaty MSR, wartość, częstotliwość indeksacji, daty obowiązywania, sposób uwzględnienia w wycenie i harmonogramie.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Leasing` → `SrodekTrwalyLeasing`

- pola bazodanowe: 12
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czestotliwosc | `Soneta.SrodkiTrwale.CzestotliwoscIndeksacji` | bazodanowe, enum |  | Czestotliwość indeksacji |
| DataDo | `Soneta.Types.Date` | bazodanowe |  | Data zakończenia |
| DataOd | `Soneta.Types.Date` | bazodanowe |  | Data rozpoczęcia |
| Leasing | `Soneta.SrodkiTrwale.SrodekTrwalyLeasing` | bazodanowe, guided-parent |  |  |
| Lp | `int` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  | Opis oplaty |
| RozpoczecieSplaty | `Soneta.Types.YearMonth` | bazodanowe |  | Rozpoczęcie spłaty |
| TypOplaty | `Soneta.SrodkiTrwale.TypOplatyMSR` | bazodanowe |  | Typ opłaty |
| TypWHarmonogramie | `Soneta.SrodkiTrwale.KierunekRaty` | bazodanowe, enum |  | Typ opłaty leasingowej w harmonogramie |
| UwzgledniajWHarmonogramie | `bool` | bazodanowe |  | Czy uwzględniać w harmonogramie |
| UwzgledniajWWycenie | `Soneta.SrodkiTrwale.UwzgledniajWWycenie` | bazodanowe, enum |  | Jak uwzględniać w wycenie |
| Wartosc | `Soneta.Types.Currency` | bazodanowe |  | Wartość pozycji |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### CzestotliwoscIndeksacji (`Soneta.SrodkiTrwale.CzestotliwoscIndeksacji`)
- `Jednorazowa` = 0
- `Miesieczna` = 1 — Miesięczna
- `Kwartalna` = 3
- `Polroczna` = 6 — Półroczna
- `Roczna` = 12

### KierunekRaty (`Soneta.SrodkiTrwale.KierunekRaty`)
- `NieDotyczy` = -10 — Nie dotyczy
- `Wszystkie` = -1
- `OplataWstepna` = 0 — Opłata wstępna
- `OplataLeasingowa` = 5 — Opłata leasingowa
- `Kapital` = 10 — Kapitał
- `Odsetki` = 20
- `Wykup` = 30
- `PozostaleKoszty` = 50 — Pozostałe koszty
- `KapitalOdsetki` = 110 — Kapitał+Odsetki
- `OplataWstepnaWykup` = 120 — Opłata wstępna+Wykup
- `KapitalOplataWstepnaWykup` = 130 — Kapitał+Opłata wstępna+Wykup

### UwzgledniajWWycenie (`Soneta.SrodkiTrwale.UwzgledniajWWycenie`)
- `Zobowiazania` = 0 — Zobowiązania
- `AktywaZTytPrawa` = 1 — Aktywa z tyt. prawa do użytkowania
- `Zawsze` = 2
- `Nigdy` = 3
