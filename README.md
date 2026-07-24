# Soneta AI Skills

Zestaw skills dla asystentów AI (Claude, Cursor, Windsurf, itp.) wspierających programowanie, projektowanie i konfigurację **platformy Soneta (enova365, Triva)**.

## Dostępne skille

### 0. soneta-erp (meta-skill)

Mapa i przewodnik po pozostałych skillach. Pomaga wybrać właściwy skill w zależności od warstwy zadania (dane, UI, logika, płace).

**Kiedy używać:** rozpoczynasz nowe zadanie dla enova365/Soneta/Triva i nie wiesz, który skill zastosować; zadanie obejmuje wiele warstw platformy i potrzebna jest koordynacja między skillami.

### 1. soneta-programming

Fundamentalne klasy ORM platformy Soneta (enova365, Triva).

**Zakres:**
- Mapowanie obiektowo-relacyjne (`Row`, `Table`, `Module`)
- Zarządzanie sesją (`Session`) i transakcjami biznesowymi
- Logowanie i dostęp do bazy (`Login`, `Database`, `BusApplication`)
- Paczki danych (`Datapack`, `GuidedRow`) i synchronizacja
- Kontekst aplikacji (`Context`)

**Kiedy używać:** pytania o klasy logiki biznesowej, sesje, transakcje, hierarchię `Row` → `Table` → `Module`.

### 2. soneta-business-xml

Generator plików `business.xml` definiujących strukturę obiektów biznesowych.

**Zakres:**
- Definiowanie tabel i kolumn
- Typy danych (proste, relacyjne, złożone)
- Relacje między obiektami (1:N, N:1, polimorficzne)
- Klucze i indeksy
- Wzorce: słowniki, dokumenty z pozycjami, historia zmian

**Kiedy używać:** tworzenie nowego modułu biznesowego, definiowanie encji, generowanie plików `*.business.xml`.

### 3. soneta-form-xml

Tworzenie plików `form.xml` opisujących formularze i widoki UI platformy Soneta.

**Zakres:**
- Formularze stron (`pageform.xml`), widoki list (`viewform.xml`), lookupy (`lookupform.xml`), gridy (`gridform.xml`)
- Elementy: `DataForm`, `Page`, `Group`, `Grid`, `Field`, `Row`, `Stack`, `Flow`, `Command`
- Atrybuty: `EditValue`, `DataContext`, `Visibility`, `RowCondition`, `Renderable`, `CaptionHtml`
- Warunkowe formatowanie, wiązanie danych, wzorce UI

**Kiedy używać:** tworzenie zakładek, widoków list, formularzy i lookupów dla platformy Soneta.

### 4. soneta-addon-planning

Planowanie projektów dodatków dla platformy Soneta.

**Zakres:**
- Interaktywny proces planowania w 3 etapach (wizja, architektura, specyfikacja szczegółowa)
- Struktura danych (tabele, relacje)
- Elementy konfigurowalne, definicje list i menu
- Formularze, workery i raporty
- Dokumentacja implementacyjna z TODO

**Kiedy używać:** planowanie nowego modułu/dodatku, przygotowanie założeń projektu, specyfikacja funkcjonalna.

### 5. soneta-ui-style

System projektowy (design system) platformy Soneta do budowania aplikacji webowych.

**Zakres:**
- Palety kolorów (motywy jasny/ciemny) — szmaragdowy `#016E46` jako kolor główny
- Typografia (Roboto), layout, system odstępów (skala 4px)
- Komponenty UI: przyciski, formularze, tabele, sidebar, header, kafelki, modale
- Cienie, ikony SVG (~370 ikon liniowych), animacje, responsywność
- Enterprise minimalism, flat design z subtelnymi cieniami

**Kiedy używać:** projektowanie stron/aplikacji w stylu Soneta, dashboardy, formularze, strony logowania, panele administracyjne.

### 6. soneta-place-def-elementow

Tworzenie i konfiguracja definicji elementów wynagrodzenia na platformie Soneta (moduł Płace).

**Zakres:**
- Algorytmy naliczania: kreator, edytor C# (`_Param`, `_Wylicz`, `_Wartość1h`), algorytmy wbudowane
- 12 wzorców dla Dodatków, 5 dla Nieobecności, 5 dla Dodatków automatycznych (z analizy ~247 definicji)
- Receptury kodu C#: iterowanie po elementach, staż pracy, wymiar etatu, czas pracy, wskaźniki, cechy pracownika
- Konfiguracja zakładek: Ogólne, Deklaracje (PIT/ZUS), Nieobecności, Algorytm
- Metody sterujące naliczaniem (`_PodstawaUrlopu`, `_PodstawaZasiłku`)

**Kiedy używać:** tworzenie/modyfikacja definicji elementu wynagrodzenia, pisanie algorytmów płacowych (premia procentowa, dodatek stażowy, zasiłek chorobowy, ekwiwalent za urlop).

### 7. soneta-tools

Narzędzia deweloperskie wiersza poleceń używane w Soneta.

**Zakres:**
- `dbmgr` — zarządzanie bazami danych z CLI: tworzenie/rejestracja/kasowanie, konwersja, backup/restore (binarny `.bac` i tekstowy `.zip`), licencje i klucz wirtualny, rozszerzenia (extensions), import XML, analiza, kompilacja algorytmów
- `buscall` — testowanie na żywej aplikacji: zdalne sterowanie programem (nawigacja, formularze, gridy, edycja) i zrzuty ekranu do analizy wizualnej; wariant MCP `callmcp`
- Przygotowanie baz testowych/demo i automatyzacja operacji w skryptach/CI

**Kiedy używać:** zarządzanie bazą enova z CLI, tworzenie bazy demo, backup/konwersja bazy, weryfikacja zmian w kodzie na uruchomionej aplikacji.

### 8. soneta-config

Narzędzia i mechanizmy związane z konfiguracją systemu i funkcjami domenowymi platformy. Zawartość jest rozwijana — poniżej to, co faktycznie obecne w skillu.

**Zakres:**
- **Import/eksport danych i ustawień konfiguracyjnych przez pliki XML** — struktura pliku `<session>`: import według rekordów (dane konfiguracyjne, pliki `*.dbinit.xml`, baza demo), import przez logikę biznesową (`business="true"`, pełna walidacja), eksport rekordów guidowanych z datapackiem; identyfikacja rekordów (GUID, `where`, `key`, `id`), formaty wartości, atrybuty specjalne, przenoszenie ustawień między bazami.
- `scan-folders` — inwentaryzacja **folderów statycznych menu** (`[assembly: FolderView]`) z bibliotek DLL: drzewo pozycji menu (listy, formularze) i ich powiązanie z tabelą/`ViewInfo`; czyta metadane przez Roslyn, bez uruchamiania aplikacji. Perspektywa funkcjonalno-użytkowa, komplementarna do skanów danych (`scan-modules`) ze `soneta-programming`.

**Kiedy używać:** budowa/analiza pliku XML importu danych, przenoszenie konfiguracji między bazami, eksport danych do XML; mapowanie struktury menu dodatku, szukanie ścieżki-rodzica dla nowego folderu.

> Uwaga: warstwa kodu importu/eksportu (`SessionReader`/`SessionWriter`) i kod ORM → `soneta-programming`; operacje na bazie z CLI → `soneta-tools`.

### 9. soneta-containers

Uruchamianie i wdrażanie platformy Soneta (enova365, Triva) w kontenerach — dla partnerów, bez dostępu do kodu programu.

**Zakres:**
- **Docker Compose** (ścieżka główna): gotowe `docker-compose.yaml` (dbinit + server + web), cykl życia, zmienne `SONETA_...`
- **Apple `container` / Container Desktop** (macOS): różnice, wklejanie YAML, grupy, `x-init`
- **Helm / Kubernetes** (beta): `helm repo add soneta`, `values.yaml`, `dblist`, `adminMode`
- **Wybór wersji obrazów**: `soneta/server.standard`, `web.standard` — Docker Hub (publiczne) i `registry.soneta.pl` (alfa)
- **Baza w kontenerze**: usługa init z `dbmgr create` (`--demo`, `--recreate`), SQL zewnętrzny lub kontener `mssql`

**Kiedy używać:** stawianie środowiska test/demo na obrazach Soneta, `docker compose up`, Container Desktop, `helm install`, wybór tagu/wersji, problemy startu stacku (kolejność, host-alias, porty). Składnię komend `dbmgr` → `soneta-tools`.

## Powiązania między skillami

Skille są zaprojektowane do współpracy:

1. **soneta-erp** → wskazuje właściwy skill dla danego zadania
2. **soneta-addon-planning** → planuje strukturę nowego dodatku
3. **soneta-business-xml** → definiuje obiekty biznesowe w XML
4. **soneta-programming** → pokazuje jak pracować z wygenerowanymi klasami C#
5. **soneta-form-xml** → tworzy formularze UI dla obiektów
6. **soneta-ui-style** → styluje interfejs webowy zgodnie z design systemem enova365
7. **soneta-place-def-elementow** → konfiguruje warstwę płacową (definicje elementów wynagrodzenia)
8. **soneta-config** → konfiguruje działający program (ustawienia, cechy, prawa) i uruchamia funkcje domenowe (czynności, harmonogram)
9. **soneta-tools** → narzędzia CLI wspierające cykl pracy: `dbmgr` (bazy testowe/demo, backup, konwersja) i `buscall` (weryfikacja zmian na żywej aplikacji)
10. **soneta-containers** → uruchamia i wdraża gotowy produkt w kontenerach (docker compose, Apple container, Helm); bazę zakłada `dbmgr` w kontenerze (składnia → `soneta-tools`)

## Instalacja

### Claude Code

Skopiuj foldery skilli do `~/.claude/skills/`.

### Cursor / Windsurf / inne IDE

Dodaj zawartość skilli do kontekstu projektu lub rules.

## Licencja

MIT