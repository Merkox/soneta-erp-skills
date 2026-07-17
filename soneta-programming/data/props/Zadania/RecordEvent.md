# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Cti.Models.RecordEvent`
Nazwa tabeli: `RecordEvents`
Opis: Tabela przechowująca informacje o zdarzeniach CRM oraz ich powiązania z nagraniami połączeń telefonicznych. Zawiera dane identyfikacyjne zdarzenia i linki do odpowiednich plików nagrań.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| RecordEvent | `Soneta.Zadania.Zadanie` | bazodanowe |  |  |
| RecordLink | `Soneta.Business.MemoText` | bazodanowe |  |  |
