# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProTechnologiaMaterialuOperacjiZlecenia`
Nazwa tabeli: `ProTechMatOZ`
Tytuł: Technologie materiałów operacji zleceń
Opis: Element szczegółowy materiału operacji zlecenia (ProMaterialOperacjiZlecenia). Wiąże materiał zlecenia z technologią jego wytworzenia, umożliwiając kaskadowe generowanie zleceń produkcyjnych na półprodukty wymagane w danej operacji zlecenia.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Material` → `ProMaterialOperacjiZlecenia`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Lp | `int` | bazodanowe |  | Liczba porządkowa dla technologii materiału operacji zlecenia. |
| Material | `Soneta.ProdukcjaPro.ProMaterialOperacjiZlecenia` | bazodanowe, guided-parent | Materiał | Materiał dla technologii materiału operacji zlecenia. |
| Technologia | `Soneta.ProdukcjaPro.ProTechnologia` | bazodanowe |  | Technologia dla technologii materiału operacji zlecenia. |
