# Pola i właściwości klasy biznesowej: `Soneta.Handel.PrzesylkaDokRel`
Nazwa tabeli: `PrzesylkiDokRel`
Tytuł: Relacje przesyłek
Opis: Relacja między dokumentem handlowym a przesyłką kurierską. Umożliwia przypisanie wielu dokumentów do jednej przesyłki, co pozwala na zbiorcze nadawanie paczek dla kilku zamówień lub faktur.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DokumentHandlowy | `Soneta.Handel.DokumentHandlowy` | bazodanowe, tylko-odczyt | Dokument handlowy |  |
| PrzesylkaSpedytor | `Soneta.Handel.PrzesylkaSpedyt` | bazodanowe, tylko-odczyt | Przesylki spedytor |  |
