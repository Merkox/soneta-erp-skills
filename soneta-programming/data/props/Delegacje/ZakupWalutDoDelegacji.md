# Pola i właściwości klasy biznesowej: `Soneta.Delegacje.ZakupWalutDoDelegacji`
Nazwa tabeli: `ZakupyWalutDeleg`
Tytuł: Pozyskanie
Opis: Element szczegółowy Delegacja (Delegacja). Rejestruje operację zakupu lub pozyskania waluty obcej na potrzeby delegacji zagranicznej. Przechowuje kwotę zakupionej waluty oraz koszt jej nabycia, co umożliwia prawidłowe rozliczenie różnic kursowych w delegacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Delegacja` → `Delegacja`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Delegacja | `Soneta.Delegacje.Delegacja` | bazodanowe, guided-parent |  | Pozyskanie walut na delegację. |
| KosztZakupu | `Soneta.Types.Currency` | bazodanowe |  | Koszt zakupu waluty. |
| Lp | `int` | bazodanowe |  | Numer kolejny rekordu pozyskania walut |
| WalutaZakupiona | `Soneta.Types.Currency` | bazodanowe |  | Waluta zakupiona. |
