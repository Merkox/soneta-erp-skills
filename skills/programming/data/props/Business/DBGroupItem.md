# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.DBGroupItem`
Nazwa tabeli: `DBGroupItems`
Tytuł: Pozycje grupy bazy danych
Opis: Przypisanie bazy danych klienta do grupy. Tworzy relację wiele-do-wielu między bazami danych a grupami.
Tabela konfiguracyjna: Tak

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DBGroup | `Db.DBGroup` | bazodanowe, tylko-odczyt | Grupa bazy danych | Grupa bazy danych |
| DBItem | `Db.DBItem` | bazodanowe, tylko-odczyt | Baza danych | Bazy danych |
