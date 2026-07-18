# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProCzasPracy`
Nazwa tabeli: `ProCzasyPracy`
Tytuł: Czasy pracy
Opis: Element szczegółowy zasobu operacji zlecenia (ProZasobOperacjiZlecenia). Rejestruje rzeczywiste czasy pracy zasobu z przypisaniem osoby, operatora i użytkownika panelu meldunkowego, zawierając daty rozpoczęcia i zakończenia, ilość, stan rejestracji oraz powiązanie z akordem.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `ZasobOperacjiZlecenia` → `ProZasobOperacjiZlecenia`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Awaria | `Soneta.ProdukcjaPro.ProAwaria` | tylko-odczyt |  | Pierwsza awaria powiązana z czasem pracy. |
| Awarie | `SubTable<Soneta.ProdukcjaPro.ProAwaria>` | podlista |  | Awarie powiązane z czasem pracy. |
| Context | `Context` | podlista |  |  |
| Czas | `TimeSec` | bazodanowe |  | Czas trwania czasu pracy. |
| CzasRozpoczecia | `TimeSec` |  | Czas rozpoczęcia | Czas rozpoczęcia czasu pracy. |
| CzasZakonczenia | `TimeSec` |  | Czas zakończenia | Czas zakończenia czasu pracy. |
| DataRozpoczecia | `Date` |  | Data rozpoczęcia | Data rozpoczęcia czasu pracy. |
| DataZakonczenia | `Date` |  | Data zakończenia | Data zakończenia czasu pracy. |
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość czasu pracy. |
| IloscPrzeliczona | `Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla czasu pracy. |
| Operator | `App.Operator` | bazodanowe |  | Operator czasu pracy. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis czasu pracy. |
| Osoba | `Soneta.ProdukcjaPro.ProOsoba` | bazodanowe |  | Osoba czasu pracy. |
| Rozpoczecie | `System.DateTime` | bazodanowe | Rozpoczęcie | Data i czas rozpoczęcia czasu pracy. |
| Stan | `Soneta.ProdukcjaPro.ProStanCzasuPracy` (enum) | bazodanowe |  | Stan czasu pracy. |
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
