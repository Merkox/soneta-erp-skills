# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFIdentWewnRola`
Nazwa tabeli: `KSeFIdentWewnRole`
Tytuł: Role identyfikatorów wewnętrznych KSeF
Opis: Przypisanie roli podmiotu trzeciego KSeF do identyfikatora wewnętrznego. Określa typ roli (sprzedaż/zakup) i konkretną rolę podmiotu trzeciego, dla której identyfikator wewnętrzny jest stosowany.
Tabela konfiguracyjna: Tak

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| IdentWewnKSeF | `Soneta.Core.KSeFIdentWewn` | bazodanowe |  |  |
| Rola | `Soneta.Core.Enums.RolaPodmiotuTrzeciegoKSeF` | bazodanowe, enum | Rola podmiotu trzeciego KSeF | Rola podmiotu trzeciego KSeF |
| TypRoli | `Soneta.Core.Enums.TypRoliPodmiotuTrzeciegoKSeF` | bazodanowe, enum | Typ roli podmiotu (sprzedaż, zakup) | Typ roli podmiotu (sprzedaż, zakup) |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RolaPodmiotuTrzeciegoKSeF (`Soneta.Core.Enums.RolaPodmiotuTrzeciegoKSeF`)
- `Brak` = 0
- `Faktor` = 1 — 1 - Faktor
- `Odbiorca` = 2 — 2 - Odbiorca
- `PodmiotPierwotny` = 3 — 3 - Podmiot pierwotny
- `DodatkowyNabywca` = 4 — 4 - Dodatkowy nabywca
- `WystawcaFaktury` = 5 — 5 - Wystawca faktury
- `DokonujacyPlatnosci` = 6 — 6 - Dokonujący płatności
- `JednostkaSamorzaduTerytorialnegoWystawca` = 7 — 7 - Jednostka samorządu terytorialnego - wystawca
- `JednostkaSamorzaduTerytorialnegoOdbiorca` = 8 — 8 - Jednostka samorządu terytorialnego - odbiorca
- `CzłonekGrupyVATWystawca` = 9 — 9 - Członek grupy VAT - wystawca
- `CzłonekGrupyVATOdbiorca` = 10 — 10 - Członek grupy VAT - odbiorca
- `Pracownik` = 11 — 11 - Pracownik
- `RolaInna` = 100 — Rola inna

### TypRoliPodmiotuTrzeciegoKSeF (`Soneta.Core.Enums.TypRoliPodmiotuTrzeciegoKSeF`)
- `Sprzedaz` = 1
- `Zakup` = 2
