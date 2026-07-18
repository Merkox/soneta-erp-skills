# Pola i właściwości klasy biznesowej: `Soneta.Place.PodstawaNieobecnosciOkresowa`
Nazwa tabeli: `PodstawyNieobOkr`
Opis: Element szczegółowy pracownika (Pracownik). Przechowuje podstawy naliczania nieobecności dla składników okresowych (np. premii kwartalnych), z podziałem na okresy rozliczeniowe.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 1
- podlisty: 1
- subrowy: 0
- razem: 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaElementu | `Soneta.Place.DefinicjaElementu` | bazodanowe |  | Definicja elementu |
| Kwota | `decimal` | bazodanowe | Kwota okresowych |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Podstawa | `decimal` | bazodanowe |  | Podstawa okresowych |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| ProcentSkladki | `Percent` | bazodanowe | Procent składki | Procent składki potrąconej |
| WyplacanaDo | `YearMonth` |  |  |  |
| WyplacanaOd | `YearMonth` |  |  |  |
