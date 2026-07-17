# Pola i właściwości klasy biznesowej: `Soneta.Place.PodstawaNieobecnosciOkresowa`
Nazwa tabeli: `PodstawyNieobOkr`
Opis: Element szczegółowy pracownika (Pracownik). Przechowuje podstawy naliczania nieobecności dla składników okresowych (np. premii kwartalnych), z podziałem na okresy rozliczeniowe.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaElementu | `Soneta.Place.DefinicjaElementu` | bazodanowe |  | Definicja elementu |
| Kwota | `decimal` | bazodanowe | Kwota okresowych |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Podstawa | `decimal` | bazodanowe |  | Podstawa okresowych |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, guided-parent |  |  |
| ProcentSkladki | `Soneta.Types.Percent` | bazodanowe | Procent składki | Procent składki potrąconej |
| WyplacanaDo | `Soneta.Types.YearMonth` |  |  |  |
| WyplacanaOd | `Soneta.Types.YearMonth` |  |  |  |
