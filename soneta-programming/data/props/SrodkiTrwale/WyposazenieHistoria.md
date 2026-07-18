# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.WyposazenieHistoria`
Nazwa tabeli: `EwidWyposazeniaH`
Tytuł: Ewidencja wyposażenia - historia
Opis: Element szczegółowy wyposażenia (Wyposazenie). Rejestruje historyczne zmiany danych wyposażenia, takich jak ilość, wartość, miejsce użytkowania, osoba odpowiedzialna oraz wartość rynkowa z datą wyceny.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Wyposazenie` → `Wyposazenie`
Historia: Tak — zapis historyczny tabeli `Wyposazenie`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista |  |  |
| DataWyceny | `Date` | bazodanowe |  | Data wyceny wartości rynkowej wysposażenia |
| Ilosc | `int` | bazodanowe | Ilość |  |
| JednostkaMiary | `Soneta.Towary.Jednostka` | bazodanowe | Jm. |  |
| MiejsceUzytkowania | `Soneta.SrodkiTrwale.MiejsceUzytkowania` | bazodanowe | Miejsce użytkowania | Miejsce użytkowania środeka trwałego |
| Nazwisko | `string` | bazodanowe |  | Nazwisko osoby odpowiedzialnej za wyposażenie |
| Odpowiedzialny | `Soneta.Kadry.Pracownik` | bazodanowe |  | Pracownik odpowiedzialny za wyposażenie |
| Parent | `Row` | tylko-odczyt |  |  |
| Wartosc | `Currency` | bazodanowe | Wartość |  |
| WartoscRynkowa | `Currency` | bazodanowe | Wartość rynkowa | Wartość rynkowa wysposażenia |
| Wyposazenie | `Soneta.SrodkiTrwale.Wyposazenie` | bazodanowe, tylko-odczyt, guided-parent |  |  |
