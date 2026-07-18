# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Cti.Models.RecordEvent`
Nazwa tabeli: `RecordEvents`
Opis: Tabela przechowująca informacje o zdarzeniach CRM oraz ich powiązania z nagraniami połączeń telefonicznych. Zawiera dane identyfikacyjne zdarzenia i linki do odpowiednich plików nagrań.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 1
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| RecordEvent | `Soneta.Zadania.Zadanie` | bazodanowe, tylko-odczyt |  |  |
| RecordLink | `MemoText` | bazodanowe, podlista |  |  |
