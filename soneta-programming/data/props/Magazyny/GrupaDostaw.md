# Pola i właściwości klasy biznesowej: `Soneta.Magazyny.Dostawy.GrupaDostaw`
Nazwa tabeli: `GrupyDostaw`
Tytuł: Partie
Opis: Partia towaru (grupa dostaw) umożliwiająca śledzenie pochodzenia towaru na magazynie. Identyfikowana numerem i powiązana z towarem, pozwala na kontrolę dat ważności, blokadę oraz rozliczanie przychodów i rozchodów.
Tabela konfiguracyjna: Nie
Implementuje interfejsy: `IKodowany`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 1
- podlisty: 2
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Blokada. | Blokuje możliwość manipulowania grupą dostaw. |
| Data | `Date` | bazodanowe | Data | Data. |
| KodKreskowy | `string` |  |  |  |
| KodyKreskowe | `SubTable<Soneta.Core.KodKreskowy>` | podlista |  |  |
| Numer | `string` | bazodanowe | Numer | Numer partii. |
| RelacjePartii | `SubTable<Soneta.Handel.Dostawy.RelacjaGrupyDostaw>` | podlista |  |  |
| Towar | `Soneta.Towary.Towar` | bazodanowe, tylko-odczyt | Towar w partii. | Towar w partii. |
