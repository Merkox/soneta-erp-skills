# Pola i właściwości klasy biznesowej: `Soneta.Core.RodzajDokumentuKseF`
Nazwa tabeli: `RodzajeDokKseF`
Tytuł: Słownik rodzajów dokumentów
Opis: Rodzaj dokumentu KSeF definiujący konfigurację przetwarzania faktur. Określa symbol, nazwę, kategorię dokumentu, powiązanie z definicją dokumentu ewidencji i handlowego, matrycę, magazyn, oddział oraz opcjonalny algorytm (kod).
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe: 16
- pola kalkulowane (z klas biznesowych): 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Blokada | Procedura zablokowana |
| CechaKategoria | `Soneta.Business.FeatureDefinition` | bazodanowe |  | Wskazanie definicji cechy do wyliczania kategorii |
| DefaultFileName | `string` |  |  |  |
| DefaultIdentifier | `string` |  |  |  |
| DefaultProject | `Soneta.Business.Compiler.RuntimeProject` |  |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe | Definicja dokumentu | Definicja dokumentu |
| DefinicjaDokHandlowego | `object` |  |  |  |
| DefinicjaDokHandlowegoGuid | `System.Guid` | bazodanowe | Definicja dokumentu handlowego Guid | Definicja dokumentu handlowego Guid |
| Documents | `System.Collections.Generic.IEnumerable<Soneta.Business.Compiler.IRuntimeDocument>` |  |  |  |
| KategoriaDokumentu | `Soneta.Core.ConfigKategoriaKSeF` | bazodanowe, enum | Kategoria dokumentu | Kategoria dokumentu |
| Kod | `Soneta.Business.MemoText` | bazodanowe |  | Kod |
| KodWlaczony | `bool` | bazodanowe |  | Włącznik kodu |
| Magazyn | `object` |  |  |  |
| MagazynGuid | `System.Guid` | bazodanowe | Magazyn Guid | Magazyn Guid |
| Matryca | `object` |  |  |  |
| MatrycaGuid | `System.Guid` | bazodanowe | Matryca Guid | Matryca Guid |
| Nazwa | `Soneta.Business.MemoText` | bazodanowe | Nazwa | Nazwa |
| NazwaS | `string` |  |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział | Oddział |
| PodmiotyRodzaju | `Soneta.Business.SubTable<Soneta.Core.RodzajPodmiot>` |  |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| Symbol | `string` | bazodanowe | Symbol | Symbol |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ConfigKategoriaKSeF (`Soneta.Core.ConfigKategoriaKSeF`)
- `Nieokreslona` = 0 — Nieokreślona
- `Handel` = 1 — Dokument handlowy
- `Ewidencja` = 2 — Dokument ewidencji
- `DoWyjasnienia` = 3 — Do wyjaśnienia
- `WgCechy` = 1000 — Wg cechy
