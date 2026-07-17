# Pola i właściwości klasy biznesowej: `Soneta.Oceny.OcenaKategoriaArkusza`
Nazwa tabeli: `OcenyKatArkuszy`
Tytuł: Kategorie arkusza oceny
Opis: Element szczegółowy arkusza oceny (OcenaKategoriaArkusza). Przechowuje zagregowaną wartość oceny dla danej kategorii kryteriów (np. kompetencje miękkie), umożliwiając raportowanie wyników w podziale na grupy tematyczne.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Arkusz` → `OcenaArkusz`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Arkusz | `Soneta.Oceny.OcenaArkusz` | bazodanowe, guided-parent |  |  |
| Kategoria | `Soneta.Oceny.KategoriaElementuOceny` | bazodanowe |  |  |
| Wartosc | `Soneta.Types.Percent` | bazodanowe |  |  |
| WartoscWgWagi | `Soneta.Types.Percent` | bazodanowe |  |  |
