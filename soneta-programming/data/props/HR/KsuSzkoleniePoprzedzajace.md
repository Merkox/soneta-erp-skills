# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.KSU.KsuSzkoleniePoprzedzajace`
Nazwa tabeli: `ZklKsuSzkPop`
Tytuł: Powiązania informacji KSU ze szkoleniami poprzedzającymi
Opis: Zawiera szkolenia wymagane przed objęciem stanowiska. Ułatwia planowanie ścieżek rozwojowych stanowisk.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaInfo | `Soneta.HR.ZKL.Slowniki.KSU.KsuDefinicjaInfo` | bazodanowe | Definicja informacji KSU |  |
| PoprzedzajaceKsuGuid | `System.Guid` | bazodanowe | Szkolenie poprzedzające (identyfikator) |  |
| PoprzedzajaceKsuTyp | `Soneta.HR.ZKL.Enums.KsuPozycjaTyp` | bazodanowe, enum | Typ szkolenia poprzedzającego |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KsuPozycjaTyp (`Soneta.HR.ZKL.Enums.KsuPozycjaTyp`)
- `None` = 0 — Brak
- `Szkolenie` = 10 — Szkolenie
- `Uprawnienie` = 20 — Uprawnienie
- `SzkolenieBhp` = 30 — Szkolenie BHP
