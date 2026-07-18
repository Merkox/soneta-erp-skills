# Pola i właściwości klasy biznesowej: `Soneta.HR.DefinicjaEtapuRekrutacji`
Nazwa tabeli: `DefEtaRekrutacji`
Tytuł: Etapy rekrutacji
Opis: Słownik etapów procesu rekrutacyjnego (np. rozmowa kwalifikacyjna, test kompetencji). Definiuje nazwy kroków rekrutacji, które następnie są przypisywane do konkretnych procesów.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Zarzadzany | `bool` | bazodanowe | Zarządzany | Etap zarządzany przez proces |
