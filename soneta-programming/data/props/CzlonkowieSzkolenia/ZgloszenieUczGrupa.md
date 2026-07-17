# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.ZgloszenieUczGrupa`
Nazwa tabeli: `ZgloszeniaUczGrp`
Tytuł: Zgłoszenia na grupę.
Opis: Przypisanie zgłoszonych uczestników do konkretnych grup szkoleniowych. Łączy uczestnika z grupą i modułem szkoleniowym, umożliwiając indywidualne ustalenie kosztów i rabatów za szkolenie.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| GrupaSzkol | `Soneta.CzlonkowieSzkolenia.GrupaSzkol` | bazodanowe |  |  |
| IndywidualnaCena | `Soneta.Types.Currency` | bazodanowe |  |  |
| IndywidualnyKoszt | `bool` | bazodanowe |  |  |
| IndywidualnyRabat | `Soneta.Types.Percent` | bazodanowe |  |  |
| Modul | `Soneta.CzlonkowieSzkolenia.ModulSzkol` | bazodanowe | Moduł | Moduł z którym powiązane jest szkolenie. |
| ZgloszenieUczestnik | `Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik` | bazodanowe |  |  |
