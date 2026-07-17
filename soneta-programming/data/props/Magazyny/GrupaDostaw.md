# Pola i właściwości klasy biznesowej: `Soneta.Magazyny.Dostawy.GrupaDostaw`
Nazwa tabeli: `GrupyDostaw`
Tytuł: Partie
Opis: Partia towaru (grupa dostaw) umożliwiająca śledzenie pochodzenia towaru na magazynie. Identyfikowana numerem i powiązana z towarem, pozwala na kontrolę dat ważności, blokadę oraz rozliczanie przychodów i rozchodów.
Tabela konfiguracyjna: Nie
Implementuje interfejsy: `IKodowany`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Blokada. | Blokuje możliwość manipulowania grupą dostaw. |
| Data | `Soneta.Types.Date` | bazodanowe | Data | Data. |
| KodKreskowy | `string` |  |  |  |
| KodyKreskowe | `Soneta.Business.SubTable<Soneta.Core.KodKreskowy>` |  |  |  |
| Numer | `string` | bazodanowe | Numer | Numer partii. |
| RelacjePartii | `Soneta.Business.SubTable<Soneta.Handel.Dostawy.RelacjaGrupyDostaw>` |  |  |  |
| Towar | `Soneta.Towary.Towar` | bazodanowe | Towar w partii. | Towar w partii. |
