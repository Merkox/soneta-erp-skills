# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.ZleDlugiPozycja`
Nazwa tabeli: `ZDPozycje`
Tytuł: Pozycje ZD
Opis: Element szczegółowy dokumentu złych długów (ZleDlugiDokument). Reprezentuje pojedynczą pozycję korekty powiązaną z płatnością lub rozliczeniem, z datą korekty i kwotą. Obsługuje zarówno zwiększenia, jak i zmniejszenia podstawy opodatkowania w ramach ulgi na złe długi.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dokument` → `ZleDlugiDokument`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataDokumentu | `Soneta.Types.Date` | bazodanowe |  | Data dokumentu ZD |
| DataKorekty | `Soneta.Types.Date` | bazodanowe | Data korekty | Data ZD |
| DataUplywuTerminu | `Soneta.Types.Date` |  | Data upływu terminu |  |
| Dokument | `Soneta.Ksiega.ZleDlugiDokument` | bazodanowe, guided-parent |  |  |
| Korekta | `Soneta.Ksiega.ZleDlugiPozycja` | bazodanowe |  |  |
| Korekty | `Soneta.Business.SubTable<Soneta.Ksiega.ZleDlugiPozycjaKorekty>` |  |  |  |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  | Kwota pozycji |
| KwotaPlatnosci | `Soneta.Types.Currency` |  | Kwota płatności |  |
| Platnosc | `Soneta.Kasa.Platnosc` | bazodanowe | Płatność | Płatność |
| Przeterminowane | `int` |  | Po upływie (dni) |  |
| RodzajPlatnosci | `string` |  | Rodzaj płatności |  |
| Rozliczenia | `Soneta.Business.SubTable<Soneta.Ksiega.ZleDlugiPozycja>` |  |  |  |
| Rozliczenie | `Soneta.Kasa.RozliczenieSP` | bazodanowe |  | Rozliczenie |
| Saldo | `Soneta.Types.Currency` |  | Saldo złe długi |  |
| StatusPozycji | `Soneta.Ksiega.StatusPozycjiZleDlugi` | enum | Typ status |  |
| TerminSkrocony | `bool` | bazodanowe | Termin płatności skrócony | Termin płatności skrócony |
| Typ | `Soneta.Ksiega.TypPozycjiZleDlugi` | bazodanowe, enum |  | Typ pozycji |

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
