# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kwalifikacje.PoziomUmiejetnosci`
Nazwa tabeli: `ZklPozUmiejet`
Tytuł: Poziomy umiejętności
Opis: Słownik określa stopnie opanowania umiejętności, niezależnie od ich rodzaju. W profilu kwalifikacji daje możliwość na jednolite określenie poziomu wymagań stanowiska.
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
