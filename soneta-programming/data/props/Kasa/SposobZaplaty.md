# Pola i właściwości klasy biznesowej: `Soneta.Kasa.SposobZaplaty`
Nazwa tabeli: `SposobyZaplaty`
Tytuł: Sposoby zapłaty
Opis: Słownik sposobów zapłaty określający metody regulowania należności i zobowiązań (np. przelew, gotówka, karta). Definiuje cechy sposobu zapłaty, takie jak odroczenie, limit kredytowy, obsługa terminala płatniczego oraz mechanizm podzielonej płatności (MPP).
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 13
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Biernik | `string` | bazodanowe |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| CechaESP | `Soneta.Business.FeatureDefinition` | bazodanowe |  | Cecha wyliczająca ESP na płatnosci. |
| IdentWewKSeF | `string` | bazodanowe | Identyfikator wewnętrzny KSeF | Identyfikator wewnętrzny KSeF. |
| LimitKredytowy | `bool` | bazodanowe |  |  |
| MPP | `bool` | bazodanowe |  | Metoda podzielonej płatności. |
| Nazwa | `string` | bazodanowe |  |  |
| Odroczony | `bool` | bazodanowe |  |  |
| Platnik | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  | Płatnik powiązany ze sposobem zapłaty. |
| RolaPodmiotuTrzeciegoKSeF | `Soneta.Core.Enums.RolaPodmiotuTrzeciegoKSeF` | bazodanowe, enum | Rola Podmiotu trzeciego KSeF | Rola Podmiotu trzeciego KSeF. |
| TerminalPlatniczy | `bool` | bazodanowe |  |  |
| Typ | `Soneta.Kasa.TypySposobowZaplaty` | bazodanowe, enum |  |  |
| ZastosujDanePodmiotuTrzeciegoNaDokHan | `bool` | bazodanowe |  | Czy stosować dane podmiotu trzeciego w dokumencie handlowym. |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Platnik | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

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

### TypySposobowZaplaty (`Soneta.Kasa.TypySposobowZaplaty`)
- `Gotówka` = 1 — Gotówka
- `Przelew` = 2 — Przelew
- `KartaPłatnicza` = 3 — Karta Płatnicza
- `Bezgotówkowy` = 4 — Bezgotówkowy
