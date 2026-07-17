# Pola i właściwości klasy biznesowej: `Soneta.CRM.Lokalizacja`
Nazwa tabeli: `Lokalizacje`
Tytuł: Lokalizacje
Opis: Element szczegółowy kontrahenta (Lokalizacja). Przechowuje adresy dodatkowych lokalizacji kontrahenta (oddziały, magazyny, punkty odbioru) wraz z danymi kontaktowymi, umożliwiając kierowanie dostaw i korespondencji pod właściwy adres.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDaneKontaktoweHost`, `IEmailElement`, `IAdresHost`

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` |  |  |  |
| Aktywna | `bool` | bazodanowe | Aktywna | Aktywność lokalizacji. |
| DokumentyHandlowe | `Soneta.Business.SubTable` |  |  |  |
| Domyslna | `bool` | bazodanowe | Domyślna lokalizacja w ramach kontrahenta | Wskazuje na domyślną lokalizację w ramach kontrahenta. |
| IdentWewKSeF | `string` | bazodanowe | Identyfikator wewnętrzny KSeF | Identyfikator wewnętrzny KSeF. |
| Kod | `string` | bazodanowe | Kod | Kod lokalizacji. |
| Kontakt | `Soneta.Core.Kontakt` | bazodanowe |  |  |
| Kontakt.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Kontakt.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Kontakt.Skype | `string` |  |  |  |
| Kontakt.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Kontakt.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| Kontakty | `Soneta.Business.SubTable<Soneta.Core.DaneKontaktowe>` |  |  |  |
| Kontrahent | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  | Kontrahent, do którego przypisana jest lokalizacja. |
| MailTo | `string` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa lokalizacji. |
| Nieruchomosci | `Soneta.Business.SubTable` |  |  |  |
| OddzialFirmy | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| Pole | `string` |  |  |  |
| RodzajeLokalizacji | `Soneta.Business.SubTable<Soneta.CRM.RodzajLokalizacji>` |  |  |  |
| RolaPodmiotuTrzeciegoKSeF | `Soneta.Core.Enums.RolaPodmiotuTrzeciegoKSeF` | bazodanowe, enum | Rola Podmiotu trzeciego KSeF | Rola Podmiotu trzeciego KSeF. |
| Urzadzenia | `Soneta.Business.SubTable` |  |  |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe | Uwagi | Uwagi do lokalizacji. |
| WiadomosciPowiazane | `Soneta.Business.SubTable<Soneta.CRM.ElementEmail>` |  |  |  |
| Zadania | `Soneta.Business.SubTable` |  |  |  |

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
