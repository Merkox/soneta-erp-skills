# Pola i właściwości klasy biznesowej: `Soneta.Towary.Przelicznik`
Nazwa tabeli: `Przeliczniki`
Opis: Element szczegółowy jednostki miary (Jednostka). Definiuje przelicznik między dwiema jednostkami tego samego typu, określając jednostkę wyliczaną, bazową i współczynnik konwersji, co umożliwia automatyczne przeliczanie ilości towarów.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Wyliczana` → `Jednostka`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bazowa | `Soneta.Towary.Jednostka` | bazodanowe |  | Jednostka bazowa, z której wyliczana jest jednostka 'Wyliczana'. |
| Kod | `string` |  |  |  |
| Wspolczynnik | `Soneta.Types.Fraction` | bazodanowe | Współczynnik | Współczynnik wyliczania jednostki wyliczanej: Wyliczna=Bazowa*Wspolczynnik. |
| Wyliczana | `Soneta.Towary.Jednostka` | bazodanowe, guided-parent |  | Jednostka wyliczana z jednostki bazowej. |
| Wzór | `string` |  |  | Wzór pokazujący sposób przeliczania jednostek. |
