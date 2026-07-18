# Pola i właściwości klasy biznesowej: `Soneta.Core.PoświadczenieOdbioru`
Nazwa tabeli: `PoswiadczOdbioru`
Tytuł: Poświadczenia odbioru
Opis: Element szczegółowy hosta poświadczenia odbioru (IPoświadczenieOdbioruHost). Rejestruje potwierdzenie odbioru dokumentu przez podmiot (web operatora), z datą, definicją, treścią oświadczenia i stanem poświadczenia.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dokument` → `IPoświadczenieOdbioruHost`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe, tylko-odczyt | Data | Data poświadczenia |
| Definicja | `Soneta.Core.DefinicjaPoświadczeniaOdbioru` | bazodanowe, tylko-odczyt | Definicja | Definicja poświadczenia odbioru |
| Dokument | `Soneta.Core.IPoświadczenieOdbioruHost` | bazodanowe, tylko-odczyt, guided-parent, iface-ref |  | Dokument z poświadczeniem odbioru |
| IsFullView | `bool` | tylko-odczyt |  |  |
| Podmiot | `IWebOperator` | bazodanowe, tylko-odczyt, iface-ref |  | Podmiot poświadczający odbiór |
| Poswiadczenie | `bool` | bazodanowe, tylko-odczyt | Poświadczenie | Poswiadczenie odbioru |
| Stan | `Soneta.Core.StanyPoświadczeniaOdbioru` (enum) | bazodanowe, tylko-odczyt |  |  |
| Tresc | `MemoText` | bazodanowe, podlista | Oświadczenie | Treść oświadczenia |
| TreśćPoświadczenia | `string` | tylko-odczyt |  |  |
| UprawnionyUżytkownik | `bool` | tylko-odczyt |  |  |

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
