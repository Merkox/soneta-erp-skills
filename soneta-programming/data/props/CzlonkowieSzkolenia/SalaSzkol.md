# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.SalaSzkol`
Nazwa tabeli: `SaleSzkol`
Tytuł: Sale szkoleniowe
Opis: Kartoteka sal szkoleniowych dostępnych do prowadzenia zajęć. Przechowuje informacje o pojemności, lokalizacji oraz możliwości łączenia sal, wykorzystywane przy planowaniu harmonogramu szkoleń.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` |  |  |  |
| IloscMiejsc | `int` | bazodanowe | Ilość miejsc | Ilość miejsc w sali. |
| LaczonaZ | `Soneta.CzlonkowieSzkolenia.SalaSzkol` | bazodanowe | Sala, z którą można połączyć bieżącą salę | Sala, z którą można połączyć bieżącą salę. |
| Nazwa | `string` | bazodanowe | Nazwa sali | Nazwa sali. |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy do którego przypisana jest sala. |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis sali | Dodatkowy opis sali. |
| Settings | `Soneta.Business.SchedulerSettings` |  |  |  |
| Symbol | `string` | bazodanowe | Symbol sali | Symbol sali. |
| View | `Soneta.Business.View` |  |  |  |
| Zajecia | `Soneta.Business.View` |  |  |  |
| ZajeciaSali | `Soneta.Business.SubTable` |  |  |  |
