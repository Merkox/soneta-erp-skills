# Pola i właściwości klasy biznesowej: `Soneta.Kadry.FundPozyczkowy`
Nazwa tabeli: `FundPozyczkowe`
Tytuł: Fundusze pożyczkowe
Opis: Członkostwo pracownika w funduszu pożyczkowym. Rejestruje okres przynależności, definicję funduszu, saldo bilansu otwarcia oraz stanowi punkt wyjścia do rejestracji pożyczek i zmian wkładu.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBazaZrodlaWyplaty`, `IPowiązanieWypłaty`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Kadry.DefinicjaFunduszuPozyczkowego` | bazodanowe, tylko-odczyt |  |  |
| Dopłaty | `ListWithView` | podlista |  |  |
| Elementy | `SubTable<Soneta.Place.WypElement>` | podlista | Elementy wynagrodzenia |  |
| ElementySkładki | `SubTable<Soneta.Place.WypElement>` | podlista |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Pozyczki | `SubTable<Soneta.Kadry.Pozyczka>` | podlista |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| RazemElementy | `ListWithView` | podlista |  |  |
| SaldoBO | `Currency` | bazodanowe |  |  |
| Zapłaty | `View` | podlista |  |  |
| ZmianyWkładu | `SubTable<Soneta.Kadry.ZmianaWkładuFunduszuPozyczkowego>` | podlista |  |  |
