# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.DictionaryItem`
Nazwa tabeli: `Dictionary`
Tytuł: Słownik
Opis: Element słownika systemowego. Przechowuje hierarchiczne listy wartości do wyboru, pogrupowane w kategorie i powiązane z kontekstem oddziału firmy.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Category | `string` | bazodanowe | Nazwa słownika | Nazwa słownika, do którego należy dany element. |
| Children | `Soneta.Business.SubTable<Soneta.Business.Db.DictionaryItem>` |  |  |  |
| DataContext | `Soneta.Business.App.IOddzialFirmy` | bazodanowe, iface-ref |  | Oddział firmy będący kontekstem wyboru danych ze słownika. |
| Description | `string` | bazodanowe | Opis | Szczegółówy opis grupy. |
| IsDictionaryStructure | `bool` |  |  |  |
| Lp | `int` | bazodanowe |  | Określa kolejność występowania elementów w słowniku. |
| Parent | `Soneta.Business.Db.DictionaryItem` | bazodanowe |  | Określa nadrzędny obiekt słownikowy |
| Path | `string` |  |  |  |
| Value | `string` | bazodanowe | Wartość | Tekst będący pojedynczym elementem słownika. |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| DataContext | `IOddzialFirmy` | `OddzialFirmy` |
