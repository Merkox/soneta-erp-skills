# Pola i właściwości klasy biznesowej: `Soneta.Kalend.NieobecnoscERP7`
Nazwa tabeli: `NieobecnosciERP7`
Opis: Bilans otwarcia danych o nieobecnościach z systemu ERP7 (RP-7). Przechowuje historyczne okresy nieobecności pracownika z podziałem na kategorie, niezbędne do prawidłowego naliczania świadczeń chorobowych.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nazwa | `string` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Typ | `Soneta.Kalend.KategorieERP7` | bazodanowe, enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KategorieERP7 (`Soneta.Kalend.KategorieERP7`)
- `WynagrodzenieChorobowe` = 1 — Wynagrodzenia chorobowe
- `SwiadczenieRehabilitacyjne` = 2 — Świadczenia rehabilitacyjne
- `ZasilkiChorobowe` = 3 — Zasiłki chorobowe
- `ZasilkiOpiekuncze` = 4 — Zasiłki opiekuńcze
- `ZasilkiMacierzynskie` = 5 — Zasiłki macierzyńskie
- `UrlopyWychowawcze` = 6 — Urlopy wychowawcze
- `UrlopyBezplatne` = 7 — Urlopy bezpłatne
