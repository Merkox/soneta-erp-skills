# Pola i właściwości klasy biznesowej: `Soneta.Handel.RelacjaInnaPlat`
Nazwa tabeli: `RelacjeInnaPlat`
Opis: Powiązanie dokumentu handlowego z inną płatnością (rozliczeniem). Przechowuje typ relacji i kwotę płatności alternatywnej dla dokumentu.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe | Dokument handlowy | Dokument handlowy dla innej płatności |
| InnaPlatnosc | `Soneta.Kasa.RozliczenieSP` | bazodanowe | Inna płatność | Inna płatność |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| Typ | `Soneta.Handel.TypyRelacjiZaliczek` | bazodanowe, enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypyRelacjiZaliczek (`Soneta.Handel.TypyRelacjiZaliczek`)
- `Zaliczka` = 1
- `Wpłata` = 2
- `Kompensata` = 3
