# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.KategoriaZapotrzebowania`
Nazwa tabeli: `KategorieZap`
Tytuł: Kategorie zapotrzebowania
Opis: Słownik kategorii zapotrzebowania na środki trwałe. Umożliwia klasyfikację zgłoszeń zapotrzebowania według roli systemowej oraz symbolu. Służy do planowania zakupów i zarządzania procesem pozyskiwania majątku trwałego.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Środek zablokowany |
| Kod | `string` |  |  |  |
| Nazwa | `string` | bazodanowe |  | Nazwa kategorii zapotrzebowania |
| Opis | `string` | bazodanowe |  | Opis kategorii zapotrzebowania |
| RolaSystemowa | `Soneta.Business.Db.SystemRole` | bazodanowe |  | Rola systemowa |
| Symbol | `string` | bazodanowe |  | Symbol kategorii zapotrzebowania |
