# Pola i właściwości klasy biznesowej: `Soneta.Delegacje.ZakupWalutDoDelegacji`
Nazwa tabeli: `ZakupyWalutDeleg`
Tytuł: Pozyskanie
Opis: Element szczegółowy Delegacja (Delegacja). Rejestruje operację zakupu lub pozyskania waluty obcej na potrzeby delegacji zagranicznej. Przechowuje kwotę zakupionej waluty oraz koszt jej nabycia, co umożliwia prawidłowe rozliczenie różnic kursowych w delegacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Delegacja` → `Delegacja`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Delegacja | `Soneta.Delegacje.Delegacja` | bazodanowe, tylko-odczyt, guided-parent |  | Pozyskanie walut na delegację. |
| KosztZakupu | `Currency` | bazodanowe |  | Koszt zakupu waluty. |
| Lp | `int` | bazodanowe |  | Numer kolejny rekordu pozyskania walut |
| WalutaZakupiona | `Currency` | bazodanowe |  | Waluta zakupiona. |
