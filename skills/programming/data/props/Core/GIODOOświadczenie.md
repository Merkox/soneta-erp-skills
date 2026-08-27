# Pola i właściwości klasy biznesowej: `Soneta.Core.GIODOOświadczenie`
Nazwa tabeli: `GIODOOswiadcz`
Tytuł: Oświadczenia
Opis: Oświadczenie RODO (zgoda na przetwarzanie danych) złożone przez osobę. Zawiera datę, treść, definicję oświadczenia, okres obowiązywania, numer dokumentu, rodzaj, oddział, sposób pozyskania oraz powiązanie z ewentualnym wycofaniem zgody.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe |  |  |
| Data | `Date` | bazodanowe | Data | Data oświadczenia. |
| DataWycofaniaZgody | `Date` | bazodanowe, tylko-odczyt |  |  |
| Definicja | `Soneta.Core.GIODODefinicjaOświadczenia` | bazodanowe, tylko-odczyt | Definicja | Definicja oświadczenia. |
| Host | `Soneta.Core.IGIODOOświadczenieHost` | bazodanowe, tylko-odczyt, iface-ref | Składający oświadczenie | Zapis, do którego przypisano informacja o oświadczeniu |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  | Okres, na który udzielono zgodę |
| Oswiadczenie | `bool` | bazodanowe | Oświadczenie | Oświadczenie. |
| Rodzaj | `Soneta.Core.RodzajeOświadczeńGIODO` (enum) | bazodanowe, tylko-odczyt |  |  |
| SposobPozyskania | `string` | bazodanowe | Sposób pozyskania | Sposób pozyskania oświadczenia |
| Tresc | `MemoText` | bazodanowe, podlista | Oświadczenie | Treść oświadczenia |
| WycofaneZgody | `SubTable<Soneta.Core.GIODOOświadczenie>` | podlista |  |  |
| WycofanieZgody | `Soneta.Core.GIODOOświadczenie` | bazodanowe, tylko-odczyt |  |  |
| Zatwierdzone | `bool` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IGIODOOświadczenieHost` | `KontaktOsoba`, `Kontrahent`, `Pracownik`, `UczestnikBase` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajeOświadczeńGIODO (`Soneta.Core.RodzajeOświadczeńGIODO`)
- `Oświadczenie` = 0 — Oświadczenie
- `UdzielenieZgody` = 1
- `WycofanieZgody` = 2
