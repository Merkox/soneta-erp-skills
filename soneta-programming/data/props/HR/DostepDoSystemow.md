# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.OpisStanowiska.ZasobyINarzedzia.DostepDoSystemow`
Nazwa tabeli: `ZklDostSys`
Tytuł: Dostępy do systemów
Opis: Słownik definiuje systemy informatyczne wymagane do realizacji obowiązków służbowych. W opisie ogólnym stanowiska wspiera kontrolę bezpieczeństwa informacji i przygotowanie środowiska pracy.
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
