# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.PrzedmiotSzkol`
Nazwa tabeli: `PrzedmiotySzkol`
Tytuł: Przedmioty
Opis: Słownik przedmiotów realizowanych w ramach szkoleń. Definiuje tematykę zajęć dydaktycznych wraz z opisem i zakresem merytorycznym, wykorzystywaną przy budowaniu programu szkolenia.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nazwa | `string` | bazodanowe | Nazwa przedmiotu | Nazwa przedmiotu. |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy. |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis przedmiotu | Opis przedmiotu. |
| Zakres | `Soneta.CzlonkowieSzkolenia.PrzedmiotSzkol` | bazodanowe | Zakres przedmiotu | Zakres przedmiotu. |
