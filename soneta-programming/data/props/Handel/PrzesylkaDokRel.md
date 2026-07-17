# Pola i właściwości klasy biznesowej: `Soneta.Handel.PrzesylkaDokRel`
Nazwa tabeli: `PrzesylkiDokRel`
Tytuł: Relacje przesyłek
Opis: Relacja między dokumentem handlowym a przesyłką kurierską. Umożliwia przypisanie wielu dokumentów do jednej przesyłki, co pozwala na zbiorcze nadawanie paczek dla kilku zamówień lub faktur.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DokumentHandlowy | `Soneta.Handel.DokumentHandlowy` | bazodanowe | Dokument handlowy |  |
| PrzesylkaSpedytor | `Soneta.Handel.PrzesylkaSpedyt` | bazodanowe | Przesylki spedytor |  |
