# Pola i właściwości klasy biznesowej: `Soneta.Towary.KodBDO`
Nazwa tabeli: `KodyBDO`
Opis: Słownik kodów klasyfikacji odpadów zgodnych z rejestrem BDO (Baza danych o produktach i opakowaniach oraz o gospodarce odpadami). Przechowuje hierarchiczne kody odpadów z opisem, identyfikatorem w systemie BDO oraz oznaczeniem, czy odpad jest niebezpieczny.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ID_BDO | `string` | bazodanowe |  | ID w systemie BDO |
| Kod | `string` | bazodanowe |  |  |
| MaPodrzedne | `bool` |  |  |  |
| Nadrzedny | `Soneta.Towary.KodBDO` |  |  |  |
| Niebezpieczny | `bool` | bazodanowe |  | Określa czy odpad jest niebezpieczny |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Podrzedne | `System.Collections.Generic.IEnumerable<Soneta.Towary.KodBDO>` |  |  |  |
