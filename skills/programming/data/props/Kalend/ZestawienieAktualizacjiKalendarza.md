# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ZestawienieAktualizacjiKalendarza`
Nazwa tabeli: `ZestAktKalend`
Tytuł: Zestawienia dokumentów aktualizacji kalendarzy
Opis: Element szczegółowy definicji aktualizacji kalendarza (DefinicjaAktualizacjiKalendarza). Powiązanie definicji dokumentu aktualizacji z definicją zestawienia czasu pracy, określające jakie zestawienia są generowane dla danego typu dokumentu.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DefinicjaDokumentu` → `DefinicjaAktualizacjiKalendarza`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaDokumentu | `Soneta.Kalend.DefinicjaAktualizacjiKalendarza` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| DefinicjaZestawienia | `Soneta.Kalend.DefinicjaZestawieniaCzasu` | bazodanowe |  |  |
