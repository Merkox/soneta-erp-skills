# Pola i właściwości klasy biznesowej: `Soneta.Place.BilansOtwarciaPIT`
Nazwa tabeli: `BilansyOtwPIT`
Tytuł: Bilansy otwarcia PIT
Opis: Bilans otwarcia danych podatkowych PIT pracownika przy zmianie pracodawcy lub systemu. Przechowuje skumulowane wartości składek ZUS, zdrowotnych i przychodów z poprzedniego okresu zatrudnienia.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 19
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Elementy | `Soneta.Business.SubTable<Soneta.Place.ElementBilansuOtwarciaPIT>` |  |  |  |
| OkresWażności | `Soneta.Types.FromTo` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Przychod26Zwol | `decimal` |  |  |  |
| Przychod26ZwolEtat | `decimal` | bazodanowe | Przchód (26, etat) |  |
| Przychod26ZwolMacierzynski | `decimal` | bazodanowe | Przychód (26, macierzyński) |  |
| Przychod26ZwolStaze | `decimal` | bazodanowe | Przychód (26, staż) |  |
| Przychod26ZwolUmowa | `decimal` | bazodanowe | Przchód (26, umowa) |  |
| PrzychodUlga | `decimal` |  |  |  |
| PrzychodUlgaEtat | `decimal` | bazodanowe | Przychód (ulgi, etat) |  |
| PrzychodUlgaMacierzynski | `decimal` | bazodanowe | Przychód (ulgi, macierzyński) |  |
| PrzychodUlgaUmowa | `decimal` | bazodanowe | Przychód (ulgi, umowa) |  |
| SkladkiCzlonkowskie | `decimal` | bazodanowe | Składka członkowska |  |
| Spoleczne | `decimal` | bazodanowe | Koszty ZUS |  |
| Spoleczne26 | `decimal` | bazodanowe | Koszty ZUS (26) |  |
| Spoleczne26Zwol | `decimal` | bazodanowe | Koszty ZUS (od przychodu zwolnionego, 26) |  |
| Wersja | `Soneta.Place.WersjaBilansuOtwarciaPIT` | bazodanowe, enum |  |  |
| Zatwierdzony | `bool` |  |  |  |
| ZdrDoOdlicz | `decimal` | bazodanowe | Składka zdrowotna (odliczana) |  |
| ZdrDoOdlicz26 | `decimal` | bazodanowe | Składka zdrowotna (odliczana, 26) |  |
| ZdrDoOdlicz26Zwol | `decimal` | bazodanowe | Składka zdrowotna (od przychodu zwolnionego, 26) |  |
| Zdrowotne9Procent | `decimal` | bazodanowe | Składka zdrowotna do 9% |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### WersjaBilansuOtwarciaPIT (`Soneta.Place.WersjaBilansuOtwarciaPIT`)
- `PIT11_11` = 1111 — PIT-11 (11)
- `PIT11_29` = 1129 — PIT-11 (29)
