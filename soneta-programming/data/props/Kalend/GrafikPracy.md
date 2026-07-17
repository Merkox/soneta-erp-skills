# Pola i właściwości klasy biznesowej: `Soneta.Kalend.GrafikPracy`
Nazwa tabeli: `GrafikiPracy`
Tytuł: Grafiki planu pracy
Opis: Grafik planu pracy przypisany do jednostki organizacyjnej. Łączy definicję grafiku z nazwą i wydziałem, umożliwiając tworzenie harmonogramów pracy dla grup pracowników.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaGrafikaPracy` | bazodanowe |  |  |
| DniGrafika | `object` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Pracownicy | `Soneta.Business.SubTable<Soneta.Kalend.GrafikPracownika>` |  |  |  |
| Tools | `Soneta.Kalend.DefinicjaGrafikaPracy.Tools` |  |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
