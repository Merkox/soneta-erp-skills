# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.ZestawST`
Nazwa tabeli: `ZestawyST`
Tytuł: Zestawy środków trwałych
Opis: Grupowanie środków trwałych w nazwane zestawy do celów ewidencyjnych i raportowych. Umożliwia łączenie powiązanych składników majątku (np. linia produkcyjna złożona z wielu maszyn) w logiczną całość na potrzeby zarządzania i amortyzacji.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kod | `string` |  |  |  |
| Nazwa | `string` | bazodanowe |  | Nazwa zestawu środków trwałych |
| Opis | `string` | bazodanowe |  | Opis zestawu środków trwałych |
| SrodkiTrwaleHistoria | `Soneta.Business.SubTable<Soneta.SrodkiTrwale.SrodekTrwalyBaseHistoria>` |  |  |  |
