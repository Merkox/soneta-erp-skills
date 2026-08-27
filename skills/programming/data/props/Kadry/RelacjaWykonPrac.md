# Pola i właściwości klasy biznesowej: `Soneta.Kadry.RelacjaWykonPrac`
Nazwa tabeli: `RelacjeWykonPrac`
Tytuł: Powiązanie Wykonujący Pracownik
Opis: Tabela łącząca wykonującego (operatora systemu lub pracownika) z kartoteką pracownika. Umożliwia przypisanie konta operatora do konkretnego pracownika na potrzeby autoryzacji i pulpitu pracowniczego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Wykonujacy | `IWykonujacy` | bazodanowe, tylko-odczyt |  |  |
