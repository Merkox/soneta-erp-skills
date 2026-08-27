# Pola i właściwości klasy biznesowej: `Soneta.Waluty.KursWaluty`
Nazwa tabeli: `KursyWalut`
Opis: Element szczegółowy kursów walut (TabelaKursowa). Przechowuje kurs kupna i sprzedaży danej waluty na konkretną datę wraz z krotnością, umożliwiając przeliczanie wartości walutowych w dokumentach i rozliczeniach.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Tabela` → `TabelaKursowa`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| DataOgłoszenia | `Date` | tylko-odczyt |  |  |
| Informacja | `string` | tylko-odczyt |  | Informacja o przeliczniku walut |
| Krotnosc | `int` | bazodanowe |  |  |
| Kurs | `double` | bazodanowe |  |  |
| KursFaktyczny | `double` | tylko-odczyt |  | Zawiera faktyczny kurs waluty po uwzględnieniu krotności. |
| KursZakupu | `double` | bazodanowe |  |  |
| NumerTabeli | `string` | bazodanowe |  |  |
| OkresWażności | `FromTo` | podlista |  |  |
| OkresWażnościWgOgłoszenia | `FromTo` | podlista |  |  |
| Tabela | `Soneta.Waluty.TabelaKursowa` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Waluta | `Soneta.Waluty.Waluta` | bazodanowe, tylko-odczyt |  |  |
| WażnyDo | `Date` | tylko-odczyt |  |  |
| WażnyOd | `Date` | tylko-odczyt |  |  |
