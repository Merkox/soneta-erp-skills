# Pola i właściwości klasy biznesowej: `Soneta.Kadry.FundPozyczkowy`
Nazwa tabeli: `FundPozyczkowe`
Tytuł: Fundusze pożyczkowe
Opis: Członkostwo pracownika w funduszu pożyczkowym. Rejestruje okres przynależności, definicję funduszu, saldo bilansu otwarcia oraz stanowi punkt wyjścia do rejestracji pożyczek i zmian wkładu.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBazaZrodlaWyplaty`, `IPowiązanieWypłaty`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Kadry.DefinicjaFunduszuPozyczkowego` | bazodanowe |  |  |
| Dopłaty | `Soneta.Business.ListWithView` |  |  |  |
| Elementy | `Soneta.Business.SubTable<Soneta.Place.WypElement>` |  | Elementy wynagrodzenia |  |
| ElementySkładki | `Soneta.Business.SubTable<Soneta.Place.WypElement>` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Pozyczki | `Soneta.Business.SubTable<Soneta.Kadry.Pozyczka>` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| RazemElementy | `Soneta.Business.ListWithView` |  |  |  |
| SaldoBO | `Soneta.Types.Currency` | bazodanowe |  |  |
| Zapłaty | `Soneta.Business.View` |  |  |  |
| ZmianyWkładu | `Soneta.Business.SubTable<Soneta.Kadry.ZmianaWkładuFunduszuPozyczkowego>` |  |  |  |
