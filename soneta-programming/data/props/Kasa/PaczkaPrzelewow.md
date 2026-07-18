# Pola i właściwości klasy biznesowej: `Soneta.Kasa.PaczkaPrzelewow`
Nazwa tabeli: `PaczkiPrzelewow`
Tytuł: Paczki przelewów
Opis: Dokument grupujący przelewy do zbiorczego eksportu do banku. Paczka jest powiązana z rachunkiem bankowym firmy, posiada status realizacji i zawiera listę pozycji z poszczególnymi przelewami przeznaczonymi do wysyłki.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokument`

- pola bazodanowe (zapisywalne): 9
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 5
- podlisty: 3
- subrowy: 1
- razem: 19

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  |  |
| Definicja | `Soneta.Kasa.DefinicjaPaczkiPrzelewu` | bazodanowe |  |  |
| EwidencjaSP | `Soneta.Kasa.RachunekBankowyFirmy` | bazodanowe |  |  |
| Firma | `Soneta.Core.OddzialFirmy` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  | Nazwa paczki przelewów. |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | tylko-odczyt |  |  |
| Opis | `string` | bazodanowe |  |  |
| Pozycje | `LpSubTable<Soneta.Kasa.PozycjaPaczkiPrzelewow>` | podlista |  |  |
| StatusPP | `Soneta.Core.StatusPaczkiPrzelewow` (enum) | bazodanowe | Status paczki |  |
| TypPrzelewow | `Soneta.Kasa.TypPrzelewow` (enum) | bazodanowe | Typ przelewów |  |
| WartoscPaczki | `decimal` | tylko-odczyt | Wartość paczki |  |
| ZleceniodawcaLabel | `string` | tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusPaczkiPrzelewow (`Soneta.Core.StatusPaczkiPrzelewow`)
- `Wszystkie` = -1
- `Planowana` = 0
- `Modyfikowana` = 5
- `Weryfikowana` = 10
- `Zatwierdzona` = 20
- `Wyeksportowana` = 30
- `Anulowana` = 40
- `Zrealizowana` = 60
- `ZrealizowanaCzesciowo` = 70 — Zrealizowana częściowo
- `Odrzucona` = 80

### TypPrzelewow (`Soneta.Kasa.TypPrzelewow`)
- `Standardowy` = 0
- `Walutowy` = 5 — Walutowy
