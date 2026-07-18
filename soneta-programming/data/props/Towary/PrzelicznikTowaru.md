# Pola i właściwości klasy biznesowej: `Soneta.Towary.PrzelicznikTowaru`
Nazwa tabeli: `PrzelTow`
Opis: Element szczegółowy towaru (Towar). Definiuje indywidualny przelicznik jednostek miary dla konkretnego towaru, nadpisujący globalne przeliczniki. Pozwala ustalić współczynnik konwersji między jednostką wyliczaną a bazową specyficzny dla danego asortymentu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Towar` → `Towar`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bazowa | `Soneta.Towary.Jednostka` | bazodanowe |  | Jednostka bazowa, z której wyliczana jest jednostka 'Wyliczana'. |
| Towar | `Soneta.Towary.Towar` | bazodanowe, tylko-odczyt, guided-parent |  | Towar, dla którego zdefiniowany jest przelicznik |
| Wspolczynnik | `Fraction` | bazodanowe | Współczynnik | Współczynnik wyliczania jednostki wyliczanej: Wyliczna=Bazowa*Wspolczynnik. |
| Wyliczana | `Soneta.Towary.Jednostka` | bazodanowe |  | Jednostka wyliczana z jednostki bazowej. |
| Wzór | `string` | tylko-odczyt |  | Wzór pokazujący sposób przeliczania jednostek. |
