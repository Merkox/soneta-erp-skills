# Pola i właściwości klasy biznesowej: `Soneta.Kadry.PrzychodZDzialnosci`
Nazwa tabeli: `PrzychodyZDzial`
Tytuł: Przychody oraz dochody dla form opodatkowania
Opis: Element szczegółowy pracownika (Pracownik). Roczna ewidencja przychodów i dochodów właściciela z podziałem na formy opodatkowania (karta podatkowa, ryczałt, zasady ogólne), wykorzystywana do wyliczania składek ZUS i zaliczek podatkowych PIT-5.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| KartaPodatkowa | `Soneta.Kadry.PrzychodDoOpodatkowaniaKwoty` (subrow) | bazodanowe |  |  |
| KartaPodatkowa.Dochod | `decimal` | bazodanowe | Dochód |  |
| KartaPodatkowa.Przychod | `decimal` | bazodanowe | Przychód |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Razem | `Soneta.Kadry.PrzychodDoOpodatkowaniaRazem` (subrow) | bazodanowe |  |  |
| Razem.Dochod | `decimal` | tylko-odczyt |  |  |
| Razem.Przychod | `decimal` | tylko-odczyt |  |  |
| Rok | `int` | bazodanowe |  |  |
| Ryczalt | `Soneta.Kadry.PrzychodDoOpodatkowaniaKwoty` (subrow) | bazodanowe |  |  |
| RyczaltPrzychodBezZUS | `decimal` | bazodanowe |  |  |
| WgOgolnychZasad | `Soneta.Kadry.PrzychodDoOpodatkowaniaKwoty` (subrow) | bazodanowe |  |  |
