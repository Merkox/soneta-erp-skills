# Pola i właściwości klasy biznesowej: `Soneta.Handel.PrzesylkaDokRel`
Nazwa tabeli: `PrzesylkiDokRel`
Tytuł: Relacje przesyłek
Opis: Relacja między dokumentem handlowym a przesyłką kurierską. Umożliwia przypisanie wielu dokumentów do jednej przesyłki, co pozwala na zbiorcze nadawanie paczek dla kilku zamówień lub faktur.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DokumentHandlowy | `Soneta.Handel.DokumentHandlowy` | bazodanowe, tylko-odczyt | Dokument handlowy |  |
| PrzesylkaSpedytor | `Soneta.Handel.PrzesylkaSpedyt` | bazodanowe, tylko-odczyt | Przesylki spedytor |  |
