# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.ElemSlownika`
Nazwa tabeli: `ElemSlownikow`
Tytuł: Elementy słowników
Opis: Konkretna pozycja (wpis) w słowniku analitycznym. Przechowuje symbol i nazwę elementu słownika, np. kontrahenta, centrum kosztów czy projektu. Elementy słownika służą do tworzenia kont analitycznych oraz klasyfikacji zapisów księgowych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IElementSlownika`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Ksiega.DefinicjaSlownika` | bazodanowe, tylko-odczyt |  | Definicja słownika |
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  | Oddział firmy |
| PowiazaniaKontElementu | `SubTable<Soneta.Ksiega.PowiazanieKontaBase>` | podlista |  |  |
| Symbol | `string` | bazodanowe |  |  |
| Wielooddzialowosc | `bool` | tylko-odczyt |  |  |
| Zablokowany | `bool` | bazodanowe |  |  |
