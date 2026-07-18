# Pola i właściwości klasy biznesowej: `Soneta.Towary.KodBDO`
Nazwa tabeli: `KodyBDO`
Opis: Słownik kodów klasyfikacji odpadów zgodnych z rejestrem BDO (Baza danych o produktach i opakowaniach oraz o gospodarce odpadami). Przechowuje hierarchiczne kody odpadów z opisem, identyfikatorem w systemie BDO oraz oznaczeniem, czy odpad jest niebezpieczny.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 2
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ID_BDO | `string` | bazodanowe |  | ID w systemie BDO |
| Kod | `string` | bazodanowe |  |  |
| MaPodrzedne | `bool` | tylko-odczyt |  |  |
| Nadrzedny | `Soneta.Towary.KodBDO` | tylko-odczyt |  |  |
| Niebezpieczny | `bool` | bazodanowe |  | Określa czy odpad jest niebezpieczny |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| Podrzedne | `System.Collections.Generic.IEnumerable<Soneta.Towary.KodBDO>` | podlista |  |  |
