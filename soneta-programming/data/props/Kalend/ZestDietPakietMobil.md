# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ZestDietPakietMobil`
Nazwa tabeli: `ZestDietPaMob`
Tytuł: Zestawienia diet pakiet mobilności
Opis: Element szczegółowy hosta zestawienia diet pakietu mobilności (IZestawienieDietPakietMobilHost). Dzienna pozycja zestawienia diet w ramach pakietu mobilności, zawierająca kraj oddelegowania, czas pracy, liczbę diet i ich wartość z uwzględnieniem korekt.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Host` → `IZestawienieDietPakietMobilHost`

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Time` | bazodanowe |  |  |
| Diety | `double` | bazodanowe |  |  |
| DietyKorekta | `double` | bazodanowe |  |  |
| DzienMiesiaca | `Date` | bazodanowe, tylko-odczyt |  |  |
| Host | `Soneta.Kalend.IZestawienieDietPakietMobilHost` | bazodanowe, tylko-odczyt, guided-parent, iface-ref |  |  |
| KodKraju | `string` |  |  |  |
| KorektaReczna | `bool` | bazodanowe |  |  |
| KrajOddelegowania | `Soneta.Kadry.IKrajDelegacji` | bazodanowe, iface-ref |  |  |
| Miesiac | `YearMonth` |  |  |  |
| WartoscDiet | `Currency` | bazodanowe |  |  |
| WartoscDietPIT | `Currency` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IZestawienieDietPakietMobilHost` | `Pracownik`, `Umowa` |
| KrajOddelegowania | `IKrajDelegacji` | `KrajDelegacji` |
