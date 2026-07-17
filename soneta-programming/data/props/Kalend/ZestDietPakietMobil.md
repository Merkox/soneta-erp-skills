# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ZestDietPakietMobil`
Nazwa tabeli: `ZestDietPaMob`
Tytuł: Zestawienia diet pakiet mobilności
Opis: Element szczegółowy hosta zestawienia diet pakietu mobilności (IZestawienieDietPakietMobilHost). Dzienna pozycja zestawienia diet w ramach pakietu mobilności, zawierająca kraj oddelegowania, czas pracy, liczbę diet i ich wartość z uwzględnieniem korekt.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Host` → `IZestawienieDietPakietMobilHost`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Diety | `double` | bazodanowe |  |  |
| DietyKorekta | `double` | bazodanowe |  |  |
| DzienMiesiaca | `Soneta.Types.Date` | bazodanowe |  |  |
| Host | `Soneta.Kalend.IZestawienieDietPakietMobilHost` | bazodanowe, guided-parent, iface-ref |  |  |
| KodKraju | `string` |  |  |  |
| KorektaReczna | `bool` | bazodanowe |  |  |
| KrajOddelegowania | `Soneta.Kadry.IKrajDelegacji` | bazodanowe, iface-ref |  |  |
| Miesiac | `Soneta.Types.YearMonth` |  |  |  |
| WartoscDiet | `Soneta.Types.Currency` | bazodanowe |  |  |
| WartoscDietPIT | `Soneta.Types.Currency` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IZestawienieDietPakietMobilHost` | `Pracownik`, `Umowa` |
| KrajOddelegowania | `IKrajDelegacji` | `KrajDelegacji` |
