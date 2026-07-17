# Pola i właściwości klasy biznesowej: `Soneta.Kadry.RelacjaWykonPrac`
Nazwa tabeli: `RelacjeWykonPrac`
Tytuł: Powiązanie Wykonujący Pracownik
Opis: Tabela łącząca wykonującego (operatora systemu lub pracownika) z kartoteką pracownika. Umożliwia przypisanie konta operatora do konkretnego pracownika na potrzeby autoryzacji i pulpitu pracowniczego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, guided-parent |  |  |
| Wykonujacy | `Soneta.Business.IWykonujacy` | bazodanowe |  |  |
