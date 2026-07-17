# Pola i właściwości klasy biznesowej: `Soneta.Waluty.KursWaluty`
Nazwa tabeli: `KursyWalut`
Opis: Element szczegółowy kursów walut (TabelaKursowa). Przechowuje kurs kupna i sprzedaży danej waluty na konkretną datę wraz z krotnością, umożliwiając przeliczanie wartości walutowych w dokumentach i rozliczeniach.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Tabela` → `TabelaKursowa`

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DataOgłoszenia | `Soneta.Types.Date` |  |  |  |
| Informacja | `string` |  |  | Informacja o przeliczniku walut |
| Krotnosc | `int` | bazodanowe |  |  |
| Kurs | `double` | bazodanowe |  |  |
| KursFaktyczny | `double` |  |  | Zawiera faktyczny kurs waluty po uwzględnieniu krotności. |
| KursZakupu | `double` | bazodanowe |  |  |
| NumerTabeli | `string` | bazodanowe |  |  |
| OkresWażności | `Soneta.Types.FromTo` |  |  |  |
| OkresWażnościWgOgłoszenia | `Soneta.Types.FromTo` |  |  |  |
| Tabela | `Soneta.Waluty.TabelaKursowa` | bazodanowe, guided-parent |  |  |
| Waluta | `Soneta.Waluty.Waluta` | bazodanowe |  |  |
| WażnyDo | `Soneta.Types.Date` |  |  |  |
| WażnyOd | `Soneta.Types.Date` |  |  |  |
