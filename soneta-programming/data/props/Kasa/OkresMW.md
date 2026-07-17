# Pola i właściwości klasy biznesowej: `Soneta.Kasa.OkresMW`
Nazwa tabeli: `OkresyMW`
Tytuł: Okresy magazynu walut
Opis: Definicja okresu rozliczeniowego magazynu walut powiązanego z okresem obrachunkowym. Wyznacza przedział czasowy, w ramach którego naliczane są zasoby i obroty walutowe oraz wyliczane różnice kursowe z tytułu operacji w walucie obcej.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Następny | `Soneta.Kasa.OkresMW` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| OkresObrachunkowy | `Soneta.Business.Row` | bazodanowe |  |  |
| Poprzedni | `Soneta.Kasa.OkresMW` |  |  |  |
| Symbol | `string` | bazodanowe |  | Symbol okresu magazynu walut |
