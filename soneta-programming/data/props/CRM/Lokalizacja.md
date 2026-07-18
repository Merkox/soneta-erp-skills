# Pola i właściwości klasy biznesowej: `Soneta.CRM.Lokalizacja`
Nazwa tabeli: `Lokalizacje`
Tytuł: Lokalizacje
Opis: Element szczegółowy kontrahenta (Lokalizacja). Przechowuje adresy dodatkowych lokalizacji kontrahenta (oddziały, magazyny, punkty odbioru) wraz z danymi kontaktowymi, umożliwiając kierowanie dostaw i korespondencji pod właściwy adres.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDaneKontaktoweHost`, `IEmailElement`, `IAdresHost`

- pola bazodanowe (zapisywalne): 12
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 2
- podlisty: 8
- subrowy: 1
- razem: 25

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| Aktywna | `bool` | bazodanowe | Aktywna | Aktywność lokalizacji. |
| DokumentyHandlowe | `SubTable` | podlista |  |  |
| Domyslna | `bool` | bazodanowe | Domyślna lokalizacja w ramach kontrahenta | Wskazuje na domyślną lokalizację w ramach kontrahenta. |
| IdentWewKSeF | `string` | bazodanowe | Identyfikator wewnętrzny KSeF | Identyfikator wewnętrzny KSeF. |
| Kod | `string` | bazodanowe | Kod | Kod lokalizacji. |
| Kontakt | `Soneta.Core.Kontakt` (subrow) | bazodanowe |  |  |
| Kontakt.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Kontakt.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Kontakt.Skype | `string` |  |  |  |
| Kontakt.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Kontakt.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| Kontakty | `SubTable<Soneta.Core.DaneKontaktowe>` | podlista |  |  |
| Kontrahent | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  | Kontrahent, do którego przypisana jest lokalizacja. |
| MailTo | `string` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa lokalizacji. |
| Nieruchomosci | `SubTable` | podlista |  |  |
| OddzialFirmy | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| Pole | `string` |  |  |  |
| RodzajeLokalizacji | `SubTable<Soneta.CRM.RodzajLokalizacji>` | podlista |  |  |
| RolaPodmiotuTrzeciegoKSeF | `Soneta.Core.Enums.RolaPodmiotuTrzeciegoKSeF` (enum) | bazodanowe | Rola Podmiotu trzeciego KSeF | Rola Podmiotu trzeciego KSeF. |
| Urzadzenia | `SubTable` | podlista |  |  |
| Uwagi | `MemoText` | bazodanowe, podlista | Uwagi | Uwagi do lokalizacji. |
| WiadomosciPowiazane | `SubTable<Soneta.CRM.ElementEmail>` | podlista |  |  |
| Zadania | `SubTable` | podlista |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Kontrahent | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |

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
