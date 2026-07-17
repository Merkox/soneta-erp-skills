# Pola i właściwości klasy biznesowej: `Soneta.Place.RozliczenieWynagrodzenia`
Nazwa tabeli: `RozliczWynagrodz`
Tytuł: Rozliczenia wynagrodzenia
Opis: Sposób rozliczenia wynagrodzenia pracownika na rachunki bankowe. Definiuje podział kwoty do wypłaty na poszczególne rachunki z uwzględnieniem priorytetów, kwot stałych lub procentowych.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Host` → `IRozliczenieWynagrodzeniaHost`

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Etat | `bool` | bazodanowe |  |  |
| Ewidencja | `Soneta.Kasa.EwidencjaSP` | bazodanowe |  |  |
| Host | `Soneta.Place.IRozliczenieWynagrodzeniaHost` | bazodanowe, guided-parent, iface-ref |  |  |
| Inne | `bool` | bazodanowe |  |  |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` |  |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| Procent | `Soneta.Types.Percent` | bazodanowe |  |  |
| Rachunek | `Soneta.Kasa.RachunekBankowyPodmiotu` | bazodanowe |  |  |
| Umowa | `bool` | bazodanowe |  |  |
| Waluta | `Soneta.Waluty.Waluta` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IRozliczenieWynagrodzeniaHost` | `Pozyczka`, `Pracownik`, `Umowa` |
