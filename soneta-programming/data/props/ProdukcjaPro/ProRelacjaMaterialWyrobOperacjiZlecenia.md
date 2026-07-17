# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProRelacjaMaterialWyrobOperacjiZlecenia`
Nazwa tabeli: `ProRMatWyrOZ`
Tytuł: Relacje materiałów i wyrobów operacji zlecenia
Opis: Element szczegółowy materiału operacji zlecenia (ProMaterialOperacjiZlecenia). Definiuje powiązanie między materiałem a wyrobem w ramach operacji zlecenia, określając typ relacji, ilość oraz przepływ surowca do konkretnego produktu wyjściowego.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Material` → `ProMaterialOperacjiZlecenia`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Ilosc | `Soneta.Types.Amount` | bazodanowe | Ilość | Ilość relacji materiał wyrób operacji zlecenia. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa dla relacji materiał wyrób operacji zlecenia. |
| Material | `Soneta.ProdukcjaPro.ProMaterialOperacjiZlecenia` | bazodanowe, guided-parent | Materiał | Materiał dla relacji materiał wyrób operacji zlecenia. |
| Typ | `Soneta.ProdukcjaPro.ProTypRelacjiMaterialWyrob` | bazodanowe, enum |  | Typ relacji materiał wyrób operacji technologii. |
| Wyrob | `Soneta.ProdukcjaPro.ProWyrobOperacjiZlecenia` | bazodanowe | Wyrób | Wyrób dla relacji materiał wyrób operacji zlecenia. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProTypRelacjiMaterialWyrob (`Soneta.ProdukcjaPro.ProTypRelacjiMaterialWyrob`)
- `None` = 0
- `Polprodukt` = 1 — Półprodukt
- `Prefabrykat` = 2
- `All` = 3 — Wszystkie
