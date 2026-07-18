# Pola i właściwości klasy biznesowej: `Soneta.Kadry.ZajęcieKomorniczeHistoria`
Nazwa tabeli: `ZajKomorniczeHis`
Tytuł: Zajęcia wynagrodzeń
Opis: Element szczegółowy zajęcia komorniczego (ZajęcieKomornicze). Wersja historyczna zajęcia wynagrodzenia rejestrująca zmiany kwoty do potrącenia, limitów procentowych i kwotowych, zawieszenia spłaty, priorytetu oraz ustawień potrąceń z zasiłków i świadczeń.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zajecie` → `ZajęcieKomornicze`
Historia: Tak — zapis historyczny tabeli `ZajęcieKomornicze`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista |  |  |
| DepozytKomorniczy | `bool` | bazodanowe |  |  |
| IndywidualnyLimitKwota | `bool` | bazodanowe |  |  |
| IndywidualnyLimitProcent | `bool` | bazodanowe |  |  |
| Kwota | `Currency` | bazodanowe |  |  |
| LimitKwota | `Currency` | bazodanowe |  |  |
| LimitProcent | `Percent` | bazodanowe |  |  |
| OpisPrzelewu | `string` | bazodanowe |  |  |
| Parent | `Row` | tylko-odczyt |  |  |
| PotracajSwiadczenia | `bool` | bazodanowe |  |  |
| PotracajZasilki | `bool` | bazodanowe |  |  |
| PowodAktualizacji | `string` | bazodanowe, tylko-odczyt | Powód aktualizacji | Opis powodu aktualizacji zapisu |
| Priorytet | `int` | bazodanowe | Priorytet |  |
| UwzgledniajKwoteWolna | `bool` | bazodanowe |  |  |
| Zajecie | `Soneta.Kadry.ZajęcieKomornicze` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| ZawieszenieSplaty | `bool` | bazodanowe | Zawieszenie spłaty |  |
