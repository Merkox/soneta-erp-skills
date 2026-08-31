# Pola i właściwości klasy biznesowej: `Soneta.Core.GIODOWymianaDanych`
Nazwa tabeli: `GIODOWymDanych`
Opis: Rejestr udostępnień i pozyskań danych osobowych zgodnie z RODO. Dokumentuje wymianę danych: kierunek (udostępnienie/pozyskanie), podmiot, zakres danych, sposób pozyskania, zbiór danych, definicję dokumentu oraz flagi (na wniosek osoby, tylko dostęp itp.).
Tabela konfiguracyjna: Nie
Guided: root
Selektor: pole `Kierunek` (`Soneta.Core.GIODOKierunekWymianyDanych`) — wiele typów w jednej tabeli, podtypów: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe |  |  |
| Data | `Date` | bazodanowe | Data | Data udostępnienia. |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| Host | `Soneta.Core.IGIODOWymianaDanychHost` | bazodanowe, tylko-odczyt, iface-ref |  | Zapis do którego przypisano informacja o wymianie danych |
| Kierunek | `Soneta.Core.GIODOKierunekWymianyDanych` (enum) | bazodanowe, tylko-odczyt, selektor | Kierunek | Udostępnienie czy pozyskanie. |
| NaWniosekOsoby | `bool` | bazodanowe, tylko-odczyt | Na wniosek osoby | Dane udostępnione na wniosek osoby, której dotyczą. |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| Podmiot | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref | Kontrahent | Podmiot, któremu udostępniono dane. |
| PodmiotExt | `Soneta.Core.IGIODOPodmiot` | tylko-odczyt | Podmiot |  |
| PozyskaneOdOsoby | `bool` | bazodanowe | Pozyskane od osoby | Dane pozyskane od osoby, której dotyczą. |
| SposobPozyskania | `string` | bazodanowe | Sposób pozyskania | Sposób pozyskania |
| TylkoDostep | `bool` | bazodanowe | Tylko dostęp | Przetwarzanie danych na infrastrukturze powierzającego. |
| UdostepnioneOsobie | `bool` | bazodanowe | Udostępnione osobie | Dane udostępnione osobie, której dotyczą. |
| Zakres | `MemoText` | bazodanowe, podlista | Zakres | Zakres udostępnionych danych. |
| Zatwierdzony | `bool` |  |  |  |
| ZbiorDanych | `Soneta.Core.GIODO.GIODOZbiorDanych` | bazodanowe, tylko-odczyt |  | Zbiór danych do którego przypisano informacja o wymianie danych |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Kierunek`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Powierzenie` | 1 | `Soneta.Core.GIODOPowierzenieDanych` | Powierzenie danych osobowych |
| `Pozyskanie` | 2 | `Soneta.Core.GIODOPozyskanieDanych` | Pozyskanie danych osobowych |
| `PowierzenieZbioru` | 3 | `Soneta.Core.GIODOPowierzenieZbioru` | Powierzenie zbioru danych osobowych |
| `PozyskanieZbioru` | 4 | `Soneta.Core.GIODOPozyskanieZbioru` | Pozyskanie zbioru danych osobowych |
| `Udostępnienie` | 5 | `Soneta.Core.GIODOUdostępnienieDanych` | Udostępnienie danych osobowych |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IGIODOWymianaDanychHost` | `KontaktOsoba`, `Kontrahent`, `Pracownik`, `UczestnikBase` |
| Podmiot | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### GIODOKierunekWymianyDanych (`Soneta.Core.GIODOKierunekWymianyDanych`)
- `Powierzenie` = 1 — Powierzenie
- `Pozyskanie` = 2
- `PowierzenieZbioru` = 3
- `PozyskanieZbioru` = 4
- `Udostępnienie` = 5
