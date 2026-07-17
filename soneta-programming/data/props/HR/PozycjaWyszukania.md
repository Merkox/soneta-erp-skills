# Pola i właściwości klasy biznesowej: `Soneta.HR.PozycjaWyszukania`
Nazwa tabeli: `PozycjeWyszukan`
Tytuł: Kryteria
Opis: Element szczegółowy wyszukania (Wyszukanie). Definiuje pojedyncze kryterium wyszukiwania z zakresem wartości (min/max), wagą i flagą wymagalności, służące do filtrowania kandydatów.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Wyszukanie` → `Wyszukanie`

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.HR.DefElementuOcenyPracownika` | bazodanowe |  |  |
| ElementMax | `Soneta.HR.WartośćElementuOcenyPracownika` |  |  |  |
| ElementMin | `Soneta.HR.WartośćElementuOcenyPracownika` |  |  |  |
| Lp | `int` | bazodanowe |  |  |
| Max | `decimal` | bazodanowe |  |  |
| Min | `decimal` | bazodanowe |  |  |
| Waga | `decimal` | bazodanowe |  |  |
| Wymagany | `bool` | bazodanowe |  |  |
| Wyszukanie | `Soneta.HR.Wyszukanie` | bazodanowe, guided-parent |  |  |
| ZMax | `bool` |  |  |  |
| ZMin | `bool` |  |  |  |
