# Pola i właściwości klasy biznesowej: `Soneta.CRM.PodmiotPowiazany`
Nazwa tabeli: `PodmiotyPow`
Tytuł: Podmiot powiązany
Opis: Powiązanie kontrahenta z podmiotem w kontekście oddziału firmy. Umożliwia definiowanie relacji między kontrahentami a oddziałami (np. jako dostawca, odbiorca) wraz z informacjami o rodzaju powiązania, roli i okresie obowiązywania.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział | Oddział firmy |
| PowiazaniePodmiotu | `Soneta.CRM.PowiazaniePodmiotu` | bazodanowe | Powiązanie | Powiązanie |
| PowiazaniePodmiotu.IdentWewKSeF | `string` | bazodanowe | Identyfikator wewnętrzny KSeF | Identyfikator wewnętrzny KSeF. |
| PowiazaniePodmiotu.Okres | `Soneta.Types.FromTo` | bazodanowe | Okres |  |
| PowiazaniePodmiotu.RodzajPowiazania | `Soneta.CRM.RodzajPowiazaniaPodmiotu` | bazodanowe, enum | Rodzaj powiązania |  |
| PowiazaniePodmiotu.Rola | `Soneta.CRM.RolaPodmiotu` | bazodanowe, enum | Rola |  |
| PowiazaniePodmiotu.RolaPodmiotuTrzeciegoKSeF | `Soneta.Core.Enums.RolaPodmiotuTrzeciegoKSeF` | bazodanowe, enum | Rola Podmiotu trzeciego KSeF | Rola Podmiotu trzeciego KSeF. |
| PowiazaniePodmiotu.WysylajNipWPodmiocieTrzecimKSeF | `bool` | bazodanowe | Czy wysyłać NIP w podmiocie trzecim. | Czy wysyłać NIP w podmiocie trzecim. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajPowiazaniaPodmiotu (`Soneta.CRM.RodzajPowiazaniaPodmiotu`)
- `Inny` = 0 — Inny
- `VAT` = 1 — VAT
- `KSeF` = 2 — KSeF
- `JST` = 3 — JST

### RolaPodmiotu (`Soneta.CRM.RolaPodmiotu`)
- `Inna` = 0 — Inna
- `JednostkaNadrzedna` = 1 — Jednostka nadrzędna
- `CzlonekGrupyVAT` = 2 — Członek grupy VAT
- `PrzedstawicielGrupyVAT` = 3 — Przedstawiciel grupy VAT
- `Odbiorca` = 4 — Odbiorca
- `DokonujacyPlatnosci` = 5 — Dokonujący płatności
- `JednostkaSamorzaduTerytorialnego` = 6 — Jednostka samorządu terytorialnego - odbiorca
- `Pracownik` = 7 — Pracownik
- `Faktor` = 8 — Faktor

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
