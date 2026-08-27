# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProRozliczenieZapotrzebowania`
Nazwa tabeli: `ProRozZapot`
Tytuł: Rozliczenia zapotrzebowań
Opis: Element szczegółowy materiału operacji zlecenia (ProMaterialOperacjiZlecenia). Rejestruje powiązanie materiału zlecenia z pozycją dokumentu handlowego (zamówienia zakupu), umożliwiając śledzenie realizacji zapotrzebowań materiałowych i bilansowanie dostaw.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `MaterialOperacjiZlecenia` → `ProMaterialOperacjiZlecenia`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość rozliczenia zapotrzebowań. |
| IloscPrzeliczona | `double` | bazodanowe | Ilość przeliczona | Ilość przeliczona rozliczenia zapotrzebowań. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa rozliczenia zapotrzebowań. |
| MaterialOperacjiZlecenia | `Soneta.ProdukcjaPro.ProMaterialOperacjiZlecenia` | bazodanowe, guided-parent |  | Materiał operacji zlecenia dla rozliczenia zapotrzebowań. |
| PozycjaDokumentuHandlowego | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe | Pozycja dokumentu handlowego | Pozycja dokumentu handlowego rozliczenia zapotrzebowań. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar rozliczenia zapotrzebowań. |
