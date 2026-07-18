# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.KategoriaZapotrzebowania`
Nazwa tabeli: `KategorieZap`
Tytuł: Kategorie zapotrzebowania
Opis: Słownik kategorii zapotrzebowania na środki trwałe. Umożliwia klasyfikację zgłoszeń zapotrzebowania według roli systemowej oraz symbolu. Służy do planowania zakupów i zarządzania procesem pozyskiwania majątku trwałego.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Środek zablokowany |
| Kod | `string` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  | Nazwa kategorii zapotrzebowania |
| Opis | `string` | bazodanowe |  | Opis kategorii zapotrzebowania |
| RolaSystemowa | `Db.SystemRole` | bazodanowe |  | Rola systemowa |
| Symbol | `string` | bazodanowe |  | Symbol kategorii zapotrzebowania |
