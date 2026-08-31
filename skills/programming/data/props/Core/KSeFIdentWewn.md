# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFIdentWewn`
Nazwa tabeli: `KSeFIdentyWewn`
Tytuł: Identyfikatory wewnętrzne KSeF
Opis: Identyfikator wewnętrzny KSeF (NIP lub numer wewnętrzny) dla podmiotu trzeciego. Określa źródło danych adresowych dla sprzedaży, powiązany oddział, magazyn, operatora, rodzaj dokumentu KSeF dla zakupu oraz flagę inicjowania przy tworzeniu dokumentu handlowego.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Blokada identyfikatora wewnętrznego | Blokada identyfikatora wewnętrznego |
| DaneAdresoweSprzedaz | `Soneta.Core.Enums.ZrodloDanychAdresowychKSeF` (enum) | bazodanowe | Źródło danych adresowych dla sprzedaży | Źródło danych adresowych dla sprzedaży |
| Identyfikator | `string` | bazodanowe | Identyfikator wewnętrzny KSeF lub NIP | Identyfikator wewnętrzny KSeF lub NIP |
| Nazwa | `string` | bazodanowe | Nazwa identyfikatora | Nazwa identyfikatora |
| RelacjeDoTokenowKSeF | `SubTable<Soneta.Core.KSeFTokenIdentWewnRel>` | podlista |  |  |
| Role | `SubTable<Soneta.Core.KSeFIdentWewnRola>` | podlista |  |  |
| SprzedazInicjujDlaDokumentow | `bool` | bazodanowe | Inicjuj przy tworzeniu dokumentu handlowego | Inicjuj przy tworzeniu dokumentu handlowego |
| SprzedazMagazyny | `SubTable<Soneta.Core.KSeFIdentWewnSprzedazMagazyn>` | podlista |  |  |
| SprzedazOddzialy | `SubTable<Soneta.Core.KSeFIdentWewnSprzedazOddzial>` | podlista |  |  |
| SprzedazOperatorzy | `SubTable<Soneta.Core.KSeFIdentWewnSprzedazOperator>` | podlista |  |  |
| TypIdentyfikatoraWewnetrznego | `Soneta.Core.Enums.TypIdentyfikatoraWewnetrznegoKSeF` (enum) | tylko-odczyt |  |  |
| ZakupRodzajDokumentuKSeF | `Soneta.Core.RodzajDokumentuKseF` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypIdentyfikatoraWewnetrznegoKSeF (`Soneta.Core.Enums.TypIdentyfikatoraWewnetrznegoKSeF`)
- `IdWew` = 0 — IdWew
- `NIP` = 1
- `BrakId` = 2 — Brak Id
- `NrVatUE` = 3 — NrVatUE
- `NrID` = 4 — NrID

### ZrodloDanychAdresowychKSeF (`Soneta.Core.Enums.ZrodloDanychAdresowychKSeF`)
- `Brak` = 0
- `Lokalizacja` = 1
- `Odbiorca` = 2
- `NieWysylaj` = 3 — Nie wysyłaj
- `Oddzial` = 4 — Oddział
- `DaneFirmy` = 5 — Dane firmy
- `DaneKontrahenta` = 6 — Dane kontrahenta
