# Pola i właściwości klasy biznesowej: `Soneta.Core.DokumentPowiazanyDokEwid`
Nazwa tabeli: `DokumentyPowiazaneDokEwid`
Tytuł: Dokumenty powiązane DokEwid
Opis: Tabela przechowuje powiązania między dokumentami ewidencji a innymi dokumentami w systemie. Umożliwia tworzenie relacji łączących dokument ewidencji z dowolnym dokumentem implementującym interfejs powiązania. Służy do śledzenia zależności i powiązań między dokumentami księgowymi i handlowymi.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dokument | `Soneta.Core.IDokumentPowiazanyDokEwid` | bazodanowe | Dokument |  |
| DokumentEwid | `Soneta.Core.DokEwidencji` | bazodanowe, tylko-odczyt |  |  |
