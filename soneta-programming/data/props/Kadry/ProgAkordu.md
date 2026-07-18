# Pola i właściwości klasy biznesowej: `Soneta.Kadry.ProgAkordu`
Nazwa tabeli: `ProgiAkordow`
Tytuł: Progi akordów
Opis: Element szczegółowy akordu (IAkord). Próg w progresywnym systemie akordowym określający wartość wynagrodzenia za jednostkę pracy po przekroczeniu danego progu wydajności.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Akord` → `IAkord`

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Akord | `Soneta.Kadry.IAkord` | bazodanowe, tylko-odczyt, guided-parent, iface-ref |  |  |
| Prog | `double` | bazodanowe |  |  |
| Wartosc | `DoubleCy` | bazodanowe |  |  |
| Zerowy | `bool` | bazodanowe, tylko-odczyt |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Akord | `IAkord` | `AkordHistoria`, `DefinicjaAkordu` |
