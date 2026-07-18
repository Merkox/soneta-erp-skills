# Pola i właściwości klasy biznesowej: `Soneta.Kalend.WyjatekRegulyDostepnosci`
Nazwa tabeli: `WyjatkiRegDost`
Tytuł: Wyjątki od reguły dostępności
Opis: Tabela przechowuje wyjątki od reguł dostępności w kalendarzu. Każdy wyjątek powiązany jest z konkretną regułą dostępności i wskazuje datę, w której dana reguła nie obowiązuje.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Regula` → `RegulaDostepnosci`

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| Regula | `Soneta.Kalend.RegulaDostepnosci` | bazodanowe, tylko-odczyt, guided-parent |  |  |
