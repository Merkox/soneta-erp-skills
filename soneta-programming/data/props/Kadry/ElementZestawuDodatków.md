# Pola i właściwości klasy biznesowej: `Soneta.Kadry.ElementZestawuDodatków`
Nazwa tabeli: `ElementyZestDod`
Tytuł: Elementy zestawów
Opis: Element szczegółowy zestawu dodatków (ZestawDodatków). Pojedynczy element płacowy wchodzący w skład zestawu dodatków, powiązany z definicją elementu wynagrodzenia.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Zestaw` → `ZestawDodatków`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Zestaw | `Soneta.Kadry.ZestawDodatków` | bazodanowe, tylko-odczyt, guided-parent |  |  |
