# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ObiektAktualizacjiKalendarza`
Nazwa tabeli: `ObAktKalend`
Tytuł: Powiązania obiektu oraz dokumentu aktualizacji kalendarza
Opis: Powiązanie obiektu do planowania z dokumentem aktualizacji kalendarza. Przypisuje obiekt (np. maszynę, stanowisko) do dokumentu aktualizacji, umożliwiając planowanie czasu pracy z uwzględnieniem zasobów.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dokument | `Soneta.Kalend.DokumentAktualizacjiKalendarza` | bazodanowe |  |  |
| Obiekt | `Soneta.Kalend.ObiektDoPlanowania` | bazodanowe |  |  |
