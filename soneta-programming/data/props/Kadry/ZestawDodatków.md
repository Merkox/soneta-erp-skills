# Pola i właściwości klasy biznesowej: `Soneta.Kadry.ZestawDodatków`
Nazwa tabeli: `ZestawyDodatkow`
Tytuł: Zestawy dodatków
Opis: Słownik zestawów dodatków do wynagrodzenia umożliwiający grupowe przypisywanie wielu elementów płacowych pracownikom. Każdy zestaw posiada nazwę i może zawierać wiele elementów zestawu.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| ElementyZestawu | `Soneta.Business.SubTable<Soneta.Kadry.ElementZestawuDodatków>` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
