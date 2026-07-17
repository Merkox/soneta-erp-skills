# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kwalifikacje.SystemITJezykProgramowania`
Nazwa tabeli: `ZklSystITProg`
Tytuł: Systemy IT i języki programowania
Opis: Definiuje technologie, systemy i języki programowania stosowane w organizacji. W profilu kwalifikacji umożliwia precyzyjne określenie wymagań technicznych.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` |  |  |  |
