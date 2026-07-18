# Pola i właściwości klasy biznesowej: `Soneta.Kasa.OkresMW`
Nazwa tabeli: `OkresyMW`
Tytuł: Okresy magazynu walut
Opis: Definicja okresu rozliczeniowego magazynu walut powiązanego z okresem obrachunkowym. Wyznacza przedział czasowy, w ramach którego naliczane są zasoby i obroty walutowe oraz wyliczane różnice kursowe z tytułu operacji w walucie obcej.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Następny | `Soneta.Kasa.OkresMW` | tylko-odczyt |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| OkresObrachunkowy | `Row` | bazodanowe, tylko-odczyt |  |  |
| Poprzedni | `Soneta.Kasa.OkresMW` | tylko-odczyt |  |  |
| Symbol | `string` | bazodanowe |  | Symbol okresu magazynu walut |
