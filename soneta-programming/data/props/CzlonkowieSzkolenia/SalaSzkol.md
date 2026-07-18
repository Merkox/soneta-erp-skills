# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.SalaSzkol`
Nazwa tabeli: `SaleSzkol`
Tytuł: Sale szkoleniowe
Opis: Kartoteka sal szkoleniowych dostępnych do prowadzenia zajęć. Przechowuje informacje o pojemności, lokalizacji oraz możliwości łączenia sal, wykorzystywane przy planowaniu harmonogramu szkoleń.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| IloscMiejsc | `int` | bazodanowe | Ilość miejsc | Ilość miejsc w sali. |
| LaczonaZ | `Soneta.CzlonkowieSzkolenia.SalaSzkol` | bazodanowe | Sala, z którą można połączyć bieżącą salę | Sala, z którą można połączyć bieżącą salę. |
| Nazwa | `string` | bazodanowe | Nazwa sali | Nazwa sali. |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy do którego przypisana jest sala. |
| Opis | `MemoText` | bazodanowe, podlista | Opis sali | Dodatkowy opis sali. |
| Settings | `SchedulerSettings` | tylko-odczyt |  |  |
| Symbol | `string` | bazodanowe | Symbol sali | Symbol sali. |
| View | `View` | podlista |  |  |
| Zajecia | `View` | podlista |  |  |
| ZajeciaSali | `SubTable` | podlista |  |  |
