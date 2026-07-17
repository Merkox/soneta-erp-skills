# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.ElemSlownika`
Nazwa tabeli: `ElemSlownikow`
Tytuł: Elementy słowników
Opis: Konkretna pozycja (wpis) w słowniku analitycznym. Przechowuje symbol i nazwę elementu słownika, np. kontrahenta, centrum kosztów czy projektu. Elementy słownika służą do tworzenia kont analitycznych oraz klasyfikacji zapisów księgowych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IElementSlownika`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Ksiega.DefinicjaSlownika` | bazodanowe |  | Definicja słownika |
| ElementyPodzielnika | `Soneta.Business.SubTable<Soneta.Core.ElementPodzielnika>` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  | Oddział firmy |
| PowiazaniaKontElementu | `Soneta.Business.SubTable<Soneta.Ksiega.PowiazanieKontaBase>` |  |  |  |
| Symbol | `string` | bazodanowe |  |  |
| Wielooddzialowosc | `bool` |  |  |  |
| Zablokowany | `bool` | bazodanowe |  |  |
