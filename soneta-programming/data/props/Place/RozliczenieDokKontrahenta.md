# Pola i właściwości klasy biznesowej: `Soneta.Place.RozliczenieDokKontrahenta`
Nazwa tabeli: `RozliDokKontr`
Tytuł: Dokumenty ewidencji rozliczeń kontrahentów
Opis: Element szczegółowy dokumentu rozliczenia kontrahenta (DokumentRozliczeniaKontrahenta). Wiąże dokument rozliczenia z dokumentem ewidencji księgowej, rejestrując kwotę do zaksięgowania.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dokument` → `DokumentRozliczeniaKontrahenta`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dokument | `Soneta.Place.DokumentRozliczeniaKontrahenta` | bazodanowe, guided-parent |  |  |
| DokumentEwidencji | `Soneta.Core.DokEwidencji` | bazodanowe |  |  |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  |  |
