# Pola i właściwości klasy biznesowej: `Soneta.Handel.RelacjaInnaPlat`
Nazwa tabeli: `RelacjeInnaPlat`
Opis: Powiązanie dokumentu handlowego z inną płatnością (rozliczeniem). Przechowuje typ relacji i kwotę płatności alternatywnej dla dokumentu.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe, tylko-odczyt | Dokument handlowy | Dokument handlowy dla innej płatności |
| InnaPlatnosc | `Soneta.Kasa.RozliczenieSP` | bazodanowe, tylko-odczyt | Inna płatność | Inna płatność |
| Kwota | `Currency` | bazodanowe |  |  |
| Typ | `Soneta.Handel.TypyRelacjiZaliczek` (enum) | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypyRelacjiZaliczek (`Soneta.Handel.TypyRelacjiZaliczek`)
- `Zaliczka` = 1
- `Wpłata` = 2
- `Kompensata` = 3
