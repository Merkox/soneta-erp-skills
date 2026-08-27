# Pola i właściwości klasy biznesowej: `Soneta.Core.IsoNumerProcedury`
Nazwa tabeli: `IsoNumeryProc`
Tytuł: Numery procedur ISO
Opis: Element szczegółowy procedury ISO (IsoProcedura). Przechowuje numer procedury ISO przypisany do konkretnego oddziału firmy, umożliwiając różne numeracje ISO w różnych oddziałach.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Procedura` → `IsoProcedura`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Numer | `string` | bazodanowe |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| Procedura | `Soneta.Core.IsoProcedura` | bazodanowe, tylko-odczyt, guided-parent |  |  |
