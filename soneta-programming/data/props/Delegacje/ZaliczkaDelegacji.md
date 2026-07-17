# Pola i właściwości klasy biznesowej: `Soneta.Delegacje.ZaliczkaDelegacji`
Nazwa tabeli: `ZaliczkiDeleg`
Tytuł: Zaliczki do delegacji
Opis: Element szczegółowy Delegacja (Delegacja). Rejestruje zaliczkę wypłaconą pracownikowi przed wyjazdem służbowym lub w jego trakcie. Zawiera kwotę zaliczki oraz powiązanie z dokumentem kasowym wypłaty, co pozwala na końcowe rozliczenie delegacji z uwzględnieniem już przekazanych środków.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Delegacja` → `Delegacja`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Delegacja | `Soneta.Delegacje.Delegacja` | bazodanowe, guided-parent |  | Zaliczki wypłacone do delegacji. |
| DokWyplaty | `Soneta.Kasa.Zaplata` | bazodanowe |  | Dokument zaliczki |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  | Kwota zaliczki |
| Lp | `int` | bazodanowe |  | Numer kolejny rozliczenia |
