# Pola i właściwości klasy biznesowej: `Soneta.Core.GIODOWymianaDanych`
Nazwa tabeli: `GIODOWymDanych`
Opis: Rejestr udostępnień i pozyskań danych osobowych zgodnie z RODO. Dokumentuje wymianę danych: kierunek (udostępnienie/pozyskanie), podmiot, zakres danych, sposób pozyskania, zbiór danych, definicję dokumentu oraz flagi (na wniosek osoby, tylko dostęp itp.).
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 18
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe | Data | Data udostępnienia. |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| Host | `Soneta.Core.IGIODOWymianaDanychHost` | bazodanowe, iface-ref |  | Zapis do którego przypisano informacja o wymianie danych |
| Kierunek | `Soneta.Core.GIODOKierunekWymianyDanych` | bazodanowe, enum | Kierunek | Udostępnienie czy pozyskanie. |
| NaWniosekOsoby | `bool` | bazodanowe | Na wniosek osoby | Dane udostępnione na wniosek osoby, której dotyczą. |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| Podmiot | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref | Kontrahent | Podmiot, któremu udostępniono dane. |
| PodmiotExt | `Soneta.Core.IGIODOPodmiot` |  | Podmiot |  |
| PozyskaneOdOsoby | `bool` | bazodanowe | Pozyskane od osoby | Dane pozyskane od osoby, której dotyczą. |
| SposobPozyskania | `string` | bazodanowe | Sposób pozyskania | Sposób pozyskania |
| TylkoDostep | `bool` | bazodanowe | Tylko dostęp | Przetwarzanie danych na infrastrukturze powierzającego. |
| UdostepnioneOsobie | `bool` | bazodanowe | Udostępnione osobie | Dane udostępnione osobie, której dotyczą. |
| Zakres | `Soneta.Business.MemoText` | bazodanowe | Zakres | Zakres udostępnionych danych. |
| Zatwierdzony | `bool` |  |  |  |
| ZbiorDanych | `Soneta.Core.GIODO.GIODOZbiorDanych` | bazodanowe |  | Zbiór danych do którego przypisano informacja o wymianie danych |

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
