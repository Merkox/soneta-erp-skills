# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFIdentWewn`
Nazwa tabeli: `KSeFIdentyWewn`
Tytuł: Identyfikatory wewnętrzne KSeF
Opis: Identyfikator wewnętrzny KSeF (NIP lub numer wewnętrzny) dla podmiotu trzeciego. Określa źródło danych adresowych dla sprzedaży, powiązany oddział, magazyn, operatora, rodzaj dokumentu KSeF dla zakupu oraz flagę inicjowania przy tworzeniu dokumentu handlowego.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Blokada identyfikatora wewnętrznego | Blokada identyfikatora wewnętrznego |
| DaneAdresoweSprzedaz | `Soneta.Core.Enums.ZrodloDanychAdresowychKSeF` | bazodanowe, enum | Źródło danych adresowych dla sprzedaży | Źródło danych adresowych dla sprzedaży |
| Identyfikator | `string` | bazodanowe | Identyfikator wewnętrzny KSeF lub NIP | Identyfikator wewnętrzny KSeF lub NIP |
| Nazwa | `string` | bazodanowe | Nazwa identyfikatora | Nazwa identyfikatora |
| RelacjeDoTokenowKSeF | `Soneta.Business.SubTable<Soneta.Core.KSeFTokenIdentWewnRel>` |  |  |  |
| Role | `Soneta.Business.SubTable<Soneta.Core.KSeFIdentWewnRola>` |  |  |  |
| SprzedazInicjujDlaDokumentow | `bool` | bazodanowe | Inicjuj przy tworzeniu dokumentu handlowego | Inicjuj przy tworzeniu dokumentu handlowego |
| SprzedazMagazyn | `Soneta.Core.IElementSlownika` | bazodanowe, iface-ref |  |  |
| SprzedazMagazyny | `Soneta.Business.SubTable<Soneta.Core.KSeFIdentWewnSprzedazMagazyn>` |  |  |  |
| SprzedazOddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| SprzedazOddzialy | `Soneta.Business.SubTable<Soneta.Core.KSeFIdentWewnSprzedazOddzial>` |  |  |  |
| SprzedazOperator | `Soneta.Business.App.Operator` | bazodanowe |  |  |
| SprzedazOperatorzy | `Soneta.Business.SubTable<Soneta.Core.KSeFIdentWewnSprzedazOperator>` |  |  |  |
| TypIdentyfikatoraWewnetrznego | `Soneta.Core.Enums.TypIdentyfikatoraWewnetrznegoKSeF` | enum |  |  |
| ZakupRodzajDokumentuKSeF | `Soneta.Core.RodzajDokumentuKseF` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| SprzedazMagazyn | `IElementSlownika` | `Bank`, `CentrumKosztow`, `DokumentHandlowy`, `ElemSlownika`, `EwidencjaSP`, `GrupaSzkol`, `InstytucjaFinansowaPPK`, `Kontrahent`, `KosztRMK`, `Lead`, `Magazyn`, `OddzialFirmy`, `Pojazd`, `Pracownik`, `ProWydzial`, `ProZasob`, `ProZlecenie`, `Projekt`, `RodzajSzkol`, `RodzajZrodla`, `SrodekTrwalyBase`, `Towar`, `Transakcja`, `UrzadCelny`, `UrzadSkarbowy`, `Urzadzenie`, `Wydzial`, `ZUS`, `Zadanie`, `ZrodloFinansowania` |

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
