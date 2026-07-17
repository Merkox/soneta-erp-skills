# Pola i właściwości klasy biznesowej: `Soneta.Core.PoświadczenieOdbioru`
Nazwa tabeli: `PoswiadczOdbioru`
Tytuł: Poświadczenia odbioru
Opis: Element szczegółowy hosta poświadczenia odbioru (IPoświadczenieOdbioruHost). Rejestruje potwierdzenie odbioru dokumentu przez podmiot (web operatora), z datą, definicją, treścią oświadczenia i stanem poświadczenia.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dokument` → `IPoświadczenieOdbioruHost`

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe | Data | Data poświadczenia |
| Definicja | `Soneta.Core.DefinicjaPoświadczeniaOdbioru` | bazodanowe | Definicja | Definicja poświadczenia odbioru |
| Dokument | `Soneta.Core.IPoświadczenieOdbioruHost` | bazodanowe, guided-parent, iface-ref |  | Dokument z poświadczeniem odbioru |
| IsFullView | `bool` |  |  |  |
| Podmiot | `Soneta.Business.IWebOperator` | bazodanowe, iface-ref |  | Podmiot poświadczający odbiór |
| Poswiadczenie | `bool` | bazodanowe | Poświadczenie | Poswiadczenie odbioru |
| Stan | `Soneta.Core.StanyPoświadczeniaOdbioru` | bazodanowe, enum |  |  |
| Tresc | `Soneta.Business.MemoText` | bazodanowe | Oświadczenie | Treść oświadczenia |
| TreśćPoświadczenia | `string` |  |  |  |
| UprawnionyUżytkownik | `bool` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Dokument | `IPoświadczenieOdbioruHost` | `DbTuple` |
| Podmiot | `IWebOperator` | `KontaktOsoba`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanyPoświadczeniaOdbioru (`Soneta.Core.StanyPoświadczeniaOdbioru`)
- `Anulowany` = 0
- `Aktywny` = 1
- `Zatwierdzony` = 2
