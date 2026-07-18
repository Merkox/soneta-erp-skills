# Pola i właściwości klasy biznesowej: `Soneta.Towary.TowarUlubiony`
Nazwa tabeli: `TowaryUlubione`
Tytuł: Ulubione towary
Opis: Element szczegółowy obiektu nadrzędnego, np. kontrahenta lub osoby kontaktowej (ITowaryUlubioneHost). Przypisuje wybrany towar jako ulubiony do danego podmiotu, co przyspiesza wyszukiwanie najczęściej używanego asortymentu podczas wystawiania dokumentów handlowych.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zapis` → `ITowaryUlubioneHost`

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Towar | `Soneta.Towary.Towar` | bazodanowe | Ulubiony towar | Ulubiony towar skojarzony z danym zapisem. |
| Zapis | `Soneta.Core.ITowaryUlubioneHost` | bazodanowe, tylko-odczyt, guided-parent, iface-ref |  | Zapis, do którego przypisany jest dany towar |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Zapis | `ITowaryUlubioneHost` | `KontaktOsoba`, `Kontrahent` |
