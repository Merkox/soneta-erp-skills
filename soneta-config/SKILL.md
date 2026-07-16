---
name: soneta-config
description: >
  Narzędzia i mechanizmy platformy Soneta (enova365, Triva) związane z konfiguracją
  systemu i funkcjami domenowymi. Obecnie skill zawiera narzędzie do inwentaryzacji
  STATYCZNYCH FOLDERÓW MENU z bibliotek DLL (`scan-folders` — atrybuty
  `[assembly: FolderView]`), które buduje drzewo pozycji menu: listy, formularze i
  ich powiązanie z tabelą/`ViewInfo`. Używaj gdy użytkownik: (1) chce zobaczyć lub
  zmapować strukturę menu programu z bibliotek dodatku (drzewo folderów, listy,
  formularze); (2) eksploruje nieznany dodatek i pyta, jak rozbudowuje menu; (3) szuka
  właściwej ścieżki-rodzica, aby wpiąć nowy folder w istniejące menu; (4) weryfikuje,
  że nowy `[assembly: FolderView]` trafił we właściwe miejsce drzewa; (5) potrzebuje
  mapy: pozycja menu ↔ `ViewInfo`/tabela/typ obiektu. Kod ORM/workery/foldery pisane
  w C# → /soneta-programming; operacje na bazie z CLI → /soneta-tools.
---

# Ustawienia, konfiguracja i funkcje domenowe platformy Soneta (enova365, Triva)

Skill gromadzi narzędzia i mechanizmy związane z **konfiguracją systemu** oraz
**funkcjami domenowymi** platformy Soneta. Zawartość jest rozwijana — poniżej udokumentowane
są wyłącznie narzędzia faktycznie obecne w skillu; kolejne artykuły dodawane są sukcesywnie.

## Kiedy ten skill, a kiedy inny

| Potrzeba | Skill |
|---|---|
| Inwentaryzacja/mapa **folderów statycznych menu** (`[assembly: FolderView]`) z DLL | **/soneta-config** (`scan-folders`, niżej) |
| Klasy ORM, sesje, transakcje, workery/extendery, foldery/listy pisane w C# | [/soneta-programming](../soneta-programming/SKILL.md) |
| Inwentaryzacja modułów/tabel (`scan-modules`), pól (`scan-props`), workerów (`scan-workers`) | [/soneta-programming](../soneta-programming/SKILL.md) |
| Operacje na bazie z CLI (dbmgr), test na żywej aplikacji (buscall) | [/soneta-tools](../soneta-tools/SKILL.md) |
| Definicja struktury tabel/kolumn/relacji w XML | [/soneta-business-xml](../soneta-business-xml/SKILL.md) |
| Formularze i widoki UI (form.xml) | [/soneta-form-xml](../soneta-form-xml/SKILL.md) |
| Planowanie całego dodatku/modułu | [/soneta-addon-planning](../soneta-addon-planning/SKILL.md) |

## Narzędzia

- **`scan-folders`** — buduje drzewo **folderów statycznych menu** programu z atrybutów
  assembly `[assembly: FolderView(...)]` (oraz pochodnych) w skompilowanych bibliotekach.
  Klasyfikuje węzły na listy (`ViewInfoType`/`ViewType`/`TableName`), formularze
  (`ObjectType`) i menu; przy widokach pokazuje `Description` oraz powiązaną tabelę/`ViewInfo`.
  Filtr prefiksem ścieżki i tryb `--flat`. Czyta metadane przez Roslyn — bez uruchamiania
  aplikacji i bez ładowania IL do CLR. Skrypt: [scripts/scan-folders.csx](scripts/scan-folders.csx).
  Pełny opis, uruchomienie i przykłady: [references/scan-folders.md](references/scan-folders.md).

  Perspektywa **funkcjonalno-użytkowa** (co użytkownik klika w menu) — komplementarna do
  perspektywy **danych** (`scan-modules`) i **pól** (`scan-props`) ze skilla
  [/soneta-programming](../soneta-programming/SKILL.md). Planistyczne użycie inwentaryzacji
  opisuje [/soneta-addon-planning](../soneta-addon-planning/SKILL.md).

## Powiązania

- [/soneta-programming](../soneta-programming/SKILL.md) — pisanie folderów/list w kodzie C#
  oraz komplementarne skany DLL (`scan-modules`, `scan-props`, `scan-workers`).
- [/soneta-addon-planning](../soneta-addon-planning/SKILL.md) — użycie inwentaryzacji menu
  na etapie planowania dodatku.
- [/soneta-tools](../soneta-tools/SKILL.md) — operacje na bazie z CLI, weryfikacja na żywej aplikacji.
- [/soneta-erp](../soneta-erp/SKILL.md) — mapa wyboru skilla.
