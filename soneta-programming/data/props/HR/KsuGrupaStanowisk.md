# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.KSU.KsuGrupaStanowisk`
Nazwa tabeli: `ZklKsuGrStan`
Tytuł: Powiązania informacji KSU z grupami stanowisk
Opis: Tabela definiuje grupy stanowisk w ramach słownika  Katalogu Szkoleń i Uprawnień. Wykorzystywane do tworzenia słownika i profilu szkoleń.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaInfo | `Soneta.HR.ZKL.Slowniki.KSU.KsuDefinicjaInfo` | bazodanowe, tylko-odczyt | Definicja informacji KSU |  |
| GrupaStanowisk | `Soneta.HR.GrupaStanowisk` | bazodanowe | Grupa stanowisk |  |
