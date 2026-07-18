# Pola i właściwości klasy biznesowej: `Soneta.Place.RozliczenieDokKontrahenta`
Nazwa tabeli: `RozliDokKontr`
Tytuł: Dokumenty ewidencji rozliczeń kontrahentów
Opis: Element szczegółowy dokumentu rozliczenia kontrahenta (DokumentRozliczeniaKontrahenta). Wiąże dokument rozliczenia z dokumentem ewidencji księgowej, rejestrując kwotę do zaksięgowania.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dokument` → `DokumentRozliczeniaKontrahenta`

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dokument | `Soneta.Place.DokumentRozliczeniaKontrahenta` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| DokumentEwidencji | `Soneta.Core.DokEwidencji` | bazodanowe |  |  |
| Kwota | `Currency` | bazodanowe |  |  |
