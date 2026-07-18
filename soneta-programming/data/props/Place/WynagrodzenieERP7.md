# Pola i właściwości klasy biznesowej: `Soneta.Kalend.WynagrodzenieERP7`
Nazwa tabeli: `WynagrodzeERP7`
Opis: Bilans otwarcia danych o wynagrodzeniach z systemu ERP7 (RP-7). Przechowuje skumulowane kwoty wynagrodzeń pracownika w podziale na kategorie składkowe, służące do prawidłowego wyliczenia świadczeń.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 10
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| KwotyInne | `decimal` | bazodanowe |  |  |
| KwotyNieoskladkowane | `decimal` | bazodanowe |  |  |
| KwotyStaleZmienne | `decimal` | bazodanowe |  |  |
| KwotySwiadczeniaKol3 | `decimal` | bazodanowe |  |  |
| KwotySwiadczeniaKol4 | `decimal` | bazodanowe |  |  |
| KwotyWypadkowego | `decimal` | bazodanowe |  |  |
| LacznaKwota | `decimal` | bazodanowe |  |  |
| MiesiacPrzekroczenia | `Soneta.Tools.EnumItem<Soneta.Place.DefinicjeMiesiecy>` |  |  |  |
| MiesiacPrzekroczeniaZUS | `int` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| RodzajInne | `string` | bazodanowe |  |  |
| Rok | `int` | bazodanowe |  |  |
