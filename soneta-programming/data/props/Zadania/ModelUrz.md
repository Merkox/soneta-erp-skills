# Pola i właściwości klasy biznesowej: `Soneta.Zadania.ModelUrz`
Nazwa tabeli: `ModeleUrz`
Tytuł: Model urządzeń
Opis: Model urządzenia w ramach typu urządzenia. Grupuje urządzenia o wspólnych cechach, definiując domyślny okres przeglądów, towar oraz oddział firmy.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 0
- razem: 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe | Aktywny | Określa, że jest to aktywny model urządzenia. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa modelu urządzenia. |
| OddzialFirmy | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy do którego przypisany jest model. |
| Opis | `MemoText` | bazodanowe, podlista | Opis | Opis modelu. |
| PrzegladOkres | `int` | bazodanowe |  | Co ile miesięcy przegląd. |
| Symbol | `string` | bazodanowe | Symbol | Symbol modelu urządzenia. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Lista towarów. |
| TypUrzadzenia | `Soneta.Zadania.TypUrzadzenia` | bazodanowe | Typ urządzenia | Typ urządzenia. |
