# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.WyposazenieHistoria`
Nazwa tabeli: `EwidWyposazeniaH`
Tytuł: Ewidencja wyposażenia - historia
Opis: Element szczegółowy wyposażenia (Wyposazenie). Rejestruje historyczne zmiany danych wyposażenia, takich jak ilość, wartość, miejsce użytkowania, osoba odpowiedzialna oraz wartość rynkowa z datą wyceny.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Wyposazenie` → `Wyposazenie`

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Soneta.Types.FromTo` | bazodanowe |  |  |
| DataWyceny | `Soneta.Types.Date` | bazodanowe |  | Data wyceny wartości rynkowej wysposażenia |
| Ilosc | `int` | bazodanowe | Ilość |  |
| JednostkaMiary | `Soneta.Towary.Jednostka` | bazodanowe | Jm. |  |
| MiejsceUzytkowania | `Soneta.SrodkiTrwale.MiejsceUzytkowania` | bazodanowe | Miejsce użytkowania | Miejsce użytkowania środeka trwałego |
| Nazwisko | `string` | bazodanowe |  | Nazwisko osoby odpowiedzialnej za wyposażenie |
| Odpowiedzialny | `Soneta.Kadry.Pracownik` | bazodanowe |  | Pracownik odpowiedzialny za wyposażenie |
| Parent | `Soneta.Business.Row` |  |  |  |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość |  |
| WartoscRynkowa | `Soneta.Types.Currency` | bazodanowe | Wartość rynkowa | Wartość rynkowa wysposażenia |
| Wyposazenie | `Soneta.SrodkiTrwale.Wyposazenie` | bazodanowe, guided-parent |  |  |
