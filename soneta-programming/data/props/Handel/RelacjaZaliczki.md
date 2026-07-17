# Pola i właściwości klasy biznesowej: `Soneta.Handel.RelacjaZaliczki`
Nazwa tabeli: `RelacjeZaliczek`
Opis: Powiązanie dokumentu handlowego z zapłatą zaliczkową. Przechowuje typ relacji zaliczkowej i kwotę przypisaną do dokumentu.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe | Dokument handlowy | Dokument handlowy dla zaliczki |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| KwotaRozliczonaDokumentu | `Soneta.Types.Currency` |  |  |  |
| Typ | `Soneta.Handel.TypyRelacjiZaliczek` | bazodanowe, enum |  |  |
| Zaplata | `Soneta.Kasa.Zaplata` | bazodanowe | Zapłata | Zaplata dla zaliczki |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypyRelacjiZaliczek (`Soneta.Handel.TypyRelacjiZaliczek`)
- `Zaliczka` = 1
- `Wpłata` = 2
- `Kompensata` = 3
