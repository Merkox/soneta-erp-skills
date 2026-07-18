# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProRelacjaZasobUrzadzenie`
Nazwa tabeli: `ProRZasobUrz`
Tytuł: Relacje zasobów i urządzeń
Opis: Element szczegółowy zasobu produkcyjnego (ProZasob). Wiąże zasób produkcyjny z fizycznymi urządzeniami z modułu środków trwałych, umożliwiając śledzenie powiązań między zasobami planistycznymi a rzeczywistym wyposażeniem zakładu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zasob` → `ProZasob`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Lp | `int` | bazodanowe |  | Liczba porządkowa dla relacji zasób urządzenie. |
| Urzadzenie | `Soneta.Zadania.Urzadzenie` | bazodanowe | Urządzenie | Urządzenie dla relacji zasób urządzenie. |
| Zasob | `Soneta.ProdukcjaPro.ProZasob` | bazodanowe, guided-parent | Zasób | Zasób dla relacji zasób urządzenie. |
