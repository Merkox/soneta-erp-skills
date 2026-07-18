# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.ZleDlugiPozycja`
Nazwa tabeli: `ZDPozycje`
Tytuł: Pozycje ZD
Opis: Element szczegółowy dokumentu złych długów (ZleDlugiDokument). Reprezentuje pojedynczą pozycję korekty powiązaną z płatnością lub rozliczeniem, z datą korekty i kwotą. Obsługuje zarówno zwiększenia, jak i zmniejszenia podstawy opodatkowania w ramach ulgi na złe długi.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dokument` → `ZleDlugiDokument`
Selektor: pole `Typ` (`Soneta.Ksiega.TypPozycjiZleDlugi`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataDokumentu | `Date` | bazodanowe, tylko-odczyt |  | Data dokumentu ZD |
| DataKorekty | `Date` | bazodanowe | Data korekty | Data ZD |
| DataUplywuTerminu | `Date` | tylko-odczyt | Data upływu terminu |  |
| Dokument | `Soneta.Ksiega.ZleDlugiDokument` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Korekta | `Soneta.Ksiega.ZleDlugiPozycja` | bazodanowe |  |  |
| Korekty | `SubTable<Soneta.Ksiega.ZleDlugiPozycjaKorekty>` | podlista |  |  |
| Kwota | `Currency` | bazodanowe |  | Kwota pozycji |
| KwotaPlatnosci | `Currency` | tylko-odczyt | Kwota płatności |  |
| Platnosc | `Soneta.Kasa.Platnosc` | bazodanowe | Płatność | Płatność |
| Przeterminowane | `int` | tylko-odczyt | Po upływie (dni) |  |
| RodzajPlatnosci | `string` | tylko-odczyt | Rodzaj płatności |  |
| Rozliczenia | `SubTable<Soneta.Ksiega.ZleDlugiPozycja>` | podlista |  |  |
| Rozliczenie | `Soneta.Kasa.RozliczenieSP` | bazodanowe |  | Rozliczenie |
| Saldo | `Currency` | tylko-odczyt | Saldo złe długi |  |
| StatusPozycji | `Soneta.Ksiega.StatusPozycjiZleDlugi` (enum) | tylko-odczyt | Typ status |  |
| TerminSkrocony | `bool` | bazodanowe | Termin płatności skrócony | Termin płatności skrócony |
| Typ | `Soneta.Ksiega.TypPozycjiZleDlugi` (enum) | bazodanowe, tylko-odczyt, selektor |  | Typ pozycji |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Korekta` | 1 | `Soneta.Ksiega.ZleDlugiKorekta` | Korekta ZD |
| `Rozliczenie` | 2 | `Soneta.Ksiega.ZleDlugiRozliczenie` | Rozliczenie ZD |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusPozycjiZleDlugi (`Soneta.Ksiega.StatusPozycjiZleDlugi`)
- `Brak` = 0
- `Korekta` = 1 — Korekta
- `RozliczeniePrzedKorekta` = 2 — Rozliczenie przed korektą
- `RozliczeniePoKorekcie` = 3 — Rozliczenie po korekcie

### TypPozycjiZleDlugi (`Soneta.Ksiega.TypPozycjiZleDlugi`)
- `Brak` = 0 — Brak
- `Korekta` = 1 — Złe długi korekta
- `Rozliczenie` = 2 — Złe długi rozliczenie
