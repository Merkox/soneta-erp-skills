# Pola i właściwości klasy biznesowej: `Soneta.Core.CRUContract`
Nazwa tabeli: `CRUContracts`
Tytuł: Dokument CRU
Opis: Zawiera listę dokumentów dedykowanych dla Centralnego Rejestru Umów. Pozwala na przegląd aktualizacji oraz umów bazowych.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 16
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CRUDate | `Soneta.Types.Date` | bazodanowe | Data umowy | Data zawarcia umowy CRU |
| CRUHasNoNumberFlag | `bool` | bazodanowe |  | Flaga oznaczająca brak numeru umowy CRU |
| CRUId | `string` | bazodanowe | Identyfikator rekordu | Identyfikator rekordu w systemie zewnętrznym CRU |
| CRUIndefinitePeriod | `bool` | bazodanowe | Umowa na czas nieoznaczony | Flaga oznaczająca umowę CRU na czas nieoznaczony |
| CRUNumber | `string` | bazodanowe | Numer umowy | Numer umowy CRU |
| CRUPeriod | `Soneta.Types.FromTo` | bazodanowe | Okres | Okres obowiązywania umowy CRU |
| CRUStatus | `Soneta.Core.CRU.ContractStatus` | bazodanowe, enum | Status umowy | Status umowy CRU |
| CRUSubject | `string` | bazodanowe | Przedmiot umowy | Przedmiot umowy CRU |
| CRUValue | `decimal` | bazodanowe | Wartość umowy | Wartość przedmiotu umowy CRU |
| CreatedBy | `Soneta.Business.ITaskUser` | bazodanowe, iface-ref | Użytkownik | Użytkownik/operator który utworzył rekord |
| DisplayName | `string` |  |  |  |
| Host | `Soneta.Core.CRU.ICRUContractHost` | bazodanowe | Rekord powiązany | Rekord powiązany |
| Model | `Soneta.Business.MemoText` | bazodanowe | Model | Zserializowany model danych |
| RowStatus | `Soneta.Core.CRUContractRowStatus` | bazodanowe, enum | Status rekordu | Status rekordu - draft lub opublikowana |
| RowType | `Soneta.Core.CRUContractRowType` | bazodanowe, enum | Rodzaj rekordu | Rodzaj rekordu - umowa lub aktualizacja |
| UpdatedContract | `Soneta.Core.CRUContract` | bazodanowe | Umowa aktualizowana | Aktualizowana umowa/rekord CRUContract |
| WithdrawReason | `string` | bazodanowe | Powód wycofania umowy | Powód wycofania umowy przekazywany do API CRU |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| CreatedBy | `ITaskUser` | `KontaktOsoba`, `Operator`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego`, `WykladowcaSzkol` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ContractStatus (`Soneta.Core.CRU.ContractStatus`)
- `Unknown` = 0 — Nieokreślony
- `Active` = 1 — Aktywna
- `Inactive` = 2 — Nieaktywna

### CRUContractRowStatus (`Soneta.Core.CRUContractRowStatus`)
- `Draft` = 0 — W przygotowaniu
- `Prepared` = 1 — Przygotowana
- `Published` = 2 — Opublikowana
- `Sent` = 3 — Wysłana
- `Withdrawn` = 10 — Wycofana

### CRUContractRowType (`Soneta.Core.CRUContractRowType`)
- `Contract` = 0 — Umowa - pierwsza wersja
- `AdhocUpdate` = 1 — Aktualizacja z umowy
- `OtherDocUpdate` = 2 — Aktualizacja innym dokumentem
- `Final` = 3 — Umowa - bieżąca wersja
