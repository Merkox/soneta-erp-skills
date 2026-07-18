# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.DBGroupItem`
Nazwa tabeli: `DBGroupItems`
Tytuł: Pozycje grupy bazy danych
Opis: Przypisanie bazy danych klienta do grupy. Tworzy relację wiele-do-wielu między bazami danych a grupami.
Tabela konfiguracyjna: Tak

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DBGroup | `Db.DBGroup` | bazodanowe, tylko-odczyt | Grupa bazy danych | Grupa bazy danych |
| DBItem | `Db.DBItem` | bazodanowe, tylko-odczyt | Baza danych | Bazy danych |
