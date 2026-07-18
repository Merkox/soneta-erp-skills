# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProTechnologiaMaterialuOperacjiTechnologii`
Nazwa tabeli: `ProTechMatOT`
Tytuł: Technologie materiałów operacji technologii
Opis: Element szczegółowy materiału operacji technologii (ProMaterialOperacjiTechnologii). Wiąże materiał z technologią jego wytworzenia, umożliwiając kaskadowe generowanie zleceń produkcyjnych na półprodukty wymagane w danej operacji.
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
| Lp | `int` | bazodanowe |  | Liczba porządkowa dla technologii materiału operacji technologii. |
| Material | `Soneta.ProdukcjaPro.ProMaterialOperacjiTechnologii` | bazodanowe, guided-parent | Materiał | Materiał dla technologii materiału operacji technologii. |
| Technologia | `Soneta.ProdukcjaPro.ProTechnologia` | bazodanowe |  | Technologia dla technologii materiału operacji technologii. |
