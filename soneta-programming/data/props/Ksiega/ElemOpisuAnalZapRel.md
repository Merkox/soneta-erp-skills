# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.ElemOpisuAnalZapRel`
Nazwa tabeli: `OpisAnalZapRel`
Tytuł: Opis analityczny relacje
Opis: Element szczegółowy zapisu księgowego (ZapisKsiegowy). Łączy zapis księgowy z elementem opisu analitycznego poprzez określoną relację, umożliwiając przypisanie wymiarów analitycznych do konkretnych zapisów w dekrecie.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `ZapisKsiegowy` → `ZapisKsiegowy`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| OpisAnalityczny | `Soneta.Ksiega.ElemOpisuAnalitycznego` | bazodanowe |  |  |
| RelacjaOpisAnal | `Soneta.Ksiega.RelacjaOpisAnal` | bazodanowe |  |  |
| ZapisKsiegowy | `Soneta.Ksiega.ZapisKsiegowy` | bazodanowe, guided-parent | Opisy analityczne zapis relacje |  |
