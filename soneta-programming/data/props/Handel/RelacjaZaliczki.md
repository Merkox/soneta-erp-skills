# Pola i właściwości klasy biznesowej: `Soneta.Handel.RelacjaZaliczki`
Nazwa tabeli: `RelacjeZaliczek`
Opis: Powiązanie dokumentu handlowego z zapłatą zaliczkową. Przechowuje typ relacji zaliczkowej i kwotę przypisaną do dokumentu.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 0
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe, tylko-odczyt | Dokument handlowy | Dokument handlowy dla zaliczki |
| Kwota | `Currency` | bazodanowe |  |  |
| KwotaRozliczonaDokumentu | `Currency` | tylko-odczyt |  |  |
| Typ | `Soneta.Handel.TypyRelacjiZaliczek` (enum) | bazodanowe |  |  |
| Zaplata | `Soneta.Kasa.Zaplata` | bazodanowe, tylko-odczyt | Zapłata | Zaplata dla zaliczki |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypyRelacjiZaliczek (`Soneta.Handel.TypyRelacjiZaliczek`)
- `Zaliczka` = 1
- `Wpłata` = 2
- `Kompensata` = 3
