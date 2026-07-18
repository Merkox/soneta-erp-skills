# Pola i właściwości klasy biznesowej: `Soneta.Core.DomyslnyCel`
Nazwa tabeli: `DomyslneCele`
Tytuł: Domyślne cele rodzajów kontaktu
Opis: Konfiguracja domyślnych celów dla rodzajów kontaktu. Określa, jaki cel ze słownika jest automatycznie przypisywany przy tworzeniu danych kontaktowych danego rodzaju i typu hosta.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Cel | `Soneta.Core.SlownikElem` | bazodanowe | Cel kontaktu |  |
| HostType | `string` | bazodanowe | Rodzaj hosta kontaktu |  |
| HostTypeName | `string` |  |  |  |
| Rodzaj | `Soneta.Core.RodzajKontaktu` | bazodanowe | Rodzaj kontaktu |  |
