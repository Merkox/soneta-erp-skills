# Pola i właściwości klasy biznesowej: `Soneta.Core.GIODOOświadczenie`
Nazwa tabeli: `GIODOOswiadcz`
Tytuł: Oświadczenia
Opis: Oświadczenie RODO (zgoda na przetwarzanie danych) złożone przez osobę. Zawiera datę, treść, definicję oświadczenia, okres obowiązywania, numer dokumentu, rodzaj, oddział, sposób pozyskania oraz powiązanie z ewentualnym wycofaniem zgody.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 16
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe | Data | Data oświadczenia. |
| DataWycofaniaZgody | `Soneta.Types.Date` | bazodanowe |  |  |
| Definicja | `Soneta.Core.GIODODefinicjaOświadczenia` | bazodanowe | Definicja | Definicja oświadczenia. |
| Host | `Soneta.Core.IGIODOOświadczenieHost` | bazodanowe, iface-ref | Składający oświadczenie | Zapis, do którego przypisano informacja o oświadczeniu |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  | Okres, na który udzielono zgodę |
| Oswiadczenie | `bool` | bazodanowe | Oświadczenie | Oświadczenie. |
| Rodzaj | `Soneta.Core.RodzajeOświadczeńGIODO` | bazodanowe, enum |  |  |
| SposobPozyskania | `string` | bazodanowe | Sposób pozyskania | Sposób pozyskania oświadczenia |
| Tresc | `Soneta.Business.MemoText` | bazodanowe | Oświadczenie | Treść oświadczenia |
| WycofaneZgody | `Soneta.Business.SubTable<Soneta.Core.GIODOOświadczenie>` |  |  |  |
| WycofanieZgody | `Soneta.Core.GIODOOświadczenie` | bazodanowe |  |  |
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
