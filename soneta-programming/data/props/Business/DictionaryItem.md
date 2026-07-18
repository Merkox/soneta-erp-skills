# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.DictionaryItem`
Nazwa tabeli: `Dictionary`
Tytuł: Słownik
Opis: Element słownika systemowego. Przechowuje hierarchiczne listy wartości do wyboru, pogrupowane w kategorie i powiązane z kontekstem oddziału firmy.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 2
- podlisty: 1
- subrowy: 0
- razem: 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Category | `string` | bazodanowe, tylko-odczyt | Nazwa słownika | Nazwa słownika, do którego należy dany element. |
| Children | `SubTable<Db.DictionaryItem>` | podlista |  |  |
| DataContext | `App.IOddzialFirmy` | bazodanowe, iface-ref |  | Oddział firmy będący kontekstem wyboru danych ze słownika. |
| Description | `string` | bazodanowe | Opis | Szczegółówy opis grupy. |
| IsDictionaryStructure | `bool` | tylko-odczyt |  |  |
| Lp | `int` | bazodanowe |  | Określa kolejność występowania elementów w słowniku. |
| Parent | `Db.DictionaryItem` | bazodanowe |  | Określa nadrzędny obiekt słownikowy |
| Path | `string` |  |  |  |
| Value | `string` | bazodanowe | Wartość | Tekst będący pojedynczym elementem słownika. |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| DataContext | `IOddzialFirmy` | `OddzialFirmy` |
