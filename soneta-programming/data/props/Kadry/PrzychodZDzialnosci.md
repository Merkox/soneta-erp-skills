# Pola i właściwości klasy biznesowej: `Soneta.Kadry.PrzychodZDzialnosci`
Nazwa tabeli: `PrzychodyZDzial`
Tytuł: Przychody oraz dochody dla form opodatkowania
Opis: Element szczegółowy pracownika (Pracownik). Roczna ewidencja przychodów i dochodów właściciela z podziałem na formy opodatkowania (karta podatkowa, ryczałt, zasady ogólne), wykorzystywana do wyliczania składek ZUS i zaliczek podatkowych PIT-5.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| KartaPodatkowa | `Soneta.Kadry.PrzychodDoOpodatkowaniaKwoty` | bazodanowe |  |  |
| KartaPodatkowa.Dochod | `decimal` | bazodanowe | Dochód |  |
| KartaPodatkowa.Przychod | `decimal` | bazodanowe | Przychód |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, guided-parent |  |  |
| Razem | `Soneta.Kadry.PrzychodDoOpodatkowaniaRazem` | bazodanowe |  |  |
| Razem.Dochod | `decimal` |  |  |  |
| Razem.Przychod | `decimal` |  |  |  |
| Rok | `int` | bazodanowe |  |  |
| Ryczalt | `Soneta.Kadry.PrzychodDoOpodatkowaniaKwoty` | bazodanowe |  |  |
| RyczaltPrzychodBezZUS | `decimal` | bazodanowe |  |  |
| WgOgolnychZasad | `Soneta.Kadry.PrzychodDoOpodatkowaniaKwoty` | bazodanowe |  |  |
