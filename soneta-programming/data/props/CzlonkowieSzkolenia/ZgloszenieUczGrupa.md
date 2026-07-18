# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.ZgloszenieUczGrupa`
Nazwa tabeli: `ZgloszeniaUczGrp`
Tytuł: Zgłoszenia na grupę.
Opis: Przypisanie zgłoszonych uczestników do konkretnych grup szkoleniowych. Łączy uczestnika z grupą i modułem szkoleniowym, umożliwiając indywidualne ustalenie kosztów i rabatów za szkolenie.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| GrupaSzkol | `Soneta.CzlonkowieSzkolenia.GrupaSzkol` | bazodanowe |  |  |
| IndywidualnaCena | `Currency` | bazodanowe |  |  |
| IndywidualnyKoszt | `bool` | bazodanowe |  |  |
| IndywidualnyRabat | `Percent` | bazodanowe |  |  |
| Modul | `Soneta.CzlonkowieSzkolenia.ModulSzkol` | bazodanowe | Moduł | Moduł z którym powiązane jest szkolenie. |
| ZgloszenieUczestnik | `Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik` | bazodanowe |  |  |
