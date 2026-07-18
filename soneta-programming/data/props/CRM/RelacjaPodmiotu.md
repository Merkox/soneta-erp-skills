# Pola i właściwości klasy biznesowej: `Soneta.CRM.RelacjaPodmiotu`
Nazwa tabeli: `RelacjePodmiotow`
Tytuł: Relacje podmiotów
Opis: Definiuje relację hierarchiczną pomiędzy podmiotami (np. firma matka - spółka córka, odbiorca - płatnik). Umożliwia modelowanie powiązań kapitałowych i handlowych między kontrahentami, bankami i urzędami.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 2
- subrowy: 1
- razem: 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nadrzedny | `Soneta.Core.IPodmiot` | bazodanowe, iface-ref | Podmiot nadrzędny |  |
| OdbiorcaPlatnik | `bool` | bazodanowe | Odbiorca/Dostawca jest płatnikiem |  |
| Podrzedni | `View` | podlista |  |  |
| Podrzedny | `Soneta.Core.IPodmiot` | bazodanowe, tylko-odczyt, iface-ref | Podmiot podrzędny |  |
| PowiazaniePodmiotu | `Soneta.CRM.PowiazaniePodmiotu` (subrow) | bazodanowe | Powiązanie | Powiązanie |
| PowiazaniePodmiotu.IdentWewKSeF | `string` | bazodanowe | Identyfikator wewnętrzny KSeF | Identyfikator wewnętrzny KSeF. |
| PowiazaniePodmiotu.Okres | `FromTo` | bazodanowe, podlista | Okres |  |
| PowiazaniePodmiotu.RodzajPowiazania | `Soneta.CRM.RodzajPowiazaniaPodmiotu` (enum) | bazodanowe | Rodzaj powiązania |  |
| PowiazaniePodmiotu.Rola | `Soneta.CRM.RolaPodmiotu` (enum) | bazodanowe | Rola |  |
| PowiazaniePodmiotu.RolaPodmiotuTrzeciegoKSeF | `Soneta.Core.Enums.RolaPodmiotuTrzeciegoKSeF` (enum) | bazodanowe | Rola Podmiotu trzeciego KSeF | Rola Podmiotu trzeciego KSeF. |
| PowiazaniePodmiotu.WysylajNipWPodmiocieTrzecimKSeF | `bool` | bazodanowe | Czy wysyłać NIP w podmiocie trzecim. | Czy wysyłać NIP w podmiocie trzecim. |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Nadrzedny | `IPodmiot` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |
| Podrzedny | `IPodmiot` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

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
