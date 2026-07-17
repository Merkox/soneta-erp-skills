# Pola i właściwości klasy biznesowej: `Soneta.Kasa.PaczkaPrzelewow`
Nazwa tabeli: `PaczkiPrzelewow`
Tytuł: Paczki przelewów
Opis: Dokument grupujący przelewy do zbiorczego eksportu do banku. Paczka jest powiązana z rachunkiem bankowym firmy, posiada status realizacji i zawiera listę pozycji z poszczególnymi przelewami przeznaczonymi do wysyłki.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokument`

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Definicja | `Soneta.Kasa.DefinicjaPaczkiPrzelewu` | bazodanowe |  |  |
| EwidencjaSP | `Soneta.Kasa.RachunekBankowyFirmy` | bazodanowe |  |  |
| Firma | `Soneta.Core.OddzialFirmy` |  |  |  |
| Nazwa | `string` | bazodanowe |  | Nazwa paczki przelewów. |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` |  |  |  |
| Opis | `string` | bazodanowe |  |  |
| Pozycje | `Soneta.Business.LpSubTable<Soneta.Kasa.PozycjaPaczkiPrzelewow>` |  |  |  |
| StatusPP | `Soneta.Core.StatusPaczkiPrzelewow` | bazodanowe, enum | Status paczki |  |
| TypPrzelewow | `Soneta.Kasa.TypPrzelewow` | bazodanowe, enum | Typ przelewów |  |
| WartoscPaczki | `decimal` |  | Wartość paczki |  |
| ZleceniodawcaLabel | `string` |  |  |  |

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
