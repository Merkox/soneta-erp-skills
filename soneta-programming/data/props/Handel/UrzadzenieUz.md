# Pola i właściwości klasy biznesowej: `Soneta.Handel.UrzadzenieUz`
Nazwa tabeli: `UrzadzeniaUz`
Tytuł: Urządzenia użytkowane
Opis: Konkretne urządzenie użytkowane powiązane z definicją (DefUrzadzeniaUz). Identyfikowane unikalnym identyfikatorem, przypisywane do pozycji dokumentów handlowych (np. umów serwisowych).
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Handel.DefUrzadzeniaUz` | bazodanowe |  | Definicja urządzenia. |
| ElemyRozliczenia | `Soneta.Business.ListWithView` |  |  |  |
| Identyfikator | `string` | bazodanowe |  | Identyfikator urządzenia. |
| Nazwa | `string` | bazodanowe |  | Nazwa urządzenia. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis urządzenia. |
| OstatniDokumentRozliczający | `Soneta.Handel.DokumentHandlowy` |  |  |  |
| OstatniaPozycjaDokumentuRozliczającego | `Soneta.Handel.PozycjaDokHandlowego` |  |  |  |
| OstatniaPozycjaUmowy | `Soneta.Handel.PozycjaDokHandlowego` |  |  |  |
| OstatniaUmowa | `Soneta.Handel.DokumentHandlowy` |  |  |  |
| Pozycje | `Soneta.Business.SubTable<Soneta.Handel.PozycjaDokHandlowego>` |  |  |  |
