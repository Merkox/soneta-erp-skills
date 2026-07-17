# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.Insurance`
Nazwa tabeli: `Insurances`
Tytuł: Ubezpieczenia pojazdów
Opis: Rejestr polis ubezpieczeniowych pojazdów floty firmowej. Przechowuje dane o okresie ubezpieczenia, ubezpieczycielu, numerze polisy, zakresie ochrony (OC, AC, NNW, Assistance), wycenie pojazdu oraz składce ubezpieczeniowej.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IEmailElement`

- pola bazodanowe: 13
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AC | `bool` | bazodanowe | AC |  |
| Amount | `Soneta.Types.Currency` | bazodanowe | Składka |  |
| Assistance | `bool` | bazodanowe | Assistance |  |
| Damages | `Soneta.Business.SubTable<Soneta.Vehicles.DamageEvent>` |  |  |  |
| Description | `Soneta.Business.MemoText` | bazodanowe | Opis polisy |  |
| Document | `Soneta.Core.IInsuranceDocument` | bazodanowe | Dokument |  |
| Estimate | `Soneta.Types.Currency` | bazodanowe | Wycena |  |
| From | `Soneta.Types.Date` | bazodanowe | Rozpoczęcie |  |
| Insurer | `Soneta.CRM.Kontrahent` | bazodanowe | Ubezpieczyciel |  |
| NNW | `bool` | bazodanowe | NNW |  |
| Number | `string` | bazodanowe | Numer polisy |  |
| OC | `bool` | bazodanowe | OC |  |
| To | `Soneta.Types.Date` | bazodanowe | Zakończenie |  |
| Vehicle | `Soneta.Samochodowka.Pojazd` | bazodanowe | Pojazd |  |
| WiadomosciPowiazane | `Soneta.Business.SubTable<Soneta.CRM.ElementEmail>` |  |  |  |
