# Pola i właściwości klasy biznesowej: `Soneta.Kadry.ZestawDodatków`
Nazwa tabeli: `ZestawyDodatkow`
Tytuł: Zestawy dodatków
Opis: Słownik zestawów dodatków do wynagrodzenia umożliwiający grupowe przypisywanie wielu elementów płacowych pracownikom. Każdy zestaw posiada nazwę i może zawierać wiele elementów zestawu.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| ElementyZestawu | `SubTable<Soneta.Kadry.ElementZestawuDodatków>` | podlista |  |  |
| Nazwa | `string` | bazodanowe |  |  |
