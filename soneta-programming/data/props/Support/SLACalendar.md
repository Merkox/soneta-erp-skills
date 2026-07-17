# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.SLACalendar`
Nazwa tabeli: `SLACalendars`
Tytuł: Kalendarz
Opis: Słownik kalendarzy roboczych wykorzystywanych do obliczania czasów SLA. Definiuje godziny pracy w dni robocze, soboty oraz niedziele i święta, umożliwiając precyzyjne wyliczanie terminów reakcji i naprawy z uwzględnieniem dostępności zespołu.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Name | `string` | bazodanowe | Nazwa | Nazwa |
| SaturdayFrom | `Soneta.Types.Time` | bazodanowe | Soboty od | Soboty od |
| SaturdayHours | `double` | bazodanowe | Soboty ilość godzin | Soboty ilość godzin |
| SundayFrom | `Soneta.Types.Time` | bazodanowe | Niedziele i święta od | Niedziele i święta od |
| SundayHours | `double` | bazodanowe | Niedziele i święta ilość godzin | Niedziele i święta ilość godzin |
| WorkingDaysFrom | `Soneta.Types.Time` | bazodanowe | Dni robocze od | Dni robocze od |
| WorkingDaysHours | `double` | bazodanowe | Dni robocze ilość godzin | Dni robocze ilość godzin |
