# Pola i właściwości klasy biznesowej: `Soneta.Kalend.WyjatekRegulyDostepnosci`
Nazwa tabeli: `WyjatkiRegDost`
Tytuł: Wyjątki od reguły dostępności
Opis: Tabela przechowuje wyjątki od reguł dostępności w kalendarzu. Każdy wyjątek powiązany jest z konkretną regułą dostępności i wskazuje datę, w której dana reguła nie obowiązuje.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Regula` → `RegulaDostepnosci`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Regula | `Soneta.Kalend.RegulaDostepnosci` | bazodanowe, guided-parent |  |  |
