# Pola i właściwości klasy biznesowej: `Soneta.Waluty.TabelaKursowa`
Nazwa tabeli: `TabeleKursowe`
Tytuł: Tabele kursowe
Opis: Definicja tabeli kursowej służącej do przeliczania wartości walutowych. Określa walutę bazową tabeli i sposób pobierania kursów (np. wg kursu z dnia operacji). Umożliwia korzystanie z wielu źródeł kursów, takich jak NBP czy ECB.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| KursWBazowej | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Notowania | `Soneta.Business.SubTable<Soneta.Waluty.KursWaluty>` |  |  |  |
| WalutaBazowa | `Soneta.Waluty.Waluta` | bazodanowe |  |  |
| WgKursuDnia | `bool` | bazodanowe |  |  |
