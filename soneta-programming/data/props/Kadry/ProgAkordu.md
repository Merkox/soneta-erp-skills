# Pola i właściwości klasy biznesowej: `Soneta.Kadry.ProgAkordu`
Nazwa tabeli: `ProgiAkordow`
Tytuł: Progi akordów
Opis: Element szczegółowy akordu (IAkord). Próg w progresywnym systemie akordowym określający wartość wynagrodzenia za jednostkę pracy po przekroczeniu danego progu wydajności.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Akord` → `IAkord`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Akord | `Soneta.Kadry.IAkord` | bazodanowe, guided-parent, iface-ref |  |  |
| Prog | `double` | bazodanowe |  |  |
| Wartosc | `Soneta.Types.DoubleCy` | bazodanowe |  |  |
| Zerowy | `bool` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Akord | `IAkord` | `AkordHistoria`, `DefinicjaAkordu` |
