# Pola i właściwości klasy biznesowej: `Soneta.Core.RodzajDokumentuKseF`
Nazwa tabeli: `RodzajeDokKseF`
Tytuł: Słownik rodzajów dokumentów
Opis: Rodzaj dokumentu KSeF definiujący konfigurację przetwarzania faktur. Określa symbol, nazwę, kategorię dokumentu, powiązanie z definicją dokumentu ewidencji i handlowego, matrycę, magazyn, oddział oraz opcjonalny algorytm (kod).
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe (zapisywalne): 13
- pola kalkulowane (zapisywalne): 3
- pola tylko-odczyt: 4
- podlisty: 5
- subrowy: 1
- razem: 26

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Blokada | Procedura zablokowana |
| CechaKategoria | `FeatureDefinition` | bazodanowe |  | Wskazanie definicji cechy do wyliczania kategorii |
| DefaultFileName | `string` | tylko-odczyt |  |  |
| DefaultIdentifier | `string` | tylko-odczyt |  |  |
| DefaultProject | `Compiler.RuntimeProject` | tylko-odczyt |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe | Definicja dokumentu | Definicja dokumentu |
| DefinicjaDokHandlowego | `object` |  |  |  |
| DefinicjaDokHandlowegoGuid | `System.Guid` | bazodanowe | Definicja dokumentu handlowego Guid | Definicja dokumentu handlowego Guid |
| Documents | `System.Collections.Generic.IEnumerable<Compiler.IRuntimeDocument>` | podlista |  |  |
| KategoriaDokumentu | `Soneta.Core.ConfigKategoriaKSeF` (enum) | bazodanowe | Kategoria dokumentu | Kategoria dokumentu |
| Kod | `MemoText` | bazodanowe, podlista |  | Kod |
| KodWlaczony | `bool` | bazodanowe |  | Włącznik kodu |
| Magazyn | `object` |  |  |  |
| MagazynGuid | `System.Guid` | bazodanowe | Magazyn Guid | Magazyn Guid |
| Matryca | `object` |  |  |  |
| MatrycaGuid | `System.Guid` | bazodanowe | Matryca Guid | Matryca Guid |
| Nazwa | `MemoText` | bazodanowe, podlista | Nazwa | Nazwa |
| NazwaS | `string` | tylko-odczyt |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział | Oddział |
| PodmiotyRodzaju | `SubTable<Soneta.Core.RodzajPodmiot>` | podlista |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| Symbol | `string` | bazodanowe | Symbol | Symbol |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ConfigKategoriaKSeF (`Soneta.Core.ConfigKategoriaKSeF`)
- `Nieokreslona` = 0 — Nieokreślona
- `Handel` = 1 — Dokument handlowy
- `Ewidencja` = 2 — Dokument ewidencji
- `DoWyjasnienia` = 3 — Do wyjaśnienia
- `WgCechy` = 1000 — Wg cechy
