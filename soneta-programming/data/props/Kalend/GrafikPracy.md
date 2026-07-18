# Pola i właściwości klasy biznesowej: `Soneta.Kalend.GrafikPracy`
Nazwa tabeli: `GrafikiPracy`
Tytuł: Grafiki planu pracy
Opis: Grafik planu pracy przypisany do jednostki organizacyjnej. Łączy definicję grafiku z nazwą i wydziałem, umożliwiając tworzenie harmonogramów pracy dla grup pracowników.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaGrafikaPracy` | bazodanowe |  |  |
| DniGrafika | `object` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Pracownicy | `SubTable<Soneta.Kalend.GrafikPracownika>` | podlista |  |  |
| Tools | `Soneta.Kalend.DefinicjaGrafikaPracy.Tools` | tylko-odczyt |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe, tylko-odczyt | Jednostka organizacyjna |  |
