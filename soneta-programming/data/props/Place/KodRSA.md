# Pola i właściwości klasy biznesowej: `Soneta.Place.KodRSA`
Nazwa tabeli: `KodyRSA`
Tytuł: Kody na deklaracji RSA
Opis: Słownik kodów tytułu świadczenia/przerwy stosowanych na deklaracji ZUS RSA. Określa typ kodu, powiązanie z pozycją RCA, okres obowiązywania i zasady rozliczania składek chorobowych i wypadkowych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 16
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Budzet | `bool` | bazodanowe |  |  |
| Chorobowe | `bool` | bazodanowe |  |  |
| DefinicjeNieobecnosci | `Soneta.Business.SubTable<Soneta.Kalend.DefinicjaNieobecnosci>` |  |  |  |
| Dodatkowy | `int` | bazodanowe |  |  |
| Kategoria | `string` | bazodanowe |  |  |
| Kod | `int` | bazodanowe |  |  |
| KodText | `string` |  |  |  |
| Korekta | `int` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| PozycjaRCA | `Soneta.Place.PozycjaRCA` | bazodanowe, enum |  |  |
| Typ | `Soneta.Place.TypKoduRSA` | bazodanowe, enum |  |  |
| WgOkresu | `bool` | bazodanowe |  |  |
| WymaganeUbezpieczenie | `Soneta.Place.WymaganeUbezpieczenie` | bazodanowe, enum |  |  |
| Wynagrodzenie | `bool` | bazodanowe |  |  |
| WynagrodzenieChorobowe | `bool` | bazodanowe |  |  |
| Wypadkowe | `bool` | bazodanowe |  |  |
| Wyrównanie | `Soneta.Place.KodRSA` |  |  |  |
| ZasilekChorobowy | `bool` | bazodanowe |  |  |
| ZasiłekRSA | `bool` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PozycjaRCA (`Soneta.Place.PozycjaRCA`)
- `NieDotyczy` = 0
- `ZasiłekRodzinny` = 1
- `DodatekRodzinny` = 2
- `ZasiłekPielęgnacyjny` = 3
- `ZasiłekWychowawczy` = 4
- `DodDoZasRodzinnego` = 5 — Dodatek do zasiłku rodzinnego
- `PodstawowaSkładkaNaPFE` = 10 — Podstawowa składka na PFE
- `ZwrotSkładkiNaPPKUczestnika` = 11 — Zwrot składki na PPK uczestnika
- `ZwrotSkładkiNaPPKPracodawcy` = 12 — Zwrot składki na PPK pracodawcy

### TypKoduRSA (`Soneta.Place.TypKoduRSA`)
- `PrzerwaWOpłacaniuSkładek` = 1 — Przerwa w opłacaniu składek
- `Świadczenie` = 2
- `ŚwiadczenieIPrzerwa` = 3

### WymaganeUbezpieczenie (`Soneta.Place.WymaganeUbezpieczenie`)
- `NieWymaga` = 0 — Nie wymaga
- `Dowolne` = 1
- `Chorobowe` = 2
- `Wypadkowe` = 3
