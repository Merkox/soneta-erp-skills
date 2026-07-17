# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kompetencje.GrupaKompetencjiUniwersalnych`
Nazwa tabeli: `ZklKtgKmpUniw`
Tytuł: Katalog kompetencji uniwersalnych
Opis: Zawiera grupy kompetencji uniwersalnych, takich jak przywództwo czy adaptacyjność. Wspiera budowę spójnych profili miękkich kompetencji.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Kompetencje | `Soneta.Business.SubTable<Soneta.HR.ZKL.Slowniki.Kompetencje.KompetencjaUniwersalna>` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` |  |  |  |
