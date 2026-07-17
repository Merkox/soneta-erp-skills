# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFPodmiot3`
Nazwa tabeli: `KSeFPodmioty3`
Tytuł: Dane podmiotów trzecich komunikatu KSeF
Opis: Dane podmiotu trzeciego (np. odbiorca, nabywca, płatnik) w komunikacie KSeF. Przechowuje rolę podmiotu, źródło danych adresowych, identyfikator wewnętrzny KSeF, typ identyfikatora, powiązanie z kontrahentem oraz flagę edycji i automatycznego dodania.
Tabela konfiguracyjna: Nie
Implementuje interfejsy: `IDaneKontrahentaHost`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dane | `Soneta.Core.Enums.ZrodloDanychAdresowychKSeF` | bazodanowe, enum | Miejsce pobierania danych do KSeF | Miejsce pobierania danych do KSeF |
| DaneKontrahenta | `Soneta.Core.DaneKontrahenta` |  |  |  |
| DodanyAutomatycznie | `bool` | bazodanowe | Dodany automatycznie | Czy dane zostały dodane automatycznie przez system |
| Edycja | `bool` | bazodanowe | Edycja danych podmiotu trzeciego KSeF | Edycja danych podmiotu trzeciego KSeF |
| IdentWew | `string` | bazodanowe | Identyfikator wewnętrzny KSeF | Identyfikator wewnętrzny KSeF |
| KSeFKomunikat | `Soneta.Core.KSeFKomunikat` | bazodanowe |  |  |
| Podmiot | `Soneta.Core.IPodmiot` | bazodanowe, iface-ref |  |  |
| Rola | `Soneta.Core.Enums.RolaPodmiotuTrzeciegoKSeF` | bazodanowe, enum | Rola podmiotu trzeciego KSeF | Rola podmiotu trzeciego KSeF |
| RolaInnaOpis | `string` | bazodanowe | Opis roli innej | Opis roli podmiotu, gdy nie pasuje do żadnej z dostępnych ról |
| TypIdentWew | `Soneta.Core.Enums.TypIdentyfikatoraWewnetrznegoKSeF` | bazodanowe, enum | Typ identyfikatora wewnętrznego KSeF | Typ identyfikatora wewnętrznego KSeF |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Podmiot | `IPodmiot` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

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

### TypIdentyfikatoraWewnetrznegoKSeF (`Soneta.Core.Enums.TypIdentyfikatoraWewnetrznegoKSeF`)
- `IdWew` = 0 — IdWew
- `NIP` = 1
- `BrakId` = 2 — Brak Id
- `NrVatUE` = 3 — NrVatUE
- `NrID` = 4 — NrID

### ZrodloDanychAdresowychKSeF (`Soneta.Core.Enums.ZrodloDanychAdresowychKSeF`)
- `Brak` = 0
- `Lokalizacja` = 1
- `Odbiorca` = 2
- `NieWysylaj` = 3 — Nie wysyłaj
- `Oddzial` = 4 — Oddział
- `DaneFirmy` = 5 — Dane firmy
- `DaneKontrahenta` = 6 — Dane kontrahenta
