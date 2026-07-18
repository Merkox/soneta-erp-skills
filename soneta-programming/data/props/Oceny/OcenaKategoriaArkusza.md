# Pola i właściwości klasy biznesowej: `Soneta.Oceny.OcenaKategoriaArkusza`
Nazwa tabeli: `OcenyKatArkuszy`
Tytuł: Kategorie arkusza oceny
Opis: Element szczegółowy arkusza oceny (OcenaKategoriaArkusza). Przechowuje zagregowaną wartość oceny dla danej kategorii kryteriów (np. kompetencje miękkie), umożliwiając raportowanie wyników w podziale na grupy tematyczne.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Arkusz` → `OcenaArkusz`

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Arkusz | `Soneta.Oceny.OcenaArkusz` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Kategoria | `Soneta.Oceny.KategoriaElementuOceny` | bazodanowe, tylko-odczyt |  |  |
| Wartosc | `Percent` | bazodanowe, tylko-odczyt |  |  |
| WartoscWgWagi | `Percent` | bazodanowe, tylko-odczyt |  |  |
