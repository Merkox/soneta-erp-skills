# Pola i właściwości klasy biznesowej: `Soneta.Kadry.ZajęcieKomorniczeHistoria`
Nazwa tabeli: `ZajKomorniczeHis`
Tytuł: Zajęcia wynagrodzeń
Opis: Element szczegółowy zajęcia komorniczego (ZajęcieKomornicze). Wersja historyczna zajęcia wynagrodzenia rejestrująca zmiany kwoty do potrącenia, limitów procentowych i kwotowych, zawieszenia spłaty, priorytetu oraz ustawień potrąceń z zasiłków i świadczeń.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zajecie` → `ZajęcieKomornicze`

- pola bazodanowe: 15
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Soneta.Types.FromTo` | bazodanowe |  |  |
| DepozytKomorniczy | `bool` | bazodanowe |  |  |
| IndywidualnyLimitKwota | `bool` | bazodanowe |  |  |
| IndywidualnyLimitProcent | `bool` | bazodanowe |  |  |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| LimitKwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| LimitProcent | `Soneta.Types.Percent` | bazodanowe |  |  |
| OpisPrzelewu | `string` | bazodanowe |  |  |
| Parent | `Soneta.Business.Row` |  |  |  |
| PotracajSwiadczenia | `bool` | bazodanowe |  |  |
| PotracajZasilki | `bool` | bazodanowe |  |  |
| PowodAktualizacji | `string` | bazodanowe | Powód aktualizacji | Opis powodu aktualizacji zapisu |
| Priorytet | `int` | bazodanowe | Priorytet |  |
| UwzgledniajKwoteWolna | `bool` | bazodanowe |  |  |
| Zajecie | `Soneta.Kadry.ZajęcieKomornicze` | bazodanowe, guided-parent |  |  |
| ZawieszenieSplaty | `bool` | bazodanowe | Zawieszenie spłaty |  |
