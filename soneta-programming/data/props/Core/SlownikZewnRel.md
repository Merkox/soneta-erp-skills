# Pola i właściwości klasy biznesowej: `Soneta.Core.SlownikZewnRel`
Nazwa tabeli: `SlownikiZewnRel`
Tytuł: SlownikiZewnRel
Opis: Tabela relacji łącząca słowniki zewnętrzne z elementami wewnętrznymi systemu. Tworzy powiązanie między pozycją słownika zewnętrznego a konkretnym obiektem biznesowym w programie.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Element | `Soneta.Core.IElementSlownikZewnRel` | bazodanowe, iface-ref |  | Obiekt wewnętrzny |
| SlownikZewn | `Soneta.Core.SlownikZewn` | bazodanowe |  | Słownik zewnętrzy |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Element | `IElementSlownikZewnRel` | `Towar` |
