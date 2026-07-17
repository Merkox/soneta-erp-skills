# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProCzasPracy`
Nazwa tabeli: `ProCzasyPracy`
Tytuł: Czasy pracy
Opis: Element szczegółowy zasobu operacji zlecenia (ProZasobOperacjiZlecenia). Rejestruje rzeczywiste czasy pracy zasobu z przypisaniem osoby, operatora i użytkownika panelu meldunkowego, zawierając daty rozpoczęcia i zakończenia, ilość, stan rejestracji oraz powiązanie z akordem.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `ZasobOperacjiZlecenia` → `ProZasobOperacjiZlecenia`

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Awaria | `Soneta.ProdukcjaPro.ProAwaria` |  |  | Pierwsza awaria powiązana z czasem pracy. |
| Awarie | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProAwaria>` |  |  | Awarie powiązane z czasem pracy. |
| Context | `Soneta.Business.Context` |  |  |  |
| Czas | `Soneta.Types.TimeSec` | bazodanowe |  | Czas trwania czasu pracy. |
| CzasRozpoczecia | `Soneta.Types.TimeSec` |  | Czas rozpoczęcia | Czas rozpoczęcia czasu pracy. |
| CzasZakonczenia | `Soneta.Types.TimeSec` |  | Czas zakończenia | Czas zakończenia czasu pracy. |
| DataRozpoczecia | `Soneta.Types.Date` |  | Data rozpoczęcia | Data rozpoczęcia czasu pracy. |
| DataZakonczenia | `Soneta.Types.Date` |  | Data zakończenia | Data zakończenia czasu pracy. |
| Ilosc | `Soneta.Types.Amount` | bazodanowe | Ilość | Ilość czasu pracy. |
| IloscPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla czasu pracy. |
| Operator | `Soneta.Business.App.Operator` | bazodanowe |  | Operator czasu pracy. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis czasu pracy. |
| Osoba | `Soneta.ProdukcjaPro.ProOsoba` | bazodanowe |  | Osoba czasu pracy. |
| Rozpoczecie | `System.DateTime` | bazodanowe | Rozpoczęcie | Data i czas rozpoczęcia czasu pracy. |
| Stan | `Soneta.ProdukcjaPro.ProStanCzasuPracy` | bazodanowe, enum |  | Stan czasu pracy. |
| Utworzenie | `System.DateTime` | bazodanowe |  | Data i czas utworzenia czasu pracy. |
| Uzytkownik | `Soneta.ProdukcjaPro.ProUzytkownikPaneluMeldunkowego` | bazodanowe | Użytkownik | Użytkownik panelu meldunkowego czasu pracy. |
| Zakonczenie | `System.DateTime` | bazodanowe | Zakończenie | Data i czas zakończenia czasu pracy. |
| ZasobMeldunku | `Soneta.ProdukcjaPro.ProZasobMeldunku` | bazodanowe | Zasób meldunku | Zasób meldunku czasu pracy. |
| ZasobOperacjiZlecenia | `Soneta.ProdukcjaPro.ProZasobOperacjiZlecenia` | bazodanowe, guided-parent | Zasób operacji zlecenia | Zasób operacji zlecenia dla czasu pracy. |
| ZestawienieAkordu | `Soneta.Kalend.ZestawienieAkorduBase` | bazodanowe |  | Zestawienie akordu czasu pracy. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProStanCzasuPracy (`Soneta.ProdukcjaPro.ProStanCzasuPracy`)
- `None` = 0
- `Rozpoczety` = 1 — Rozpoczęty
- `Zakonczony` = 2 — Zakończony
- `Rozliczony` = 4 — Rozliczony
- `All` = 7 — Wszystkie
