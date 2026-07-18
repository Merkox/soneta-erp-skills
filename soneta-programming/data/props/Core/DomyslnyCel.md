# Pola i właściwości klasy biznesowej: `Soneta.Core.DomyslnyCel`
Nazwa tabeli: `DomyslneCele`
Tytuł: Domyślne cele rodzajów kontaktu
Opis: Konfiguracja domyślnych celów dla rodzajów kontaktu. Określa, jaki cel ze słownika jest automatycznie przypisywany przy tworzeniu danych kontaktowych danego rodzaju i typu hosta.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Cel | `Soneta.Core.SlownikElem` | bazodanowe | Cel kontaktu |  |
| HostType | `string` | bazodanowe | Rodzaj hosta kontaktu |  |
| HostTypeName | `string` |  |  |  |
| Rodzaj | `Soneta.Core.RodzajKontaktu` | bazodanowe | Rodzaj kontaktu |  |
