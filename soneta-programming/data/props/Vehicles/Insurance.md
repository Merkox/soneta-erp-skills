# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.Insurance`
Nazwa tabeli: `Insurances`
Tytuł: Ubezpieczenia pojazdów
Opis: Rejestr polis ubezpieczeniowych pojazdów floty firmowej. Przechowuje dane o okresie ubezpieczenia, ubezpieczycielu, numerze polisy, zakresie ochrony (OC, AC, NNW, Assistance), wycenie pojazdu oraz składce ubezpieczeniowej.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IEmailElement`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AC | `bool` | bazodanowe | AC |  |
| Amount | `Currency` | bazodanowe | Składka |  |
| Assistance | `bool` | bazodanowe | Assistance |  |
| Damages | `SubTable<Soneta.Vehicles.DamageEvent>` | podlista |  |  |
| Description | `MemoText` | bazodanowe, podlista | Opis polisy |  |
| Document | `Soneta.Core.IInsuranceDocument` | bazodanowe | Dokument |  |
| Estimate | `Currency` | bazodanowe | Wycena |  |
| From | `Date` | bazodanowe | Rozpoczęcie |  |
| Insurer | `Soneta.CRM.Kontrahent` | bazodanowe | Ubezpieczyciel |  |
| NNW | `bool` | bazodanowe | NNW |  |
| Number | `string` | bazodanowe | Numer polisy |  |
| OC | `bool` | bazodanowe | OC |  |
| To | `Date` | bazodanowe | Zakończenie |  |
| Vehicle | `Soneta.Samochodowka.Pojazd` | bazodanowe, tylko-odczyt | Pojazd |  |
| WiadomosciPowiazane | `SubTable<Soneta.CRM.ElementEmail>` | podlista |  |  |
