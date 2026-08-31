# Pola i właściwości klasy biznesowej: `Soneta.Handel.UrzadzenieUz`
Nazwa tabeli: `UrzadzeniaUz`
Tytuł: Urządzenia użytkowane
Opis: Konkretne urządzenie użytkowane powiązane z definicją (DefUrzadzeniaUz). Identyfikowane unikalnym identyfikatorem, przypisywane do pozycji dokumentów handlowych (np. umów serwisowych).
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Handel.DefUrzadzeniaUz` | bazodanowe |  | Definicja urządzenia. |
| ElemyRozliczenia | `ListWithView` | podlista |  |  |
| Identyfikator | `string` | bazodanowe |  | Identyfikator urządzenia. |
| Nazwa | `string` | bazodanowe |  | Nazwa urządzenia. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis urządzenia. |
| OstatniDokumentRozliczający | `Soneta.Handel.DokumentHandlowy` | tylko-odczyt |  |  |
| OstatniaPozycjaDokumentuRozliczającego | `Soneta.Handel.PozycjaDokHandlowego` | tylko-odczyt |  |  |
| OstatniaPozycjaUmowy | `Soneta.Handel.PozycjaDokHandlowego` | tylko-odczyt |  |  |
| OstatniaUmowa | `Soneta.Handel.DokumentHandlowy` | tylko-odczyt |  |  |
| Pozycje | `SubTable<Soneta.Handel.PozycjaDokHandlowego>` | podlista |  |  |
