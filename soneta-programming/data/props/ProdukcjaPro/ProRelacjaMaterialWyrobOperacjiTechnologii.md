# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProRelacjaMaterialWyrobOperacjiTechnologii`
Nazwa tabeli: `ProRMatWyrOT`
Tytuł: Relacje materiałów i wyrobów operacji techologii
Opis: Element szczegółowy materiału operacji technologii (ProMaterialOperacjiTechnologii). Definiuje powiązanie między materiałem a wyrobem w ramach operacji technologicznej, określając przepływ surowca do konkretnego produktu wyjściowego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Material` → `ProMaterialOperacjiTechnologii`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Lp | `int` | bazodanowe |  | Liczba porządkowa dla relacji materiał wyrób operacji techologii. |
| Material | `Soneta.ProdukcjaPro.ProMaterialOperacjiTechnologii` | bazodanowe, guided-parent | Materiał | Materiał dla relacji materiał wyrób operacji techologii. |
| Wyrob | `Soneta.ProdukcjaPro.ProWyrobOperacjiTechnologii` | bazodanowe | Wyrób | Wyrób dla relacji materiał wyrób operacji techologii. |
